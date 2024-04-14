using System.Reflection.Metadata;

namespace MyInheritance
{
    class ProgramMain
    {
        public static void Main(string[] args)
        {
            ////Single_Level:A derived class that inherits from only one base class.
            //string[] dogFoods = { "Meat", "Biscuits", "Bones" };
            //Dog dog = new Dog(dogFoods);
            //dog.PrintFavoriteFoods(); // Output the dog's favorite foods


            ////Multi_Level:A derived class that inherits from a base class
            /// and the derived class itself becomes the base class for another derived class.
            //Multi_C c = new Multi_C();
            //c.MethodA();
            //c.MethodB();
            //c.MethodC();


            ////Hierarchical:A base class that serves as a parent class for two or more derived classes.
            //Derived1 b1 = new Derived1();
            //Derived2 c1 = new Derived2();
            //Console.WriteLine(b1.Info());
            //Console.WriteLine(Derived2.GetInfo());


            //Multiple Inheritance:One derived class inherits from multiple base classes.
            //Multi_Documents obj = new Multi_Documents();
            //obj.Print();
            //obj.Display();

            //Instance Method
            //Dog_Using_Instance_Method obj = new Dog_Using_Instance_Method();
            //obj.Eat();    //calling the inherited method from Animal
            //obj.Bark();

            //Abstract class
            //Abstract_Circle circle = new Abstract_Circle(5);
            //circle.Display(); // Inherited method from the abstract class
            //Console.WriteLine("Area of the circle: " + circle.Area()); // Implemented abstract method



        }
    }
}




/*Important Points
           * A superclass can have any number of subclasses. But a subclass can have only one superclass. 
           * Constructors are not members, so they are not inherited by subclasses, 
              but the constructor of the superclass can be invoked from the subclass.
           * Static classes cannot be Inherited
           */  /*Important Points
             * A superclass can have any number of subclasses. But a subclass can have only one superclass. 
             * Constructors are not members, so they are not inherited by subclasses, 
                but the constructor of the superclass can be invoked from the subclass.
             * Static classes cannot be Inherited
             */