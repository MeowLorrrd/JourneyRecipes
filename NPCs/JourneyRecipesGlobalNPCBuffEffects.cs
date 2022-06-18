using Terraria;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class JourneyRecipesGlobalNPCBuffEffects : GlobalNPC
    {
        public override bool Autoload(ref string name)
        {
            return ModContent.GetInstance<Config>().AllowBuffStat;
        }
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if (player.HasBuff(10))
            {
                spawnRate = (int)(spawnRate * 1.2f);
            }
        }
    }
}