using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Labor7
{
    internal class Mole
    {
        
        private int position;

        public int Position
        {
            get { return position; }
          //  set { position = value; }
        }
        public void TurnUp()
        {
            Console.Clear();
            Console.SetCursorPosition(position,0);
            Console.Write("M");
            Console.SetCursorPosition(0, 0);
        }
        public void Hide(int min, int max)
        {
            Random random = new Random();
            position = random.Next( min, max+1);
        }
    }
}
