using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml.Serialization;

namespace DataEditor
{
    public class Student
    {
        public Student() 
        {
            this.Admission = DateTime.Now;
        }
        public Student(string familyName, string name, string fatherName, DateTime admission)
        {
            this.FamilyName = familyName;
            this.Name = name;
            this.FatherName = fatherName;
            this.Admission = admission;
        }

        public string FamilyName { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime Admission { get; set; }
    }

    [Serializable]
    public class StringDataSource
    {
        public ObservableCollection<Student> data = new ObservableCollection<Student>();
    }
}
