using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassManagement
{
   public class StudDetails
    {
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string ReferenceID { get; set; }
        public string Level { get; set; }
        public string School { get; set; }
        public bool print { get; set; }
    }
    public partial class school : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            gvClass.DataSource = ClassSource();
            gvClass.DataBind();
            }

        }


        private List<StudDetails> GetClassSource()
        {
            List<StudDetails> dt = new List<StudDetails>();
            if (Session["Classes"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                dt=(List<StudDetails>)Session["Classes"];
            }
            return dt;
        }

        public DataTable ClassSource()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Klass", typeof(string));
            table.Columns.Add("Level", typeof(string));
            table.Columns.Add("School", typeof(string));
            table.Columns.Add("Leerlingen", typeof(int));
          
            var t = GetClassSource().GroupBy(d => d.ClassName).Select(y => new DictionaryEntry
            {
                Key = y.Key,
                Value = y.Count()
            }).ToList();
            foreach(DictionaryEntry de in t)
            {

                StudDetails std=GetClassSource().Where(d => d.ClassName == de.Key).FirstOrDefault();
                table.Rows.Add(std.ClassName, std.Level, std.School, GetClassSource().Where(d => d.ClassName == de.Key && d.print).Count());
            }
           
         

            return table;
        }




    }
}