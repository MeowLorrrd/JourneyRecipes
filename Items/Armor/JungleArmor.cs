using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class JungleArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JungleHat || item.type == ItemID.AncientCobaltHelmet)
            {
                player.magicCrit += 2;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JungleHat || item.type == ItemID.AncientCobaltHelmet)
            {
                string JungleArmorHead = "6% increased magic critical strike chance"; 
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "4% increased magic critical strike chance")
                    {
                        line.text = JungleArmorHead;
                    }
                }
            }
        }
    }
    [AutoloadEquip(EquipType.Body)]
    public class JungleArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JungleShirt || item.type == ItemID.AncientCobaltBreastplate)
            {
                player.magicCrit -= 4;
                player.magicDamage += .06f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JungleShirt || item.type == ItemID.AncientCobaltBreastplate)
            {
                string JungleArmorHead = "6% increased magic damage";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "4% increased magic critical strike chance")
                    {
                        line.text = JungleArmorHead;
                    }
                }
            }
        }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class JungleArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JunglePants || item.type == ItemID.AncientCobaltLeggings)
            {
                player.magicCrit += 2;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JunglePants || item.type == ItemID.AncientCobaltLeggings)
            {
                string JungleArmorHead = "6% increased magic critical strike chance";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "4% increased magic critical strike chance")
                    {
                        line.text = JungleArmorHead;
                    }
                }
            }
        }
    }
}