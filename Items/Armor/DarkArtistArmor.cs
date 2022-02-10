using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    #region Dark Artist Head
    [AutoloadEquip(EquipType.Head)]
    public class DarkArtistArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeAltHead)
            {
                player.magicDamage += .05f;
                player.minionDamage += .05f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeAltHead)
            {
                string TavernkeepT2ArmorMageHead = "Increases your max number of sentries by 2";
                string TavernkeepT2ArmorMageHead2 = "15% increased minion & magic damage";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "Increases your max number of sentries")
                    {
                        line.text = TavernkeepT2ArmorMageHead;
                    }
                    if (line.text == "10% increased minion & magic damage")
                    {
                        line.text = TavernkeepT2ArmorMageHead2;
                    }
                }
            }
        }
    }
    #endregion
    #region Dark Artist Body
    [AutoloadEquip(EquipType.Body)]
    public class DarkArtistArmorBody: GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeAltShirt)
            {
                player.magicDamage -= .05f;
                player.minionDamage -= .05f;
                player.manaCost -= .15f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeAltShirt)
            {
                string TavernkeepT2ArmorMageChest = "25% increased minion damage and 10% increased magic damage\nReduces mana costs by 15%";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "30% increased minion damage and 15% increased magic damage")
                    {
                        line.text = TavernkeepT2ArmorMageChest;
                    }
                }
            }
        }
    }
    #endregion
    #region Dark Artist Legs
    [AutoloadEquip(EquipType.Legs)]
    public class DarkArtistArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeAltPants)
            {
                player.moveSpeed += .2f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeAltPants)
            {
                var TavernkeepT2ArmorMageLegs = new TooltipLine(mod, "1.4 added tip", "20% increased movement speed");
                string TavernkeepT2ArmorMageLegsFix = "20% increased movement speed\nIncreases your max number of sentries\nGreatly enhances Flameburst effectiveness";
                bool tiddy = false;
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "Set bonus: Increases your max number of sentries\nGreatly enhances Flameburst effectiveness")
                    {
                        line.text = TavernkeepT2ArmorMageLegsFix;
                        tiddy = true;
                    }
                }
                if (!tiddy)
                {
                    tooltips.Add(TavernkeepT2ArmorMageLegs);
                }
            }
        }
    }
    #endregion
}