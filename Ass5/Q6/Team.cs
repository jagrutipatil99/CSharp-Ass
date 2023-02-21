using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAss_All.Ass5.Q6
{
    class Team
    {
        static void Main(string[] args)
        {

            Player[] india = new Player[]
            {
                new Player{Name="Rohit",Runs=25000},
                new Player{Name="Ajay",Runs=26700},
                new Player{Name="Virat",Runs=2600},
             };

            IEnumerable<Player> GetAllCustomer()
            {
                return india;
            }
            foreach (var item in GetAllCustomer())
            {
                Console.Write("\nName: " + item.Name + "\nRuns Scored :" + item.Runs);
            }

        }
    }
}
