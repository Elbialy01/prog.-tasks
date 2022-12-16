using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            course[] courses = {new course(){name="math",code=1021,grade=150 },
            new course(){name="programing",code=1212,grade=130 },
            new course(){name="control",code=1321,grade=130 }
            };
            student mahmoud = new student(12,"mahmoud","male", courses);
            Console.WriteLine(mahmoud[1021]);
        }
    }
  public  struct student
    {
     public int id { get;set; }
        public string name { get;set; } 
        public string gender { get;set;}
        course[] courses;
        
       
        public student(int _id,string _name,string _gender, course[]_courses)
        {
            id = _id;
            name = _name;
            gender = _gender;   
            courses = _courses; 
            
        }

        public string  this[int _code]
        {

            get
            {
                for(int i = 0; i < courses.Length; i++)
                {
                    if (courses[i].code == _code)
                    {
                        return $"{courses[i].name} grades {courses[i].grade}";
                    }
                }
                return "invalid code";
            }
        }
    public void display(course[] courses)
        {
            Console.WriteLine(name);
            Console.WriteLine("-------------");
            foreach (course c in courses)
            {
                Console.WriteLine("course: "+c.name+" code: "+c.code+" grades: "+c.grade);
                Console.WriteLine("--------------------------------------------------------------------------------------------------");
            }
            
        }

    }
    public struct course
    {
    
        public int code { get; set; }
        public string name { get; set; }    
        public int grade { get; set; }
    
    }
}
