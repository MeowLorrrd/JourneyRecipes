using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class DamageType : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowThrowingToRanged)
            {
                if (item.thrown)
                {
                    item.ranged = true;
                    item.melee = false;
                    item.thrown = false;
                }
                //Fix bc bone throws twice
                if (item.type == ItemID.Bone)
                {
                    item.useTime = 12;
                    item.useAnimation = 12;
                }
            }
            //Fix bc Bone Javelin has fire gauntlet fire thingy but is not melee??
            //Actually not a bug from this mod so will leave it bugged ig
            if (item.type == ItemID.BoneJavelin)
            {
                item.melee = false;
            }
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.Beenade)
                {
                    item.damage = 12;
                }
                if (item.type == ItemID.BoneJavelin)
                {
                    item.damage = 20;
                }
            }    
        }
    }
}