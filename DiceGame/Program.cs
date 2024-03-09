
Random dice = new Random();

var Roll1 = dice.Next(1, 7);
var Roll2 = dice.Next(1, 7);
var Roll3 = dice.Next(1, 7);

var total = Roll1 + Roll2 + Roll3;

Console.WriteLine($"Your total score is: {total}");