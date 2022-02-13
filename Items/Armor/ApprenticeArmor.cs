using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    #region Apprentice Armor Head
    [AutoloadEquip(EquipType.Head)]
    public class ApprenticeArmor : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeHat)
                player.magicDamage += .1f;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ApprenticeHat)
            {
                string GermanOld = "Erhöht die Höchstanzahl deiner Wächter und verringert Manakosten um 10%";
                string GermanNew = "Erhöht deine maximale Anzahl an Wächtern auf 1, erhöht den Magieschaden und reduziert die Manakosten um 10%";
                string EnglishOld = "Increases your max number of sentries and reduces mana costs by 10%";
                string EnglishNew = "Increases your max number of sentries by 1, 10% increased magic damage and reduces mana costs by 10%";
                string SpanishOld = "Aumenta el número máximo de centinelas y se reduce un 10% el coste de maná";
                string SpanishNew = "Aumenta en 1 el máximo de centinelas que puedes tener, aumenta el daño por magia en un 10% y reduce en un 10% los costes de maná";
                string FrenchOld = "Augmente votre nombre max de sentinelles et -10 % de coûts de mana";
                string FrenchNew = "Augmente votre nombre maximal de sentinelles de 1, +10 % de dégâts magiques et -10 % d'usage de mana";
                string ItalianOld = "Aumenta il numero massimo di sentinelle e riduce il costo di mana del 10%";
                string ItalianNew = "Aumenta il numero massimo di sentinelle di 1; danno magico aumentato del 10% e costo di mana ridotto del 10%";
                string PolishOld = "Zwiększa twoją maksymalną liczbę wartowników i zmniejsza koszt many o 10%";
                string PolishNew = "Zwiększa maksymalną liczbę twoich wartowników o 1 oraz obrażenia magiczne o 10% , a także zmniejsza koszt many o 10%";
                string PortugeseOld = "Aumenta o número máximo de sentinelas e reduz em 10% o custo em mana";
                string PortugeseNew = "Aumenta o número máximo de sentinelas em 1 e o dano por magia em 10% e reduz o custo de mana em 10%";
                string RussianOld = "Увеличивает ваше максимальное количество стражников и снижает стоимость маны на 10 %";
                string RussianNew = "Увеличивает магический урон на 10 % и ваше максимальное количество стражников на 1, а также снижает стоимость манны на 10 %";
                string ChineseOld = "提高哨兵数量上限，魔力花费减少10%";
                string ChineseNew = "哨兵数量上限提高1个，魔法伤害增加10%，魔力花费减少10%";
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
    #region Apprentice Armor Legs
    [AutoloadEquip(EquipType.Legs)]
    public class ApprenticeArmorLegs : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.ApprenticeTrousers) //No config needed cus tooltip is actually an error
            {
                string GermanOld = "Um 10% erhöhter Günstlingschaden und 20% erhöhte Bewegungsgeschwindigkeit";
                string GermanNew = "Um 10% erhöhter Günstlingschaden, um 20% erhöhte kritische Magie-Trefferchance und erhöhtes Bewegungstempo";
                string EnglishOld = "10% increased minion damage and 20% increased movement speed";
                string EnglishNew = "10% increased minion damage, 20% increased magic critical strike chance and movement speed";
                string SpanishOld = "Aumenta un 10% el daño de súbditos y un 20% la velocidad de movimiento";
                string SpanishNew = "Aumenta un 10% el daño de súbditos, un 20% la probabilidad de impacto crítico mágico y la velocidad de movimiento";
                string FrenchOld = "+10 % de dégâts des sbires et +20 % de vitesse de déplacement";
                string FrenchNew = "+10 % de dégâts des sbires, +20 % de chances de coup critique magique et de vitesse de déplacement";
                string ItalianOld = "Danno dei seguaci aumentato del 10% e velocità di movimento aumentata del 20%";
                string ItalianNew = "Danno dei seguaci aumentato del 10%, probabilità colpi critici magici e velocità di movimento aumentate del 20%";
                string PolishOld = "10% zwiększone obrażenia sług oraz 20% zwiększona szybkość poruszania się";
                string PolishNew = "10% zwiększone obrażenia sług, 20% zwiększona szansa na magiczne trafienie krytyczne oraz szybkość poruszania się";
                string PortugeseOld = "10% de aumento nos danos por lacaios e 20% de aumento na velocidade dos movimentos";
                string PortugeseNew = "10% de aumento nos danos por lacaios, 20% de aumento na chance de acerto mágico crítico e na velocidade dos movimentos";
                string RussianOld = "Увеличивает урон прислужников на 10 % и скорость движения на 20 %";
                string RussianNew = "Увеличивает урон прислужников на 10 %, шанс магического критического удара и скорость движения на 20 %";
                string ChineseOld = "仆从伤害增加10%，移动速度提高20%";
                string ChineseNew = "仆从伤害增加10%，魔法暴击率和移动速度各提高20%";
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