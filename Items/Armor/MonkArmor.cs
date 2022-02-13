using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    #region Monk Armor Head
    [AutoloadEquip(EquipType.Head)]
    public class MonkArmorHead : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkBrows)//not sure if config is needed, as this is just a tooltip update ¯\_(ツ)_/¯
                //on the other hand, would be weird if no because pants also need config
            {
                string GermanOld = "Erhöht die Höchstanzahl deiner Wächter und erhöht die Angriffsgeschwindigkeit für Nahkampf um 20%";
                string GermanNew = "Erhöht deine maximale Anzahl an Wächtern auf 1 und erhöht Nahkampftempo um 20%";
                string EnglishOld = "Increases your max number of sentries and increases melee attack speed by 20%";
                string EnglishNew = "Increases your max number of sentries by 1 and increases melee attack speed by 20%";
                string SpanishOld = "Aumenta el número máximo de centinelas y aumenta un 20% la velocidad de los ataques cuerpo a cuerpo";
                string SpanishNew = "Aumenta en 1 el máximo de centinelas que puedes tener y aumenta un 20% la velocidad de los ataques cuerpo a cuerpo";
                string FrenchOld = "Augmente votre nombre maximal de sentinelles et +20 % de vitesse d'attaques au corps à corps";
                string FrenchNew = "Augmente votre nombre maximal de sentinelles de 1 et vous octroie +20 % de vitesse d'attaque au corps à corps";
                string ItalianOld = "Aumenta il numero massimo di sentinelle e la velocità di attacco in mischia del 20%";
                string ItalianNew = "Aumenta il numero massimo di sentinelle di 1 e la velocità di attacco in mischia del 20%";
                string PolishOld = "Zwiększa maksymalną liczbę wartowników, a także zwiększa o 20% szybkość ataku w zwarciu";
                string PolishNew = "Zwiększa maksymalną liczbę wartowników o 1 oraz zwiększa szybkość ataku w zwarciu o 20%";
                string PortugeseOld = "Aumenta o número máximo de sentinelas e aumenta a velocidade de ataque físico em 20%";
                string PortugeseNew = "Aumenta o número máximo de sentinelas em 1 e a velocidade de ataques físicos em 20%";
                string RussianOld = "Увеличивает ваше максимальное количество стражников и скорость ближнего боя на 20 %";
                string RussianNew = "Увеличивает ваше максимальное количество стражников на 1 и скорость ближнего боя на 20 %";
                string ChineseOld = "提高哨兵数量上限，近战攻击速度提高20%";
                string ChineseNew = "哨兵数量上限提高1个，近战攻击速度提高20%";
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
    #region Monk Armor Legs
    [AutoloadEquip(EquipType.Legs)]
    public class MonkArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkPants)
                player.meleeCrit += 5;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MonkPants)
            {
                string GermanOld = "Um 10% erhöhter Günstlingsschaden, um 10% erhöhte kritische Angriffschance und um 20% erhöhte Bewegungsgeschwindigkeit";
                string GermanNew = "Um 10% erhöhter Günstlingschaden,\num 15% erhöhte kritische Nahkampf-Trefferchance und um 20% erhöhtes Bewegungstempo";
                string EnglishOld = "10% increased critical strike chance and 20% increased movement speed";
                string EnglishNew = "15% increased melee critical strike chance and 20% increased movement speed";
                string SpanishOld = "Aumenta un 10% la probabilidad de impacto crítico y un 20% la velocidad de movimiento";
                string SpanishNew = "Aumenta un 15% la probabilidad de impacto crítico cuerpo a cuerpo y la velocidad de movimiento";
                string FrenchOld = "+10 % de chances de coup critique et +20 % de vitesse de déplacement";
                string FrenchNew = "+15 % de chances de coup critique au corps à corps et +20 % de vitesse de déplacement";
                string ItalianOld = "probabilità colpi critici aumentata del 10% e velocità di movimento aumentata del 20%";
                string ItalianNew = "probabilità colpi critici in mischia aumentata del 15% e velocità di movimento aumentata del 20%";
                string PolishOld = "10% większa szansa na trafienie krytyczne oraz 20% zwiększona szybkość poruszania się";
                string PolishNew = "15% zwiększona szansa na trafienie krytyczne w walce w zwarciu, a także 20% zwiększona szybkość poruszania się";
                string PortugeseOld = "10% de aumento na chance de acerto crítico e 20% de aumento na velocidade dos movimentos";
                string PortugeseNew = "Aumenta a chance de ataque físico crítico em 15% e a velocidade dos movimentos em 20%";
                string RussianOld = "Увеличивает шанс критического удара на 10 % и скорость движения на 20 %";
                string RussianNew = "Увеличивает шанс критического удара в ближнем бою на 15 % и скорость движения на 20 %";
                string ChineseOld = "暴击率增加10%，移动速度提高20%";
                string ChineseNew = "近战暴击率提高15%，移动速度提高20%";
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