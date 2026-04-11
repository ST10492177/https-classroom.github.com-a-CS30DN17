using System;
using System.Drawing;
using System.Media;

namespace ai_chatapp
{//start of namespace
    public class voice_logo
    {//start of class

        //auto get the path directory 
       private string full_path = AppDomain.CurrentDomain.BaseDirectory;
        public voice_logo()
        {//start of constructor

            //calling sound method 
            greetings();

            //call the loco method
            asci();
            chat game = new chat();

            // Start the game
            game.StartChat();

            Console.ReadLine();

        }//end of constructor

        //method to play sound
        private void greetings()
        {//start of greetings  method
            //check if the path is auto collected
            Console.WriteLine(full_path);

            //then replace the \bin\Debug\ 
            string correct_path = full_path.Replace(@"\bin\Debug\", @"\greet.wav");
            // check if the path is correct
            Console.WriteLine(correct_path);

            //use the soundplay class to play the sound
            //create an instance for the sound player class
            //with an object name and greet 
            SoundPlayer greet = new SoundPlayer(correct_path);
            //then play the sound
            greet .Play();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
           Console.WriteLine("{welcome to cyber security awareness chat bot}");
            Console.WriteLine("::::::::::::::::::::::::::::::::::::");
            Console.WriteLine("                | w | ");
            Console.WriteLine("                | e |");
            Console.WriteLine("                | l |");
            Console.WriteLine("                | c |");
            Console.WriteLine("                | o |");
            Console.WriteLine("                | m |");
            Console.WriteLine("                | e |");
            Console.ResetColor();


        }//end of greetins method

        // method to turn logo to ascii
        private void asci()
        {
            //path of the logo [ where the logo is ]
            string path = full_path .Replace(@"\bin\Debug\",@"\logo.jpg");
          

            Bitmap image = new Bitmap(path);

            // Resize for better console fit
            int width = 70;
            int height = 20; //(image.Height * width) / image.Width;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Default color , you can set yours before this line
            string asciiChars = "@#S%?*+;:,. ";

            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {
                //then width
                for (int x = 0; x < resized.Width; x++)
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }

    }//end of class
}//end of namespace