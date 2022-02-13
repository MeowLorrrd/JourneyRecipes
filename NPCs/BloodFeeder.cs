using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class BloodFeeder : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.BloodFeeder)
            {
                npc.lifeMax = 150;
                npc.damage = 50;
                npc.defense = 20;
                npc.value = 500f;
            }
        }
    }
}