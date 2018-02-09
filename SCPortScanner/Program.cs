using SaiYuan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCPortScanner
{
    class Program
    {
        static object[,] arguments = 
        {
            {"a", true, "这是第一个参数", "请输入第一个参数" },
            {"b", true, "这是第二个参数", "请输入第二个参数" },
            {"c", false, "这是第三个参数", "" },
        };

        static void Main(string[] args)
        {
            ParameterParser parameterParser = new ParameterParser(arguments);
        }
    }
}
