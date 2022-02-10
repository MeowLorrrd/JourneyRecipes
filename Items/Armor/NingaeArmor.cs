using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    #region NingaeArmor
    [AutoloadEquip(EquipType.Head)]
    public class NingaeArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaHood)
            {
                player.thrownVelocity -= .15f;
                player.magicCrit += 3;
                player.meleeCrit += 3;
                player.rangedCrit += 3;
                
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaHood)
            {
                string NingaeArmorHead = "3% increased critical strike chance";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "15% increased throwing velocity")
                    {
                        line.text = NingaeArmorHead;
                    }
                }
            }
        }
    }

    [AutoloadEquip(EquipType.Body)]
    public class NingaeArmorChest : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaShirt)
            {
                player.thrownDamage -= .15f;
                player.magicCrit += 3;
                player.meleeCrit += 3;
                player.rangedCrit += 3;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaShirt)
            {
                string NingaeArmorShirt = "3% increased critical strike chance";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "15% increased throwing damage")
                    {
                        line.text = NingaeArmorShirt;
                    }
                }
            }
        }
    }

    [AutoloadEquip(EquipType.Legs)]
    public class NingaeArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaPants)
            {
                player.thrownCrit -= 10;
                player.magicCrit += 3;
                player.meleeCrit += 3;
                player.rangedCrit += 3;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaPants)
            {
                string NingaeArmorPants = "3% increased critical strike chance";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "10% increased throwing critical strike chance")
                    {
                        line.text = NingaeArmorPants;
                    }
                }
            }
        }
    }
    #endregion
    public class NingaeArmorSet : GlobalItem
    {
        const string Ninjaset = "Ninja_armor_set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.NinjaHood && body.type == ItemID.NinjaShirt && legs.type == ItemID.NinjaPants)
            {
                return Ninjaset;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowThrowingToRanged && set == Ninjaset)
            {
                player.moveSpeed += .2f;
                player.thrownCost33 = false;
                player.setBonus = "20% increased movement speed";
            }
        }
    }
}