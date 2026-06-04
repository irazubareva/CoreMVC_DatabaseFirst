using Newtonsoft.Json.Serialization;

namespace CoreMVC_DatabaseFirst.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }

        public Person(string name, string adress, int age, int weight) 
        { 
            Name = name;
            Adress = adress;
            Age = age;
            Weight = weight;
        
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
