using ExemploWebForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExemploWebForms
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new Context();
            IQueryable<Category> query = _db.Categories;
            return query;
        }

    }
}