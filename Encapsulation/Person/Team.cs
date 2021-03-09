using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
       
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }
        public string Name { get; set; }
        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this.firstTeam.AsReadOnly(); }
        }
        public IReadOnlyCollection<Person> SecondTeam
        {
            get { return this.reserveTeam.AsReadOnly(); }
        }
        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }
    }
}
