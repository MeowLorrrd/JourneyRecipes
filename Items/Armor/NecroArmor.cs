using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class NecroArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.NecroHelmet || item.type == ItemID.AncientNecroHelmet)
            {
                player.statDefense += 1;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.NecroHelmet || item.type == ItemID.AncientNecroHelmet)
            {
                string NecroArmorHead = "6 defense";
                string NecroArmorSet = "Set bonus: 10% increased ranged critical strike chance";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "5 defense")
                    {
                        line.text = NecroArmorHead;
                    }
                    if (line.text == "Set bonus: 20% chance to not consume ammo")
                    {
                        line.text = NecroArmorSet;
                    }
                }
            }
        }
    }
    [AutoloadEquip(EquipType.Body)]
    public class NecroArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.NecroBreastplate)
            {
                player.statDefense += 1;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.NecroBreastplate)
            {
                string NecroArmorBody = "7 defense";
                string NecroArmorSet = "Set bonus: 10% increased ranged critical strike chance";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "6 defense")
                    {
                        line.text = NecroArmorBody;
                    }
                    if (line.text == "Set bonus: 20% chance to not consume ammo")
                    {
                        line.text = NecroArmorSet;
                    }
                }
            }
        }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class NecroArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.NecroGreaves)
            {
                player.statDefense += 1;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.NecroGreaves)
            {
                string NecroArmorLegs = "6 defense";
                string NecroArmorSet = "Set bonus: 10% increased ranged critical strike chance";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "5 defense")
                    {
                        line.text = NecroArmorLegs;
                    }
                    if (line.text == "Set bonus: 20% chance to not consume ammo")
                    {
                        line.text = NecroArmorSet;
                    }
                }
            }
        }
    }
    public class NecroSet : GlobalItem
    {
        const string Necroset = "Necro_Armor_set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.NecroHelmet || head.type == ItemID.AncientNecroHelmet && body.type == ItemID.NecroBreastplate && legs.type == ItemID.NecroGreaves)
            {
                return Necroset;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == Necroset)
            {
                player.ammoCost80 = false;
                player.rangedCrit += 10;
            }    
        }
    }
}
