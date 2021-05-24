using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figures
{
	class Figure
	{
		public string KolToch;
		public string Plosh;
		public string Perim;
		public Figure( string KolToch, string Plosh, string Perim)
		{
			
			this.KolToch = KolToch;
			this.Plosh = Plosh;
			this.Perim = Perim;
		}
		public virtual void ShowInfo()
		{
			
			Console.WriteLine("Количество точек фигуры:"+KolToch);
			Console.WriteLine("Площадь: "+Plosh);
			Console.WriteLine("Периметр: "+Perim);
			Console.WriteLine();
		}
	}
}
