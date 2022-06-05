using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class JourneyRecipesGlobalBuff : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            switch (item.type)
            {
                case ItemID.CratePotion:
                case ItemID.GravitationPotion:
                case ItemID.InvisibilityPotion:
                    item.buffTime = 10800;
                    break;
                case ItemID.EndurancePotion:
                case ItemID.GillsPotion:
                case ItemID.InfernoPotion:
                case ItemID.MagicPowerPotion:
                case ItemID.RagePotion:
                case ItemID.WrathPotion:
                    item.buffTime = 14400;
                    break;
            }
        }
    }
}