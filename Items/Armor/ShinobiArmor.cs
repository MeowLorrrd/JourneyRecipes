using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    #region Shinobi Infiltrator Head
    [AutoloadEquip(EquipType.Head)]
    public class ShinobiArmorHead : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkAltHead)
            {
                string TavernkeepT2ArmorMeleeSpeedTypeHead = "Increases your max number of sentries by 2 and increases 20% melee & minion damage";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "Increases your max number of sentries and increases 20% melee & minion damage")
                    {
                        line.text = TavernkeepT2ArmorMeleeSpeedTypeHead;
                    }
                }
            }
        }
    }
    #endregion
    #region Shinobi Infiltrator Body
    [AutoloadEquip(EquipType.Body)]
    public class ShinobiArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkAltShirt)
            {
                player.meleeCrit += 5;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkAltShirt)
            {
                var TavernkeepT2ArmorMeleeSpeedTypeChest = new TooltipLine(mod, "1.4 add tip", "5% increased melee critical strike chance");
                string TavernkeepT2ArmorMeleeSpeedTypeChestFix = "5% increased melee critical strike chance\nSet bonus: Increases your max number of sentries\nGreatly enhances Lightning Aura effectiveness";
                bool SLB = false;
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "Set bonus: Increases your max number of sentries\nGreatly enhances Lightning Aura effectiveness")
                    {
                        line.text = TavernkeepT2ArmorMeleeSpeedTypeChestFix;
                        SLB = true;
                    }
                }
                if (!SLB)
                {
                    tooltips.Add(TavernkeepT2ArmorMeleeSpeedTypeChest);
                }
            }
        }
    }
    #endregion
    #region Shinobi Infiltrator Legs
    [AutoloadEquip(EquipType.Legs)]
    public class ShinobiArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkAltPants)
            {
                player.moveSpeed += 0.1f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkAltPants)
            {
                string TavernkeepT2ArmorMeleeSpeedTypePants = "30% increased movement speed";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "20% increased movement speed")
                    {
                        line.text = TavernkeepT2ArmorMeleeSpeedTypePants;
                    }
                }
            }
        }
    }
    #endregion
}