using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Tiles
{
    public class JourneyRecipesGlobalTile : GlobalTile
    {
        public override void SetDefaults()
        {
            //rude
        }
        public override bool CanExplode(int x, int y, int type)
        {
            bool tc = Config.Instance.allowTileChange;
            if (tc)
            {
                switch (type)
                {
                    case 37:
                        if (!Main.hardMode)
                            return false;
                        break;
                    case 137:
                        //if (!NPC.downedGolemBoss)
                        {
                            int num = Main.tile[x, y].frameY / 18;
                            if ((uint)(num - 1) <= 3u)
                            {
                                return false;
                            }
                        }
                        break;
                }
            }
            return base.CanExplode(x, y, type);
        }
    }
}
