using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class GlobalNPCShop : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (Config.Instance.allowNPCStat && type == NPCID.Merchant && Main.hardMode)
            {
                shop.item[nextSlot].SetDefaults(ItemID.SharpeningStation);
                shop.item[nextSlot].shopCustomPrice = 100000;
                nextSlot++;
            }
        }
    }
}
