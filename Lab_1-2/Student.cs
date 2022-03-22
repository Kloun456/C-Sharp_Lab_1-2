using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Kurs { get; set; }
        public int[] Marks;
        public Student() { FirstName = LastName = "\0"; Age = Kurs = 0; }
        public void Add(Student student2)
        {
            for (var i = 0; i < 5; i++)
            {
                Marks[i] += student2.Marks[i];
                if (Marks[i] > 5)
                    Marks[i] = 5;
            }
            FirstName += " " + student2.FirstName;
            LastName += " " + student2.LastName;
            Age += student2.Age;
            Kurs += student2.Kurs;
            if (Kurs > 6)
                Kurs = 6;
        }
        public void Add(Student student2, Student student3)
        {
            for (var i = 0; i < 5; i++)
            {
                Marks[i] += student2.Marks[i] + student3.Marks[i];
                if (Marks[i] > 5)
                    Marks[i] = 5;
            }
            FirstName += " " + student2.FirstName + " " + student3.FirstName;
            LastName += " " + student2.LastName + " " + student3.LastName;
            Age += student2.Age + student3.Age;
            Kurs += student2.Kurs + student3.Kurs;
            if (Kurs > 6)
                Kurs = 6;
        }
    }
    
}
