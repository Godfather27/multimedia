using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace image
{
    class Program
    {
        static void Main(string[] args)
        {
            Image i = Image.FromFile(args[1]);
            Bitmap img = new Bitmap(i);
            switch(args[0]){
                case "1": invert(img);
                    break;
                case "2": clamp(img);
                    break;
                case "3": multiply(img);
                    break;
                case "4": uniquant(img);
                    break;
                case "5": threshold(img);
                    break;
            }

            Console.Write("DONE");
            Console.ReadLine();
            
        }

        static public void clamp(Bitmap img){
            Color c;
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Byte r = img.GetPixel(x, y).R;
                    if(r < 75){
                        r = 75;
                    }
                    if(r > 180){
                        r = 180;
                    }
                    c = Color.FromArgb(r, img.GetPixel(x, y).G, img.GetPixel(x, y).B);
                    img.SetPixel(x, y, c);
                }
            }
            img.Save("clamp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        
        static public void invert(Bitmap img){
            Color c;
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Byte r = img.GetPixel(x, y).R;
                    c = Color.FromArgb(255 - r, img.GetPixel(x, y).G, img.GetPixel(x, y).B);
                    img.SetPixel(x, y, c);
                }
            }
            img.Save("inversion.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        
        static void multiply(Bitmap img){
            Color c;
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int r = img.GetPixel(x, y).R * 4;
                    if(r < 2){
                        r = 75;
                    }
                    if(r > 253){
                        r = 180;
                    }
                    c = Color.FromArgb(r, img.GetPixel(x, y).G, img.GetPixel(x, y).B);
                    img.SetPixel(x, y, c);
                }
            }
            img.Save("multiclamp.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        
        static void uniquant(Bitmap img){
            Color c;
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    int r = img.GetPixel(x, y).R / 32;
                    r *= 16;
                    int g = img.GetPixel(x, y).G / 32;
                    g *= 16;
                    int b = img.GetPixel(x, y).B / 32;
                    b *= 16;
                    c = Color.FromArgb(r, g, b);
                    img.SetPixel(x, y, c);
                }
            }
            img.Save("uniquant.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        static public void threshold(Bitmap img){
            Color c;
            for (int x = 0; x < img.Width; x++)
            {
                for (int y = 0; y < img.Height; y++)
                {
                    Byte r = img.GetPixel(x, y).R;
                    if(r < 128) r = 0; else r = 255;
                    c = Color.FromArgb(r, img.GetPixel(x, y).G, img.GetPixel(x, y).B);
                    img.SetPixel(x, y, c);
                }
            }
            img.Save("threshold.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
   