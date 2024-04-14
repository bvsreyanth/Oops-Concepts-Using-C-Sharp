namespace MyInheritance
{

    internal class Derived1 : Base_A
    {
        public string Info()
        {
            var baseMessage = Msg();
            Console.WriteLine(baseMessage);
            return "This is B class Method";
        }
    }
}

