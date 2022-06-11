using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemStack : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (GetInstance<Config>().allowMaxStack)
            {
                switch (item.type)
                {
                    case 8:
                    case 19:
                    case 20:
                    case 21:
                    case 22:
                    case 27:
                    case 57:
                    case 59:
                    case 62:
                    case 75:
                    case 86:
                    case 117:
                    case 175:
                    case 194:
                    case 195:
                    case 282:
                    case 286:
                    case 307:
                    case 308:
                    case 309:
                    case 310:
                    case 311:
                    case 312:
                    case 313:
                    case 314:
                    case 315:
                    case 316:
                    case 317:
                    case 318:
                    case 369:
                    case 381:
                    case 382:
                    case 391:
                    case 427:
                    case 428:
                    case 429:
                    case 430:
                    case 431:
                    case 432:
                    case 433:
                    case 523:
                    case 703:
                    case 704:
                    case 705:
                    case 706:
                    case 974:
                    case 1006:
                    case 1184:
                    case 1191:
                    case 1198:
                    case 1225:
                    case 1245:
                    case 1257:
                    case 1329:
                    case 1333:
                    case 1557:
                    case 1828:
                    case 2171:
                    case 2274:
                    case 2357:
                    case 2358:
                    case 3002:
                    case 3004:
                    case 3045:
                    case 3112:
                    case 3114:
                    case 3261:
                    case 3467:
                        item.maxStack = 999;
                        break;
                    case 166:
                    case 167:
                    case 235:
                    case 2896:
                    case 3115:
                    case 3547:
                        item.maxStack = 99;
                        break;
                }
            }
        }
    }
}