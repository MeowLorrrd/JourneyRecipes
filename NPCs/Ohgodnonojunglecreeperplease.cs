using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class Ohgodnonojunglecreeperplease : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            if (Config.Instance.allowNPCStat && (npc.type == NPCID.JungleCreeper || npc.type == NPCID.JungleCreeperWall))
            {
                npc.lifeMax = 400;
                npc.damage = 100;
                npc.defense = 40;
            }
        }
        public override void OnHitPlayer(NPC npc, Player target, int damage, bool crit)
        {
            if (Config.Instance.allowNPCStat && (npc.type == NPCID.JungleCreeper || npc.type == NPCID.JungleCreeperWall))
            {
                if (Main.rand.Next(10) == 0)
                {
                    target.AddBuff(BuffID.Venom, 240);
                }
            }
        }
    }
}