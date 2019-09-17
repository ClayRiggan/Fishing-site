using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FishBait2.Members
{
    public partial class AddFish : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
                DataLayer.Fish fish = new DataLayer.FishBL().GetFish(1, 1);
                txtType.Text = fish.Type;
                txtLength.Text = fish.Length.ToString();
                txtWeight.Text = fish.Weight.ToString();
            txtNotes.Text = fish.Notes;
                //txtBoat  make combo box
                //txtLocation make combo box
            //};
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int MemberID = 1;
            string FishType = txtType.Text;
            decimal.TryParse(txtLength.Text, out decimal Length);
            decimal.TryParse(txtWeight.Text, out decimal Weight);
            DateTime DateCaught = Calendar1.SelectedDate;
            int BoatID = 1;          //change to combo box
            int LocationID = 1;  //change to combo box
            string Notes = txtNotes.Text;
            new DataLayer.FishBL().AddFish(Length, Weight, FishType, LocationID, Notes, BoatID, MemberID);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}