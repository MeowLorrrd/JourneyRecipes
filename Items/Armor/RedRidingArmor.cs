using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class RedRidingArmorHead : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.HuntressAltHead)
            {
                string GermanOld = "Erhöht die Höchstanzahl deiner Wächter";
                string GermanNew = "Erhöht deine maximale Anzahl an Wächtern auf 2";
                string EnglishOld = "Increases your max number of sentries";
                string EnglishNew = "Increases your max number of sentries by 2";
                string SpanishOld = "Aumenta el número máximo de centinelas";
                string SpanishNew = "Aumenta el número máximo de centinelas en 2";
                string FrenchOld = "Augmente votre nombre maximal de sentinelles";
                string FrenchNew = "Augmente votre nombre maximal de sentinelles de 2";
                string ItalianOld = "Aumenta il numero massimo di sentinelle";
                string ItalianNew = "Aumenta il numero massimo di sentinelle di 2";
                string PolishOld = "Zwiększa maksymalną liczbę wartowników";
                string PolishNew = "Zwiększa maksymalną liczbę wartowników o 2";
                string PortugeseOld = "Aumenta o número máximo de sentinelas";
                string PortugeseNew = "Aumenta o número máximo de sentinelas em 2";
                string RussianOld = "Увеличивает ваше максимальное количество стражников";
                string RussianNew = "Увеличивает ваше максимальное количество стражников на 2";
                string ChineseOld = "提高哨兵数量上限";
                string ChineseNew = "哨兵数量上限提高2个";
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
    public class RedRidingArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.HuntressAltShirt)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().Ammo20 = true;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            string GermanOld = "Um 25% erhöhter Günstlings- & Fernkampfschaden";
            string GermanNew = "Um 25% erhöhter Günstling- & Fernkampfschaden un 20% Chance, keine Munition zu verbrauchen";
            string EnglishOld = "25% increased minion & ranged damage";
            string EnglishNew = "25% increased minion & ranged damage and 20% chance to not consume ammo";
            string SpanishOld = "Aumenta un 25% el daño de súbditos y de ataques a distancia";
            string SpanishNew = "Aumenta un 25% el daño de súbditos y de ataques a distancia y un 20% la probabilidad de no consumir munición";
            string FrenchOld = "+25 % de dégâts des sbires et à distance";
            string FrenchNew = "+25 % de dégâts des sbires et à distance et +20 % de chances de ne pas utiliser de munitions";
            string ItalianOld = "Danno dei seguaci e a distanza aumentato del 25%";
            string ItalianNew = "Danno dalla distanza e dei seguaci aumentato del 25%; 20% di probabilità di non consumare munizioni";
            string PolishOld = "25% zwiększone obrażenia sług i obrażenia dystansowe";
            string PolishNew = "25% zwiększone obrażenia sług oraz obrażenia dystansowe, a także 20% szans niezużycia amunicji";
            string PortugeseOld = "25% de aumento nos danos por lacaios e ataque à distância";
            string PortugeseNew = "25% de aumento no dano por ataque de lacaio e à distância e 20% de chance de não consumir munição";
            string RussianOld = "Увеличивает урон прислужников и дистанционный урон на 25 %";
            string RussianNew = "Увеличивает урон прислужников и дистанционный урон на на 25 %, а также дает шанс 20 % не потратить боеприпасы";
            string ChineseOld = "仆从和远程伤害增加25%";
            string ChineseNew = "仆从和远程伤害各增加25%，20%的几率不消耗弹药";
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
    [AutoloadEquip(EquipType.Legs)]
    public class RedRidingArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.HuntressAltPants)
            {
                player.rangedCrit += 10;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.HuntressAltPants)
            {
                string GermanOld = "Um 25% erhöhter Günstlingschaden und 20% erhöhte Bewegungsgeschwindigkeit";
                string GermanNew = "Um 25% erhöhter Günstlingsschaden und um 10% erhöhte kritische Fernkampf-Trefferchance\nUm 20% erhöhtes Bewegungstempo";
                string EnglishOld = "25% increased minion damage and 20% increased movement speed";
                string EnglishNew = "25% increased minion damage and 10% increased ranged critical strike chance\n20% increased movement speed";
                string SpanishOld = "Aumenta un 25% el daño de súbditos y un 20% la velocidad de movimiento";
                string SpanishNew = "Aumenta un 25% el daño de súbditos y un 10% la probabilidad de ataque crítico a distancia\nAumenta un 20% la velocidad de movimiento";
                string FrenchOld = "+25 % de dégâts des sbires et +20 % de vitesse de déplacement";
                string FrenchNew = "+25 % de dégâts des sbires et +10 % de chances de coup critique à distance\n+20 % de vitesse de déplacement";
                string ItalianOld = "Danno dei seguaci aumentato del 25% e velocità di movimento aumentata del 20%";
                string ItalianNew = "Danno dei seguaci aumentato del 25%, probabilità colpi critici dalla distanza aumentata del 10%, velocità di movimento aumentata del 20%";
                string PolishOld = "25% zwiększone obrażenia sług oraz 20% zwiększona szybkość poruszania się";
                string PolishNew = "25% zwiększone obrażenia sług oraz 10% większa szansa na dystansowe trafienie krytyczne\n20% zwiększona szybkość poruszania się";
                string PortugeseOld = "25% de aumento nos danos por lacaios e 20% de aumento na velocidade dos movimentos";
                string PortugeseNew = "25% de aumento no dano por lacaios e 10% de aumento na chance de ataque à distância crítico\n20% de aumento na velocidade dos movimentos";
                string RussianOld = "Увеличивает урон прислужников на 25 % и скорость движения на 20 %";
                string RussianNew = "Увеличивает урон прислужников на 25 % и шанс критического дистанционного урона на 10 %\nУвеличивает скорость движения на 20 %";
                string ChineseOld = "仆从伤害增加25%，移动速度提高20%";
                string ChineseNew = "仆从伤害增加25%，远程暴击率增加10%\n移动速度提高20%";
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