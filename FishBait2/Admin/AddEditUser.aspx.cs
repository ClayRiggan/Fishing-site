using System;
using DataLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FishBait2.Admin
{
    public partial class AddEditUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string First = txtFirstName.Text;
            string Last = txtLastName.Text;
            string Email = txtEmail.Text;
            string Phone = txtPhone.Text;
            string Address = txtAddress.Text;
            string Address2 = txtAddress2.Text;
            string City = txtCity.Text;
            string State = txtState.Text;
            string Zip = txtZip.Text;
            new MembersBL().AddMember(First, Last, Email, Phone, Address, Address2, City, State, Zip);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}