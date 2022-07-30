using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemValue : GlobalItem
    {
        public override bool Autoload(ref string name)
        {
            return GetInstance<JourneyRecipesServerConfig>().allowSellChange;
        }
        public override void SetDefaults(Item item)
        {
            switch (item.type)//Move to diff file
            {
                case 64:
                case 96:
                case 111:
                case 115:
                case 162:
                case 800:
                case 802:
                case 1256:
                case 1290:
                case 3062:
                    item.value = Item.sellPrice(gold: 1, silver: 50);//shadow orb & crimson heart loot
                    break;
                case 2757:
                case 2760:
                case 2763:
                case 3381:
                    item.value = Item.sellPrice(gold: 7);//+3 lunar helmets
                    break;
                case 2758:
                case 2761:
                case 2764:
                case 3382:
                    item.value = Item.sellPrice(gold: 14);//lunar breastplates
                    break;
                case 2759:
                case 2762:
                case 2765:
                case 3383:
                    item.value = Item.sellPrice(gold: 10, silver: 50);//lunar leggings
                    break;
                case 3020:
                case 3021:
                case 3022:
                case 3023:
                    item.value = Item.sellPrice(gold: 6);//+3hook
                    break;
                case 1829:
                case 1916:
                case 273:
                    item.value = Item.sellPrice(gold: 4);
                    break;
                case 533:
                case 1265:
                    item.value = Item.sellPrice(gold: 7);//uzi megashark
                    break;
                case 3006:
                case 3007:
                case 3008:
                case 3012:
                case 3013:
                case 3014:
                case 3015:
                case 3016:
                case 3029:
                case 3030:
                case 3051:
                    item.value = Item.sellPrice(gold: 8);//biome mimic drops
                    break;
                case 56:
                    item.value = Item.sellPrice(silver: 10);//demon ore
                    break;
                case 57:
                    item.value = Item.sellPrice(silver: 30);//demon bar
                    break;
                case 113:
                case 155:
                case 157:
                case 163:
                case 164:
                case 329:
                case 3313:
                    item.value = Item.sellPrice(gold: 1, silver: 75);//dungeon loot
                    break;
                case 391:
                    item.value = Item.sellPrice(silver: 60);//adamantite bar
                    break;
                case 880:
                    item.value = Item.sellPrice(silver: 13);//crimtane ore
                    break;
                case 1198:
                    item.value = Item.sellPrice(silver: 68);//titanium bar
                    break;
                case 1257:
                    item.value = Item.sellPrice(silver: 39);//crimtane bar
                    break;
                case 3094:
                    item.value = Item.sellPrice(copper: 5);//javelin
                    break;
                case 3187:
                    item.value = Item.sellPrice(silver: 35);//glaidator helmet
                    break;
                case 3188:
                    item.value = Item.sellPrice(silver: 28);//gladiator breastplate
                    break;
                case 3189:
                    item.value = Item.sellPrice(silver: 21);//gladiator leggings
                    break;
                case 1121:
                case 1123:
                case 2888:
                    item.value = Item.sellPrice(gold: 2);//Queen Bee drops
                    break;
                case 1349:
                    item.value = Item.sellPrice(copper: 2);//party bullet
                    break;
            }
        }
    }
}