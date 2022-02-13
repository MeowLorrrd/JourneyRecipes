using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class JungleArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JungleHat || item.type == ItemID.AncientCobaltHelmet)
                player.magicCrit += 2;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JungleHat || item.type == ItemID.AncientCobaltHelmet)
            {
                string GermanOld = "Um 4% erhöhte kritische Magie-Trefferchance";
                string GermanNew = "Um 6% erhöhte kritische Magie-Trefferchance";
                string EnglishOld = "4% increased magic critical strike chance";
                string EnglishNew = "6% increased magic critical strike chance";
                string SpanishOld = "Aumenta un 4% la probabilidad de impacto mágico crítico";
                string SpanishNew = "Aumenta un 6% la probabilidad de impacto mágico crítico";
                string FrenchOld = "+4 % de chance de coup critique magique";
                string FrenchNew = "+6 % de chances de coup critique magique";
                string ItalianOld = "Aumenta la possibilità di colpo critico magico del 4%";
                string ItalianNew = "Aumenta la probabilità di colpo critico magico del 6%";
                string PolishOld = "4% większa szansa na magiczne trafienie krytyczne";
                string PolishNew = "6% większa szansa na magiczne trafienie krytyczne";
                string PortugeseOld = "4% de aumento na chance de acerto crítico de magias";
                string PortugeseNew = "6% de aumento na chance de ataque mágico crítico";
                string RussianOld = "Увеличивает шанс критического магического урона на 4 %";
                string RussianNew = "Увеличивает шанс критического магического урона на 6 %";
                string ChineseOld = "魔法暴击率增加4%";
                string ChineseNew = "魔法暴击率增加6%";
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
    public class JungleArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JungleShirt || item.type == ItemID.AncientCobaltBreastplate)
            {
                player.magicCrit -= 4;
                player.magicDamage += .06f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JungleShirt || item.type == ItemID.AncientCobaltBreastplate)
            {
                string GermanOld = "Um 4% erhöhte kritische Magie-Trefferchance";
                string GermanNew = "Um 6% erhöhter Magieschaden";
                string EnglishOld = "4% increased magic critical strike chance";
                string EnglishNew = "6% increased magic damage";
                string SpanishOld = "Aumenta un 4% la probabilidad de impacto mágico crítico";
                string SpanishNew = "Aumenta el daño de los ataques mágicos en un 6%";
                string FrenchOld = "+4 % de chance de coup critique magique";
                string FrenchNew = "+6 % de dégâts magiques"; 
                string ItalianOld = "Aumenta la possibilità di colpo critico magico del 4%";
                string ItalianNew = "Danno magico aumentato del 6%";
                string PolishOld = "4% większa szansa na magiczne trafienie krytyczne";
                string PolishNew = "6% zwiększone obrażenia magiczne";
                string PortugeseOld = "4% de aumento na chance de acerto crítico de magias";
                string PortugeseNew = "6% de aumento no dano por magia";
                string RussianOld = "Увеличивает шанс критического магического урона на 4 %";
                string RussianNew = "Увеличивает магический урон на 6 %";
                string ChineseOld = "魔法暴击率增加4%";
                string ChineseNew = "魔法伤害增加6%";
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
    public class JungleArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JunglePants || item.type == ItemID.AncientCobaltLeggings)
                player.magicCrit += 2;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.JunglePants || item.type == ItemID.AncientCobaltLeggings)
            {
                string GermanOld = "Um 4% erhöhte kritische Magie-Trefferchance";
                string GermanNew = "Um 6% erhöhte kritische Magie-Trefferchance";
                string EnglishOld = "4% increased magic critical strike chance";
                string EnglishNew = "6% increased magic critical strike chance";
                string SpanishOld = "Aumenta un 4% la probabilidad de impacto mágico crítico";
                string SpanishNew = "Aumenta un 6% la probabilidad de impacto mágico crítico";
                string FrenchOld = "+4 % de chance de coup critique magique";
                string FrenchNew = "+6 % de chances de coup critique magique";
                string ItalianOld = "Aumenta la possibilità di colpo critico magico del 4%";
                string ItalianNew = "Aumenta la probabilità di colpo critico magico del 6%";
                string PolishOld = "4% większa szansa na magiczne trafienie krytyczne";
                string PolishNew = "6% większa szansa na magiczne trafienie krytyczne";
                string PortugeseOld = "4% de aumento na chance de acerto crítico de magias";
                string PortugeseNew = "6% de aumento na chance de ataque mágico crítico";
                string RussianOld = "Увеличивает шанс критического магического урона на 4 %";
                string RussianNew = "Увеличивает шанс критического магического урона на 6 %";
                string ChineseOld = "魔法暴击率增加4%";
                string ChineseNew = "魔法暴击率增加6%";
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
}