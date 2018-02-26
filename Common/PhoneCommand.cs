using System;
using System.Runtime.InteropServices;

namespace Spreadtrum
{
    class PhoneCommand
    {

        public struct PCCHANNEL_ATTRIBUTE
        {

        }

        [DllImport("PhoneCommand", EntryPoint = "SP_BeginPhoneTest")]
        public extern static int SP_BeginPhoneTest(IntPtr hDiagPhone, );

        /// <summary>
        /// 展讯DLL进入工程模式
        /// </summary>
        /// <param name="hDiagPhone"></param>
        /// <param name="bUsbDevice"></param>
        /// <param name="nExpPort"></param>
        /// <param name="ePhoneMode"></param>
        /// <param name="hMonitorEvent"></param>
        /// <param name="ulTimeOut"></param>
        /// <returns></returns>
        [DllImport("PhoneCommand.dll", EntryPoint = "SP_EnterModeProcess")]
        public extern static int SP_EnterModeProcess(IntPtr hDiagPhone, bool bUsbDevice, int nExpPort, int ePhoneMode, IntPtr hMonitorEvent, ulong ulTimeOut);
    }
}