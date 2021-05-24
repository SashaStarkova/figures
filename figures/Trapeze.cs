using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
	class Trapeze : Figure
	{
		public Trapeze(string KolToch, string Plosh, string Perim) : base(KolToch, Plosh, Perim)
		{

		}
		public void Info()
		{
			Console.WriteLine("Факт о фигуре:");
			Console.WriteLine("Средняя линия трапеции параллельна основаниям и равна их полусумме.");
		}
	}
}
