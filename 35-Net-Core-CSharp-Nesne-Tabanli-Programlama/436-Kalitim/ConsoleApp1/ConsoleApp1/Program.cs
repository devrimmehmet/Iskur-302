using System;

namespace ConsoleApp1
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string SurName { get; set; }
            public int Age { get; set; }
            public Person(string name, string surname)
            {
                this.Name = name;
                this.SurName = surname;
                Console.WriteLine("Person Nesnesi Oluşturuldu.");
            }
            public virtual void Intro()
            {
                Console.WriteLine($"name: {this.Name} surname: {this.SurName}");

            }
        }
       
        class Student : Person
        {
            public string studentNumber { get; set; }
            public Student(string name,string surname,string studentNumber) :base(name,surname)
            {
                this.studentNumber = studentNumber;
                Console.WriteLine("Student Nesnesi Oluşturuldu.");
            }
            public override void Intro()
            {
                Console.WriteLine($"name: {this.Name} surname: {this.SurName} Number: {this.studentNumber}");

            }
        }
        class Teacher : Person
        {
            public string  Branch { get; set; }
            public Teacher(string name,string surname, string branch) :base(name, surname)
            {
                this.Branch = branch;
                Console.WriteLine("Teacher Nesnesi Oluşturuldu.");
            }
            public void Teach()
            {
                Console.WriteLine("I am teaching...");
            }
            public override void Intro()
            {
                Console.WriteLine($"name: {this.Name} surname: {this.SurName} Branch: {this.Branch}");

            }
        }

      abstract  class Shape
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public Shape(int w,int h)
            {
                this.Width = w;
                this.Height = h;
            }
            public abstract void Draw();
            public int CalculateArea()
            {
                return this.Width * this.Height;
            }
            
        }
        class Square : Shape
        {
            public Square(int w,int h):base(w,h)
            {

            }
            public override void Draw()
            {
                
                Console.WriteLine("Draw a Square");
            }
        }
        class Rectangle : Shape
        {
            public Rectangle(int w, int h):base(w,h)
            {

            }
            public override void Draw()
            {
                
                Console.WriteLine("Draw a Rectangle");
            }
        }


        static void Main(string[] args)
        {
            // inheritance (Kalıtım): Miras Alma
            // Person=> name, surname, age, eat(), drink(), run()
            // Student=>studentNumber, study()
            // Teacher=>branch,teach()

            //var p=new Person("Ahmet","ALAÇATI");
            //var s = new Student("Devrim Mehmet", "Pattabanoğlu","655");
            //var t = new Teacher("Sadık", "Turan", "Bilişim");
            //p.Intro();
            //s.Intro();
            //t.Intro();
            var shapes = new Shape[3];
            shapes[0] = new Rectangle(10,15);
            shapes[1] = new Square(15,15);
            shapes[2] = new Rectangle(15,20);

            foreach (var shape in shapes)
            {
                shape.Draw();
                Console.WriteLine($"Alan: {shape.CalculateArea()}");
            }
        }
    }
}
