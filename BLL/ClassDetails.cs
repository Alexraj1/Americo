using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLL
{
    public class ClassDetails
    {
       private const string filePath = @"D:\_Project\Americo\ClassManagement\resources\data\ClassDetails.xml";
        public ClassNames cn=new ClassNames();
        public ClassDetails()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ClassNames));

            using (Stream reader = new FileStream(filePath, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                cn = (ClassNames)xs.Deserialize(reader);
            }
        }
        public List< ClassName> GetClassNames()
        {
            try
            {
               return cn.ClassName.ToList();
               
            }
            catch (Exception)
            {

                return null;
            }

        }

        public List<Student> GetStudents(string ClassName)
        {
            try
            {
                Students std=cn.ClassName.Where(d=> d.V==ClassName).Select(f=> f.Students).FirstOrDefault();
                return std.Student.ToList();
            }
            catch (Exception)
            {

                return null;
            }

        }

    }
}
