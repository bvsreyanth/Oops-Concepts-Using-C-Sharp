namespace MyInheritance
{
    class Multi_C : Multi_B
    {
        public void MethodC()
        {
            Console.WriteLine("Method C in class C");
            MethodA();
        }
    }
}
