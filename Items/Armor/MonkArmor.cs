using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    #region Monk Armor Head
    [AutoloadEquip(EquipType.Head)]
    public class MonkArmorHead : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkBrows)
            {
                string TavernkeepT1ArmorMeleeSpeedTypeHead = "Increases your max number of sentries by 1 and increases melee attack speed by 20%";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "Increases your max number of sentries and increases melee attack speed by 20%")
                    {
                        line.text = TavernkeepT1ArmorMeleeSpeedTypeHead;
                    }
                }
            }
        }
    }
    #endregion
    #region Monk Armor Legs
    [AutoloadEquip(EquipType.Legs)]
    public class MonkArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkPants)
            {
                player.meleeCrit += 5;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkPants)
            {
                string TavernkeepT1ArmorMeleeSpeedTypeLegs = "15% increased melee critical strike chance and 20% increased movement speed";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "10% increased critical strike chance and 20% increased movement speed")
                    {
                        line.text = TavernkeepT1ArmorMeleeSpeedTypeLegs;
                    }
                }
            }
        }
    }
    #endregion
}