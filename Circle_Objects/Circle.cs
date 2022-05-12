using System;
namespace Circle_Objects
{
	public class Circle
	{
		public double radius { get; set; }
		public double circumference;
		public double area;

		public Circle (double aRadius)
        {
			radius = aRadius;
        }

		public double CalculateCircumference()
        {
			circumference = (2 * Math.PI * radius);
			return circumference;
        }

		public string CaclulateFormattedCircumference()
        {
			string fCircumference = FormatNumber(CalculateCircumference());
			return $"The circumference is {fCircumference}";
        }

		public double CalculateArea()
        {
			area = Math.PI * radius * radius;
			return area;
        }

		public string CalculateFormattedArea()
        {
			string fArea = FormatNumber(CalculateArea());
			return $"The area is {fArea}";
        }

		private string FormatNumber(double x)
        {
			string newString = Math.Round(x, 2).ToString();
			return newString;
		}
	}
}

