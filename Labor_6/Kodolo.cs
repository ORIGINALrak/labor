using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Labor_6
{
    internal class Kodolo
    {
        int kulcs;

        public Kodolo(int kulcs)
        {
            this.kulcs=kulcs;
        }
        private string TransformMessage(string uzenet, int kulcs)
        {
            string msg = "";
            for(int i = 0; i < uzenet.Length; i++)
            {
                msg += (char)((int)uzenet[i] + kulcs);
            }
            return msg;
        }
        public string Encode(string uzenet)
        {
            return TransformMessage(uzenet, kulcs);
        }
        public string Decode(string uzenet)
        {
            return TransformMessage(uzenet, - kulcs);
        }
    }
}
