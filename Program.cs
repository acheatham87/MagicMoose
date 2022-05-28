using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    MooseSays("Please ask me a question.");
    Console.ReadLine();
    MooseResponse();
}

void MooseResponse()
{
    Random r = new Random();
    int randomReturn = r.Next(1,20);
    switch(randomReturn)
    {
        case 1:
        MooseSays("As I see it, yes.");
        break;
        case 2:
        MooseSays("Ask again later.");
        break;
        case 3:
        MooseSays("Better not tell you now.");
        break;
        case 4:
        MooseSays("Cannot predict now.");
        break;
        case 5:
        MooseSays("Concentrate and ask again.");
        break;
        case 6:
        MooseSays("Don't count on it.");
        break;
        case 7:
        MooseSays("It is certain.");
        break;
        case 8:
        MooseSays("It is decidedly so.");
        break;
        case 9:
        MooseSays("Most likely.");
        break;
        case 10:
        MooseSays("My reply is no.");
        break;
        case 11:
        MooseSays("My sources say no.");
        break;
        case 12:
        MooseSays("Outlook not so good.");
        break;
        case 13:
        MooseSays("Reply hazey, try again.");
        break;
        case 14:
        MooseSays("Signs point to yes.");
        break;
        case 15:
        MooseSays("Very doubtful.");
        break;
        case 16:
        MooseSays("Without a doubt.");
        break;
        case 17:
        MooseSays("Yes.");
        break;
        case 18:
        MooseSays("Yes, definitely.");
        break;
        case 19:
        MooseSays("You may rely on it.");
        break;
        case 20:
        MooseSays("Outlook good.");
        break;
    }
    MooseSays("Please ask me another question.");
    if(Console.ReadLine() != "")
    {
        MooseResponse();
    }
    else
    {
        return;
    }
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}
