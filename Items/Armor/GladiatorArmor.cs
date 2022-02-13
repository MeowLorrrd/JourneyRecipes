using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.Localization;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class GladiatorArmorHead : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.GladiatorHelmet)
                item.defense = 5;
        }
    }

    [AutoloadEquip(EquipType.Body)]
    public class GladiatorArmorBody : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.GladiatorBreastplate)
                item.defense = 6;
        }
    }

    [AutoloadEquip(EquipType.Legs)]
    public class GladiatorArmorLegs : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.GladiatorLeggings)
                item.defense = 5;
        }
    }

    public class GladiatorArmorSet : GlobalItem
    {
        const string GladiatorSet = "Gladiator_armor_set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.GladiatorHelmet && body.type == ItemID.GladiatorBreastplate && legs.type == ItemID.GladiatorLeggings)
            {
                return GladiatorSet;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == GladiatorSet)
            {
                player.noKnockback = true;
                if (GameCulture.German.IsActive)
                {
                    player.setBonus = "Gewährt Immunität gegen Rückstoß";
                }
                if (GameCulture.English.IsActive)
                {
                    player.setBonus = "Grants immunity to knockback";
                }
                if (GameCulture.Spanish.IsActive)
                {
                    player.setBonus = "Vuelve inmune al retroceso";
                }
                if (GameCulture.French.IsActive)
                {
                    player.setBonus = "Immunise contre le recul";
                }
                if (GameCulture.Italian.IsActive)
                {
                    player.setBonus = "Rende immuni dallo spintone";
                }
                if (GameCulture.Polish.IsActive)
                {
                    player.setBonus = "Daje odporność na odrzut";
                }
                if (GameCulture.Portuguese.IsActive)
                {
                    player.setBonus = "Oferece imunidade a recuos";
                }
                if (GameCulture.Russian.IsActive)
                {
                    player.setBonus = "Дает невосприимчивость к отбрасыванию";
                }
                if (GameCulture.Chinese.IsActive)
                {
                    player.setBonus = "对击退免疫";
                }
            }
        }
    }
}