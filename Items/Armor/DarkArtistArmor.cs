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
                string GermanOld1 = "Erhöht die Höchstanzahl deiner Wächter";
                string GermanOld2 = "Um 10% erhöhter Günstling- & Magieschaden";
                string GermanNew1 = "Erhöht deine maximale Anzahl an Wächtern auf 2";
                string GermanNew2 = "Um 15% erhöhter Günstling- und Magieschaden";//
                string EnglishOld1 = "Increases your max number of sentries";
                string EnglishOld2 = "10% increased minion & magic damage";
                string EnglishNew1 = "Increases your max number of sentries by 2";
                string EnglishNew2 = "15% increased minion & magic damage";//
                string SpanishOld1 = "Aumenta el número máximo de centinelas";
                string SpanishOld2 = "Aumenta un 10% el daño mágico y de súbditos";
                string SpanishNew1 = "Aumenta en 2 el máximo de centinelas que puedes tener";
                string SpanishNew2 = "Aumenta un 15% el daño de los súbditos y de la magia";//
                string FrenchOld1 = "Augmente votre nombre maximal de sentinelles";
                string FrenchOld2 = "+10 % de dégâts des sbires et magiques";
                string FrenchNew1 = "Augmente votre nombre maximal de sentinelles de 2";
                string FrenchNew2 = "+15 % de dégâts des sbires et magiques";//
                string ItalianOld1 = "Aumenta il numero massimo di sentinelle";
                string ItalianOld2 = "Danno dei seguaci e magico aumentato del 10%";
                string ItalianNew1 = "Aumenta il numero massimo di sentinelle di 2";
                string ItalianNew2 = "Danno dei seguaci e magico aumentato del 15%";//
                string PolishOld1 = "Zwiększa maksymalną liczbę wartowników";
                string PolishOld2 = "10% zwiększone obrażenia sług i obrażenia magiczne";
                string PolishNew1 = "Zwiększa maksymalną liczbę wartowników o 2";
                string PolishNew2 = "15% zwiększone obrażenia sług oraz obrażenia magiczne";//
                string PortugeseOld1 = "Aumenta o número máximo de sentinelas";
                string PortugeseOld2 = "10% de aumento nos danos por lacaios e magia";
                string PortugeseNew1 = "Aumenta o número máximo de sentinelas em 2";
                string PortugeseNew2 = "15% de aumento no dano por lacaios e no dano por magia";//
                string RussianOld1 = "Увеличивает ваше максимальное количество стражников";
                string RussianOld2 = "Увеличивает урон прислужников и магический урон на 10 %";
                string RussianNew1 = "Увеличивает ваше максимальное количество стражников на 2";
                string RussianNew2 = "Увеличивает урон прислужников и магический урон на 15 %";//
                string ChineseOld1 = "提高哨兵数量上限";
                string ChineseOld2 = "仆从和魔法伤害各增加10%";
                string ChineseNew1 = "哨兵数量上限提高2个";
                string ChineseNew2 = "仆从和魔法伤害各增加15%";//
                #region new tooltips
                foreach (TooltipLine line in tooltips)
                {
                    if (line.text == GermanOld1)
                    {
                        line.text = GermanNew1;
                    }
                    if (line.text == GermanOld2)
                    {
                        line.text = GermanNew2;
                    }
                    if (line.text == EnglishOld1)
                    {
                        line.text = EnglishNew1;
                    }
                    if (line.text == EnglishOld2)
                    {
                        line.text = EnglishNew2;
                    }
                    if (line.text == SpanishOld1)
                    {
                        line.text = SpanishNew1;
                    }
                    if (line.text == SpanishOld2)
                    {
                        line.text = SpanishNew2;
                    }
                    if (line.text == FrenchOld1)
                    {
                        line.text = FrenchNew1;
                    }
                    if (line.text == FrenchOld2)
                    {
                        line.text = FrenchNew2;
                    }
                    if (line.text == ItalianOld1)
                    {
                        line.text = ItalianNew1;
                    }
                    if (line.text == ItalianOld2)
                    {
                        line.text = ItalianNew2;
                    }
                    if (line.text == PolishOld1)
                    {
                        line.text = PolishNew1;
                    }
                    if (line.text == PolishOld2)
                    {
                        line.text = PolishNew2;
                    }
                    if (line.text == PortugeseOld1)
                    {
                        line.text = PortugeseNew1;
                    }
                    if (line.text == PortugeseOld2)
                    {
                        line.text = PortugeseNew2;
                    }
                    if (line.text == RussianOld1)
                    {
                        line.text = RussianNew1;
                    }
                    if (line.text == RussianOld2)
                    {
                        line.text = RussianNew2;
                    }
                    if (line.text == ChineseOld1)
                    {
                        line.text = ChineseNew1;
                    }
                    if (line.text == ChineseOld2)
                    {
                        line.text = ChineseNew2;
                    }
                }
                #endregion
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
                string GermanOld = "Um 30% erhöhter Günstlingschaden und 15% erhöhter Magieschaden";
                string GermanNew = "Um 25% erhöhter Günstlingschaden und um 10% erhöhter Magieschaden\nReduziert die Manakosten um 15%";
                string EnglishOld = "30% increased minion damage and 15% increased magic damage";
                string EnglishNew = "25% increased minion damage and 10% increased magic damage\nReduces mana costs by 15%";
                string SpanishOld = "Aumenta un 30% el daño de súbditos y un 15% el daño mágico";
                string SpanishNew = "Aumenta un 25% el daño de súbditos y un 10% el daño mágico\nReduce en un 15% los costes de maná";
                string FrenchOld = "+30 % de dégâts des sbires et +15 % de chances de coup critique magique";
                string FrenchNew = "+25 % de dégâts des sbires et +10 % de dégâts magiques\n-15 % d'usage de mana";
                string ItalianOld = "Danno dei seguaci aumentato del 30% e danno magico aumentato del 15%";
                string ItalianNew = "Danno dei seguaci aumentato del 25% e danno magico aumentato del 10%\nRiduce il costo di mana del 15%";
                string PolishOld = "30% zwiększone obrażenia sług oraz 15% zwiększone obrażenia magiczne";
                string PolishNew = "25% zwiększone obrażenia sług oraz 10% zwiększone obrażenia magiczne\nZmniejsza koszt many o 15%";
                string PortugeseOld = "30% de aumento nos danos por lacaios e 15% de aumento nos danos mágicos";
                string PortugeseNew = "25% de aumento no dano por lacaios e 10% de aumento no dano por magia\nReduz o custo de mana em 15%";
                string RussianOld = "Увеличивает урон прислужников на 30 % и магический урон на 15 %";
                string RussianNew = "Увеличивает урон прислужников на 25 % и магический урон на 10 %\nУменьшает стоимость маны на 15 %";
                string ChineseOld = "仆从伤害增加30%，魔法伤害增加15%";
                string ChineseNew = "仆从伤害增加25%，魔法伤害增加10%\n魔力花费减少15%";
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
    #region Dark Artist Legs
    [AutoloadEquip(EquipType.Legs)]
    public class DarkArtistArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeAltPants)
                player.moveSpeed += .2f;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeAltPants)
            {
                string GermanOld = "Um 20% erhöhter Günstlingschaden und 25% Chance auf kritischen Magietreffer";
                string GermanNew = "Um 20% erhöhter Günstlingsschaden und um 25% erhöhte kritische Magie-Trefferchance\nUm 20% erhöhtes Bewegungstempo";
                string EnglishOld = "20% increased minion damage and 25% increased magic critical strike chance";
                string EnglishNew = "20% increased minion damage and 25% increased magic critical strike chance\n20% increased movement speed";
                string SpanishOld = "Aumenta un 20% el daño de súbditos y un 25% la probabilidad de ataque mágico crítico";
                string SpanishNew = "Aumenta un 20% el daño de súbditos y un 25% la probabilidad de ataque mágico crítico\nAumenta un 20% la velocidad de movimiento";
                string FrenchOld = "+20 % de dégâts des sbires et +25 % de chances de coup critique magique";
                string FrenchNew = "+20 % de dégâts des sbires et +25 % de chances de coup critique magique\n+20 % de vitesse de déplacement";
                string ItalianOld = "Danno dei seguaci aumentato del 20% e probabilità di colpo critico magico aumentata del 25%";
                string ItalianNew = "Danno dei seguaci aumentato del 20%, probabilità colpi critici magici aumentata del 25%, velocità di movimento aumentata del 20%";
                string PolishOld = "20% zwiększone obrażenia sług oraz 25% zwiększona szansa na magiczne trafienie krytyczne";
                string PolishNew = "20% zwiększone obrażenia sług oraz 25% zwiększona szansa na magiczne trafienie krytyczne\n20% zwiększona szybkość poruszania się";
                string PortugeseOld = "20% de aumento nos danos por lacaios e 25% de aumento nas chances de ataque mágico crítico";
                string PortugeseNew = "20% de aumento no dano por lacaios e 25% de aumento na chance de ataque mágico crítico\n20% de aumento na velocidade dos movimentos";
                string RussianOld = "Увеличивает урон прислужников на 20 % и шанс критического магического удара на 25 %";
                string RussianNew = "Увеличивает урон прислужников на 20 % и шанс критического магического удара на 25 %\nУвеличивает скорость движения на 20 %";
                string ChineseOld = "仆从伤害增加20%，魔法暴击率增加25%";
                string ChineseNew = "仆从伤害增加20%，魔法暴击率增加25%\n移动速度提高20%";
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