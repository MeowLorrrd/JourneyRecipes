﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class IceElementalProjectile : GlobalProjectile
    {
        public override void OnHitPlayer(Projectile projectile, Player target, int damage, bool crit)
        {
            if (Config.Instance.allowNPCStat && projectile.type == ProjectileID.FrostBlastHostile)
            {
                if (Main.rand.Next(3) == 0)
                {
                    target.AddBuff(BuffID.Frostburn, 360);
                }
            }
        }
    }
}