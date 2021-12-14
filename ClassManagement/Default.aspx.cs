using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassManagement
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetClassSource();
            Response.Redirect("School.aspx");
          
        }


        private List<StudDetails> GetClassSource()
        {
            List<StudDetails> dt = new List<StudDetails>();
            if (Session["Classes"] == null)
            {
                List<StudDetails> lstStudDetail = new List<StudDetails>();
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H508_03", ReferenceID = "300121", Name = "William RENTU", Level = "KG", School = "L", print = true });
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H508_03", ReferenceID = "300122", Name = "Henry RANFIEL", Level = "KG", School = "L", print = true });
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H508_03", ReferenceID = "300123", Name = "Cruz DENTIL", Level = "KG", School = "L", print = true });
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H508_03", ReferenceID = "300124", Name = "Peter HITSON", Level = "KG", School = "L", print = false });

                lstStudDetail.Add(new StudDetails() { ClassName = "L_H509_03", ReferenceID = "523132", Name = "Lee BELIVER", Level = "KG", School = "L", print = true });
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H509_03", ReferenceID = "523133", Name = "Bruce ROUSSOU", Level = "KG", School = "L", print = true });
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H509_03", ReferenceID = "523134", Name = "Ajay ALYAS", Level = "KG", School = "L", print = true });
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H509_03", ReferenceID = "523136", Name = "Star NOUSSAY", Level = "KG", School = "L", print = true });
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H509_03", ReferenceID = "523137", Name = "Laurent RAMWARD", Level = "KG", School = "L", print = true });

                lstStudDetail.Add(new StudDetails() { ClassName = "L_H513", ReferenceID = "2145234", Name = "Fred THOMSO", Level = "KL", School = "L", print = true });

                lstStudDetail.Add(new StudDetails() { ClassName = "L_H513_03", ReferenceID = "9767534", Name = "Thomas HENDRE", Level = "KG", School = "L", print = true });
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H513_03", ReferenceID = "9767535", Name = "Joan MAEN", Level = "KG", School = "L", print = true });
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H513_03", ReferenceID = "9767536", Name = "Julie OPTEN", Level = "KG", School = "L", print = true });
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H513_03", ReferenceID = "9767537", Name = "Anne TEND", Level = "KG", School = "L", print = true });

                lstStudDetail.Add(new StudDetails() { ClassName = "L_H524_00", ReferenceID = "542144", Name = "Suzanne UTONTU", Level = "KG", School = "L", print = true });
                lstStudDetail.Add(new StudDetails() { ClassName = "L_H524_00", ReferenceID = "213434", Name = "Harry SED", Level = "KG", School = "L", print = true });

                Session["Classes"] = lstStudDetail;
            }
            else
            {
                dt = (List<StudDetails>)Session["Classes"];
            }
            return dt;
        }
    }
}