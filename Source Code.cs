using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Cursor1
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Point p = Cursor.Position;
                Console.WriteLine("X:" + p.X + "  Y:" + p.Y);
            }

        }
    }
}
