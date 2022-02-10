using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Ammo
{
    [AutoloadEquip(EquipType.Head)]
    public class ChlorophyteArmorHeadMelee : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ChlorophyteMask)
            {
                player.statDefense -= 5;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ChlorophyteMask)
            {
                string ChlorophyteArmorHeadMelee = "20 defense";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "25 defense")
                    {
                        line.text = ChlorophyteArmorHeadMelee;
                    }
                }
            }
        }
    }
    public class ChlorophyteArmorSet : GlobalItem
    {
        const string ChlorophyteArmorMeleeSet = "Chlorophyte_armor_set_with_Mask";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.ChlorophyteMask && body.type == ItemID.ChlorophytePlateMail && legs.type == ItemID.ChlorophyteGreaves)
            {
                return ChlorophyteArmorMeleeSet;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == ChlorophyteArmorMeleeSet)
            {
                player.setBonus = "Summons a powerful leaf crystal to shoot at nearby enemies\nReduces damage taken by 5%";
                player.endurance += .05f;
            }
        }
    }
    public class CrystalLeaf : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowArmorStat && projectile.type == ProjectileID.CrystalLeaf)
            {
                //Make shit shoot every .67 sec instead of .83
            }
        }
    }
}