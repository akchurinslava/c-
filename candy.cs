var candy = Console.ReadLine("Do you want candy?: ");
while(candy!="cANDy")
{
    candy = Console.ReadLine("Do you want candy?: ");
}

var candy = "";
do
{
    Console.Beep();
    Console.Clear();
    Console.WriteLine("Do you want candy?: ");
    candy = Console.ReadLine();
} while (true);


