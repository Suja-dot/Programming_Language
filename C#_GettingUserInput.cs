static void Main(string[] args)
{
  string youName;
  Console.WriteLine("What is your name?");
  
  yourName = Console.ReadLine();
  
  Console.WirteLine("Hello {0}", yourName);
  
  int age = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("You are {0} years old", age);
}
