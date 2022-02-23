using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.LearnOOPCshap
{
	class myClass // The class
	{
		// Class members
		/*defualt private*/ string color = "red";        // field
		/*defualt private*/ int maxSpeed = 200;          // field
		/*defualt private*/ string model;                // field

		/// <summary>
		/// ในบางครั้ง field name ก็อยากจะให้ภายนอกเข้าถึงแต่ไม่ให้เข้าถึงตรง ๆ 
		/// จึงมี property get / set ขึ้นมาให้ใช้
		/// สามารถเข้าถึงได้สองชื่อคือ name / Name
		/// แต่ภายนอกเข้าถึงได้ชื่อเดียวคือ Name
		/// </summary>
		private string name; // field
		public string Name   // property
		{
			get { return name; }   // get method
			set { name = value; }  // set method
		}

		/// <summary>
		/// Automatic Properties (Short Hand)
		/// ตัวแปลเดียวใช้ได้ทั้งสองฝั่งและใช้ชื่อเดียวในการเข้าถึงคือ Id
		/// </summary>
		public string Id { get; set; }

		// Create a class constructor for the Car class
		public myClass()
		{
			model = "Mustang"; // Set the initial value for model
		}

		public void fullThrottle()   // method
		{
			Console.WriteLine("The car is going as fast as it can!");
		}
	}
}
