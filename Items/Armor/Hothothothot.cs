using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MolterArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MoltenHelmet)
            {
                player.meleeCrit += 7;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MoltenHelmet)
            {
                var MoltenArmorHead = new TooltipLine(mod, "", "7% increased melee critical strike chance");
                string MolterArmorSet = "Set bonus: 10% extra melee damage,\nCannot be set on fire";
                string MoltenArmorSetFix = "7% increased melee critical strike chance\nSet bonus: 10% extra melee damage,\nCannot be set on fire";
                bool M = false;
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == MolterArmorSet)
                    {
                        line.text = MoltenArmorSetFix;
                        M = true;
                    }
                }
                if (!M)
                {
                    tooltips.Add(MoltenArmorHead);
                }
            }
        }
    }
    [AutoloadEquip(EquipType.Body)]
    public class MolterArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MoltenBreastplate)
            {
                player.meleeDamage += .07f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MoltenBreastplate)
            {
                var MoltenArmorBody = new TooltipLine(mod, "", "7% increased melee damage");
                string MolterArmorSet = "Set bonus: 10% extra melee damage,\nCannot be set on fire";
                string MoltenArmorSetFix = "7% increased melee damage\nSet bonus: 10% extra melee damage,\nCannot be set on fire";
                bool M = false;
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == MolterArmorSet)
                    {
                        line.text = MoltenArmorSetFix;
                        M = true;
                    }
                }
                if (!M)
                {
                    tooltips.Add(MoltenArmorBody);
                }
            }
        }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class MolterArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MoltenGreaves)
            {
                player.meleeSpeed += .07f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.MoltenGreaves)
            {
                var MoltenArmorLegs = new TooltipLine(mod, "", "7% increased melee speed");
                string MolterArmorSet = "Set bonus: 10% extra melee damage,\nCannot be set on fire";
                string MoltenArmorSetFix = "7% increased melee speed\nSet bonus: 10% extra melee damage,\nCannot be set on fire";
                bool M = false;
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == MolterArmorSet)
                    {
                        line.text = MoltenArmorSetFix;
                        M = true;
                    }
                }
                if (!M)
                {
                    tooltips.Add(MoltenArmorLegs);
                }
            }
        }
    }
    public class MoltenArmorSet : GlobalItem
    {
        const string Moltenset = "Molten_armor_set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.MoltenHelmet && body.type == ItemID.MoltenBreastplate && legs.type == ItemID.MoltenGreaves)
            {
                return Moltenset;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == Moltenset)
            {
                player.meleeDamage -= .07f;
                player.buffImmune[BuffID.OnFire] = true;
                player.setBonus = "10% extra melee damage,\nCannot be set on fire";
            }
        }
    }
}