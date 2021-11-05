using System;
using System.Collections.Generic;
using System.Text;

namespace HW4__Gradebook
{
    class assignment
    {
        private String name;
        private double grade;

        //Creates an object for an assignment with its name and grade.
        public assignment (string Name, double Grade)
        {
            name = Name;
            grade = Grade;
        }

        //Gets or sets the grade of an assignment object.
        public double Grade
        {
            get { return grade; }
            set 
            { 
                if (value >= 0 && value <= 100)
                {
                    grade = value;
                }
            
            }
        }

        //Gets or sets the name of an assignment object.
        public String Name
        {
            get { return name; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }

    }
}
