using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.Localization;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MolterArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MoltenHelmet)
                player.meleeCrit += 7;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MoltenHelmet)
            {
                string GermanOld = "8 Abwehr";
                string GermanNew = "8 Abwehr\nUm 7% erhöhte kritische Nahkampf-Trefferchance";
                string EnglishOld = "8 defense";
                string EnglishNew = "8 defense\n7% increased melee critical strike chance";
                string SpanishOld = "8 defensa";
                string SpanishNew = "8 defensa\nAumenta un 7% la probabilidad de ataque crítico en el cuerpo a cuerpo";
                string FrenchOld = "8 de défense";
                string FrenchNew = "8 de défense\n+7 % de chances de coup critique au corps à corps";
                string ItalianOld = "8 difesa";
                string ItalianNew = "8 difesa\nProbabilità di colpo critico in mischia aumentata del 7%";
                string PolishOld = "8 pkt. obrony";
                string PolishNew = "8 pkt. obrony\n7% większa szansa na trafienie krytyczne w walce w zwarciu";
                string PortugeseOld = "8 defesa";
                string PortugeseNew = "8 defesa\n7% de aumento na chance de ataque físico crítico";
                string RussianOld = "8 защита";
                string RussianNew = "8 защита\nУвеличивает шанс критического урона в ближнем бою на 7 %";
                string ChineseOld = "8 防御力";
                string ChineseNew = "8 防御力\n近战暴击率增加7%";
                #region new tooltips
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == GermanOld)
                    {
                        line.text = GermanNew;
                    }
                    if (line.text == EnglishOld)
                    {
                        line.text = EnglishNew;
                    }
                    if (line.text == SpanishOld)
                    {
                        line.text = SpanishNew;
                    }
                    if (line.text == FrenchOld)
                    {
                        line.text = FrenchNew;
                    }
                    if (line.text == ItalianOld)
                    {
                        line.text = ItalianNew;
                    }
                    if (line.text == PolishOld)
                    {
                        line.text = PolishNew;
                    }
                    if (line.text == PortugeseOld)
                    {
                        line.text = PortugeseNew;
                    }
                    if (line.text == RussianOld)
                    {
                        line.text = RussianNew;
                    }
                    if (line.text == ChineseOld)
                    {
                        line.text = ChineseNew;
                    }
                }
                #endregion
            }
        }
    }
    [AutoloadEquip(EquipType.Body)]
    public class MolterArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MoltenBreastplate)
                player.meleeDamage += .07f;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MoltenBreastplate)
            {
                string GermanOld = "9 Abwehr";
                string GermanNew = "9 Abwehr\nUm 7% erhöhter Nahkampfschaden";
                string EnglishOld = "9 defense";
                string EnglishNew = "9 defense\n7% increased melee damage";
                string SpanishOld = "9 defensa";
                string SpanishNew = "9 defensa\nAumenta un 7% el daño cuerpo a cuerpo";
                string FrenchOld = "9 de défense";
                string FrenchNew = "9 de défense\n+7 % de dégâts au corps à corps";
                string ItalianOld = "9 difesa";
                string ItalianNew = "9 difesa\nDanno da mischia aumentato del 7%";
                string PolishOld = "9 pkt. obrony";
                string PolishNew = "9 pkt. obrony\n7% zwiększone obrażenia w walce w zwarciu";
                string PortugeseOld = "9 defesa";
                string PortugeseNew = "9 defesa\n7% de aumento no dano por ataques físicos";
                string RussianOld = "9 защита";
                string RussianNew = "9 защита\nУвеличивает урон в ближнем бою на 7 %";
                string ChineseOld = "9 防御力";
                string ChineseNew = "9 防御力\n近战伤害增加7%";
                #region new tooltips
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == GermanOld)
                    {
                        line.text = GermanNew;
                    }
                    if (line.text == EnglishOld)
                    {
                        line.text = EnglishNew;
                    }
                    if (line.text == SpanishOld)
                    {
                        line.text = SpanishNew;
                    }
                    if (line.text == FrenchOld)
                    {
                        line.text = FrenchNew;
                    }
                    if (line.text == ItalianOld)
                    {
                        line.text = ItalianNew;
                    }
                    if (line.text == PolishOld)
                    {
                        line.text = PolishNew;
                    }
                    if (line.text == PortugeseOld)
                    {
                        line.text = PortugeseNew;
                    }
                    if (line.text == RussianOld)
                    {
                        line.text = RussianNew;
                    }
                    if (line.text == ChineseOld)
                    {
                        line.text = ChineseNew;
                    }
                }
                #endregion
            }
        }
    }
    [AutoloadEquip(EquipType.Legs)]
    public class MolterArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MoltenGreaves)
                player.meleeSpeed += .07f;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.MoltenGreaves)
            {
                string GermanOld = "8 Abwehr";
                string GermanNew = "8 Abwehr\nUm 7% erhöhtes Nahkampftempo";
                string EnglishOld = "8 defense";
                string EnglishNew = "8 defense\n7% increased melee speed";
                string SpanishOld = "8 defensa";
                string SpanishNew = "8 defensa\nAumenta un 7% la velocidad del cuerpo a cuerpo";
                string FrenchOld = "8 de défense";
                string FrenchNew = "8 de défense\n+7 % de vitesse au corps à corps";
                string ItalianOld = "8 difesa";
                string ItalianNew = "8 difesa\nVelocità nel corpo a corpo aumentata del 7%";
                string PolishOld = "8 pkt. obrony";
                string PolishNew = "8 pkt. obrony\n7% zwiększona szybkość walki w zwarciu";
                string PortugeseOld = "8 defesa";
                string PortugeseNew = "8 defesa\n7% de aumento na velocidade do ataque físico";
                string RussianOld = "8 защита";
                string RussianNew = "8 защита\nУвеличивает скорость ближнего боя на 7 %";
                string ChineseOld = "8 防御力";
                string ChineseNew = "8 防御力\n近战速度提高7%";
                #region new tooltips
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == GermanOld)
                    {
                        line.text = GermanNew;
                    }
                    if (line.text == EnglishOld)
                    {
                        line.text = EnglishNew;
                    }
                    if (line.text == SpanishOld)
                    {
                        line.text = SpanishNew;
                    }
                    if (line.text == FrenchOld)
                    {
                        line.text = FrenchNew;
                    }
                    if (line.text == ItalianOld)
                    {
                        line.text = ItalianNew;
                    }
                    if (line.text == PolishOld)
                    {
                        line.text = PolishNew;
                    }
                    if (line.text == PortugeseOld)
                    {
                        line.text = PortugeseNew;
                    }
                    if (line.text == RussianOld)
                    {
                        line.text = RussianNew;
                    }
                    if (line.text == ChineseOld)
                    {
                        line.text = ChineseNew;
                    }
                }
                #endregion
            }
        }
    }
    public class MoltenArmorSet : GlobalItem
    {
        const string Moltenset = "Molten_armor_set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.MoltenHelmet && body.type == ItemID.MoltenBreastplate && legs.type == ItemID.MoltenGreaves)
            {
                return Moltenset;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == Moltenset)
            {
                player.meleeDamage -= .07f;
                player.buffImmune[BuffID.OnFire] = true;
                if (GameCulture.German.IsActive)
                {
                    player.setBonus = "10% zusätzlicher Nahkampfschaden,\nKann nicht in Brand gesetzt werden";
                }
                if (GameCulture.English.IsActive)
                {
                    player.setBonus = "10% extra melee damage,\nCannot be set on fire";
                }
                if (GameCulture.Spanish.IsActive)
                {
                    player.setBonus = "10% de daño extra en el cuerpo a cuerpo\nNo se le puede prender fuego";
                }
                if (GameCulture.French.IsActive)
                {
                    player.setBonus = "+10 % de dégâts supplémentaires au corps à corps, ne peut pas prendre feu";
                }
                if (GameCulture.Italian.IsActive)
                {
                    player.setBonus = "10% di danni da mischia in più,\nnon può prendere fuoco";
                }
                if (GameCulture.Polish.IsActive)
                {
                    player.setBonus = "10% dodatkowych obrażeń w walce w zwarciu\nNie można podpalić";
                }
                if (GameCulture.Portuguese.IsActive)
                {
                    player.setBonus = "Adicional de 10% de dano por ataques físicos,\nNão pode ser incendiado";
                }
                if (GameCulture.Russian.IsActive)
                {
                    player.setBonus = "Увеличивает урон в ближнем бою на 10 %\nНевозможно поджечь";
                }
                if (GameCulture.Chinese.IsActive)
                {
                    player.setBonus = "10%额外近战伤害，\n无法被点燃";
                }
            }
        }
    }
}