using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.LearnOOPCshap
{
	public abstract class animalAbstract // Abstract class
	{
		/// <summary>
		/// Abstract method (does not have a body)
		/// สร้าวเอาไว้มห้คลาสลูกไปแก้ไขเอาเองว่าสัตว์แต่ละชนิดร้องยังไง
		/// </summary>
		public abstract void animalSound();

		// Regular method
		public void sleep()
		{
			Console.WriteLine("Zzz");
		}
	}


	/// <summary>
	/// Derived class (inherit from Animal)
	/// สร้างหมูขึ้นมาสืบทอดจาก animalAbstract 
	/// </summary>
	public class Pig : animalAbstract
	{
		/// <summary>
		/// The body of animalSound() is provided here
		/// ในส่วนอขงฟังก์ชันนี้ที่ override ทำการใส่สิ่งที่หมูร้องลงไป
		/// </summary>
		public override void animalSound()
		{
			Console.WriteLine("The pig says: wee wee");
		}
	}

	public class ProgramAbstract
	{
		static void Main(string[] args)
		{
			//	เมื่อทำการสร้างหมูขึ้นมาจะสามารถใช้
			//	animalSound โดยผ่าน override เรียบร้อยแล้ว
			//	sleep ใช้จาก base
			Pig myPig = new Pig(); // Create a Pig object
			myPig.animalSound();  // Call the abstract method
			myPig.sleep();  // Call the regular method
		}
	}
}
