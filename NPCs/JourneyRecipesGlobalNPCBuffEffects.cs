using Terraria;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class JourneyRecipesGlobalNPCBuffEffects : GlobalNPC
    {
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if (ModContent.GetInstance<JourneyRecipesServerConfig>().AllowBuffStat)
            {
                if (player.HasBuff(10))
                {
                    spawnRate = (int)(spawnRate * 1.2f);
                }
            }


            if (player.GetModPlayer<JourneyRecipesPlayer>().anglerSetSpawnReduction)
            {
                spawnRate = (int)((float)spawnRate * 1.3f);
                maxSpawns = (int)((float)maxSpawns * 2f);
            }
        }
    }
}