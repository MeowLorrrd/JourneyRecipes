﻿using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemTool : GlobalItem
    {
        public override bool Autoload(ref string name)
        {
            return GetInstance<JourneyRecipesServerConfig>().allowToolStat;
        }
        public override void SetDefaults(Item item)
        {
            if (item.type == 2292)
            {
                item.fishingPole = 30;
            }
            else if (item.type == 2295)
            {
                item.fishingPole = 35;
            }
            else if (item.type == 2341)
            {
                item.pick = 59;
                item.useTime = 13;
                item.useAnimation = 22;
                item.useTurn = true;
            }
            else if (item.type == 2798)
            {
                item.axe = 0;
                item.useAnimation = 25;
                item.useTime = 6;
                item.shootSpeed = 36f;
                item.tileBoost = 11;
            }
            else if (item.type == ItemID.WireKite)
            {
                item.value = Item.sellPrice(0, 4);
            }
        }
    }
}
