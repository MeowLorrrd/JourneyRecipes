using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class Flamethrower : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && Config.Instance.allowExperimentalFeatures && item.type == ItemID.Flamethrower)
            {
                    item.damage = 35;
            }
        }
    }
    
    public class FlamethrowerProjectile : GlobalProjectile
    {
        //15% penalty for each pierce
    }
} 