﻿using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace JourneyRecipes.Projectiles
{
    public class JourneyRecipesGlobalProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)//i dont think there's a reason to make it look like this, it just looks neater??
        {
            bool ws = Config.Instance.allowWeaponStat;
            bool tb = Config.Instance.terraBladeStuff;
            bool ns = Config.Instance.allowNPCStat;
            if (ws)
            {
                FriendlyProjectile(projectile);
            }
            if (tb)
            {
                TerraBladeProjectile(projectile);
            }
            if (ns)
            {
                EnemyProjectile(projectile);
            }
        }
        public override void OnHitPlayer(Projectile projectile, Player target, int damage, bool crit)
        {
            bool ns = Config.Instance.allowNPCStat;
            if (ns)
            {
                ActiveEnemyProjectile(projectile, target);
            }
        }
        public static void FriendlyProjectile(Projectile projectile)
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
        public static void EnemyProjectile(Projectile projectile)
        {
            switch (projectile.type)
            {
                case 508:
                    projectile.damage = 36;
                    break;
            }
        }
        public void ActiveEnemyProjectile(Projectile projectile, Player target)
        {
            switch (projectile.type)
            {
                case 128:
                    if (Main.rand.NextBool(3)) target.AddBuff(BuffID.Frostburn, 360);
                    break;
                case 299:
                    if (Main.rand.NextBool(3)) target.AddBuff(BuffID.Cursed, 120);
                    break;
            }
        }
        public static void TerraBladeProjectile(Projectile projectile)
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
        public override void AI(Projectile projectile)
        {
            //code from omniswing source code
            //fixes spear ai
            {
                if (Config.Instance.allowAccessoryStat)
                {
                    if (projectile.aiStyle == 19 || projectile.aiStyle == 699)
                    {
                        projectile.timeLeft = Main.player[projectile.owner].itemAnimation;
                        projectile.netUpdate = true;
                    }
                }
            }
        }
    }
}