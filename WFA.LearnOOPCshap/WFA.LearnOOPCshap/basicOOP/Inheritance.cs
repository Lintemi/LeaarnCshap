using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.LearnOOPCshap
{
	/// <summary>
	/// Inheritance
	/// มีนคือการสืบทอดนั้นเอง
	/// จาก baseClassInheritance สู่ childClass
	/// ถ้าเราจะ resuse ไปที่หัวข้อ Polymorphism 
	/// </summary>
	class baseClassInheritance // base class (parent) 
	{
		public string brand = "Ford";   // baseClass field
		public void honk()              // baseClass method
		{
			Console.WriteLine("Tuut, tuut!");
		}
	}

	class childClass : baseClassInheritance  // derived class (child)
	{
		public string modelName = "Mustang";  // childClass field
	}

	class ProgramInheritance
	{
		static void Main(string[] args)
		{
			// Create a myCar object
			childClass myCar = new childClass();

			// Call the honk() method (From the Vehicle class) on the myCar object
			myCar.honk();

			// Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
			Console.WriteLine(myCar.brand + " " + myCar.modelName);
		}
	}
}
