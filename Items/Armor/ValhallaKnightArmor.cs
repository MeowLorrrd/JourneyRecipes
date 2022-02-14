using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    public class ValhallaKnightArmorHead : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireAltHead)
                item.defense = 20;
        }
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireAltHead)
                player.meleeDamage += .1f;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireAltHead)
            {
                string GermanOld = "Erhöht die Höchstanzahl deiner Wächter und gibt dir 10% Günstlingsschaden";
                string GermanNew = "Erhöht deine maximale Anzahl an Wächtern um 2 und erhöht Günstling- und Nahkampfschaden um 10%";
                string EnglishOld = "Increases your max number of sentries and grants you 10% minion damage";
                string EnglishNew = "Increases your max number of sentries by 2 and increases minion and melee damage by 10%";
                string SpanishOld = "Aumenta el número máximo de centinelas y otorga un 20% de daño de súbditos";
                string SpanishNew = "Aumenta en 2 el máximo de centinelas que puedes tener y aumenta un 10% el daño de los súbditos y cuerpo a cuerpo";
                string FrenchOld = "Augmente votre nombre maximal de sentinelles et +10 % de dégâts des sbires";
                string FrenchNew = "Augmente votre nombre maximal de sentinelles de 2 et vous octroie +10 % de dégâts des sbires et au corps à corps";
                string ItalianOld = "Aumenta il numero massimo di sentinelle e ti dona 10% di danno dei seguaci";
                string ItalianNew = "Aumenta il numero massimo di sentinelle di 2 e aumenta il danno dei seguaci e in mischia del 10%";
                string PolishOld = "Zwiększa maksymalną liczbę wartowników, a także zwiększa o 10% obrażenia sług";
                string PolishNew = "Zwiększa maksymalną liczbę wartowników o 2, a także zwiększa obrażenia sług oraz obrażenia w walce w zwarciu o 10%";
                string PortugeseOld = "Aumenta o número máximo de sentinelas e concede 10% de danos por lacaios";
                string PortugeseNew = "Aumenta o número máximo de sentinelas em 2 e aumenta os danos causados por lacaios e por ataques físicos em 10%";
                string RussianOld = "Увеличивает ваше максимальное количество стражников и дает вам 10 % урона прислужников";
                string RussianNew = "Увеличивает ваше максимальное количество стражников на 2 и повышает урон питомцев в ближнем бою на 10 %";
                string ChineseOld = "提高哨兵数量上限，为你带来10%的仆从伤害";
                string ChineseNew = "哨兵数量上限提高2个，仆从和近战伤害各增加10%";
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
    public class ValhallaKnightArmorBody : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireAltShirt)
                item.defense = 24;
        }
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireAltShirt)
                player.lifeRegen = 8;
        }
    }
    public class ValhallaKnightArmorLegs : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireAltPants)
                item.defense = 24;
        }
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireAltPants)
            {
                player.moveSpeed -= .2f;
            }    
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireAltPants)
            {
                string GermanOld = "Um 20% erhöhter Günstlingsschaden, kritische Angriffschance und um 30% erhöhte Bewegungsgeschwindigkeit";
                string GermanNew = "Um 20% erhöhter Günstlingschaden, erhöhte kritische Nahkampf-Trefferchance und erhöhtes Bewegungstempo";
                string EnglishOld = "20% increased minion damage, critical strike chance and 30% movement speed";
                string EnglishNew = "20% increased minion damage and melee critical strike chance and movement speed";
                string SpanishOld = "Aumenta un 20% el daño de súbditos y la probabilidad de impacto crítico, así como un 30% la velocidad de movimiento";
                string SpanishNew = "Aumenta un 20% el daño de súbditos, la probabilidad de impacto crítico cuerpo a cuerpo y la velocidad de movimiento";
                string FrenchOld = "+20 % de dégâts des sbires, de chances de coup critique et +30 % de vitesse de déplacement";
                string FrenchNew = "+20 % de dégâts de sbires, de chances de coup critique au corps à corps et de vitesse de déplacement";
                string ItalianOld = "Danno dei seguaci aumentato del 20%, probabilità colpi critici e velocità di movimento aumentata del 30%";
                string ItalianNew = "Danno dei seguaci, probabilità colpi critici in mischia e velocità di movimento aumentati del 20%";
                string PolishOld = "20% zwiększone obrażenia sług i szansa na trafienie krytyczne, a także 30% zwiększona szybkość poruszania się";
                string PolishNew = "20% zwiększone obrażenia sług oraz szansa na trafienie krytyczne w walce w zwarciu, a także szybkość poruszania się";
                string PortugeseOld = "20% de aumento nos danos por lacaios, chance de acerto crítico e 30% de aumento na velocidade dos movimentos";
                string PortugeseNew = "20% de aumento nos danos por lacaios, na velocidade dos movimentos e na chance de acerto crítico";
                string RussianOld = "Увеличивает урон прислужников на 20 %, шанс критического удара и скорость движения на 30 %";
                string RussianNew = "Увеличивает урон прислужников, шанс критического урона в ближнем бою и скорость движения на 20 %";
                string ChineseOld = "仆从伤害、暴击率各增加20%，移动速度提高30%";
                string ChineseNew = "仆从伤害、近战暴击率和移动速度各增加20%";
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