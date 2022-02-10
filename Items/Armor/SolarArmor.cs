using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Armor
{
    #region Solar Head
    [AutoloadEquip(EquipType.Head)]
    public  class SolarArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareHelmet)
            {
                player.lifeRegen += 1;
                player.meleeCrit += 9;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareHelmet)
            {
                string SolarFlareHelmetMeleeCritChanceHealthRegenBoost = "26% increased melee critical strike chance\nGrants minor life regeneration";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "17% increased melee critical strike chance")
                    {
                        line.text = SolarFlareHelmetMeleeCritChanceHealthRegenBoost;
                    }
                }
            }
        }
    }
    #endregion
    #region Solar Chest
    [AutoloadEquip(EquipType.Body)]
    public class SolarArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareBreastplate)
            {
                player.lifeRegen += 1;
                player.meleeDamage += .07f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareBreastplate)
            {
                string SolarFlareBreastplateMeleeDamageHealthRegenBoost = "29% increased melee damage\nGrants minor life regeneration";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "22% increased melee damage")
                    {
                        line.text = SolarFlareBreastplateMeleeDamageHealthRegenBoost;
                    }
                }
            }
        }
    }
    #endregion
    #region Solar Feet
    [AutoloadEquip(EquipType.Legs)]
    public class SolarArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareLeggings)
            {
                player.lifeRegen += 1;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareLeggings)
            {
                string SolarFlareLeggingsHealthRegenBoost = "15% increased movement and melee speed\nGrants minor life regeneration";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "15% increased movement and melee speed")
                    {
                        line.text = SolarFlareLeggingsHealthRegenBoost;
                    }
                }
            }
        }
    }
    #endregion
    public class SolarArmorSet : GlobalItem
    {
        const string SolarArmorSetBonus = "Solar_armor";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.SolarFlareHelmet && body.type == ItemID.SolarFlareBreastplate && legs.type == ItemID.SolarFlareLeggings)
            {
                return SolarArmorSetBonus;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == SolarArmorSetBonus)
            {
                player.endurance += .12f;
                player.solarCounter += 1;
                player.setBonus = "Set bonus: Solar shields charge over time to protect you & let you dash\nA charge is used to damage enemies you touch\nConsumed charges explode & damage enemies";
            }
        }
    }
    public class SolarBuff : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            if (Config.Instance.allowArmorStat && type == BuffID.SolarShield1)
            {
                player.endurance += .07f;
            }
            if (Config.Instance.allowArmorStat && type == BuffID.SolarShield2)
            {
                player.endurance += .13f;
            }
            if (Config.Instance.allowArmorStat && type == BuffID.SolarShield3)
            {
                player.endurance += .2f;
            }
        }
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            base.ModifyBuffTip(type, ref tip, ref rare);
            if (Config.Instance.allowArmorStat && type == BuffID.SolarShield1 || type == BuffID.SolarShield2 || type == BuffID.SolarShield3)
            {
                tip = "Damage taken reduced by 20%, repel enemies when taking damage";
            }
        }
    }
}