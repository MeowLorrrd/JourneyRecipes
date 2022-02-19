using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class FlowerofFrost : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.FlowerofFrost)
            {
                item.mana = 11;
                item.useTime = 12;
                item.useAnimation = 12;
                item.damage = 60;
            }
        }
        public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.FlowerofFrost)
            {
                target.AddBuff(BuffID.Frostburn, 8);
            }
        }
    }
}