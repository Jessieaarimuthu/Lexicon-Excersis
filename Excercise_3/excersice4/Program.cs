

namespace excersice4;


class Program
{

    public static void Main(string[] args)
    {
        Person p = new Person();
        PersonHandler ph = new PersonHandler();

        try
            {
                //Console.WriteLine("Enter Age: ");
                //p.Age = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Enter FName: ");
                //p.Fname = Console.ReadLine();
                //Console.WriteLine("Enter Lname: ");
                //p.LName = Console.ReadLine();

               ph.setAge(p,10);
                Console.WriteLine();
               p= ph.CreatePerson(10, "dasdsad", "asdasdsadsadasd", 175, 80);

                Console.WriteLine("Person Validation success");
                Console.WriteLine("Person Created!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        try
        {
            TextInputError numerr = new TextInputError();
            
        }
        catch(Exception ex)
        {

        }

        try
        {

            List<string> animals = new List<string>();
            animals.Add("Dog");
            animals.Add("Horse");
            animals.Add("Wolf");

            foreach (string animal in animals)
            {
                if (animal is "Dog")
                {
                    Dog d = new Dog();
                    d.dosound();
                }
                if (animal is "Horse")
                {
                    Horse d = new Horse();
                    d.dosound();
                }
                if (animal is "Wolf")
                {
                    Wolf d = new Wolf();
                    d.dosound();
                }
                if (animal is "Hedgehog")
                {
                    Hedgehog d = new Hedgehog();
                    d.dosound();
                }
                if (animal is "Worm")
                {
                    Worm d = new Worm();
                    d.dosound();
                }
                if (animal is "Worm")
                {
                    Worm d = new Worm();
                    d.dosound();
                }

            }
            List<string> Bird = new List<string>();
            Bird.Add("WingSpan");
            Bird.Add("Wolf");
            Bird.Add("Pelican");
            Bird.Add("Flamingo");
            Bird.Add("Swan");


            foreach (string bird in Bird)
            {
                if (bird is "WingSpan")
                {
                    WingSpan d = new WingSpan();
                    d.dosound();
                }
                if (bird is "Wolf")
                {
                    Wolf d = new Wolf();
                    d.dosound();
                }
                if (bird is "Pelican")
                {
                    Pelican d = new Pelican();
                    d.dosound();
                }
                if (bird is "Flamingo")
                {
                    Flamingo d = new Flamingo();
                    d.dosound();
                }
                if (bird is "Swan")

                {
                    Swan d = new Swan();
                    d.dosound();
                }
            }
        }


        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }


        
    }
}
	
   



