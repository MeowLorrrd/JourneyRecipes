using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class BattlePotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.BattlePotion)
            {
                item.buffType = BuffID.Battle;
                item.buffTime = 25200;
            }
        }
    }
}