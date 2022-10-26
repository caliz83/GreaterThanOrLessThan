bool letsPlay = true;

while(letsPlay == true)
{
int num1;
int num2;

Console.WriteLine("Please enter a number.");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a second number.");
num2 = Convert.ToInt32(Console.ReadLine());
if(num1 > num2){
    Console.WriteLine("Your first number is greater than your second number.");
    Console.WriteLine("Your second number is less than your first number.");
}
else if(num1 < num2){
    Console.WriteLine("Your first number is less than your second number.");
    Console.WriteLine("Your second number is greater than your first number.");
}
else{
    Console.WriteLine("Your first number is equal to your second number.");
    Console.WriteLine("Your second number is equal to your first number.");
}

bool question = true;
while(question == true)
{
Console.WriteLine("Do you want to play again? Y/N");
string playAgain = Console.ReadLine().ToUpper();

if(playAgain == "Y")
{
    letsPlay = true;
    question = false;
}
else if(playAgain == "N")
{
    letsPlay = false;
    question = false;
    Console.WriteLine("Goodbye.");
}
else
{
    Console.WriteLine("Please enter a valid option: Y or N");
    question = true;
}
}
}