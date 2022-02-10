using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class TrueNightsEdge : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.terraBladeStuff)
            {
                if (item.type == ItemID.TrueNightsEdge)
                {
                    item.autoReuse = true;
                    item.damage = 105;
                }
            }
        }
    }
}
