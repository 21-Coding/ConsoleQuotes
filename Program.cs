using System;

namespace myApp
{
  class Program
  {

     static void Main(string[] args)
    {

      TypeLine("Hello, to see your favorite Nipsey Hussle quotes please type a number from 1 - 20!");
      string stringUserNumber = Console.ReadLine();
      int intUserNumber = int.Parse(stringUserNumber);


        if (intUserNumber == 24)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Black;
        TypeLine("Im more focused on giving solutions and inspiration more than anything.");
      }
      else if (intUserNumber == 23)
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Yellow;
        TypeLine("Success to me is just being able to do what you love to do and support yourself all through.");
      }
      else if (intUserNumber == 22)
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Yellow;
        TypeLine("Try your best to make decisions outside of your ego.");
      }
      else if (intUserNumber == 21)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Black;
        TypeLine("Never give too much power over your path to outside forces.");
      }
      else if (intUserNumber == 20)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Yellow;
        TypeLine("No one in life can enjoy peace until they know the meaning of it.");
      }
      else if (intUserNumber == 19)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.White;
        TypeLine("Sometimes you have to take two steps backwards in order to take ten forward.");
      }
      else if (intUserNumber == 18)
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        TypeLine("Instead of trying to build a brick wall, lay a brick every day. Eventually you will have a wall.");
      } 
      else if (intUserNumber == 17)
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Yellow;
        TypeLine("One small misunderstanding can show you how a person really feels about you.");
      }   
      else if (intUserNumber == 16)
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        TypeLine("A speaker of truth has no friends.");
      }
      else if (intUserNumber == 15)
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Red;
        TypeLine("If you look at the people in your circle and you dont get inspired, then you dont have a circle you have a cage.");
      }
      else if (intUserNumber == 14)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        TypeLine("The reason children accept discipline from their parents is because they know their parents love them.");
      }
      else if (intUserNumber == 13)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        TypeLine("Even as you make progress, you need the discipline to keep from backtracking and sabotaging the success as its happening.");
      }
      else if (intUserNumber == 12)
      {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        TypeLine("Ownership is everything, own your mind - mind your own.");
      }
      else if (intUserNumber == 11)
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.White;
        TypeLine("Luck is just being prepared at all times, so when the door opens you are ready.");
      }
      else if (intUserNumber == 10)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        TypeLine("The company you keep has a large influence on the situations you bring to yourself. Birds of a feather flock together.");
      }
      else if (intUserNumber == 9)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.White;
        TypeLine("The most important thing, number one, is you gotta get rid of doubt. If you have doubt in what you're doing, it's not gonna work. The way to do that is to have a plan. 'Cause if you got a plan, it's not just like a pipe-dream, you have a step-by-step list of things to do to get to your goal. If you don't have that, it's very hard to really have faith in what you're doing 'cause soon as something pop up, it's gonna look like the end-all.");
      }
      else if (intUserNumber == 8)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Blue;
        TypeLine("You gotta go hard, you have to believe in yourself. You gotta have a sense of humor to know that the bullshit is gonna happen, you can't be too serious about it or too emotional and fake when the bullshit happens. You gotta just stick to the script, believe and have an overwhelming confidence. Be your own biggest fan, your own biggest believer, and put it on your back and carry the weight.");
      }
      else if (intUserNumber == 7)
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Yellow;
        TypeLine("Longwinded, running through this life like it was mine. Never settling, but setting every goal high. One thousand burpees on the path to my own destruction or success. But what is a mistake without the lesson? See, the best teacher in life is your own experience. None of us know who we are until we fail. They say every man is defined by his reaction to any given situation. Well who would you want to define you? Someone else or yourself? Whatever you do, homie, give your heart to it and stay strong.");
      }
      else if (intUserNumber == 6)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.BackgroundColor = ConsoleColor.Green;
        TypeLine("The best thing you can do for a person is to inspire them. That's the best currency you can offer: inspiration. So, when a person can rely on you for that, that empowers them in every realm of their life. Being inspired. It empowers them in their relationships, in their business, in their art, and in their creativity. It empowers them because without (in)spiration, you're empty.");
      }
      else if (intUserNumber == 5)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.BackgroundColor = ConsoleColor.Green;
        TypeLine("Define who you are and what you are, and be clear on that. Meditate on that and then, live and die by that. You can't break the rules, the fundamental rules. Be a man of your word, do what you say you're gonna do, respect people the way you would like to be respected.");
      }
      else if (intUserNumber == 4)
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.BackgroundColor = ConsoleColor.DarkGray;
        TypeLine("Thought is powerful in all phases. Even in my career, even in my life, things end up exactly how I visualized them.");
      }
      else if (intUserNumber == 3)
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Yellow;
        TypeLine("On a mission your worst enemy is idle time.");
      }
      else if (intUserNumber == 2)
      {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        TypeLine("I’m about seeing long-term, seeing a vision, understanding nothing really worthwhile happens overnight, and just sticking to your script long enough to make something real happen.");
      }
      else if (intUserNumber == 1)
      {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.Black;
        TypeLine("It's possible to monetize your art without compromising the integrity of it for commerce.");
      }
      else {
        TypeLine("Invalid input, try the numbers 1-22.");
      }

        }
          static void TypeLine(string line) 
        {
            for (int i = 0; i < line.Length; i++) 
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(50);
            }
        }
      }
    }
