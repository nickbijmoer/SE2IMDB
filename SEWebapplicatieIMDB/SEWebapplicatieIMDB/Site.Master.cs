using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SEWebapplicatieIMDB
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["UserID"] == null)
            {
                var ctrl1 = FindControlRecursive(this, "liLogin");
                if (ctrl1 != null)
                {
                    ctrl1.Visible = true;
                }
                var ctrl2 = FindControlRecursive(this, "liRegister");
                if (ctrl2 != null)
                {
                    ctrl2.Visible = true;
                }
                var ctrl3 = FindControlRecursive(this, "liWelkom");
                if (ctrl3 != null)
                {
                    ctrl3.Visible = false;
                }
                var ctrl4 = FindControlRecursive(this, "liLogout");
                if (ctrl4 != null)
                {
                    ctrl4.Visible = false;
                }
            }
            else
            {
                var ctrl5 = FindControlRecursive(this, "liLogin");
                if (ctrl5 != null)
                {
                    ctrl5.Visible = false;
                }
                var ctrl6 = FindControlRecursive(this, "liRegister");
                if (ctrl6 != null)
                {
                    ctrl6.Visible = false;
                }
                var ctrl7 = FindControlRecursive(this, "liWelkom");
                if (ctrl7 != null)
                {
                    ctrl7.Visible = true;
                }
                var ctrl8 = FindControlRecursive(this, "liLogout");
                if (ctrl8 != null)
                {
                    ctrl8.Visible = true;
                }
            }
        }

     
        public void LinkButton_Click(Object sender, EventArgs e)
        {
            Session.Remove("UserID");
            Session.RemoveAll();
            Response.Redirect("/Default.aspx");
        }
        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut();
           
        }

        private Control FindControlRecursive(Control rootControl, string controlID)
        {
            if (rootControl.ID == controlID) return rootControl;

            foreach (Control controlToSearch in rootControl.Controls)
            {
                Control controlToReturn =
                    FindControlRecursive(controlToSearch, controlID);
                if (controlToReturn != null) return controlToReturn;
            }
            return null;
        }
   
    }

}