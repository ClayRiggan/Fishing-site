using System;
using DataLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FishBait2.Grids
{
    public partial class UserGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            List<Member> users = new MembersBL().GetMemberList();
            CurrentUserGrid.DataSource = users;
            CurrentUserGrid.DataBind();
        }
    }
}