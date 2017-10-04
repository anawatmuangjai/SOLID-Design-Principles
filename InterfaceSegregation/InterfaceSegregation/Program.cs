using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Program
    {
        public class Document
        {

        }

        // Old
        public interface IMachine
        {
            void Print();
            void Scan();
            void Fax();
        }

        // Old
        public class MultiFunction : IMachine
        {
            public void Fax()
            {
                throw new NotImplementedException();
            }

            public void Print()
            {
                throw new NotImplementedException();
            }

            public void Scan()
            {
                throw new NotImplementedException();
            }
        }

        // Old
        public class OldFashionedPrinter : IMachine
        {
            public void Fax()
            {
                throw new NotImplementedException();
            }

            public void Print()
            {
                throw new NotImplementedException();
            }

            public void Scan()
            {
                throw new NotImplementedException();
            }
        }

        // New
        public interface IPrinter
        {
            void Print(Document d);
        }

        // New
        public interface IScanner
        {
            void Scan(Document d);
        }

        // New
        public class Photocopier : IPrinter, IScanner
        {
            public void Print(Document d)
            {
                throw new NotImplementedException();
            }

            public void Scan(Document d)
            {
                throw new NotImplementedException();
            }
        }

        // New
        public interface IMultiFunctionDevice : IPrinter, IScanner
        {

        }

        // New
        public class MultiFunctionMachine : IMultiFunctionDevice
        {
            private IPrinter _printer;
            private IScanner _scanner;

            public MultiFunctionMachine(IPrinter printer,IScanner scanner)
            {
                _printer = printer;
                _scanner = scanner;
            }

            public void Print(Document d)
            {
                _printer.Print(d);
            }

            public void Scan(Document d)
            {
                _scanner.Scan(d);
            }
        }

        static void Main(string[] args)
        {

        }
    }
}
