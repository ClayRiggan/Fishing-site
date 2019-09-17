using System;
using DataLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FishBait2.Members
{
    public partial class AddEditBoat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string Manufacturer = txtMfg.Text;
            string Model = txtModel.Text;
            string Name = txtName.Text;
            string HullNum = txtHullNum.Text;
            int.TryParse(txtSize.Text, out int Size);
            int.TryParse(cbPowerType.SelectedValue, out int PowerId);
            int MemberId = 1;//CurrentMember.Id;  need to get this working :(
            new BoatsBL().AddBoat(Name, HullNum, PowerId, MemberId, Size);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

        protected void cbPowerType_Init(object sender, EventArgs e)
        {
            List<PowerType> powerTypes = new PowerTypeBL().GetPowerTypesList();
            cbPowerType.DataSource = powerTypes;
            cbPowerType.DataBind();
        }
    }
}