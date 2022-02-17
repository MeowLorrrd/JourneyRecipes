using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace JourneyRecipes.Buffs
{
    public class FeatherfallPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.FeatherfallPotion)
            {
                item.buffType = BuffID.Featherfall;
                item.buffTime = 36000;
            }
        }
    }
}