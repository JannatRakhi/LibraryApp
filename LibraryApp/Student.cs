using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Student
    {

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string department;
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        private float cgpa;
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Student()
        {
          

        }
        public Student(string name,string id,string department,float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa = cgpa;
        }
        public void ShowStudentInfo()
        {
            Console.WriteLine("Student Name :" + name);
            Console.WriteLine("Student Id :" + id);
            Console.WriteLine("Student Department :" + department);
            Console.WriteLine("Student CGPA :" + cgpa);

        }



    }
}
