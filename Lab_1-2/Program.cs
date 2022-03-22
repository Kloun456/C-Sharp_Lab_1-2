using System;
using System.Numerics;


namespace Test
{
    public class Lab1_2
    {
        public static void Main()
        {
            
            //Lab_1
            Console.WriteLine("Лабораторная работа №1\nВыполнил Измайлов Егор\n");
            
            Complex x = new Complex() { Real = 2, Imag = 2.3 };
            Complex y = new Complex() { Real = 5, Imag = 1.2 };
            
            Console.WriteLine("x = {0} + {1}i", x.Real, x.Imag);
            Console.WriteLine("y = {0} + {1}i", y.Real, y.Imag);
            x.Add(y);
            y.Divide(x);
            Console.WriteLine("After addition x = x + y:\tx = {0} + {1}i", x.Real, x.Imag);
            Console.WriteLine("After divide y = y / x:\ty = {0} + {1}i", y.Real, y.Imag);
            x.Substract(y);
            y.Multiply(x);
            Console.WriteLine("After substract x = x - y:\tx = {0} + {1}i", x.Real, x.Imag);
            Console.WriteLine("After multiply y = y * x:\ty = {0} + {1}i", y.Real, y.Imag);
            
            Student student1 = new Student() { Marks = new int[5] { 1, 2, 2, 2, 2 }, Age = 18, FirstName = "Ben", LastName = "Grey", Kurs = 2 };
            Student student2 = new Student() { Marks = new int[5] { 3, 2, 4, 5, 2 }, Age = 19, FirstName = "Lisa", LastName = "Phonk", Kurs = 3 };
            Student student3 = new Student() { Marks = new int[5] { 2, 2, 2, 2, 2}, Age = 20, FirstName = "Anna", LastName = "Lord", Kurs = 4 };

            Console.Write("\nStudent 1: Firstname - " + student1.FirstName + ", Lastname - " + student1.LastName + ", Age - " + student1.Age + ", Kurs - " + student1.Kurs + "\nMarks: " );
            foreach (var mark in student1.Marks)
                Console.Write(mark + "\t");
            Console.Write("\nStudent 2: Firstname - " + student2.FirstName + ", Lastname - " + student2.LastName + ", Age - " + student2.Age + ", Kurs - " + student2.Kurs + "\nMarks: ");
            foreach (var mark in student2.Marks)
                Console.Write(mark + "\t");
            Console.Write("\nStudent 3: Firstname - " + student3.FirstName + ", Lastname - " + student3.LastName + ", Age - " + student3.Age + ", Kurs - " + student3.Kurs + "\nMarks: ");
            foreach (var mark in student3.Marks)
                Console.Write(mark + "\t");
            student1.Add(student2);
            Console.Write("\n\nAfter addition Student1 = Student1 + Student2: Firstname - " + student1.FirstName + ", Lastname - " + student1.LastName + ", Age - " + student1.Age + ", Kurs - " + student1.Kurs + "\nMarks: ");
            foreach (var mark in student1.Marks)
                Console.Write(mark + "\t");
            student1.Add(student2, student3);
            Console.Write("\n\nAfter addition Student1 = Student1 + Student2 + Student3: Firstname - " + student1.FirstName + ", Lastname - " + student1.LastName + ", Age - " + student1.Age + ", Kurs - " + student1.Kurs + "\nMarks: ");
            foreach (var mark in student1.Marks)
                Console.Write(mark + "\t");

            //Lab_2
            
            Console.WriteLine("\n\nЛабораторная работа №2\nВыполнил Измайлов Егор\n");
            Figure[] figures = {
            new Circle() { Name = "Круг",  Radius = 3.5 },
            new Decagon() { Name = "Правильный десятиугольник", Side = 4 },
            new Parallelogram() { Name = "Параллелограмм", Height = 2, Side = 4.2 },
            new Pentagon() { Name = "Правильный пятиугольник", Side = 3.2 },
            new Rectangle() { Name = "Прямоугольник", Height = 13.7, Width = 10.3 },
            new Rhombus() { Name = "Ромб", A_diagonal = 2.2, B_diagonal = 3.3 },
            new Trapezoid() { Name = "Трапеция", A_side = 6.2, B_side = 3.8, Height = 3 },
            new Treangle() { Name = "Треугольник", Height = 4, Side = 6.2 } };

            foreach (Figure f in figures)
                Console.WriteLine("Название фигуры: {0} \tПлощадь: {1}", f.Name, f.GetArea());
            
        }
       
    }
}