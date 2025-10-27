using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor8
{
    internal class Game
    {
        Field field;
        Buffalo[] buffaloes;

        public Game(int M, int N)
        {
            this.field = new Field(M);
            this.buffaloes = new Buffalo[N];
            for(int i = 0; i<N; i++)
            {
                buffaloes[i] = new Buffalo();
            }
        }
        public bool IsOver
        {
            get
            {
                int alive = buffaloes.Length;
                for(int i = 0; i < buffaloes.Length; i++)
                {
                    if (buffaloes[i].allapot == false)
                    {
                        alive--;
                    }
                    else
                    {
                        if (buffaloes[i].X != field.TargetX &&
                            buffaloes[i].Y != field.TargetX)
                        {
                            return true;
                        }
                 
                    }
                }
                if(alive == 0)
                {
                    return true;
                }
                return false;
            }
        }
        public void VisualizeElements()
        {
            Console.Clear();
            field.Show();
            for (int i = 0;i < buffaloes.Length;i++)
            {
                buffaloes[i].Show();
            }
        }
        private void Shoot()
        {
            Console.SetCursorPosition()
        }
    }
}
