using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class WallOfFlesh : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (Config.Instance.allowNPCStat && (npc.type == NPCID.WallofFlesh || npc.type == NPCID.WallofFleshEye))
                npc.buffImmune[BuffID.Poisoned] = false;
        }
    }
}