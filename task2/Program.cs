var user1 = new User();
System.Console.Write("Enter your first name : ");
user1.FirstName = Console.ReadLine();
System.Console.Write("Enter your last name : ");
user1.LastName = Console.ReadLine();
System.Console.Write("Enter your username : ");
user1.UserName = Console.ReadLine();
System.Console.Write("Enter your password : ");
user1.Password = Console.ReadLine();

System.Console.WriteLine("Login : ");
System.Console.Write("Enter your username : ");
var username = Console.ReadLine();
System.Console.Write("Enter your password : ");
var pass = Console.ReadLine();

user1.Login(username, pass);
System.Console.WriteLine("---------------------");
System.Console.WriteLine(user1.GetFullInfo());
user1.LogOut();
System.Console.WriteLine(user1.GetFullInfo());



