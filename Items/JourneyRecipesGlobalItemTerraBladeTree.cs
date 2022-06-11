using Terraria;
using Terraria.ModLoader;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemTerraBladeTree : GlobalItem
    {
        public override bool Autoload(ref string name)
        {
            return ModContent.GetInstance<Config>().TerraBladeStuff;
        }
        public override void SetDefaults(Item item)
        {
            if (item.type == 674)
            {
                item.damage = 70;
            }
            else if (item.type == 675)
            {
                item.damage = 105;
                item.autoReuse = true;
            }
            else if (item.type == 757)
            {
                item.damage = 115;
                item.useTime = 14;
                item.useAnimation = item.useTime;
            }
        }
    }
}