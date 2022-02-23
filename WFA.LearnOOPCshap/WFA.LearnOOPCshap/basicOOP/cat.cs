using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.LearnOOPCshap
{
	public class cat : animal //Inheritance To inherit from a class, use the : symbol.
	{
		private int MyProperty { get; set; }
		public cat(string w, string c)
		{
			//keyword
			//animal = base
			//this = cat
			base.setColor(c);
			base.setWalk(w);
		}

		/// <summary>
		/// ถ้าเราต้องการ override 
		/// base class ต้องประกาศ virtual 
		/// </summary>
		public override void sound()
		{
			Console.WriteLine("cat make sound");
		}

		public void serProp(int p)
		{
			MyProperty = p;
		}

		public int getProp()
		{
			return MyProperty;
		}

		public string getInfo()
		{
			return base.getWalk() + " " + base.getColor() + " " + this.MyProperty.ToString();
		}
	}
}
