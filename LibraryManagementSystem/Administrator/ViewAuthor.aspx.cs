using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic.FactoryClass;
using BusinessLogic.EntityClass;

namespace LibraryManagementSystem.Administrator
{
    public partial class ViewAuthor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AuthorFactory AF = new AuthorFactory();
            List<AuthorEntity> authorEntities = AF.GetAuthor();
            grdAuther.DataSource = authorEntities;
            grdAuther.DataBind();
            grdAuther.Columns[0].Visible = false;


        }
    }
}