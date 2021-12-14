using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace ClassManagement.resources.WebServices
{
    /// <summary>
    /// Summary description for WSClassDetails
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSClassDetails : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void GetAllStudents(string className)
        {
            ClassDetails classDetails = new ClassDetails();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.Write(js.Serialize(classDetails.GetStudents(className)));

        }
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public String GetAllStudentsPS()
        {
            return "Hi";
            ClassDetails classDetails = new ClassDetails();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.Write(js.Serialize(classDetails.GetStudents("PS")));

        }

        [ScriptMethod]
        [WebMethod]
        public string sending(string st)
        {
            st = st + "bingo";
            return st;
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public string GetAllClasses()
        {
           ClassDetails classDetails = new ClassDetails();
            JavaScriptSerializer js = new JavaScriptSerializer();
            string strJSON = js.Serialize(classDetails.GetClassNames().Select(d=> d.V));
            
            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.Write(strJSON);
            Context.Response.End();
            return strJSON;

        }
    }
}
