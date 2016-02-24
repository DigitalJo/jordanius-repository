using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.IO.Directory.GetCurrentDirectory() + "\\XMLFile1.xml";
           
            //xDoc2.Load(path);
            XDocument doc = XDocument.Load(path);
            foreach (XElement element in doc.Root
                                  .Element("Account")
                                  .Elements("User"))
            {
                Console.WriteLine("Username: {0}; Password: {1}; Active:{2}; Account: {3}; Details Account: {4}",
                                  (string)element.Element("Username"),
                                  (string)element.Element("Password"),
                                  (string)element.Element("Active"),
                                  (string)element.Element("Account"),
                                  (string)element.Element("Details").Element("Account"));
            }



            Console.ReadLine();
        }
    }
}
