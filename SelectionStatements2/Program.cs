// See https://aka.ms/new-console-template for more information
//select a random number as favorite number
var r = new Random();
var favNumber = r.Next(1, 1000);

Console.WriteLine("Try to guess my favorite number");
var userInput = int.Parse(Console.ReadLine());


//conditional responses for "too low" or "too high"
if (userInput > favNumber)
{
    Console.WriteLine("Too High!");
}
else if (userInput < favNumber)
{
    Console.WriteLine("Too Low");
}
else
    Console.WriteLine("Nevermind");
//print fav number for testing purposes
Console.WriteLine("fav:" + favNumber);

//switch case example
Console.WriteLine("Choose the number for your favorite subject\n1-Mathematics\n2-Science\n3-English\n4-History\n5-Computer Science\n6-other");

var favSubject = int.Parse(Console.ReadLine());
switch(favSubject)
{
    case 1:
        Console.WriteLine("Mathematics");
        break;
    case 2:
        Console.WriteLine("Science");
        break;
    case 3:
        Console.WriteLine("English");
        break;
    case 4:
        Console.WriteLine("History");
        break;
    case 5:
        Console.WriteLine("Computer Science");
        break;
    case 6:
        Console.WriteLine("other");
        break;
    default:
        Console.WriteLine("Invalid number");
        break;
}



