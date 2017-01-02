/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-class-vs-instance
this code may need to run in the hackerrank online ide to work correctly
*****************************/
class Person
    {
        int age;

        
        public void yearPasses()
        {
            age++;
        }
        public void amIOld()
        {
            if (age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if(age>=13 && age<18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }

        }

        public Person(int initialAge)
        {
            if (initialAge > 0)
            {
                age = initialAge;
            }
            else
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }
    