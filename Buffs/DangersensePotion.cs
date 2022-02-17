using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class DangersensePotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.TrapsightPotion)
            {
                item.buffType = BuffID.Dangersense;
                item.buffTime = 36000;
            }
        }
    }
}