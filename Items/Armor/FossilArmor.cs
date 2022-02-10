using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    #region Fossil Armor Head
    [AutoloadEquip(EquipType.Head)]
    public class FossilArmor : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilHelm)
            {
                player.rangedCrit += 4;
                player.statDefense += 1;
                player.thrownVelocity -= .2f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilHelm)
            {
                string FossilArmorHelm = "4 defense";
                string FossilArmorHelm2 = "4% increased ranged critical strike chance";
                string FossilArmorSet = "Set bonus: 20% chance to not consume ammo";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "3 defense")
                    {
                        line.text = FossilArmorHelm;
                    }
                    if (line.text == "20% increased throwing velocity")
                    {
                        line.text = FossilArmorHelm2;
                    }
                    if (line.text == "Set bonus: 50% chance to not consume thrown item")
                    {
                        line.text = FossilArmorSet;
                    }
                }
            }
        }
    }
    #endregion
    #region Fossil Armor Body
    [AutoloadEquip(EquipType.Body)]
    public class FossilBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilShirt)
            {
                player.rangedDamage += .05f;
                player.statDefense -= 1;
                player.thrownDamage -= .2f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilShirt)
            {
                string FossilArmorBody = "5 defense";
                string FossilArmorBody2 = "5% increased ranged damage";
                string FossilArmorSet = "Set bonus: 20% chance to not consume ammo";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "6 defense")
                    {
                        line.text = FossilArmorBody;
                    }
                    if (line.text == "20% increased throwing damage")
                    {
                        line.text = FossilArmorBody2;
                    }
                    if (line.text == "Set bonus: 50% chance to not consume thrown item")
                    {
                        line.text = FossilArmorSet;
                    }
                }
            }
        }
    }
    #endregion
    #region Fossil Armor Legs
    [AutoloadEquip(EquipType.Legs)]
    public class FossilLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilPants)
            {
                player.statDefense += 2;
                player.rangedCrit += 4;
                player.thrownCrit -= 15;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilPants)
            {
                string FossilArmorPants = "4 defense";
                string FossilArmorPants2 = "4% increased ranged critical strike chance ";
                string FossilArmorSet = "Set bonus: 20% chance to not consume ammo";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "2 defense")
                    {
                        line.text = FossilArmorPants;
                    }
                    if (line.text == "15% increased throwing critical strike chance")
                    {
                        line.text = FossilArmorPants2;
                    }
                    if (line.text == "Set bonus: 50% chance to not consume thrown item")
                    {
                        line.text = FossilArmorSet;
                    }
                }
            }
        }
    }
    #endregion
    public class FossilArmorSet : GlobalItem
    {
        const string Fossilset = "Fossil armor set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.FossilHelm && body.type == ItemID.FossilShirt && legs.type == ItemID.FossilPants)
            {
                return Fossilset;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowThrowingToRanged && set == Fossilset)
            {
                player.ammoCost80 = true;
                player.thrownCost50 = false;
            }
        }
    }
}