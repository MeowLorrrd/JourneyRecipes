using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class MeteorHead : GlobalNPC
    {
        public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.MeteorHead)
            {
                if (!Main.hardMode && Main.expertMode)
                    npc.lifeMax = 52;
                if (Main.hardMode && Main.expertMode)
                    npc.lifeMax = 56;
            }
        }
    }
}