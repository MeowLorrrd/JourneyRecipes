using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Tools
{
    public class Reaversharkcuzidontlikeyou : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowToolStat && item.type == ItemID.ReaverShark)
            {
                item.pick = 59;
                item.useTime = 13;
                item.useAnimation = 13;
            }
        }
    }
}