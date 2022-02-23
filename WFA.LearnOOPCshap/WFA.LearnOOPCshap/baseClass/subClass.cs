using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.LearnOOPCshap
{
	public class subClass : baseClass
	{
		public override void Greetings()
		{
			//base.Greetings();
			Console.WriteLine("subClass Saying Hello!");
			base.Greetings();
		}
	}
}
