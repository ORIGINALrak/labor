using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Labor7
{
    public enum StatuszTipus { Scheduled, Delayed, Canceled}
    internal class Flight
    {
        public string jaratszam;
        public string celallomas;
        public DateTime indulas;
        public int keses;
        StatuszTipus statusz;
        public string Jaratszam
        {
            get { return jaratszam; }
        }
        public string Celallomas
        {
            get { return celallomas; }
        }
        public DateTime Indulas
        {
            get { return indulas; }
        }
        public int Keses
        {
            get { return keses; }
        }
        public StatuszTipus Statusz
        {
            get { return statusz; }
        }

        public Flight(string jaratszam, string celallomas, DateTime indulas, int keses, StatuszTipus statusz)
        {
            this.jaratszam = jaratszam;
            this.celallomas = celallomas;
            this.indulas = indulas;
            this.keses = keses;
            this.statusz = statusz;
        }
        public Flight(string jaratszam, string celallomas, DateTime indulas)
        {
            this.jaratszam = jaratszam;
            this.celallomas = celallomas;
            this.indulas = indulas;
            keses = 0;
            statusz = StatuszTipus.Scheduled;
        }

        public void Delay(int delay)
        {
            keses = delay;
        }

        public void Cancel()
        {
            statusz = StatuszTipus.Canceled;
        }
        private void UpdateStatus(StatuszTipus stat)
        {
            statusz = stat;
        }
        private void UpdateStatus()
        {
            if (keses > 0)
            {
                statusz = StatuszTipus.Delayed;
            }
            else
            {
                statusz = StatuszTipus.Scheduled;
            }
        }
        public string AllData()
        {
            string s = "Flight " + jaratszam + " is ";
            switch (statusz)
            {
                case StatuszTipus.Scheduled:
                    s += "on time. ";
                    break;
                case StatuszTipus.Delayed:
                    s += "delayed. ";
                    break;
                case StatuszTipus.Canceled:
                    s += "canceled. ";
                    break;
            }
            return s;
        }
    }
}
