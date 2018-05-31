using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Circle
	{
		public double radius { get; set; }
		private double pi = 3.1415;
		//make Pi private - there's no need for the program to change this info

		public double GetArea()
		{
			return (pi * radius * radius);
		}
		public double GetPerimeter()
		{
			return (radius * 2 * pi);
		}

		public void Print()
		{
			Console.WriteLine($"A circle with a radius of {radius} has an area of {GetArea()} and a perimeter of {GetPerimeter()}.");
		}
	}
	
}
