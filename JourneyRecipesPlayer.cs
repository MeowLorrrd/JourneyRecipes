using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.GameContent.Events;
using Terraria.GameInput;
using Terraria.ModLoader.IO;

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
            if (Config.Instance.allowBuffStat && Sharpened && player.HeldItem.melee)
            {
                player.armorPenetration += 8;
            }
            if (Config.Instance.allowWeaponStat && player.HeldItem.type == ItemID.NettleBurst)
            {
                player.armorPenetration += 10;
            }
            return true;
        }
        public override void PostItemCheck()
        {
            if (Config.Instance.allowAccessoryStat && PlayerFeral && player.HeldItem.melee)
            {
                player.HeldItem.autoReuse = PlayerAutouse;
            }
        }
        public override bool ConsumeAmmo(Item weapon, Item ammo)
        {
            if (Config.Instance.allowArmorStat && Ammo10 && Main.rand.NextBool(10))
            {
                return false;
            }
            if (Config.Instance.allowArmorStat && Ammo20 && Main.rand.NextBool(5))
            {
                return false;
            }
            return base.ConsumeAmmo(weapon, ammo);
        }
    }
}