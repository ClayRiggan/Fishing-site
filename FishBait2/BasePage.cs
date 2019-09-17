using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace FishBait2
{
    public class BasePage
    {
        //private DataLayer.Member _Currentmember { get; set; }
        //internal DataLayer.Member CurrentMember
        ////private DataLayer.t_user _CurrentUser { get; set; }
        ////internal DataLayer.t_user CurrentUser
        //{
        //    get
        //    {
        //        if (Session["_CurrentUser"] == null)
        //        {
        //            _CurrentUser = new DataLayer.UserBL().GetCurrentUser();
        //            Session["_CurrentUser"] = _CurrentUser;
        //        }
        //        else
        //        {
        //            _CurrentUser = Session["_CurrentUser"] as DataLayer.User;
        //        }
        //        return _CurrentUser;
        //    }
        //    set
        //    {
        //        _CurrentUser = value;
        //        Session["_CurrentUser"] = value;
        //    }
        //}

        //internal int Key
        //{
        //    get
        //    {
        //        if (Request.QueryString["Key"] == null)
        //            return 0;
        //        else
        //            return Convert.ToInt32(Request.QueryString["Key"].ToString());
        //    }
        //}
        //    get
        //    {
        //        if (_Currentmember != null)
        //            return _Currentmember;
        //        if (HttpContext.Current.User != null)
        //        {
        //            if (HttpContext.Current.User.Identity.IsAuthenticated)
        //            {
        //                if (HttpContext.Current.User.Identity is FormsIdentity)
        //                {
        //                    FormsIdentity id = (FormsIdentity)HttpContext.Current.User.Identity;
        //                    FormsAuthenticationTicket ticket = id.Ticket;
        //                    // Get the stored user-data, in this case, our roles
        //                    string UserFullName = ticket.Name;
        //                    //stored user id in the data field
        //                    //int UserId = ticket.UserData;
        //                    int.TryParse(ticket.UserData, out int UserId);
        //                    _Currentmember = new DataLayer.MembersBL().GetCurrentUser(UserId);
        //                }
        //                else
        //                {
        //                    //Response.Redirect("~/Account/Login.aspx");
        //                    _Currentmember = null;
        //                }
        //            }
        //            else
        //            {
        //                //Response.Redirect("~/Account/Login.aspx");
        //                _Currentmember = null;
        //            }
        //        }
        //        else
        //        {
        //            //Response.Redirect("~/Account/Login.aspx");
        //            _Currentmember = null;
        //        }
        //        return _Currentmember;
        //    }
        //}

    }
}