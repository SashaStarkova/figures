using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
	class Rhombus : Figure
	{
		public Rhombus(string KolToch, string Plosh, string Perim) : base( KolToch, Plosh, Perim)
		{
		}
		public void Info()
		{
			Console.WriteLine("Факт о фигуре:");
			Console.WriteLine("Диагонали ромба пересекаются под прямым углом и в точке пересечения делятся пополам.");
		}
	}
}
