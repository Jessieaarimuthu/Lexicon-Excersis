using System;
namespace excersice4
{
	public class Person
	{
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;


        public int Age
        {
            get { return age; }
            set
            {
                if (value < 1)
                    throw ArgumentException("Please enter valid age");
                age = value;
            }
        }

        public string Fname
        {
            get { return fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                    throw ArgumentException("FName is mandatory and must not be less than 2 characters or longer than 10");
                fName = value;
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                    throw ArgumentException("LName is mandatory and must not be less than 3 characters or longer than 15");
                lName = value;
            }
        }

        public double Height
        {
            get; set;
        }

        public double Weight
        {
            get; set;
        }

        private Exception ArgumentException(string v)
        {
            throw new NotImplementedException(v);
        }
    }

    public class PersonHandler
    {
      

        public void setAge(Person pers, int age)
        {
            pers.Age = age;
          
        }

        public Person CreatePerson(int age, string fname, string lname, double height , double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.Fname = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;

            return person;
        }
    }
}

