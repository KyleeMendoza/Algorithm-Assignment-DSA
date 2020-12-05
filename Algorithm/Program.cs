using System;
using System.Collections.Generic;


namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose:\n1.Prints names and addresses of each member\n2.Prints all names\n3.Prints the address of a member\n4.Add member\n5.Updates list\n");
            List<membershipFile> memberfile = new List<membershipFile>();
            memberfile.Add(new membershipFile("John", "San Juan City", "1", "19", "M"));
            memberfile.Add(new membershipFile("Peter", "Manila City", "2", "19", "M"));
            memberfile.Add(new membershipFile("Mark", "Ibang planeta", "3", "19", "M"));
            memberfile.Add(new membershipFile("Luke", "Navotas City", "4", "19", "M"));

            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                returnAllNameAddress();
            }
            else if (choose == 2)
            {
                returnAllNames();
            }
            else if (choose == 3)
            {
                returnAddressOfName();
            }
            else if (choose == 4)
            {
                addNewMember();
            }
            else if (choose == 5)
            {
                updateMembers();
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////
            //ITO NA YUNG METHODS PER NUMBER SA ASSESSMENT
            /////////////////////////////////////////////////////////////////////////////////////////////////
            void returnAllNameAddress()
            {
                Console.WriteLine("ALL MEMBERS NAMES AND ADDRESSES: ");
                foreach (membershipFile member in memberfile)
                {
                    Console.WriteLine("Name: " + member.Name + "\tAddress: " + member.Address);
                }
            }
            void returnAllNames()
            {
                Console.WriteLine("ALL MEMBERS NAMES: ");
                foreach (membershipFile member in memberfile)
                {
                    Console.WriteLine("Name: " + member.Name);
                }
            }
            void returnAddressOfName()
            {
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                int checker = 0;
                foreach (membershipFile member in memberfile)
                {
                    if (name == member.Name)
                    {
                        Console.WriteLine("Name: " + member.Name + "\tAddress: " + member.Address);
                        checker++;
                    }
                }
                if (checker == 0)
                {
                    Console.WriteLine("Name not found! ");
                }
            }
            void addNewMember()
            {
                Console.WriteLine("ADDING MEMBER: \n");
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Address: ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter Telnum: ");
                string telnum = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                string age = Console.ReadLine();
                Console.WriteLine("Enter Sex: ");
                string sex = Console.ReadLine();
                memberfile.Add(new membershipFile(name, address, telnum, age, sex));
                Console.WriteLine("UPDATED LIST: \n");
                foreach (membershipFile member in memberfile)
                {
                    Console.WriteLine("Name: " + member.Name + "\tAddress: " + member.Address + "\tTelNum: " + member.TelNum + "\tAge: " + member.Age + "\tSex: " + member.Sex);
                }
            }
            void updateMembers()
            {
                Console.WriteLine("Deleting MEMBER: \n");
                Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();
                var itemToRemove = memberfile.Find(x => x.Name == name);
                memberfile.Remove(itemToRemove);
                if (itemToRemove == null)
                {
                    Console.WriteLine("Name not Found !");
                }
                else
                {
                    Console.WriteLine("UPDATED LIST: \n");
                    foreach (membershipFile member in memberfile)
                    {
                        Console.WriteLine("Name: " + member.Name + "\tAddress: " + member.Address + "\tTelNum: " + member.TelNum + "\tAge: " + member.Age + "\tSex: " + member.Sex);
                    }
                }
                
            }
        }

    }
    //CLASS PARA SA MGA MEMBER
    class membershipFile
    {
        //PRIVATE PARA MAY GETTERS AND SETTERS
        private string name;
        private string address;
        private string telNum;
        private string age;
        private string sex;

        //CONSTRUCTOR NG CLASS
        public membershipFile(string name, string address, string telnum, string age, string sex)
        {
            Name = name;
            Address = address;
            TelNum = telnum;
            Age = age;
            Sex = sex;
        }
        //GETTERS AND SETTERS
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string TelNum
        {
            get { return telNum; }
            set { telNum = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
    }
}
