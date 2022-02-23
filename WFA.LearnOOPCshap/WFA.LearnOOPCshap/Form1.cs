using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA.LearnOOPCshap
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Console.WriteLine();

			baseClass obj1 = new baseClass();
			Console.WriteLine("baseClass obj1 = new baseClass();");
			obj1.Greetings();
			Console.WriteLine();

			subClass obj2 = new subClass();
			Console.WriteLine("subClass obj2 = new subClass();");
			obj2.Greetings();
			Console.WriteLine();

			baseClass obj3 = new subClass();
			Console.WriteLine("baseClass obj3 = new subClass();");
			obj3.Greetings();
			Console.WriteLine();

			basicOOP();
		}

		private void basicOOP()
		{
			cat lo = new cat("2", "red");
			lo.serProp(7);
			Console.WriteLine(lo.getInfo());
			Console.WriteLine();

			myClass my = new myClass();
			my.Name = "A"; //set property name
			Console.WriteLine(my.Name); //get property name
			Console.WriteLine();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
