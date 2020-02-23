﻿using BattleshipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipLibrary
{
    public static class GameLogic
    {
        public static void InitializeGrid (PlayerInfoModel model)
        {
            List<string> letters = new List<string>
            {
                "A","B","C","D","E"
            };

            List<int> numbers = new List<int>
            {
                1,2,3,4,5
            };

            foreach (string letter in letters)
            {
                foreach (int number in numbers)
                {
                    AddGridSpot(model, letter, number);
                }
            }
        }

        private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
        {
            GridSpotModel spot = new GridSpotModel
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = GridSpotStatus.Empty
            };
            model.ShotGrid.Add(spot);
        }

        public static bool PlaceShip(PlayerInfoModel model, string location)
        {
            return true;
        }
    }
}
