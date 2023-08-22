using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class OneDayTeam : ITeam
    {
        Player pId,pN;
        int count=0;
        public static List<Player> oneDayTeam = new List<Player>();
        private int _capacity;
        public OneDayTeam() 
        {
            _capacity = 11;
        }

        public void Add(Player player)
        {
            if(count == _capacity) 
            {
                Console.WriteLine("Sorry you can't add players more than 11");
            }
            else
            {
                oneDayTeam.Add(player);
                count += 1;

            }
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }

        public Player GetPlayerById(int playerId)
        {
                foreach (Player player in oneDayTeam)
                {
                    if (player.PlayerId == playerId)
                    {
                        pId = player;
                    }
                }
                return pId;
            
            
            
        }

        public Player GetPlayerByName(string playerName)
        {
            foreach(Player player in oneDayTeam)
            {
                if(player.PlayerName == playerName)
                {
                    pN = player;
                }
            }
            return pN;
        }

        public void Remove(int playerId)
        {
            int i;
            for(i=count-1;i>=0;i--)
            {
                if (oneDayTeam[i].PlayerId == playerId)
                {
                    oneDayTeam.RemoveAt(i);
                    count -= 1;
                }
            }
        }
    }
}
