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
    }
}