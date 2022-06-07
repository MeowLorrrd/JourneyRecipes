using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;

namespace JourneyRecipes.NPCs
{
    public class GlobalNPCBreakerBlade : GlobalNPC
    {
        public override bool InstancePerEntity => true;

        public override void ModifyHitByItem(NPC npc, Player player, Item item, ref int damage, ref float knockback, ref bool crit)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures)
            {
                if (npc.life >= (0.9 * npc.lifeMax) && item.type == ItemID.BreakerBlade && player.HeldItem.type == ItemID.BreakerBlade)
                {
                    npc.takenDamageMultiplier = 2;
                }
                else
                {
                    return;
                }
            }
        }
    }
}