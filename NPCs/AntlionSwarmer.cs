using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class AntlionSwarmer : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.FlyingAntlion)
            {
                npc.value = 1950f;
            }
        }
        public override void NPCLoot(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.FlyingAntlion)
            {
                if (Main.rand.Next(50) == 0)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.AntlionMandible);
                }
            }
        }
    }
}