using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class GlobalNPCShop : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (Config.Instance.allowNPCStat)
            {
                if (type == NPCID.Merchant && Main.hardMode)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SharpeningStation);
                    shop.item[nextSlot].shopCustomPrice = 100000;
                    nextSlot++;
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
}