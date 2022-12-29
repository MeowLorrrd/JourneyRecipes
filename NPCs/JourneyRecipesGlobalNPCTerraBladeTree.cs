using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class JourneyRecipesGlobalNPCTerraBladeTree : GlobalNPC
    {
        public override bool Autoload(ref string name)
        {
            return ModContent.GetInstance<JourneyRecipesServerConfig>().TerraBladeStuff;
        }
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == 477)
            {
                if (!NPC.downedPlantBoss)
                {
                    npc.lifeMax = 0;
                }
            }
        }
        public override void EditSpawnPool(IDictionary<int, float> pool, NPCSpawnInfo spawnInfo)
        {
            if (Main.eclipse)
            {
                if (!NPC.downedPlantBoss)
                {
                    //test?
                    pool[477] = 0;
                }
            }
        }
    }
}