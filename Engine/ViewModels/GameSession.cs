using Engine.Models;
using Engine.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Abdul";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;



            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, -1);


        }

    }
}
