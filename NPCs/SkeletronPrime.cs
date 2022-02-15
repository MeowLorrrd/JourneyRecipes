using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class SkeletronPrime : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.SkeletronPrime)
            {
                npc.buffImmune[BuffID.CursedInferno] = false;
            }
        }
    }
}