using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.GameContent.Shaders;
using System;
using System.Collections.Generic;
using ReLogic.Utilities;
using Terraria.Audio;
using Terraria.Chat;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.Achievements;
using Terraria.GameContent.Events;
using Terraria.GameContent.UI;
using Terraria.Localization;
using Terraria.Utilities;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using ReLogic;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class RainbowRod : GlobalItem
    {
        public bool c = Config.Instance.allowWeaponStat;
        public override bool InstancePerEntity => true;
        public override bool CloneNewInstances => true;
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.RainbowRod && c)
            {
                item.damage = 50;
                item.useTime = 25;
                item.useAnimation = item.useTime;
                item.mana = 21;
                
            }
        }
    }
    public class RainbowRodProjectile : GlobalProjectile
    {
        public bool c = Config.Instance.allowWeaponStat;
        public override bool InstancePerEntity => true;
        public override bool CloneNewInstances => true;
        public override void SetDefaults(Projectile projectile)
        {
            if (projectile.type == ProjectileID.RainbowRodBullet && c)
            {
                projectile.penetrate = 3;
            }
        }
        public override void AI(Projectile projectile)
        {
            if (projectile.type == ProjectileID.RainbowRodBullet && c)
            {

            }
        }
    }
}