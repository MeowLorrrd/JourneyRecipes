using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class SonarPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.SonarPotion)
            {
                item.buffType = BuffID.Sonar;
                item.buffTime = 28800;
            }
        }
    }
}