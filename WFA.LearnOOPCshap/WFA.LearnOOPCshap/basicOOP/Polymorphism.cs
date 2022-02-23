using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA.LearnOOPCshap
{
	/// <summary>
	/// Polymorphism คือ ความหลากหลาย
	/// หนึ่งคลาสที่มี fn animalSound() ในการร้องเสียงได้หลายแบบ
	/// คลาสลูกสามารถแก้ไขเองได้หรือใช้คลาสแม่ ก็ตามแต่
	/// </summary>
	class Animal  // Base class (parent) 
	{
		public virtual void animalSound()
		{
			Console.WriteLine("The animal makes a sound");
		}
	}

	class Cat : Animal  // Derived class (child) 
	{
		public override void animalSound()
		{
			base.animalSound();
			//Console.WriteLine("The pig says: wee wee");
		}
	}

	class Dog : Animal  // Derived class (child) 
	{
		public override void animalSound()
		{
			Console.WriteLine("The dog says: bow wow");
		}
	}

	class ProgramPolymorphism
	{
		static void Main(string[] args)
		{
			Animal myAnimal = new Animal();  // Create a Animal object
			Animal myPig = new Cat();  // Create a Pig object
			Animal myDog = new Dog();  // Create a Dog object

			myAnimal.animalSound();
			myPig.animalSound();
			myDog.animalSound();
		}
	}
}
