using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class CactusArmorHead : GlobalItem
    {

    }
    [AutoloadEquip(EquipType.Body)]
    public class CactusArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.CactusBreastplate)
            {
                player.statDefense -= 1;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.CactusBreastplate)
            {
                string CactusArmorBody = "1 defense";
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == "2 defense")
                    {
                        line.text = CactusArmorBody;
                    }
                }
            }
        }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class CactusArmorLegs : GlobalItem
    {

    }
    public class CactusArmorSet : GlobalItem
    {
        const string CactusSet = "Cactus_armor_set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.CactusHelmet && body.type == ItemID.CactusBreastplate && legs.type == ItemID.CactusLeggings)
            {
                return CactusSet;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == CactusSet)
            {
                player.statDefense -= 1;
                if (!Main.expertMode)
                {
                    player.thorns = 1f;
                }
                if (Main.expertMode)
                {
                    player.thorns = 2f;
                }
                player.setBonus = "Attackers also take damage";
            }
        }
    }
}
