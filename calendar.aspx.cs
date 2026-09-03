using System;

namespace prac_5
{
    public partial class calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;

            lblSelectedDate.Text =
                "Selected Date: " +
                selectedDate.ToString("dd-MM-yy");

            Session["LeaveDate"] = selectedDate;
        }

        protected void BtnApplyLeave_Click(object sender, EventArgs e)
        {
            Response.Redirect("LeaveApply.aspx");
        }
    }
}
