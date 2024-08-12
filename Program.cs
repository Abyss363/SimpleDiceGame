Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine("YOU ROLLED TRIPLES!!! +SIX TO SCORE!!!");
    total += 6;
}
else if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1)
{
    Console.WriteLine("You rolled doubles!! Plus 2 to score!!");
    total += 2;
}


if (total >= 16)
{
    Console.WriteLine("You win a new car!!(^o^)");
}
else if(total >= 10)
{
    Console.WriteLine("You win a new laptop!!");
}
else if(total == 7)
{
    Console.WriteLine("You win a free trip");
}
else
{
    Console.WriteLine("You win a kitten");
}