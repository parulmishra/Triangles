using System;

namespace Triangles.Models
{
	public class Triangle
	{
		private int side1;
		private int side2;
		private int side3;
		
		public void SetSide1(int newSide)
		{
			side1 = newSide;
		}
		public int GetSide1()
		{
			return side1;
		}
		public void SetSide2(int newSide)
		{
			side2 = newSide;
		}
		public int GetSide2()
		{
			return side2;
		}
		public void SetSide3(int newSide)
		{
			side3 = newSide;
		}
		public int GetSide3()
		{
			return side3;
		}
		
		public string determineTriangle()
		{
			string result = "Not Determined";
			if((side1 == side2) && (side2 == side3))
				result = "Equilateral triangle";
			else if((side1 == side2) || (side1 == side3) || (side2 == side3))
				result = "Isosceles Triangle";
			else 
				result = "Scalene Triangle";
			return result;
		}
		
	}
}