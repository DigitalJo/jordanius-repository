using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenXmlExcelCreatePivotTable
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratedCode.GeneratedClass gen = new GeneratedCode.GeneratedClass();
            gen.CreatePackage("test.xlsx");
        }
    }
}
