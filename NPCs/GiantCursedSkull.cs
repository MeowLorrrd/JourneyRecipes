using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace JourneyRecipes.NPCs
{
    public class GiantCursedSkull : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.GiantCursedSkull && Config.Instance.allowNPCStat)
            {
                if (!Main.expertMode)
                {
                    if (Main.rand.Next(100) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Nazar);
                    }
                }
                if (Main.expertMode)
                {
                    if (Main.rand.Next(50) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Nazar);
                    }
                }
            }
        }
    }
}
