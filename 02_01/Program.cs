using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 计算BMI,elseif
            float height = float.Parse(Console.ReadLine());
            float weight = float.Parse(Console.ReadLine());
            float BMI = weight / (height * height);
            Console.WriteLine("Your BMI is {0}",BMI);
            if(BMI < 18.5f)
            {
                Console.WriteLine("guoqing");
            }
            else if(BMI < 24f)
            {
                Console.WriteLine("zhengchang");
            }
            else 
            {
                if (BMI < 27f)
                {
                    Console.WriteLine("qingfei");
                }
                else if (BMI < 30f)
                {
                    Console.WriteLine("zhongfei");
                }
                else if (BMI < 35f)
                {
                    Console.WriteLine("zhongfei");
                }
                else
                {
                    Console.WriteLine("zhongfei2");
                }
            }
            Console.ReadLine();

            #endregion else
            #region 计算年龄 if

            //Console.WriteLine("请输入性别");
            //string sex = Console.ReadLine();
            //if (sex == "男性")
            //{
            //    Console.WriteLine("请输入年龄");
            //    int age = int.Parse(Console.ReadLine());

            //    if (age < 12)
            //    {
            //        Console.WriteLine("正太");
            //    }
            //    else
            //    {
            //        Console.WriteLine("成男");
            //    }

            //}

            //else
            //{
            //    if (sex == "女性")
            //    {
            //        Console.WriteLine("请输入年龄");
            //        int age = int.Parse(Console.ReadLine());

            //        if (age < 10)
            //        {
            //            Console.WriteLine("萝莉");
            //        }
            //        else
            //        {
            //            Console.WriteLine("成女");
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("性别错位");

            //    }

        }
        #endregion
            
            
        }
}

