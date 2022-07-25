using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string shp;
            Console.WriteLine("请输入敌人血量：");
            shp = Console.ReadLine();
            int hp;
            hp = int.Parse(shp);

            string satk;
            Console.WriteLine("请输入玩家的攻击力：");
            satk = Console.ReadLine();
            int atk;
            atk = int.Parse(satk);
                                 

            Console.WriteLine("按回车攻击敌人");
            Console.ReadLine();

            hp -= atk;
            Console.WriteLine("玩家战斗为：{1}，敌人被攻击后的血量是：{0}",hp,atk);

            if (hp < 30)
            {
                Console.WriteLine("敌人血量到了斩杀线，按回车斩杀！");
                Console.ReadLine();
                Console.WriteLine("斩杀成功，敌人死亡！");
                
            }
            else
            {
                Console.WriteLine("继续攻击！");
                
            }
            Console.ReadLine();

        }
    }
}
