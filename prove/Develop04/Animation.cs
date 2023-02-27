using System;

public class Animation
{

    private int _max;

    public Animation(int t)
    {
        _max = t;
    }
    public void RunLineAnimation()
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
}