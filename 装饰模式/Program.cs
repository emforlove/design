using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * 装饰模式：动态的给一个对象添加一些额外的职责，就增加功能来说， 装饰模式比生成子类更为灵活。
 * 
 * 装饰模式是为已有功能动态的添加更多功能的一种方式。
 * 优点：把类中的装饰功能搬移出去，这样可以简化原有的类，有效的把类的核心职责和装饰功能分开， 而且还可以去除类中复杂的装饰逻辑。
 * 
 * 缺点：装饰模式的顺序很重要， 最理想的情况是保证装饰类之间都是彼此独立， 这样就可以按照任意的顺序进行组合。
 * 
 **/
namespace 装饰模式
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA da = new ConcreteDecoratorA();
            ConcreteDecoratorB db = new ConcreteDecoratorB();

            da.SetComponent(c);
            db.SetComponent(da);
            db.Operation();

            Console.ReadLine();
        }
    }
}
