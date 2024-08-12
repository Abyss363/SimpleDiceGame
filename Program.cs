Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1)
{ 
    Console.Write("You rolled doubles!! Plus 2 to score!!");
    total += 2;
}

if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine("YOU ROLLED TRIPLES!!! +SIX TO SCORE!!!")
}

if (total >= 15)
{
    Console.WriteLine("You Win!!(^o^)");
}

if (total < 15)
{
    Console.WriteLine("You Lose >_<!!");
}