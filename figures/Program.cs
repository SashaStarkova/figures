using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
	class Program
	{
		static void Main(string[] args)
		{ string a;
			Console.WriteLine("Введите название фигуры");
			
			Triangle A = new Triangle("3", "a*h/2", "a+b+c");
			Square B = new Square( "4", "a*a", "4a");
			Circle C = new Circle( "бесконечное", "R*R", "2*п*R");
			Rhombus D = new Rhombus( "4", "1/2*d1*d2", "4а");
			Trapeze E = new Trapeze("4","(a+b)/2*h","a+b+c+d");
			int kol = 0;
			while (kol<4)
			{
				a = Console.ReadLine();
				if ((a == "Треугольник") || (a == "Квадрат") || (a == "Круг") || (a == "Ромб")|| (a == "Трапеция"))
				{
					switch (a)
					{
						case "Треугольник":  A.ShowInfo(); A.Info();break;

						case "Квадрат":  B.ShowInfo();B.Info(); break;

						case "Круг":  C.ShowInfo();C.Info(); break;

						case "Ромб":  D.ShowInfo();D.Info(); break;

						case "Трапеция":  E.ShowInfo();E.Info(); break;
					}
					kol++;
				}
				else Console.WriteLine("Введите правильное(существующее) название фигуры");
			}
			Console.ReadKey();
		}
	}
}
