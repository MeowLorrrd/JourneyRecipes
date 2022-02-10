using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class TombCrawler : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.TombCrawlerHead)
            {
                if (Main.rand.Next(0, 2) == 0)
                {
                    int i = Main.rand.Next(1, 2);
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.FossilOre, i);
                }
            }
        }
    }
}