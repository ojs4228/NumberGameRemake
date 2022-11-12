using System;


class Program
{
    
    static void Main(string[] args)
    {


        Game game = new Game();
        int randomInt = game.DropRadomInt();
        int playCount = 0;
        Console.WriteLine(randomInt);
        Console.WriteLine("숫자를 맞춰보자!");

        while(true){

            int inputInt;
            
            Console.WriteLine("숫자를 입력해주세요");

            try
            {
                inputInt = int.Parse(Console.ReadLine());

            }catch(FormatException e)
            {
                Console.WriteLine("올바른 숫자를 입력 해주세요");
                return;
                
            }

            if (game.comparison(randomInt, inputInt)) { 

                Console.WriteLine("축하합니다! 숫자를 정확히 맞추셨습니다.");

                Console.WriteLine("시도한 횟수" + playCount);
                Console.WriteLine("정답숫자" + randomInt);

                return;
            }

            playCount++;
            
        }
 
    }
}

public class Game
{

    public bool comparison(int randomInt, int inPutInt)
    {
        if (randomInt == inPutInt)
        {
            return true;
        }
        else
        {
            PrintUpDown(randomInt, inPutInt);
            return false;
        }
        
    }


    public int DropRadomInt() {

        Random random = new Random();

        return random.Next(100);


    }

    public static void PrintUpDown(int randomInt, int inPutInt)
    {

        if(randomInt > inPutInt)
        {
            Console.WriteLine("Up");
            
        }
        if (randomInt < inPutInt)
        {
            Console.WriteLine("Down");

        }

    }


}





