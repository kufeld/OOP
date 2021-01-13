using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LinqVariant3
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "мама", "папа", "бабушка", "дедушка", "брат", "сестра", "я", "собака" };

            var updatedWords = GetFirstThreeLetters(words);
            foreach (var word in updatedWords)
                Console.WriteLine(word);

            var strs = File.ReadAllLines("db.txt");
            var dataBase = new List<Record>();

            foreach (var str in strs)
            {
                var data = str.Split();

                var record = new Record()
                {
                    ClientID = int.Parse(data[0]),
                    Year = int.Parse(data[1]),
                    Month = int.Parse(data[2]),
                    Duration = int.Parse(data[3])
                };

                dataBase.Add(record);
            }

            PrintSumDurationForClients(dataBase);

            Console.ReadKey();
        }

        static string[] GetFirstThreeLetters(string[] array)
        {
            return array
                .Where(x => x.Length != 0)
                .Select(x => (x.Length > 3 ? x.Remove(3) : x).ToUpper())
                .Distinct()
                .OrderByDescending(x => x)
                .ToArray();
        }

        static void PrintSumDurationForClients(List<Record> db)
        {
            var ClientBase = db
                .GroupBy(x => x.ClientID)
                .Select(x => (x.Select(y => y.Duration).Sum(), x.Key))
                .OrderByDescending(x => x.Item1)
                .ThenBy(x => x.Key)
                .ToArray();
            foreach (var client in ClientBase)
            {
                Console.WriteLine($"Суммарная продолжительность занятий {client.Item1} ч. для клиента с ID:{client.Key}");
            }
        }
    }
}
