using System;
using System.Collections.Generic;


namespace KKMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            App breadSticks = new App(5.00); //The price set is over the actual price therefore the getter/setter defaults the price to original price set down below.
            string appDes = "Breadsticks - Fresh breadsticks topped with garlic butter spread - ";
            
            MainCourse lasagna = new MainCourse(13.00); //The price set is over the actual price therefore the getter/setter defaults the price to original price set down below.
            string mainDes = "Lasagna - Our fabulous four cheese Lasagna topped with fresh parmesan cheese - ";
            
            Desert chocolateCake = new Desert(4.00); //The price set is over the actual price therefore the getter/setter defaults the price to original price set down below.
            string desertDes = "Chocolatey fluffy rich in flavor, drizzled with the best of chocolate drizzles made in house - ";

            string New = "NEW!";

            Console.WriteLine(appDes + "\n" +breadSticks.Price);
            Console.WriteLine(mainDes + New + "\n" + lasagna.Price);
            Console.WriteLine(desertDes + "\n" + chocolateCake.Price);

            DateTime lastWriteTime = File.GetLastWriteTime(@"C:\Users\kaleb\OneDrive\Desktop\New folder\Menu\Program.cs");
            Console.WriteLine(lastWriteTime);
        }
    }
    
    class App
    {
        private double price;
        public App(double price)
        {
            Price = price;
        }

        public double Price
        {
            get { return price; }
            set {
                 if (value > 4.99) //Default Price, Restraunt would change this value
                 {
                    price = 4.99; //Default Price, Restraunt would change this value
                 }
                 else
                 {
                 price = value;
                 }
                }
        }
    }
    class MainCourse
    {
        private double price;
        public MainCourse(double price)
        {
        Price = price;
        }

        public double Price
        {
            get { return price; }
            set{
                if (value > 12.99) //Default Price, Restraunt would change this value
                {
                    price = 12.99; //Default Price, Restraunt would change this value
                }
                else 
                {
                    price = value;
                }
            }
        }
    }
    class Desert
    {
        private double price;
        public Desert(double price)
        {
        Price = price;
        }

        public double Price
        {
            get{ return price;}
            set{
                if ( value > 3.99) //Default Price, Restraunt would change this value
                {
                    price = 3.99; //Default Price, Restraunt would change this value
                }
                else
                {
                    price = value;
                }
                
            }
        }
    }
    
}