using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Armor
{
    #region Spooky Head
    [AutoloadEquip(EquipType.Head)]
    public class SpookyArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyHelmet)
            {
                player.statDefense += 1;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyHelmet)
            {
                string SpookyHelmetTT = "9 defense";
                string SpookyHelmetTT2 = "Increases your max number of minions by 1";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "8 defense")
                    {
                        line.text = SpookyHelmetTT;
                    }
                    if (line.text == "Increases your max number of minions")
                    {
                        line.text = SpookyHelmetTT2;
                    }
                }
            }
        }
    }
    #endregion
    #region Spooky Body
    [AutoloadEquip(EquipType.Body)]
    public class SpookyArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyBreastplate)
            {
                player.statDefense += 1;
                player.maxMinions += 1;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyBreastplate)
            {
                string SpookyBreastplateTT = "11 defense";
                string SpookyBreastplateTT2 = "Increases your max number of minions by 2";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "10 defense")
                    {
                        line.text = SpookyBreastplateTT;
                    }
                    if (line.text == "Increases your max number of minions")
                    {
                        line.text = SpookyBreastplateTT2;
                    }
                }
            }
        }
    }
    #endregion
    #region Spooky Feet
    [AutoloadEquip(EquipType.Legs)]
    public class SpookyArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyLeggings)
            {
                player.statDefense += 1;
                player.moveSpeed += .2f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyLeggings)
            {
                string SpookyLeggingsTT1 = "10 defense";
                string SpookyLeggingsTT2 = "Increases your max number of minions by 1";
                var SpookyLeggingsTT3 = new TooltipLine(mod, "SpookyLeggingsToolTip2", "20% increased movement speed");
                string SpookySetBonusTTFix = "20% increased movement speed\nSet bonus: Increases minion damage by 25%";
                bool SLB = false;
                
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "9 defense")
                    {
                        line.text = SpookyLeggingsTT1;
                    }
                    if (line.text == "Increases your max number of minions")
                    {
                        line.text = SpookyLeggingsTT2;
                    }
                    if (line.text == "Set bonus: Increases minion damage by 25%")
                    {
                        line.text = SpookySetBonusTTFix;
                        SLB = true;
                    }
                }
                if (!SLB)//Add tooltip after set bonus tooltip
                {
                    tooltips.Add(SpookyLeggingsTT3);
                }
            }
        }
    }
    #endregion
    #region Summoner Emblem
    //Summoner emblem here cuz why not?
    public class SummonerEmblem : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.SummonerEmblem)
            {
                string SummonerEmblemTT1 = "15% increased minion damage";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "15% increased summon damage")
                    {
                        line.text = SummonerEmblemTT1;
                    }
                }
            }
        }
    }
    #endregion
}