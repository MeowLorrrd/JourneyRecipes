using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Tiles
{
    public class TempleTraps : GlobalTile
    {
        public override void SetDefaults()
        {
            
        }
        public override bool CanExplode(int i, int j, int type)
        {
            if (type == TileID.Traps)//figure out how to select only temple traps
            {

            }
            return base.CanExplode(i, j, type);
        }
    }
}