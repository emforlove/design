using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 单例模式
{
    class Singleton
    {
        private static Singleton instance;

        private static readonly object syncRoot = new object(); // 程序运行时创建一个静态只读的进程辅助对象

        private Singleton() // 构造方法为 private， 这就堵死了外界利用new创建此类实例的可能
        { }

        public static Singleton GetInstance() // 此实例获得本类实例的唯一全局访问点
        {
            if (instance == null) // 如果实例不存在
            {
                lock (syncRoot) // 在同一个时刻加入了锁的那部分程序，只有一个线程可以进入
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
    }
}