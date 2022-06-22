using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreDataStructures
{
    /// <summary>
    /// Features of Tuples
    /// It allows us to represent multiple data into a single data set.
    /// It allows us to create, manipulate, and access data set.
    /// It return multiple values from a method without using out parameter.
    /// It can also store duplicate elements.
    /// It allows us to pass multiple values to a method with the help of single parameters.
    /// </summary>
    public class TupleStructure
    {
        public void TupleExamples()
        {
            Tuple<string> tuple1 = new Tuple<string>("ArtturoBld");
            Tuple<string, string, int> tuple2 = new Tuple<string, string, int>("Arturo","Balderas",30);
            var My_Tuple1 = Tuple.Create("ArtturoBld");
            var My_Tuple2 = Tuple.Create("Arturo", "Balderas", 30);

            PrintTuple(My_Tuple2);
        }

        public void PrintTuple<T>(Tuple<T> tuple)
        {
            Console.WriteLine(tuple.Item1);
        }

        public void PrintTuple<T,T2>(Tuple<T,T2> tuple)
        {
            Console.WriteLine($"{tuple.Item1},{tuple.Item2}");
        }

        public void PrintTuple<T,T2,T3>(Tuple<T,T2,T3> tuple)
        {
            Console.WriteLine($"{tuple.Item1},{tuple.Item2},{tuple.Item3}");
        }

        public void PrintTuple<T, T2, T3, T4>(Tuple<T, T2, T3, T4> tuple)
        {
            Console.WriteLine($"{tuple.Item1},{tuple.Item2},{tuple.Item3},{tuple.Item4}");
        }

        public void PrintTuple<T, T2, T3, T4, T5>(Tuple<T, T2, T3, T4, T5> tuple)
        {
            Console.WriteLine($"{tuple.Item1},{tuple.Item2},{tuple.Item3},{tuple.Item4},{tuple.Item5}");
        }

        public void PrintTuple<T, T2, T3, T4, T5, T6>(Tuple<T, T2, T3, T4, T5, T6> tuple)
        {
            Console.WriteLine($"{tuple.Item1},{tuple.Item2},{tuple.Item3},{tuple.Item4},{tuple.Item5},{tuple.Item6}");
        }

        public void PrintTuple<T, T2, T3, T4, T5, T6, T7>(Tuple<T, T2, T3, T4, T5, T6, T7> tuple)
        {
            Console.WriteLine($"{tuple.Item1},{tuple.Item2},{tuple.Item3},{tuple.Item4},{tuple.Item5},{tuple.Item6},{tuple.Item7}");
        }

        public void PrintTuple<T, T2, T3, T4, T5, T6, T7, T8>(Tuple<T, T2, T3, T4, T5, T6, T7, T8> tuple)
        {
            Console.WriteLine($"{tuple.Item1},{tuple.Item2},{tuple.Item3},{tuple.Item4},{tuple.Item5},{tuple.Item6},{tuple.Item7},{tuple.Rest}");
        }
    }
}
