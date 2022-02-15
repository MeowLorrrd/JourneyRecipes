using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class ThornsPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ThornsPotion)
            {
                item.buffType = BuffID.Thorns;
                item.buffTime = 28800;
            }
        }
    }
    public class ThornsPotionBuff : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            if (Config.Instance.allowBuffDuration && type == BuffID.Thorns)
            {
                player.thorns = 1f;
            }
        }
    }
}