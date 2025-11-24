using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh2gyakorlas
{
    internal class Spaceship
    {
        string Name;
        public string name { get { return Name; } }

        ShipClassType ClassType;
        public ShipClassType classtype { get { return ClassType; } }

        int Crew;
        public int crew { get { return Crew; } }

        CrewStatusType Status;
        public CrewStatusType status { get { return Status; } }

        int Cargo;
        public int cargo { get { return Cargo; } }

        DateTime Message;
        public DateTime message { get { return Message; } }

        public Spaceship(string line)
        {
            string[] strings = line.Split(';');
            Name = strings[0];
            ShipClassType ClassType = (ShipClassType)Enum.Parse(typeof(ShipClassType), strings[1]);
            Crew = int.Parse(strings[2]);
            CrewStatusType Status = (CrewStatusType)Enum.Parse(typeof(CrewStatusType), strings[3]);
            Cargo = int.Parse(strings[4]);
            Message = DateTime.Parse(strings[5]);
        }
        private int DaysSinceLastMessage(DateTime date)
        {
            return (date - message).Days;
        }
        public bool NeedsRescue(DateTime date)
        {
            if(Status == CrewStatusType.Deceased || Status == CrewStatusType.MissingInAction)
            {
                return true;
            }
            if(Status == CrewStatusType.Active)
            {
                if (DaysSinceLastMessage(date) < 30)
                {
                    return true;
                }
            }
            if (Status == CrewStatusType.InCryosleep)
            {
                if (DaysSinceLastMessage(date) < 3650)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return name + " (" + ClassType + ")";
        }
        public string GetStatusReport(DateTime date)
        {
            string needed = "Yes";
            if(this.NeedsRescue(date))
            {
                needed = "No";
            }
            return "=== " + this.ToString() + " ===\n  Crew:\t" + crew + " (" + Status+ " )\n  Last message:\t" + message + " days\n  Rescue needed: " + needed;
        }
    }
}
