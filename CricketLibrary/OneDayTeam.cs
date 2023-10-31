using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CricketLibrary
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>(11);

        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            if (oneDayTeam.Count < 11)
            {
                oneDayTeam.Add(player);
            }
            else
            {
                throw new Exception("The team is full.");
            }
        }

        public void Remove(int pId)
        {
            oneDayTeam.RemoveAll(player => player.PlayerId == pId);
        }

        public Player GetPlayerById(int pId)
        {
            return oneDayTeam.Find(player => player.PlayerId == pId);
        }

        public Player GetPlayerByName(string pName)
        {
            return oneDayTeam.Find(player => player.PlayerName == pName);
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
