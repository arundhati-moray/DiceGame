
Random dice = new Random();

var Roll1 = dice.Next(1, 7);
var Roll2 = dice.Next(1, 7);
var Roll3 = dice.Next(1, 7);

var total = Roll1 + Roll2 + Roll3;

Console.WriteLine($"Your total score is: {Roll1}+{Roll2}+{Roll3} = {total}");

if (Roll1 == Roll2 || Roll1 == Roll3 || Roll2 == Roll3)
{
    if (Roll1 == Roll2 && Roll2 == Roll3)
    {
        Console.WriteLine("Yayy!! You rolled triples. +6 to the bonus points.");
        Console.WriteLine($"Your total score is {total}+6 = {total+6}");
    }
    else
    {
        Console.WriteLine("Yayy!! You rolled doubles. You get 2 bonus points.");
        Console.WriteLine($"Your total score is {total}+2 = {total+2}");
    }
}


if (total >= 16)
{
    Console.WriteLine("Congratilations!!! You won a new car");
}
else if(total >= 16 && total < 16 )
{
    Console.WriteLine("Congratilations!!! You won a laptop");
}
else if(total == 7)
{
   Console.WriteLine("Congratilations!!! You won a trip"); 
}
else
{
    Console.WriteLine("Congratilations!!! You won a kitten");
}