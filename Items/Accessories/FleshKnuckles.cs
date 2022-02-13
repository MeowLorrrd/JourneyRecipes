using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Accessories
{
    public class FleshKnuckles : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.FleshKnuckles)
                item.defense = 8;
        }
    }
}
