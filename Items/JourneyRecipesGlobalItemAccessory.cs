using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemAccessory : GlobalItem
    {
        public override bool Autoload(ref string name)
        {
            return GetInstance<JourneyRecipesServerConfig>().allowAccessoryStat;
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
            if (item.type== 3245)
            {
                item.accessory = true;
                item.damage = 0;
                item.knockBack = 0;
                item.crit = 0;
                item.useTime = 0;
                item.useAnimation = 0;
                item.useStyle = 0;
            }
            if (item.type == 154)
            {
                item.notAmmo = true;
            }
        }
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (item.type == 211)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().autoReuseGlove = true;
            }
            if (item.type == 897)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().autoReuseGlove = true;
            }
            if (item.type == 908)
            {
                player.lavaRose = true;
            }
            if (item.type == 936)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().autoReuseGlove = true;
            }
            if (item.type == 1343)
            {
                player.meleeDamage += .02f;
                player.meleeSpeed += .02f;
                player.GetModPlayer<JourneyRecipesPlayer>().autoReuseGlove = true;
            }
            if (item.type == 2221)
            {
                player.statManaMax2 += 20;
            }
            if (item.type == 532 || item.type == 862 || item.type == 1247)
            {
                player.starCloak = false;
                player.GetModPlayer<JourneyRecipesPlayer>().StarCloak = true;
            }
            if (item.type == 1303)
            {
                if (!player.wet)
                {
                    Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 0.225f, 0.05f, 0.15f);
                }
                if (player.wet)
                {
                    Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 1.8f, 0.4f, 1.2f);
                }
            }
            if (item.type == 1860)
            {
                if (!player.wet)
                {
                    Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 0.225f, 0.05f, 0.15f);
                }
                if (player.wet)
                {
                    Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 1.8f, 0.4f, 1.2f);
                }
            }
            if (item.type == 1861)
            {
                if (!player.wet)
                {
                    Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 0.05f, 0.15f, 0.225f);
                }
                if (player.wet)
                {
                    Lighting.AddLight((int)player.Center.X / 16, (int)player.Center.Y / 16, 0.4f, 1.2f, 1.8f);
                }
            }
            if (item.type == 3245)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().BoneGloveItem = item;
            }
            if (player.bee)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().BeeBeeBee = true;
            }
            if (item.type == 1131)
            {
                player.gravControl = true;
            }
        }
    }
}
