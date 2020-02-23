using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipLibrary.Models
{
    public class PlayerInfoModel
    {
        public string UserName { get; set; }

        public List<GridSpotModel> ShipLocations { get; set; } = new List<GridSpotModel>();
        public List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>();
    }
}
