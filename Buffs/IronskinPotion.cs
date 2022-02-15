using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class IronskinPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.IronskinPotion)
            {
                item.buffType = BuffID.Ironskin;
                item.buffTime = 28800;
            }
        }
    }
}