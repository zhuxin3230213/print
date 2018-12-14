using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    public class PrinterSys : Printer
    {
        public PrinterSys(string name)
            : base(name)
        {
        }

        /// <summary>
        /// 获取打印机状态
        /// </summary>
        /// <returns></returns>
        public enum_printerSys_status getStatus()
        {
            return (enum_printerSys_status)base.getStatus();
        }
    }
}
