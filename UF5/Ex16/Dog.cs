using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadesUF5
{
    public class Dog
    {
        public string? Name { get; set; }
        public string? Breed { get; set; }
        public int Age { get; set; }
        public Dog(string? name, string? breed, int age)
        {
            Name = name;
            Breed = breed;
            Age = age;
        }
        public override String ToString()
        {
            StringBuilder dogInfo = new StringBuilder();
            dogInfo.Append("Name: ");
            dogInfo.Append(Name);
            dogInfo.Append(", Breed: ");
            dogInfo.Append(Breed);
            dogInfo.Append(", Age: ");
            dogInfo.Append(Age);
            return dogInfo.ToString();
        }
    }
}
