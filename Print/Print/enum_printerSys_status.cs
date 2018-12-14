using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    // 打印机状态集合
    public enum enum_printerSys_status
    {
        /// <summary>
        /// 其他状态
        /// </summary>
        other = 1,
        /// <summary>
        /// 未知
        /// </summary>
        unknown,
        /// <summary>
        /// 空闲
        /// </summary>
        free,
        /// <summary>
        /// 正在打印
        /// </summary>
        print,
        /// <summary>
        /// 预热
        /// </summary>
        warmup,
        /// <summary>
        /// 停止打印
        /// </summary>
        stop,
        /// <summary>
        /// 打印中
        /// </summary>
        printing,
        /// <summary>
        /// 离线
        /// </summary>
        offline,
    }

}
