using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Tiles
{
    public class JourneyRecipesGlobalTile : GlobalTile
    {
        public override bool Autoload(ref string name)
        {
            return GetInstance<Config>().allowTileChange;
        }
        public override bool CanExplode(int x, int y, int type)
        {
            switch (Main.tile[x, y].type)
            {
                case 37:
                    if (!Main.hardMode)
                    {
                        return false;
                    }
                    break;
                case 137:
                    if (!NPC.downedGolemBoss)
                    {
                        int num = Main.tile[x, y].frameY / 18;
                        if ((uint)(num - 1) <= 3u)
                        {
                            return false;
                        }
                    }
                    break;
            }
            return base.CanExplode(x, y, type);
        }
        public override bool CanKillTile(int x, int y, int type, ref bool blockDamaged)
        {
            Player player = Main.LocalPlayer;
            switch (Main.tile[x, y].type)
            {
                case 137:
                    if (player.HeldItem.pick >= 210)
                    {
                        return true;
                    }
                    else
                    {
                        int num = Main.tile[x, y].frameY / 18;
                        if ((uint)(num - 1) <= 3u)
                        {
                            return false;
                        }
                    }
                    break;
            }
            return base.CanKillTile(x, y, type, ref blockDamaged);
        }
    }
}
