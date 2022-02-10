using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class MoonLord : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.MoonLordCore && !Main.expertMode)
            {

            }
        }
    }
}
//Moon Lord doesn't drop Greater Healing Potions, but drops Super Healing Potions