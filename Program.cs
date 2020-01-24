using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
	class Program
	{
		static void Main(string[] args)
		{
			SimpleCalculator calculator = new SimpleCalculator();

			double a = 10;
			double b = 5;

			Console.WriteLine("{0} + {1} = {2}", a, b, calculator.Add(a,b));
			Console.WriteLine("{0} * {1} = {2}", a, b, calculator.Multiply(a,b));
			Console.WriteLine("{0} - {1} = {2}", a, b, calculator.Substract(a,b));

			double devisionResult = calculator.Devide(a, b);
			if (devisionResult != 0 || a == devisionResult)
			{
				Console.WriteLine("{0} / {1} = {2}", a, b, devisionResult);
			}
			else
			{
				// Division with 0 happened!
			}
		}
	}
}
