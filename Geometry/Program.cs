using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle cir1 = new Circle();
			cir1.radius = 2.5;
			cir1.Print();

			Rectangle rect1 = new Rectangle();
			rect1.height = 1.2;
			rect1.width = 8.2;
			rect1.Print();

			Square sqr = new Square();
			//we've defined a variable named sqr - it's type is the class Square. sqr is one instance of the square
			sqr.LengthOfSides = 1.5;
			//this is setting the value of LengthOfSides
			double sidelength = sqr.LengthOfSides;
			double area = sqr.GetArea();
			//execute the GetArea method of the variable sqr
			double perimeter = sqr.GetPerimeter();
			//execute the method GetPerimeter on the variable sqr
			Console.WriteLine("The length of the side of the square is {2}.  Area is {0}.  Perimeter is {1}.", area, perimeter, sidelength);
			//this will print "Area is {the variable area}. Perimeter is {the variable perimeter}.  0 corresponds with area, 1 corresponds with perimeter.

			//Square sqr2 = new Square();
			//sqr2.LengthOfSides = 3.3;
			//Console.WriteLine("Area is {0}.  Perimeter is {1}.", sqr2.GetArea(), sqr2.GetPerimeter());
			//We don't have to create a variable that does these actions - we can just use the methods we built!


			//Better yet, we can just do the following, using what we did on lin 29 of our Square class:
			Square sqr2 = new Square();
			sqr2.LengthOfSides = 3.3;
			sqr2.Print();

		
		}
	}
}
