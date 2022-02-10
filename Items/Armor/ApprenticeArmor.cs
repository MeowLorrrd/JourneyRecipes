using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    #region Apprentice Armor Head
    [AutoloadEquip(EquipType.Head)]
    public class ApprenticeArmor : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeHat)
            {
                player.magicDamage += .1f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeHat)
            {
                string TavernkeepT1ArmorMagicHead = "Increases your max number of sentries by 1,\n10% increased magic damage and reduces mana costs by 10%";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "Increases your max number of sentries and reduces mana costs by 10%")
                    {
                        line.text = TavernkeepT1ArmorMagicHead;
                    }
                }
            }
        }
    }
    #endregion
    #region Apprentice Armor Legs
    [AutoloadEquip(EquipType.Legs)]
    public class ApprenticeArmorLegs : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.ApprenticeTrousers) //No config needed cus tooltip is actually an error
            {
                string TavernkeepT1ArmorMagicLegs = "10% increased minion damage,\n20% increased magic critical strike chance and movement speed";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "10% increased minion damage and 20% increased movement speed")
                    {
                        line.text = TavernkeepT1ArmorMagicLegs;
                    }
                }
            }
        }
    }
    #endregion
}
