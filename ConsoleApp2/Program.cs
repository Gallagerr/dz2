using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
         //1.Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            Random rand = new Random();
            int number1, number2, number3;
            number1 = rand.Next(100);
            number2 = rand.Next(100);
            number3 = rand.Next(100);
            Console.Write(number1 + "  ");
            Console.Write(number2 + "  ");
            Console.Write(number3);
            Console.ReadLine();
            Console.ReadLine();


            //2.Вывести на экран числа 5, 10 и 21 одно под другим.
            int num1 = 5, num2 = 10, num3 = 21;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.ReadLine();


            //3.Дано расстояние в сантиметрах.Найти число полных метров в нем.
            Console.Write("Введите сантиметры: ");
            int metr;
            int santimetr=int.Parse (Console.ReadLine());
            metr = santimetr / 100;
            Console.Write("V " + santimetr + " santimetrach " + metr + " metr");
            Console.ReadLine();
            Console.ReadLine();


            //4.С некоторого момента прошло 234 дня.Сколько полных недель прошло за этот период ?
            int dni = 234, nedeli;
            nedeli = dni / 7;
            Console.WriteLine("За 234 дня прошло " + nedeli + " недели ");
            Console.ReadLine();


            //5.Дано двузначное число. Найти: a.число десятков в нем;  b.число единиц в нем;  c.сумму его цифр; d.произведение его цифр
            Console.Write("Введите двух значное число: ");
            int chislo = int.Parse(Console.ReadLine());
            int chislo1 = chislo % 100 / 10;
            int chislo2 = chislo % 10;
            Console.WriteLine("Десятков= " + chislo1 + " идениц= " + chislo2);
            int summa = chislo1 + chislo2;
            int proizv = chislo1 * chislo2;
            Console.WriteLine("Сума чисел= " + summa + " Произвидение чисел= " + proizv);
            Console.ReadLine();


            //7.Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
            Console.WriteLine("Введите радиус круга и стороны квадрата:");
            const double PI = 3.14;
            int radius = int.Parse(Console.ReadLine());
            int storona = int.Parse(Console.ReadLine());
            var ploshadKruga = PI * Math.Pow(radius, 2);
            var ploshadKvadrata = Math.Pow(storona, 2);
            if (ploshadKruga > ploshadKvadrata)
            { Console.WriteLine("Площать круга больше; площать круга= "+ploshadKruga); }
            else
            { Console.WriteLine("Площать квадрата больше; площать квадрата= " + ploshadKvadrata); }
            Console.ReadLine();


            //8.Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность ?
            Console.WriteLine("Введите массы тел:");
            int massa1 = int.Parse(Console.ReadLine());
            int massa2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите объемы тел:");
            int obem1 = int.Parse(Console.ReadLine());
            int obem2 = int.Parse(Console.ReadLine());
            int plotnost1 = massa1 / obem1;
            int plotnost2 = massa2 / obem2;
            if (plotnost1 > plotnost2)
            { Console.WriteLine("Плотность 1 тела больше; Площать 1 тела=" + plotnost1); }
            else
            { Console.WriteLine("Плотность 1 тела больше; Площать 2 тела=" + plotnost2); }
            Console.ReadLine();


            //9.Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?
            Console.WriteLine("Введите сопративление и напряжение 1 цепи:");
            int sopr1 = int.Parse(Console.ReadLine());
            int napr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопративление и напряжение 2 цепи:");
            int sopr2 = int.Parse(Console.ReadLine());
            int napr2 = int.Parse(Console.ReadLine());
            int menTok1 = napr1 / sopr1;
            int menTok2 = napr2 / sopr2;
            if (menTok1 > menTok2)
            { Console.WriteLine("сила тока меньше в 1 цепи; сила тока=" + menTok1); }
            else
            { Console.WriteLine("сила тока меньше в 2 цепи; сила тока=" + menTok2); }
            Console.ReadLine();
        }
    }
}
