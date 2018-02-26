using SaiYuan;
using Spreadtrum;
using System;
using System.IO;

namespace SCPortScanner
{
    class Program
    {
        static object[,] arguments = 
        {
            {"c", true, "串口号", "请输入当前工位端口号" },
            {"i", true, "IMEI号码", "请输入要写入的IMEI号码" },
            {"a", false, "这是一个可选参数", "" }
        };

        static void Main(string[] args)
        {
            //log4net.ILog logInfo = log4net.LogManager.GetLogger("loginfo");
            //logInfo.Info("测试日志写入");
            //ParameterParser parameterParser = new ParameterParser(arguments);
            //string result = parameterParser.Parse(args);
            //if (!StringUtils.IsEmpty(result))
            //{
            //    Console.Write(System.Diagnostics.Process.GetCurrentProcess().MainModule.ModuleName);
            //    Console.Write(result);
            //    return;
            //}
            PhoneCommand.SP_EnterModeProcess()
        }
    }
}
