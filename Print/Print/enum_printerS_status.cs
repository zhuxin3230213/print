using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    // 打印机可用状态集合
    public enum enum_printerS_status
    {
        /// <summary>
        /// 故障
        /// </summary>
        warn = 0,
        /// <summary>
        /// 打印中
        /// </summary>
        print,
        /// <summary>
        /// 空闲中
        /// </summary>
        ready,
        /// <summary>
        /// 其他状态
        /// </summary>
        other
    }

}
