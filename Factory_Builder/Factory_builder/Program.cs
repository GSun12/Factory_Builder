using System;
using Factory_builder.Enums;
using Factory_builder.Factory;

namespace Factory_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new GenerateDocumentFactory();
            var certyficate = factory.Generate(DOCUMENT_TYPE.Certificate);
            var contract = factory.Generate(DOCUMENT_TYPE.Contract);

            Console.WriteLine(certyficate.Name);
            Console.WriteLine(certyficate.Size);


            Console.WriteLine(contract.Name);
            Console.WriteLine(contract.Size);

            Console.ReadKey();
        }
    }
}
