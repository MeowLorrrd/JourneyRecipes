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
using System.IO;
using System.Security.Cryptography;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using ReLogic.Utilities;
using Terraria.Audio;
using Terraria.Chat;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Tile_Entities;
using Terraria.GameContent.UI;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.IO;
using Terraria.Localization;
using Terraria.ObjectData;
using Terraria.Social;
using Terraria.UI;
using Terraria.UI.Chat;
using Terraria.UI.Gamepad;
using Terraria.Utilities;

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