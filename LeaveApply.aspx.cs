using System;
using System.Web;
using System.Web.UI;

namespace prac_5
{
    public partial class LeaveApply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Get employee name from cookie
                if (Request.Cookies["Employee"] != null)
                {
                    txtemp.Text =
                        Request.Cookies["Employee"].Value;
                }

                // Get selected date from Session
                if (Session["LeaveDate"] != null)
                {
                    DateTime selectedDate =
                        (DateTime)Session["LeaveDate"];

                    lblButtonDT.Text =
                        selectedDate.ToString("dd-MM-yy");
                }
                else
                {
                    lblButtonDT.Text =
                        DateTime.Now.ToString("dd-MM-yy");
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string ename = txtemp.Text;
            string leaveType = DropDownList1.SelectedValue;
            string reason = TextBox2.Text;
            string leaveDate = lblButtonDT.Text;

            // Store employee name in Cookie
            if (CheckBox1.Checked)
            {
                HttpCookie empCookie =
                    new HttpCookie("Employee");

                empCookie.Value = ename;
                empCookie.Expires =
                    DateTime.Now.AddDays(7);

                Response.Cookies.Add(empCookie);
            }

            // Store details in Session
            Session["Employee"] = ename;
            Session["LeaveType"] = leaveType;
            Session["LeaveDate"] = leaveDate;
            Session["Reason"] = reason;

            // Check Leave Type
            if (leaveType == "Select Leave Type")
            {
                lblmsg.Text =
                    "Please select a Leave Type.";
            }
            else
            {
                lblmsg.Text =
                    "<b>Leave Application Submitted Successfully</b>" +
                    "<br/><br/>" +
                    "Employee Name: " + ename +
                    "<br/>" +
                    "Leave Date: " + leaveDate +
                    "<br/>" +
                    "Leave Type: " + leaveType +
                    "<br/>" +
                    "Reason: " + reason;
            }
        }
    }
}
