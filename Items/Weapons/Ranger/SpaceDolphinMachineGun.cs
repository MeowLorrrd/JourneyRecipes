using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class SpaceDolphinMachineGun : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.SDMG)
            {
                item.damage = 85;
            }
        }
        public override bool ConsumeAmmo(Item item, Player player)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.SDMG)
            {
                return Main.rand.NextBool(3);
            }
            return true;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.SDMG)
            {
                string SDMGTT1 = "66% chance to not consume ammo";
                string SDMGTT2 = "'It came from the edge of space'";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "50% chance to not consume ammo")
                    {
                        line.text = SDMGTT1;
                    }
                    if (line.text == "'It came from the edge of space'")
                    {
                        line.text = SDMGTT2;
                    }
                }
            }
        }
    }
}