using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    #region Shinobi Infiltrator Head
    [AutoloadEquip(EquipType.Head)]
    public class ShinobiArmorHead : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkAltHead)
            {
                string GermanOld = "Erhöht die Höchstanzahl deiner Wächter und erhöht Nahkampf- & Günstlingschaden um 20%";
                string GermanNew = "Erhöht deine maximale Anzahl an Wächtern auf 2 und erhöht Nahkampf- & Günstlingschaden um 20%";
                string EnglishOld = "Increases your max number of sentries and increases 20% melee & minion damage";
                string EnglishNew = "Increases your max number of sentries by 2 and increases 20% melee & minion damage";
                string SpanishOld = "Aumenta el número máximo de centinelas y aumenta un 20% el daño de súbditos y cuerpo a cuerpo";
                string SpanishNew = "Aumenta en 2 el máximo de centinelas que puedes tener y aumenta un 20% el daño de los súbditos y cuerpo a cuerpo";
                string FrenchOld = "Augmente votre nombre maximal de sentinelles et +20 % de dégâts au corps à corps et des sbires";
                string FrenchNew = "Augmente votre nombre maximal de sentinelles de 2 et vous octroie +20 % de dégâts au corps à corps et de sbires";
                string ItalianOld = "Aumenta il numero massimo di sentinelle e i danni da mischia e dei seguaci del 20%";
                string ItalianNew = "Aumenta il numero massimo di sentinelle di 2 e i danni da mischia e dei seguaci del 20%";
                string PolishOld = "Zwiększa maksymalną liczbę wartowników, a także zwiększa o 20% obrażenia sług i obrażenia w walce w zwarciu";
                string PolishNew = "Zwiększa maksymalną liczbę wartowników o 2, a także zwiększa obrażenia sług oraz obrażenia w walce w zwarciu o 20%";
                string PortugeseOld = "Aumenta o número máximo de sentinelas e aumenta em 20% os danos físicos e dos lacaios";
                string PortugeseNew = "Aumenta o número máximo de sentinelas em 2\nAumenta em 20% os danos por ataques físicos e dos lacaios";
                string RussianOld = "Увеличивает ваше максимальное количество стражников, а также повышает урон в ближнем бою и урон прислужников на 20 %";
                string RussianNew = "Увеличивает ваше максимальное количество стражников на 2, а также повышает урон в ближнем бою и урон прислужников на 20 %";
                string ChineseOld = "提高哨兵数量上限，近战和仆从伤害增加20%";
                string ChineseNew = "哨兵数量上限提高2个，近战和仆从伤害各增加20%";
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
    #endregion
    #region Shinobi Infiltrator Body
    [AutoloadEquip(EquipType.Body)]
    public class ShinobiArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkAltShirt)
            {
                player.meleeCrit += 5;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkAltShirt)
            {
                string GermanOld = "Um 20% erhöhter Günstlingschaden und Nahkampfgeschwindigkeit";
                string GermanNew = "Um 20% erhöhter Günstlingschaden und erhöhtes Nahkampftempo\nUm 5% erhöhte kritische Nahkampf-Trefferchance";
                string EnglishOld = "20% increased minion damage and melee speed";
                string EnglishNew = "20% increased minion damage and melee speed\n5% increased melee critical strike chance";
                string SpanishOld = "Aumenta un 20% el daño de súbditos y la velocidad del cuerpo a cuerpo";
                string SpanishNew = "Aumenta un 20% el daño de súbditos y la velocidad del cuerpo a cuerpo\nAumenta un 5% la probabilidad de ataque crítico en el cuerpo a cuerpo";
                string FrenchOld = "+20 % de dégâts des sbires et de vitesse au corps à corps";
                string FrenchNew = "+20 % de dégâts des sbires et de vitesse au corps à corps +5 % de chances de coup critique au corps à corps";
                string ItalianOld = "Danni dei seguaci e velocità in mischia aumentati del 20%";
                string ItalianNew = "Danno dei seguaci e velocità in mischia aumentati del 20%\nprobabilità colpo critico in mischia aumentata del 5%";
                string PolishOld = "20% zwiększone obrażenia sług oraz szybkość ataku w zwarciu";
                string PolishNew = "20% zwiększone obrażenia sług oraz szybkość ataku w zwarciu\n5% większa szansa na trafienie krytyczne w walce w zwarciu";
                string PortugeseOld = "20% de aumento nos danos por lacaios e na velocidade dos ataques físicos";
                string PortugeseNew = "20% de aumento no dano por lacaios e na velocidade de ataque físico\n5% de aumento na chance de ataque físico crítico";
                string RussianOld = "Увеличивает урон прислужников и скорость ближнего боя на 20 %";
                string RussianNew = "Увеличивает урон прислужников и скорость ближнего боя на 20 %\nУвеличивает шанс критического урона в ближнем бою на 5 %";
                string ChineseOld = "仆从伤害和近战速度各增加20%";
                string ChineseNew = "仆从伤害和近战速度各增加20%\n近战暴击率增加5%";
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
    #endregion
    #region Shinobi Infiltrator Legs
    [AutoloadEquip(EquipType.Legs)]
    public class ShinobiArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkAltPants)
            {
                player.moveSpeed += 0.1f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkAltPants)
            {
                string GermanOld = "Um 20% erhöhter Günstlingschaden, Bewegungsgeschwindigkeit und kritische Nahkampfchance";
                string GermanNew = "Um 20% erhöhter Günstlingschaden und erhöhte kritische Nahkampf-Trefferchance\nUm 30% erhöhtes Bewegungstempo";
                string EnglishOld = "20% increased minion damage, movement speed and melee critical strike chance";
                string EnglishNew = "20% increased minion damage and melee critical strike chance\n30% increased movement speed";
                string SpanishOld = "Aumenta un 20% el daño de súbditos, la velocidad de movimiento y la probabilidad de impacto crítico a distancia";
                string SpanishNew = "Aumenta un 20% el daño de súbditos y la probabilidad de impacto crítico cuerpo a cuerpo\nAumenta un 30% la velocidad de movimiento";
                string FrenchOld = "+20 % de dégâts des sbires, de vitesse de déplacement et chances de coup critique au corps à corps";
                string FrenchNew = "+20 % de dégâts des sbires et chances de coup critique au corps à corps\n+30 % de vitesse de déplacement";
                string ItalianOld = "Danno dei seguaci, velocità di movimento e probabilità colpo critico in mischia aumentati del 20%";
                string ItalianNew = "Danno dei seguaci e probabilità colpi critici in mischia aumentati del 20%\nVelocità di movimento aumentata del 30%";
                string PolishOld = "20% zwiększone obrażenia sług, szybkość poruszania się i szansa na trafienie krytyczne w walce w zwarciu";
                string PolishNew = "20% zwiększone obrażenia sług oraz szansa na trafienie krytyczne w walce w zwarciu\n30% zwiększona szybkość poruszania się";
                string PortugeseOld = "20% de aumento nos danos por lacaios, na velocidade dos movimentos e na chance de acerto crítico";
                string PortugeseNew = "20% de aumento no dano por lacaios e na chance de ataque físico crítico\n30% de aumento na velocidade dos movimentos";
                string RussianOld = "Увеличивает урон прислужников, скорость движения и шанс критического урона в ближнем бою на 20 %";
                string RussianNew = "Увеличивает урон прислужников и шанс критического урона в ближнем бою на 20 %\nУвеличивает скорость движения на 30 %";
                string ChineseOld = "仆从伤害、移动速度和近战暴击率各增加20%";
                string ChineseNew = "仆从伤害和近战暴击率各增加20%\n移动速度提高30%";
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
    #endregion
}