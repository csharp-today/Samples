namespace CSharp7.Deconstruction
{
    class Example3
    {
        (string name, int age) GetPerson() => ("John", 24);

        public void Run()
        {
            string name;
            int age;
            (name, age) = GetPerson();
        }
    }
}
