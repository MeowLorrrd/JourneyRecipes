using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class SkyDragonsFury : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.MonkStaffT3)
                {
                    item.damage = 140;
                    item.autoReuse = true;
                }
            }
        }
    }
    public class SkyDragonsFuryProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (projectile.type == 707 || projectile.type == 708 || projectile.type == 709 || projectile.type == 443 && projectile.melee == true)
                {
                    projectile.damage = 70;
                }
            }
        }
    }
}