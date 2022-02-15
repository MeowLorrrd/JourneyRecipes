using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class ObsidianSkinPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.ObsidianSkinPotion)
            {
                item.buffType = BuffID.ObsidianSkin;
                item.buffTime = 21600;
            }
        }
    }
}