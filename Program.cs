namespace ATMLab
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            List<Access> usersAccess = new List<Access>();
            usersAccess.Add(new Access("John", "B0Bthebuilder", 2500));
            usersAccess.Add(new Access("Kevin", "N0t_50R30", 1900));
            usersAccess.Add(new Access("Seven", "777", 7777777));


            Console.WriteLine("Welcome to GC ATM");
            Console.WriteLine("Please Choose: Login or Register");
            String userName = "";
            Access currentUser;

            while (true)
            {
                try
                {
                    userName = Console.ReadLine();
                    currentUser = usersAccess.FirstOrDefault(a => a.Name == userName);
                    if (currentUser != null)
                    {
                        break;
                    }
                    else { Console.WriteLine("Name not found. Please try again.");
                    }
                }
                catch
                {
                    Console.WriteLine("Card not recognised. Please try again.");
                }
            }

            Console.WriteLine("Please enter Your Password:");
            string userPassword = "";
            while (true)
            {
                try
                {
                    userPassword = (Console.ReadLine());

                    if (currentUser.getPassword() == userPassword)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The password does not match the user. Please try again.");
                    }
                }

                catch
                {
                    Console.WriteLine("The password does not match the user. Please try again.");
                }
            }


        }
    }
}