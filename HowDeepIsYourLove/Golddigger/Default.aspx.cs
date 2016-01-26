using Golddigger.Models;
using Golddigger.Services.Contracts;
using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Golddigger
{
    public partial class _Default : Ninject.Web.PageBase
    {
        [Inject]
        public IUsersService users { get; set; }

        public List<User> Images { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public IQueryable<User> ListViewImages_GetData()
        {            
            return users.GetGolddiggerUsers();
        }
    }
}