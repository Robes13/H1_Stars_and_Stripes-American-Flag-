using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_American_flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Colouring the red and white part of the flag


            // Creating for loop with 13 (half of our desired height, but the colors need to fill 2 y spaces each, so this is easier)
            for (int flag_Height = 0; flag_Height < 13; flag_Height++)
            {
                // Testing if flag_height is divisible by 2 (if its True) 
                if (flag_Height % 2 == 0)
                {
                    /* If it is true we jump into this code bracket,
                    We set the for loop to run 2 times, because as said before, we want the colored lines
                    to take up to rows.
                    */
                    for (int fill_y_spaces = 0; fill_y_spaces < 2; fill_y_spaces++)
                    {
                        // Here we color 38 spaces red on the first row, the second time our fill_y_spaces is run the next row will be colored
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        for (int e = 0; e < 38; e++)
                            Console.Write(' ');
                        // Drawing a new line, so that the next row will be colored the correct place.
                        Console.Write("\n");
                    }
                }
                else
                // Look at the comments above.
                {
                    for (int fill_y_spaces = 0; fill_y_spaces < 2; fill_y_spaces++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        for (int e = 0; e < 38; e++)
                            Console.Write(' ');
                        Console.Write("\n");
                    }
                }
            }


            // Colouring the blue part of the flag

            // Setting our cursor position to be at the top left corner of the console.
            Console.SetCursorPosition(0, 0);
            // Look comments on how the red and white part was drawn. This is the same, just only one color.
            for (int flag_Height = 0; flag_Height < 11; flag_Height++)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                for (int fill_y_spaces = 0; fill_y_spaces < 24; fill_y_spaces++)
                    Console.Write(' ');
                Console.Write("\n");
            }
            

            // Placing the stars in the correct place.

            /* Here we're basically thinking of the stars as being in a sqaure of their own, 
             where the first star we place is the top left corner of our new sqaure. 
            To get the correct cursor position I created a for loop with the half of the width of this new sqaure.
             */
            for (int cursor_place = 1; cursor_place < 11; cursor_place += 2)
            {
                Console.SetCursorPosition(1, cursor_place);
                // Putting down first star
                Console.Write('*');
                // Putting the rest of the stars down with a for loop
                for (int draw_star = 0; draw_star < 5; draw_star++)
                    Console.Write("   *");
            }
            // See previous comments.
            for (int cursor_place = 2; cursor_place < 10; cursor_place += 2)
            {
                Console.SetCursorPosition(3, cursor_place);
                Console.Write("*");
                for (int draw_star = 0; draw_star < 4; draw_star++)
                    Console.Write("   *");
            }
            // Setting our cursor position below the flag, so it looks nicer after it's printed.
            Console.SetCursorPosition(0, 26);
            // I wrote a Console.ReadLine(); here so that we can observe the flag.
            Console.ReadLine();
        }
    }
}
