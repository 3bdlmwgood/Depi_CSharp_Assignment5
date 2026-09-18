namespace ConsoleApp1
{
    internal class Program
    {
        
        static void PrintHeader(int QuestionNumber)
        {
            Console.WriteLine($"====================== Q{QuestionNumber} ======================\n");
        }

        static void PrintFooter()
        {
            Console.WriteLine("\n-------------------------------------------------\n\n");
        }

        static void ProcessPerson(Person person)
        {
            person.Greet();
            person.Display();
        }

        static void Main(string[] args)
        {
            #region Q1

            PrintHeader(1);

            Shape s = new Shape(3,5);

            Console.WriteLine(s);
            Console.WriteLine($"Area = {s.Area()}");

            PrintFooter();

            #endregion


            #region Q2

            PrintHeader(2);

            Cube c = new Cube(2,3,4);

            c.Print();
            Console.WriteLine($"Area =  {c.Area()}");

            PrintFooter();

            #endregion


            #region Q3

            PrintHeader(3);

            Shape shape = new Shape(2, 3);
            Console.WriteLine($"Area = {shape.Area()}");    // Prints 6 -- 2*3

            Cube cube = new Cube(2, 3, 4);
            Console.WriteLine($"Area = {cube.Area()}");    // Prints 24 -- 2*3*4


            Shape shapeRef = new Cube(2, 3, 4);
            Console.WriteLine($"Area = {shapeRef.Area()}");    // Prints 6 -- Because Area() is hidden using new and the reference type is Shape so Shape.Area() is called.


            PrintFooter();

            #endregion


            #region Q4

            PrintHeader(4);

            object obj = new Cube(1,2,3);

            Console.WriteLine( obj.ToString());


            /* Prints Shape.ToString() Because ToString() is virtual in object and Shape overrides it. 
             * The actual object is Cube, so the overridden method is resolved at runtime.
            */

            PrintFooter();

            #endregion


            #region Q5

            PrintHeader(5);

            Person p = new Person();

            p.Greet();
            p.Display();

            PrintFooter();

            #endregion


            #region Q6

            PrintHeader(6);

            Doctor d = new Doctor { ID = 1 , Name = "Abdallah" , Age =21 , Specialty="---"};
            d.Greet();
            d.Display();

            Engineer e = new Engineer { ID = 1 , Name = "Abdallah" , Age =21 , Field="---" , YearsOfExperience =2};
            e.Greet();
            e.Display();

            PrintFooter();
            #endregion


            #region Q7

            PrintHeader(7);

            Person doctor = new Doctor {ID = 1 , Name = "Ahmed" ,Age = 25 , Specialty = "any" };
            ProcessPerson( doctor );

            Person engineer = new Engineer {ID = 1 , Name = "mohamed" ,Age = 22 , Field = "fssf" ,YearsOfExperience =2 };
            ProcessPerson( engineer );

            /*
                Greet() prints the Person version in both cases
                because Greet() is non-virtual and the derived
                classes hide it using new.

                The reference type is Person, so Person.Greet()
                is called.

                Display() is virtual in Person and overridden
                in Doctor and Engineer, so the derived version
                is called at runtime.
            */

            PrintFooter();

            #endregion


            #region Q8

            PrintHeader(8);
            Console.WriteLine("causes a compiler error.This happens because a method must be virtual, abstract, " +
                "\nor override in the base class before a derived class can override it.");
            PrintFooter();
            #endregion


            #region Q9

            PrintHeader(9);

            Console.WriteLine("The problem is that not every vehicle needs or supports the same methods. \n" +
                "Interfaces solve this by allowing each class to implement only the behaviors it needs.");

            PrintFooter();

            #endregion


            #region Q10

            PrintHeader(10);

            Console.WriteLine("Imovable and IFlyable Added.");
            
            PrintFooter();
            #endregion



        }
    }
}
