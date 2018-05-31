using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Square
	{
		public double LengthOfSides { get; set; }
		//Public means that other classes can access this data
		//Get means the value of this can be requested by just referencing the name (LengthOfSides) on the right side of an assignment.  
		//The set says you can change the value by putting on the left side of an assignment

		public double GetArea()
		{
			return LengthOfSides * LengthOfSides;
		}
		//Name the method by the action it's completing.  We're retrieving the area, so we should name it GetArea, not just Area
		//We're leaving the body ( () ) empty because we're calling the other method, LengthOfSide

		public double GetPerimeter()
		{
			return 4 * LengthOfSides;
		}
		public void Print()
		{
			Console.WriteLine($"A square with a length of {LengthOfSides} has an area of {GetArea()} and a perimeter of {GetPerimeter()}.");
		}
		//this is void because it's not going to return a value
		//($"") is interpolation, which is an easier way to convert a variable to a string
		
	}
}
