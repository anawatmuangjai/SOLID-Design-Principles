using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("The Hobbit");
            journal.AddEntry("The Lord Of The Ring");
            Console.WriteLine(journal);

            var filename = @"D:\test\journal.txt";

            var persistence = new Persistence();
            persistence.SaveToFile(journal, filename, true);
            Process.Start(filename);
        }
    }
}
