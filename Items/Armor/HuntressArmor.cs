using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    public class HuntressArmorHead : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.HuntressWig)
            {
                string GermanOld = "Erhöht die Höchstanzahl deiner Wächter und erhöht die kritische Fernkampfchance um 10%";
                string GermanNew = "Erhöht deine maximale Anzahl an Wächtern auf 1 und 10% erhöhte kritische Fernkampf-Trefferchance";
                string EnglishOld = "Increases your max number of sentries and increases ranged critical strike chance by 10%";
                string EnglishNew = "Increases your max number of sentries by 1 and increases ranged critical strike chance by 10%";
                string SpanishOld = "Aumenta el número máximo de centinelas y aumenta un 10% la probabilidad de impacto crítico a distancia";
                string SpanishNew = "Aumenta el número máximo de centinelas en 1 y aumenta un 10% el daño de los ataques críticos a distancia";
                string FrenchOld = "Augmente votre nombre maximal de sentinelles et +10 % de chances de coup critique à distance";
                string FrenchNew = "Augmente votre nombre maximal de sentinelles de 1 et vous octroie +10 % de chances de coup critique à distance";
                string ItalianOld = "Aumenta il numero massimo di sentinelle e la possibilità di attacco critico a distanza del 10%";
                string ItalianNew = "Aumenta il numero massimo di sentinelle di 1 e la possibilità di attacco critico a distanza del 10%";
                string PolishOld = "Zwiększa maksymalną liczbę wartowników oraz szansę na dystansowe trafienie krytyczne o 10%";
                string PolishNew = "Zwiększa maksymalną liczbę wartowników o 1 oraz szansę na dystansowe trafienie krytyczne o 10%";
                string PortugeseOld = "Aumenta o número máximo de sentinelas e aumenta a chance de acerto crítico à distância em 10%";
                string PortugeseNew = "Aumenta o número máximo de sentinelas em 1 e a chance de acerto crítico em ataques à distância em 10%";
                string RussianOld = "Увеличивает ваше максимальное количество стражников и повышает шанс критического дистанционного удара на 10 %";
                string RussianNew = "Увеличивает ваше максимальное количество стражников на 1 и шанс критического дистанционного удара на 10 %";
                string ChineseOld = "提高哨兵数量上限，远程暴击率提高10%";
                string ChineseNew = "哨兵数量上限提高1个，远程暴击率提高10%";
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
    public class HuntressArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.HuntressJerkin)
            {

            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.HuntressJerkin)
            {
                string GermanOld = "Um 20% erhöhter Günstlings- und Fernkampfschaden";
                string GermanNew = "Um 20% erhöhter Günstling- und Fernkampfschaden sowie 10% Chance, keine Munition zu verbrauchen";
                string EnglishOld = "20% increased minion and ranged damage";
                string EnglishNew = "20% increased minion and ranged damage and 10% chance to not consume ammo";
                string SpanishOld = "Aumenta un 20% el daño de súbditos y a distancia";
                string SpanishNew = "Aumenta un 20% el daño de los súbditos y el daño a distancia, con una probabilidad del 10% de no gastar munición";
                string FrenchOld = "+20 % de dégâts des sbires et à distance";
                string FrenchNew = "+20 % de dégâts des sbires et à distance et +10 % de chances de ne pas utiliser de munitions";
                string ItalianOld = "Danno dei seguaci e a distanza aumentato del 20%";
                string ItalianNew = "Danno dalla distanza e dei seguaci aumentato del 20% e 10% di probabilità di non consumare munizioni";
                string PolishOld = "20% zwiększone obrażenia sług i obrażenia dystansowe";
                string PolishNew = "20% zwiększone obrażenia sług oraz obrażenia dystansowe, a także 10% szans niezużycia amunicji";
                string PortugeseOld = "20% de aumento nos danos por ataques dos lacaios e à distância";
                string PortugeseNew = "20% de aumento no dano por lacaios e de ataque à distância e 10% de chance de não consumir munição";
                string RussianOld = "Увеличивает урон прислужников и дистанционный урон на 20 %";
                string RussianNew = "Увеличивает урон прислужников на 20 % и дистанционный урон на 10 %, а также дает шанс 10 % не потратить боеприпасы";
                string ChineseOld = "仆从和远程伤害各增加20%";
                string ChineseNew = "仆从和远程伤害各增加20%，10%的几率不消耗弹药";
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
