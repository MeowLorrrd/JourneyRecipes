using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemAccessory : GlobalItem
    {
        public override bool Autoload(ref string name)
        {
            return GetInstance<Config>().allowAccessoryStat;
        }
        public override void SetDefaults(Item item)
        {
            if (item.type == 49 || item.type == 860)
            {
                item.lifeRegen = 2;
            }
            if (item.type == 3016)
            {
                item.defense = 8;
            }
        }
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (item.type == 211)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().PlayerFeral = true;
            }
            else if (item.type == 897)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().PlayerFeral = true;
            }
            else if (item.type == 908)
            {
                player.lavaRose = true;
            }
            else if (item.type == 936)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().PlayerFeral = true;
            }
            else if (item.type == 1343)
            {
                player.meleeDamage += .02f;
                player.meleeSpeed += .02f;
                player.GetModPlayer<JourneyRecipesPlayer>().PlayerFeral = true;
            }
            else if (item.type == 2221)
            {
                player.statManaMax2 += 20;
            }
        }
    }
}