using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassManagement
{
    public partial class StudentDetail : System.Web.UI.Page
    {
        public string className;
        protected void Page_Load(object sender, EventArgs e)
        {
            className = Request.QueryString["ClassName"];
            if (!IsPostBack) {
                if (Request.QueryString["ClassName"] == null)
                    Response.Redirect("School.aspx");
                gvStudent.DataSource = GetClassSource().Where(d => d.ClassName == className);
                gvStudent.DataBind();
                lblClass.Text = className;
                lblStudents.Text = GetClassSource().Where(d => d.ClassName == className && d.print).Count() + " of " + GetClassSource().Where(d => d.ClassName == className).Count();
            }
 
        }

        private List<StudDetails> GetClassSource()
        {
            List<StudDetails> dt = new List<StudDetails>();
            if (Session["Classes"] != null)
            {
             
                dt = (List<StudDetails>)Session["Classes"];
            }
            else
            {
                Response.Redirect("School.aspx");
            }
            return dt;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            List<StudDetails> otherdt = GetClassSource().Where(d => d.ClassName != className).ToList();
            int n = 0, t = 0;
            foreach (GridViewRow row in gvStudent.Rows)
            {
                StudDetails st = GetClassSource().Where(d => d.ClassName == className && d.ReferenceID == row.Cells[2].Text).FirstOrDefault();
                CheckBox chk = row.Cells[0].Controls[1] as CheckBox;
                if (chk != null && chk.Checked)
                {
                    st.print = true;
                    n++;
                }
                else
                {
                    st.print = false;
                }
                t++;
                otherdt.Add(st);
            }
            Session.Remove("Classes");
            Session["Classes"] = otherdt;
            lblStudents.Text = n + " of " + t;

        }

        protected void btnSelectALL_Click(object sender, EventArgs e)
        {

            UpdatePrint(true);
        }
        private void UpdatePrint(Boolean print)
        {
            int t = 0;
            foreach (GridViewRow row in gvStudent.Rows)
            {
                CheckBox chk = row.Cells[0].Controls[1] as CheckBox;
                if (chk != null )
                {
                    chk.Checked = print;
  
                }
        
            }
            lblStudents.Text = (print?"t":"0") + " of " + t;
        }
        protected void btnUnSelectALL_Click(object sender, EventArgs e)
        {

            UpdatePrint(false);
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("School.aspx");
        }
    }
}