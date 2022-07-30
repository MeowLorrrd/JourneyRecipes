using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes
{
    public class JourneyRecipesPlayer : ModPlayer
    {
        public bool PlayerInvis;
        public bool PlayerFeral;
        public bool PlayerAutouse;
        public bool PlayerTitanGlove;
        public bool CactusThorns;
        public bool Ammo10;
        public bool Ammo20;
        public bool Sharpened;
        public override void ResetEffects()
        {
            PlayerInvis = false;
            PlayerFeral = false;
            PlayerTitanGlove = false;
            PlayerAutouse = false;
            CactusThorns = false;
            Ammo10 = false;
            Ammo20 = false;
            Sharpened = false;
        }
        public override bool PreItemCheck()
        {
            if (Config.Instance.allowAccessoryStat && PlayerFeral && player.HeldItem.melee)
            {
                PlayerAutouse = player.HeldItem.autoReuse;
                player.HeldItem.autoReuse = true;
            }//code above from Fargo's Souls
            if (Config.Instance.AllowBuffStat && Sharpened && player.HeldItem.melee)
            {
                player.armorPenetration += 8;//+4 vanilla armor pen
            }
            if (Config.Instance.allowWeaponStat && (player.HeldItem.type == ItemID.NettleBurst || player.HeldItem.type == ItemID.WaspGun || player.HeldItem.type == ItemID.CrystalVileShard))
            {
                player.armorPenetration += 10;
            }
            return base.PreItemCheck();
        }
        public override bool ConsumeAmmo(Item weapon, Item ammo)
        {
            if (ModContent.GetInstance<Config>().allowArmorStat)
            {
                if (Ammo10)
                {
                    return !Main.rand.NextBool(10);
                }
                else if (Ammo20)
                {
                    return !Main.rand.NextBool(5);
                }
            }
            return base.ConsumeAmmo(weapon, ammo);
        }
    }
}
