using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace JourneyRecipes.NPCs
{
    public class TruffleWorm : GlobalNPC
    {
        public override void AI(NPC npc)
        {
            if (Config.Instance.allowNPCStat && (npc.type == NPCID.TruffleWorm || npc.type == NPCID.TruffleWormDigger))
            {
                npc.dontTakeDamageFromHostiles = true;
            }
        }
    }
}