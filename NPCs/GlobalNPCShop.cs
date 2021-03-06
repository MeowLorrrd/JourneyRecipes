using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class GlobalNPCShop : GlobalNPC
    {
        public override bool Autoload(ref string name)
        {
            return ModContent.GetInstance<Config>().AllowNPCShop;
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
            }
            if (type == NPCID.Wizard)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Book);
                shop.item[nextSlot].shopCustomPrice = 1500;
                nextSlot++;
            }
            if (type == NPCID.WitchDoctor)
            {

            }
        }
    }
}