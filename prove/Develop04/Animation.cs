using System;

public class Animation
{

    private int _max;

    public Animation(int t)
    {
        _max = t;
    }
    private void RunLineAnimation()
    {
        List<string> picture = new List<string>();
        
        picture.Add("|");
        picture.Add("/");
        picture.Add("-");
        picture.Add("\\");
        picture.Add("-");
        picture.Add("/");
        picture.Add("|");
        picture.Add("-");
        picture.Add("\\");
        picture.Add("-");
        picture.Add("/");
        picture.Add("|");
   
       
        for (int frame = 0; frame < _max; frame ++)
        {
            if (frame < picture.Count())
            {
               Console.Write(picture[frame]);
            }

            else
            {
                Console.Write(picture[frame-4]);
            }
            Thread.Sleep(500);
            Console.Write("\b \b");

        }
    }


    private void RunDotAnimation()
    {
        List<string> picture = new List<string>();
        
        picture.Add(".");
        picture.Add("o");
        picture.Add("O");
        picture.Add("0");
        picture.Add("O");
        picture.Add("o");
        picture.Add(".");
        picture.Add("o");
        picture.Add("O");
        picture.Add("0");
        picture.Add("O");
        picture.Add("o");
        picture.Add(".");
        
       
        for (int frame = 0; frame < _max; frame ++)
        {
            if (frame < picture.Count())
            {
               Console.Write(picture[frame]);
            }

            else
            {
                Console.Write(picture[frame-4]);
            }
            Thread.Sleep(500);
            Console.Write("\b \b");

        }
    }

    public void RunAnimation()
    {
        Random random = new Random();
        int x = random.Next(0,2);
        if (x == 0)
        {
            RunDotAnimation();
        }
        else if (x == 1)
        {
            RunLineAnimation();
        }
         

    }



}