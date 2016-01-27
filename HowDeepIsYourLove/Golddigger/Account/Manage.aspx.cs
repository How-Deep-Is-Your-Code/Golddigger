namespace Golddigger.Account
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web;
    using System.Web.UI.WebControls;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using Services.Contracts;
    using Ninject;
    using Models;

    public partial class Manage : System.Web.UI.Page
    {
        [Inject]
        public IUsersService users { get; set; }

        [Inject]
        public IInterestService interestsServ { get; set; }

        [Inject]
        public ICountriesService counties { get; set; }

        [Inject]
        public ITownsService towns { get; set; }

        [Inject]
        public IUserInfoService userInfoServ { get; set; }

        public UserInfo info { get; set; }

        protected string SuccessMessage
        {
            get;
            private set;
        }

        private bool HasPassword(UserManager manager)
        {
            return manager.HasPassword(User.Identity.GetUserId());
        }

        public bool HasPhoneNumber { get; private set; }

        public bool TwoFactorEnabled { get; private set; }

        public bool TwoFactorBrowserRemembered { get; private set; }

        public int LoginsCount { get; set; }

        protected void Page_Load()
        {
            var userId = this.User.Identity.GetUserId();
            var user = users.GetById(userId);

            if (!IsPostBack)
            {
                var allCountries = counties.All().ToList();
                this.DropDownListCountries.DataSource = allCountries;
                this.DropDownListCountries.DataBind();

                var allInterests = interestsServ.All().ToList();
                this.CheckBoxInterests.DataSource = allInterests;
                this.CheckBoxInterests.DataBind();
            }

            var manager = Context.GetOwinContext().GetUserManager<UserManager>();

            HasPhoneNumber = String.IsNullOrEmpty(manager.GetPhoneNumber(User.Identity.GetUserId()));

            // Enable this after setting up two-factor authentientication
            //PhoneNumber.Text = manager.GetPhoneNumber(User.Identity.GetUserId()) ?? String.Empty;

            TwoFactorEnabled = manager.GetTwoFactorEnabled(User.Identity.GetUserId());

            LoginsCount = manager.GetLogins(User.Identity.GetUserId()).Count;

            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            if (!IsPostBack)
            {
                // Determine the sections to render
                if (HasPassword(manager))
                {
                    ChangePassword.Visible = true;
                }
                else
                {
                    CreatePassword.Visible = true;
                    ChangePassword.Visible = false;
                }

                // Render success message
                var message = Request.QueryString["m"];
                if (message != null)
                {
                    // Strip the query string from action
                    Form.Action = ResolveUrl("~/Account/Manage");

                    SuccessMessage =
                        message == "ChangePwdSuccess" ? "Your password has been changed."
                        : message == "SetPwdSuccess" ? "Your password has been set."
                        : message == "RemoveLoginSuccess" ? "The account was removed."
                        : message == "AddPhoneNumberSuccess" ? "Phone number has been added"
                        : message == "RemovePhoneNumberSuccess" ? "Phone number was removed"
                        : String.Empty;
                    successMessage.Visible = !String.IsNullOrEmpty(SuccessMessage);
                }
            }
        }

        protected void itemSelected(object sender, EventArgs e)
        {
            var dropDownList = sender as DropDownList;

            var firstTownId = dropDownList.SelectedItem.Value;
            var id = int.Parse(firstTownId);

            var townsForDropDown = towns.GetTownsForCountry(id).ToList();
            this.DropDownListTowns.Items.Clear();
            this.DropDownListTowns.DataSource = townsForDropDown;
            this.DropDownListTowns.DataBind();
        }

        protected void EditUserInfo_Click(object sender, EventArgs e)
        {
            var interests = new HashSet<Interest>();
            foreach (ListItem item in CheckBoxInterests.Items)
            {
                if (item.Selected)
                {
                    var interest = interestsServ.GetInterestById(int.Parse(item.Value));
                    interests.Add(interest);
                }
            }

            var type = Type.SelectedValue;
            var typeAsNumber = int.Parse(type);

            if (typeAsNumber > 2)
            {
                // handle possible abuse
            }

            var currentUser = users.GetById(this.User.Identity.GetUserId());

            if (currentUser.UserInfo == null)
            {
                currentUser.UserInfo = new UserInfo();
            }

            currentUser.UserInfo.AccountType = (AccountType)typeAsNumber;
            currentUser.UserInfo.CountryId = int.Parse(DropDownListCountries.SelectedItem.Value);
            currentUser.UserInfo.TownId = int.Parse(DropDownListTowns.SelectedItem.Value);

            var usersInterests = currentUser.UserInfo.Interests;
            foreach (var interest in interests)
            {
                var isNewInterest = true;
                foreach (var item in usersInterests)
                {
                    if(interest.InterestId == item.InterestId)
                    {
                        isNewInterest = false;
                        break;
                    }
                }

                if(isNewInterest)
                {
                    currentUser.UserInfo.Interests.Add(interest);
                }
            }

            userInfoServ.Update();
            users.Update();
            Response.Redirect("~/Account/Profile.aspx?id=" + currentUser.Id);
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }

        // Remove phonenumber from user
        protected void RemovePhone_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<UserManager>();
            var signInManager = Context.GetOwinContext().Get<SignInManager>();
            var result = manager.SetPhoneNumber(User.Identity.GetUserId(), null);
            if (!result.Succeeded)
            {
                return;
            }
            var user = manager.FindById(User.Identity.GetUserId());
            if (user != null)
            {
                signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                Response.Redirect("/Account/Manage?m=RemovePhoneNumberSuccess");
            }
        }

        // DisableTwoFactorAuthentication
        protected void TwoFactorDisable_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<UserManager>();
            manager.SetTwoFactorEnabled(User.Identity.GetUserId(), false);

            Response.Redirect("/Account/Manage");
        }

        //EnableTwoFactorAuthentication 
        protected void TwoFactorEnable_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<UserManager>();
            manager.SetTwoFactorEnabled(User.Identity.GetUserId(), true);

            Response.Redirect("/Account/Manage");
        }
    }
}