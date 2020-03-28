using System;
using System.Drawing;
using System.Windows.Forms;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen p = new Pen(System.Drawing.Color.Yellow);
            PersonBuilder ptb = new PersonThinBuilder(new PictureBox().CreateGraphics(),p);

            PersonDirector pdThin = new PersonDirector(ptb);
            pdThin.CreatePerson();

            PersonFatBuilder pfb = new PersonFatBuilder(new PictureBox().CreateGraphics(),p);
            PersonDirector pdFat = new PersonDirector(pfb);
            pdFat.CreatePerson();
        }
    }
}
