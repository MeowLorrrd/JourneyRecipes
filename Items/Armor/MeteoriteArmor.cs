using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MeteoriteArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorHelmet)
            {
                player.magicDamage += .02f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorHelmet)
            {
                {
                    string UniMeteorTooltip = "9% increased magic damage";
                    foreach (TooltipLine line in tooltips)
                    {
                        if (line.text == "7% increased magic damage")
                        {
                            line.text = UniMeteorTooltip;
                        }
                    }
                }
            }
        }
    }
    [AutoloadEquip(EquipType.Body)]
    public class MeteoriteArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorSuit)
            {
                player.magicDamage += .02f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorSuit)
            {
                {
                    string UniMeteorTooltip = "9% increased magic damage";
                    foreach (TooltipLine line in tooltips)
                    {
                        if (line.text == "7% increased magic damage")
                        {
                            line.text = UniMeteorTooltip;
                        }
                    }
                }
            }
        }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class MeteoriteArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorLeggings)
            {
                player.magicDamage += .02f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorLeggings)
            {
                {
                    string UniMeteorTooltip = "9% increased magic damage";
                    foreach (TooltipLine line in tooltips)
                    {
                        if (line.text == "7% increased magic damage")
                        {
                            line.text = UniMeteorTooltip;
                        }
                    }
                }
            }
        }
    }
}