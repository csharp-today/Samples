using System.ComponentModel.DataAnnotations.Schema;

namespace PostgreCodeFirst
{
    [ComplexType]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
