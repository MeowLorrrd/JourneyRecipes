using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class GlobalNPCShop : GlobalNPC
    {
        public override bool Autoload(ref string name)
        {
            return ModContent.GetInstance<JourneyRecipesServerConfig>().AllowNPCShop;
        }
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Merchant)
            {
                if (Main.hardMode)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SharpeningStation);
                    shop.item[nextSlot].shopCustomPrice = 100000;
                    nextSlot++;
                }
            }
            if (type == NPCID.Mechanic)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Timer1Second);
                shop.item[nextSlot].shopCustomPrice = 10000;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Timer3Second);
                shop.item[nextSlot].shopCustomPrice = 10000;
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Timer5Second);
                shop.item[nextSlot].shopCustomPrice = 10000;
                nextSlot++;
                shop.item[nextSlot++].SetDefaults(ItemID.Teleporter);
            }
            if (type == NPCID.Steampunker)//TODO: remove Teleporter from shop
            {
                //shop.item[nextSlot--].SetDefaults(ItemID.Teleporter);
            }
            if (type == NPCID.Wizard)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Book);
                shop.item[nextSlot].shopCustomPrice = 1500;
                nextSlot++;
            }
            if (type == NPCID.SkeletonMerchant)
            {
                switch (Main.moonPhase)
                {
                    default:
                        shop.item[nextSlot++].SetDefaults(ItemID.WoodenBoomerang);
                        break;
                    case 1:
                        shop.item[nextSlot++].SetDefaults(ItemID.Umbrella);
                        break;
                    case 2:
                        shop.item[nextSlot++].SetDefaults(ItemID.WandofSparking);
                        break;
                    case 3:
                        //shop.item[nextSlot++].SetDefaults(ItemID.StepStoollmao);
                        break;
                    case 4:
                        shop.item[nextSlot++].SetDefaults(ItemID.Aglet);
                        break;
                    case 5:
                        shop.item[nextSlot++].SetDefaults(ItemID.ClimbingClaws);
                        break;
                    case 6:
                        shop.item[nextSlot++].SetDefaults(3068);
                        break;
                    case 7:
                        shop.item[nextSlot++].SetDefaults(ItemID.Radar);
                        break;
                    case 8:
                        shop.item[nextSlot++].SetDefaults(ItemID.Teleporter);
                        break;
                }
            }
            if (type == NPCID.WitchDoctor)
            {//TODO:
             //Remove old shops for these items
                /*
                if (NPC.downedQueenBee)
                {
                    if (!Main.dayTime)
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.PygmyNecklace);
                        //shop.item[nextSlot].shopCustomPrice = 200000;
                    }
                }
                if (NPC.downedPlantBoss)
                {
                    shop.item[nextSlot++].SetDefaults(ItemID.TikiMask);
                    shop.item[nextSlot++].SetDefaults(ItemID.TikiShirt);
                    shop.item[nextSlot++].SetDefaults(ItemID.TikiPants);
                    if (Main.player[Main.myPlayer].ZoneJungle)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.HerculesBeetle);
                        nextSlot++;
                    }
                }
                */
                if (NPC.downedQueenBee)
                {
                    if (!Main.LocalPlayer.HasItem(ItemID.PygmyStaff))
                    {
                        if (!Main.dayTime)
                            shop.item[nextSlot++].SetDefaults(ItemID.PygmyNecklace);
                    }
                }
                if (NPC.downedPlantBoss)
                {
                    if (!Main.LocalPlayer.HasItem(ItemID.PygmyStaff))
                    {
                        shop.item[nextSlot++].SetDefaults(ItemID.TikiMask);
                        shop.item[nextSlot++].SetDefaults(ItemID.TikiShirt);
                        shop.item[nextSlot++].SetDefaults(ItemID.TikiPants);
                        if (Main.LocalPlayer.ZoneJungle)
                        {
                            shop.item[nextSlot++].SetDefaults(ItemID.HerculesBeetle);
                        }
                    }
                }
            }
        }
    }
}