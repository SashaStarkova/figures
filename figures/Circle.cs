using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
	class Circle : Figure
	{
		public Circle( string KolToch, string Plosh, string Perim) : base( KolToch, Plosh, Perim)
		{

		}
		public void Info()
		{
			Console.WriteLine("Факт о фигуре:");
			Console.WriteLine("Радиус круга равен половине его диаметра.");
		}
	}
}
