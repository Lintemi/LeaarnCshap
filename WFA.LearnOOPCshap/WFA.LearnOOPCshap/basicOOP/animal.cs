using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.LearnOOPCshap
{
	public class animal
	{
		private string walk { get; set; }
		private string color { get; set; }

		public animal()
		{

		}
		
		public virtual void sound()
		{
			Console.WriteLine("make sound");
		}
		public void setWalk(string w)
		{
			walk = w;
		}
		public void setColor(string c)
		{
			color = c;
		}
		public string getWalk()
		{
			return walk;
		}
		public string getColor()
		{
			return color;
		}

	}
}
