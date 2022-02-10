using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Weapons.Mage
{
    public class WandofSparking : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.WandofSparking)
                {
                    item.useTime = 26;
                    item.useAnimation = 26;
                    item.damage = 14;
                    item.crit = 14;
                }
            }
        }
        public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Config.Instance.allowWeaponStat)
            {
                if (item.type == ItemID.WandofSparking)
                {
                    if (Main.rand.Next(0, 2) == 0)
                    {
                        int WoSdeBuff = Main.rand.Next(1, 3);
                        target.AddBuff(BuffID.OnFire, WoSdeBuff);
                    }
                }    
            }
        }
    }
}
