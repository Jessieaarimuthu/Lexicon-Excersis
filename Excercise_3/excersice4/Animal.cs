using System;
namespace excersice4
{
 public	abstract class Animal
	{
		public string Name;
		public double Weight;
		public int Age;

		public Animal()
		{
			
		}

        public abstract void dosound();

		public abstract string Stats();

    }

	class Dog : Animal
	{
        
		public string isfriendly;

        public override void dosound()
		{
			Console.WriteLine("Bark Bark");
		}

        public override string Stats()
        {
			isfriendly = "Dog is Friendly";

            return isfriendly;
        }
    }


	class Horse : Animal
	{
		string runfaster;
		public override void dosound()
		{
			Console.WriteLine("Neigh Niegh");
		}
        public override string Stats()
        {
            runfaster = "Horse runs faster";

            return runfaster;
        }
    }


	class Hedgehog : Animal
	{
		string nrOfSpikes;
		public override void dosound()
		{
			Console.WriteLine("Grunting");
		}
        public override string Stats()
        {
            nrOfSpikes = "Hedgehog has 100's of spikes";

            return nrOfSpikes;
        }

    }


	class Worm : Animal
	{
		string ispoisnous;
		public override void dosound()
		{
			Console.WriteLine("wor wor");
		}
        public override string Stats()
        {
            ispoisnous = "Worm is poisnous";

            return ispoisnous;
        }
    }

 public	class Bird : Animal
	{
		public string WingSpan;
		public override void dosound()
		{
			Console.WriteLine("chewink chewink");
		}
        public override string Stats()
        {
            WingSpan = "WingSoan of Bird is 30 years";

            return WingSpan;
        }
    }

	class Wolf : Animal
	{
		string isdangerous;
        public override void dosound()
        {
            Console.WriteLine("oooooo oooooo");
        }
        public override string Stats()
        {
            isdangerous = "Wolf is Dangerous";

            return isdangerous;
        }
    }

    class Pelican : Bird
    {
        bool isWaterBird;
		
        public override void dosound()
        {
            Console.WriteLine("Pelician");
        }
    }

    class Flamingo : Bird
    {
        bool haspinkfeathers;
        public override void dosound()
        {
            Console.WriteLine("Fakmingo");
        }
    }

    class Swan : Bird
    {
        bool isWhite;
        public override void dosound()
        {
            Console.WriteLine("Swan Sawn");
        }
    }

	interface IPerson
	{
       
	     string Talk( int i);
	}

	class Wolfman:Wolf,IPerson
	{
		public virtual string Talk(int i)
		{
			return this.GetType().Name;
		}
	}
}
		



