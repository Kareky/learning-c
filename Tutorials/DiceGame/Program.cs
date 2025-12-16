/*   INSTRUCTION OF THE EXERCISE
    If the score is greater than an arbitrary total, then you'll display a winning message to the user. If the score is below the cutoff, you'll display a losing message to the user.

    If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
    If all three dice you roll result in the same value, you get six bonus points for rolling triples.
    If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game. Otherwise, you lose.
*/

//Giving playful instructions to the user
Console.WriteLine("WELCOME TO THE DICE GAME!");
Console.WriteLine("In this game you will roll three 6 faced dice.");
Console.WriteLine("To win, your total score must be 15 or greater. Otherwise, you lose.");
Console.WriteLine("The rules are simples:");
Console.WriteLine("You will roll three dice, each with values ranging from 1 to 6. The sum of the three dice rolls will determine your score.");
Console.WriteLine("If any two dice you roll result in the same value, you get two bonus points for rolling doubles.");
Console.WriteLine("If all three dice you roll result in the same value, you get six bonus points for rolling triples.");
Console.WriteLine("Let's roll the dice!");

//Making a dramatic pause before rolling the dice
System.Threading.Thread.Sleep(5000);

Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//Another dramatic pause! They're never enough
System.Threading.Thread.Sleep(1000);

//Checking for any doubles or triples and adding the bonus points
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        total += 6;
        Console.WriteLine("I can't believe it! That's a triple! You've made wonderfull <3\n+6 bonus to total!");
        Console.WriteLine($"Now you have a total of {total} points! That's a hella lot!");
    } else {
        total += 2;
        Console.WriteLine("Wow! You've rolled doubles! You're rocking it! +2 bonus to total!");
        Console.WriteLine($"Now you have a total of {total} points! Keep it up!");
    }
}

//The last, intense dramatic pause before the big reveal!
System.Threading.Thread.Sleep(1000);

//Writing the user the result
if (total >= 15) {
    Console.WriteLine("Congratulations, you win! That result was great! Hope you'll come back again pretty soon <3");
} else {
    Console.WriteLine("Sorry, the result wasn't high enough :( But fear not! The win is just one try away, I am sure about that! See you next time!");
}