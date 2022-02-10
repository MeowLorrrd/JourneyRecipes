using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.NPCs
{
    public class Mothron : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (Config.Instance.terraBladeStuff && npc.type == NPCID.Mothron)
            {
                if (!NPC.downedPlantBoss)
                {
                    npc.lifeMax = 0;
                }
            }
        }
    }
}