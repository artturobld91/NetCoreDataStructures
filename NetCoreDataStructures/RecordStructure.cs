using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreDataStructures
{
    public class RecordStructure
    {
        public record Person(string FirstName, string LastName);
        public record Car
        {
            public string Model { get; init; } = default!;
            public string Make { get; init; } = default!;
        }

        public readonly record struct Point(double x, double y, double z);

        public void RecordExamples()
        {
            Person person1 = new("Arturo", "Balderas");
            Person person2 = new("Ximena", "Moreno");
            Console.WriteLine(person1);
            Console.WriteLine(person2);
            //ReferenceEquals(person1, person2);  
        }
    }
}
