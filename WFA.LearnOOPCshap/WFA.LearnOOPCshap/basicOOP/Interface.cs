using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.LearnOOPCshap
{
	/// <summary>
	/// interfaces ไม่มีสามารถสร้างเป็น object ได้
	/// interfaces มีเพียง method / properties จะไม่มี fields/variables
	/// method ใน interfaces จะไม่มี body
	/// properties นี้สร้างไงไม่รู้ เชี่ย>...
	/// </summary>
	interface IFirstInterface
	{
		void myMethod(); // interface method
	}

	interface ISecondInterface
	{
		void myOtherMethod(); // interface method
	}

	/// <summary>
	/// Implement multiple interfaces
	/// C# ไม่สามารถ Inheritance ได้มากกว่านึ่ง แต่แก้ปัญหานี้ด้วย interfaces
	/// interfaces สืบถอดได้หลาย interfaces โดยใช้ ,
	/// การสืบทอดหลาย interfaces จำเป็นต้องมี fn ครบทุก interfaces ที่สืบทอดมา
	/// </summary>
	class DemoClass : IFirstInterface, ISecondInterface
	{
		public void myMethod()
		{
			Console.WriteLine("Some text..");
		}
		public void myOtherMethod()
		{
			Console.WriteLine("Some other text...");
		}
	}

	class ProgramInterface
	{
		static void Main(string[] args)
		{
			DemoClass myObj = new DemoClass();
			myObj.myMethod();
			myObj.myOtherMethod();
		}
	}
}
