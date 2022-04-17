using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class ChaosElemental : GlobalNPC
    {
        /*public override bool PreNPCLoot(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.ChaosElemental && Main.expertMode)
            {
                NPCLoader.blockLoot.Add(ItemID.RodofDiscord);
            }
            return base.PreNPCLoot(npc);
        }
        public override void NPCLoot(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.ChaosElemental && Main.expertMode)
            {
                int i = Main.rand.Next(400);
                if (i == 0)
                    Item.NewItem(npc.Hitbox, ItemID.RodofDiscord);
            }
        }*/
    }
}