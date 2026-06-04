using Newtonsoft.Json.Serialization;

namespace CoreMVC_DatabaseFirst.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public decimal Age { get; set; }
        public string Weight { get; set; }

        public Person(string name)
        {
            Name= name;
        }

        public override string ToString()
        {
            return Name;
        }
        public void Print()
        {

        }
    }
}
