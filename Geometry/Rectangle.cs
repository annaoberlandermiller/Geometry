using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	class Rectangle : Quadrilateral
	{
		public override int GetArea()
		{
			return this.Side1 * this.Side2;  
			//whenever you have a method in a base class and you think you'll need to do something different in teh derrived class, mark the derived class method as override

		}

		public Rectangle(int length, int width)
		{
			this.Side1 = length;
			this.Side3 = length;
			this.Side2 = width;
			this.Side4 = width;
		}


	public Rectangle()
		{

		}
	}

}
