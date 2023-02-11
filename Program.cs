using System;

namespace MyConsoleApplication
{
    class Student : StudentInformation
    {
        //properties
        public string Name {get; set; }
        public int ID { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        //instance method
        //this method will print out student detail
        public void PrintDetails()
        {
            Console.WriteLine("Name: " + Name + ", ID: " + ID + ", Age: " + Age + ", Address: " + Address);
        }
       

        //indexer    
        public string this[int index]
        {
            get
            {
                //index[0] = Name, index[1] = ID, index[2] = Age
                if (index == 0)
                    return Name;
                else if (index == 1)
                    return ID.ToString();
                else
                    return Age.ToString();
            }
        }
    }

    
    interface StudentInformation
    {
        string Name { get; set; }
        int ID { get; set; }
        int Age { get; set; }
        string Address { get; set; }

        void PrintDetails();

        //indexer
        string this[int index] { get ; }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            //create a instance method
            Student Long = new Student()
            {
                Name = "Long",
                ID = 47511,
                Age = 25,
                Address = "Planet Earth"
            };
            //execute instance method
            Long.PrintDetails();

        
        }
    }
}