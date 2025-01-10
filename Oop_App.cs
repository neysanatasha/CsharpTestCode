using System;

namespace oop_challange
{

    class Program
    {
        static void Main()
        {
            FormulatrixRepositoryManager repositoryManager = new FormulatrixRepositoryManager();
            repositoryManager.Initialize();

            // Register and retrieve items
            repositoryManager.Register("json1", "{ 'name': 'Harry', 'age': 18 }", (int)EnumFileFormat.JSON);
            repositoryManager.Register("xml1", "<person><name>Layla</name><age>31</age></person>", (int)EnumFileFormat.XML);
            repositoryManager.Register("json2", "{ 'name': 'Potter', 'age': 26 }", (int)EnumFileFormat.JSON);
            repositoryManager.Register("xml2", "<person><name>Forger</name><age>22</age></person>", (int)EnumFileFormat.XML);

            Console.WriteLine("Retrieved JSON item: " + repositoryManager.Retrieve("json1"));
            Console.WriteLine("Retrieved XML item: " + repositoryManager.Retrieve("xml1"));

            // Retrieve item type
            Console.WriteLine("Type of jsonItem: " + repositoryManager.GetType("json1"));
            Console.WriteLine("Type of xmlItem: " + repositoryManager.GetType("xml1"));

            // Deregister an item
            repositoryManager.Deregister("json1");

            // Retrieve item type
            Console.WriteLine("Type of jsonItem: " + repositoryManager.GetType("json1"));
            Console.WriteLine("Type of xmlItem: " + repositoryManager.GetType("xml1"));

        }
    }
}