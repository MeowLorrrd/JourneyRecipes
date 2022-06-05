using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Tiles
{
    public class Meteorite : GlobalTile
    {
        public override bool CanExplode(int i, int j, int type)
        {
            if (type == TileID.Meteorite && !Main.hardMode) return false;
            return base.CanExplode(i, j, type);
        }
    }
}