using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.Localization;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class NecroArmorHead : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && (item.type == ItemID.NecroHelmet || item.type == ItemID.AncientNecroHelmet))
                item.defense = 6;
        }
    }
    [AutoloadEquip(EquipType.Body)]
    public class NecroArmorBody : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.NecroBreastplate)
                item.defense = 7;
        }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class NecroArmorLegs : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.NecroGreaves)
                item.defense = 6;
        }
    }
    public class NecroSet : GlobalItem
    {
        const string Necroset = "Necro_Armor_set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.NecroHelmet || head.type == ItemID.AncientNecroHelmet && body.type == ItemID.NecroBreastplate && legs.type == ItemID.NecroGreaves)
            {
                return Necroset;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == Necroset)
            {
                player.ammoCost80 = false;
                player.rangedCrit += 10;
                if (GameCulture.German.IsActive)
                {
                    player.setBonus = "Um 10% erhöhte kritische Fernkampf-Trefferchance";
                }
                if (GameCulture.English.IsActive)
                {
                    player.setBonus = "10% increased ranged critical strike chance";
                }
                if (GameCulture.Spanish.IsActive)
                {
                    player.setBonus = "Aumenta un 10% la probabilidad de ataque crítico a distancia";
                }
                if (GameCulture.French.IsActive)
                {
                    player.setBonus = "+10 % de chances de coup critique à distance";
                }
                if (GameCulture.Italian.IsActive)
                {
                    player.setBonus = "Probabilità di colpo critico a distanza aumentata del 10%";
                }
                if (GameCulture.Polish.IsActive)
                {
                    player.setBonus = "10% większa szansa na dystansowe trafienie krytyczne";
                }
                if (GameCulture.Portuguese.IsActive)
                {
                    player.setBonus = "10% de aumento na chance de ataque à distância crítico";
                }
                if (GameCulture.Russian.IsActive)
                {
                    player.setBonus = "Увеличивает шанс критического дистанционного урона на 10 %";
                }
                if (GameCulture.Chinese.IsActive)
                {
                    player.setBonus = "远程暴击率增加10%";
                }
            }    
        }
    }
}
