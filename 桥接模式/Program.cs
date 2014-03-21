using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 桥接模式
             * 将抽象部分与它的实现部分分离， 使它们都可以独立地变化。
             * 
             * 实现系统有可能有多角度分类， 每一种分类都有可能变化， 那么就把这种多角度分离出来让他们独立变化， 减少它们之间的耦合。
             * 
             * 合成 聚合复用原则： 尽量使用 合成 聚合， 尽量不要使用类继承。
             * 
             * 优先使用对象的合成 聚合将有助于你保持每个类被封装， 并被集中在单个任务上。 这样类和类继承层次会保持较小规模， 并且不大可能增长为不可控制的庞然大物。
             */

            // Abstraction 抽象
            // Implementor 实现
            // RefineAbstraction 被提炼的抽象
            // ConcreteImplementorA，ConcreteImplementorB 具体实现
            Abstraction ab = new RefineAbstraction();

            ab.SetImplementor(new ConcreteImplementorA());
            ab.Operation();

            ab.SetImplementor(new ConcreteImplementorB());
            ab.Operation();

            Console.ReadLine();
        }
    }
}
