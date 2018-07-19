using System;

namespace CSharp7.Deconstruction
{
    class Officer
    {
        public string Name { get; set; }
        public string Rank { get; set; }

        public void Deconstruct(out string name, out string rank)
        {
            name = Name;
            rank = Rank;
        }
    }

    class OfficerExample
    {
        Officer GetOfficer() =>
            new Officer
            {
                Name = "James Bond",
                Rank = "Commander"
            };

        public void Run()
        {
            // It's allowed to deconstruct an Officer instance
            Officer officer = GetOfficer();
            var (name1, rank1) = officer;
            Console.WriteLine($"{name1} is {rank1}");

            // Or just deconstruct directly result of a method
            var (name2, rank2) = GetOfficer();
            Console.WriteLine($"{name2} is {rank2}");
        }
    }
}
