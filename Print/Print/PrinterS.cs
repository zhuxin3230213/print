using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    public class PrinterS : PrinterSys
    {
        public PrinterS(string name)
            : base(name)
        {

        }

        /// <summary>
        /// 获取打印机状态
        /// </summary>
        /// <returns></returns>
        public enum_printerS_status getStatus()
        {
            enum_printerSys_status statusSys = base.getStatus();
            enum_printerS_status status;
            switch (statusSys)
            {
                // Epson
                case enum_printerSys_status.free:
                    status = enum_printerS_status.ready;
                    break;
                case enum_printerSys_status.print:
                case enum_printerSys_status.printing:
                    status = enum_printerS_status.print;
                    break;
                case enum_printerSys_status.warmup:
                    status = enum_printerS_status.other;
                    break;
                default:
                    status = enum_printerS_status.warn;
                    break;
            }
            return status;
        }
    }
}
