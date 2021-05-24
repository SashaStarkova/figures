using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
	class Triangle : Figure
	{ public Triangle( string KolToch, string Plosh, string Perim): base ( KolToch, Plosh, Perim)
		{ 
		
		}
		public void Info()
		{
			Console.WriteLine("Факт о фигуре:");
			Console.WriteLine("Сумма всех углов треугольника равна 180 градусов.");
		}
	}
}
