﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;
using ReLogic.Utilities;

namespace JourneyRecipes.Projectiles
{
    public class JourneyRecipesGlobalProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            bool ws = Config.Instance.allowWeaponStat;
            bool tb = Config.Instance.terraBladeStuff;
            if (ws)
            {
                switch (projectile.type)
                {
                    case 92:
                        projectile.damage = 7;
                        projectile.penetrate = 1;
                        break;
                    case 242:
                        projectile.penetrate = 3;
                        break;
                    case 260:
                        projectile.penetrate = 1;
                        break;
                    case 266:
                        projectile.netImportant = true;
                        projectile.usesIDStaticNPCImmunity = true;
                        projectile.idStaticNPCHitCooldown = 12;
                        break;
                    case 297:
                        projectile.penetrate = 3;
                        break;
                    case 387:
                        projectile.netImportant = true;
                        projectile.usesIDStaticNPCImmunity = true;
                        projectile.idStaticNPCHitCooldown = 16;
                        break;
                    case 388:
                        projectile.netImportant = true;
                        projectile.usesIDStaticNPCImmunity = true;
                        projectile.idStaticNPCHitCooldown = 12;
                        break;
                    case 389:
                        projectile.usesIDStaticNPCImmunity = true;
                        projectile.idStaticNPCHitCooldown = 12;
                        projectile.extraUpdates = 2;
                        break;
                    case 433:
                        if (projectile.melee) projectile.damage = 70;
                        break;
                    case 533:
                        projectile.netImportant = true;
                        projectile.usesIDStaticNPCImmunity = true;
                        projectile.idStaticNPCHitCooldown = 8;
                        break;
                    case 697:
                        projectile.scale = 1.35f;
                        projectile.damage = 150;
                        break;
                    case 708:
                    case 709:
                        projectile.damage = 70;
                        break;
                }
            }
            if (tb)
            {
                switch (projectile.type)
                {
                    case 132:
                        projectile.damage = 173;
                        break;
                    case 156:
                        projectile.penetrate = 2;
                        break;
                    case 157:
                        projectile.damage = 158;
                        break;
                }
            }
        }
    }
}