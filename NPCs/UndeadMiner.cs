using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class UndeadMiner : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.UndeadMiner)
            {
                if (Main.rand.Next(20) == 0)
                    Item.NewItem(npc.Hitbox, ItemID.BonePickaxe);

            }
        }
    }
}