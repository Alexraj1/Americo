using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace BLL
{
	[XmlRoot(ElementName = "name")]
	public class Name
	{
		[XmlElement(ElementName = "firstname")]
		public string Firstname { get; set; }
		[XmlElement(ElementName = "lastname")]
		public string Lastname { get; set; }
		[XmlElement(ElementName = "print")]
		public string Print { get; set; }
	}

	[XmlRoot(ElementName = "address")]
	public class Address
	{
		[XmlElement(ElementName = "street")]
		public string Street { get; set; }
		[XmlElement(ElementName = "city")]
		public string City { get; set; }
		[XmlElement(ElementName = "email")]
		public string Email { get; set; }
		[XmlElement(ElementName = "phone")]
		public string Phone { get; set; }
	}

	[XmlRoot(ElementName = "student")]
	public class Student
	{
		[XmlElement(ElementName = "name")]
		public Name Name { get; set; }
		[XmlElement(ElementName = "address")]
		public Address Address { get; set; }
	}

	[XmlRoot(ElementName = "students")]
	public class Students
	{
		[XmlElement(ElementName = "student")]
		public List<Student> Student { get; set; }
	}

	[XmlRoot(ElementName = "ClassName")]
	public class ClassName
	{
		[XmlElement(ElementName = "V")]
		public string V { get; set; }
		[XmlElement(ElementName = "students")]
		public Students Students { get; set; }
	}

	[XmlRoot(ElementName = "ClassNames")]
	public class ClassNames
	{
		[XmlElement(ElementName = "ClassName")]
		public List<ClassName> ClassName { get; set; }
	}

}