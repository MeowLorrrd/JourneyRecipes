using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class GladiatorArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.GladiatorHelmet)
            {
                player.statDefense += 3;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.GladiatorHelmet)
            {
                string GladiatorArmorHead = "5 defense";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "2 defense")
                    {
                        line.text = GladiatorArmorHead;
                    }
                }
            }
        }
    }

    [AutoloadEquip(EquipType.Body)]
    public class GladiatorArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.GladiatorBreastplate)
            {
                player.statDefense += 3;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.GladiatorBreastplate)
            {
                string GladiatorArmorBody = "6 defense";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "3 defense")
                    {
                        line.text = GladiatorArmorBody;
                    }
                }
            }
        }
    }

    [AutoloadEquip(EquipType.Legs)]
    public class GladiatorArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.GladiatorLeggings)
            {
                player.statDefense += 3;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.GladiatorLeggings)
            {
                string GladiatorArmorLegs = "5 defense";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "2 defense")
                    {
                        line.text = GladiatorArmorLegs;
                    }
                }
            }
        }
    }

    public class GladiatorArmorSet : GlobalItem
    {
        const string GladiatorSet = "Gladiator_armor_set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.GladiatorHelmet && body.type == ItemID.GladiatorBreastplate && legs.type == ItemID.GladiatorLeggings)
            {
                return GladiatorSet;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == GladiatorSet)
            {
                player.noKnockback = true;
                player.setBonus = "Grants Immunity to knockback";
            }
        }
    }
}