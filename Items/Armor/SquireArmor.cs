using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class SquireArmorHead : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireGreatHelm)
            {
                item.defense = 13;
                item.lifeRegen = 4;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireGreatHelm)
            {
                string GermanOld = "Erhöht die Höchstanzahl deiner Wächter und erhöht deine Lebensregeneration";
                string GermanNew = "Erhöht deine maximale Anzahl an Wächtern auf 1 und erhöht Lebensregeneration";
                string EnglishOld = "Increases your max number of sentries and increases your life regeneration";
                string EnglishNew = "Increases your max number of sentries by 1 and increases your life regeneration";
                string SpanishOld = "Aumenta el número máximo de centinelas y aumenta la regeneración de vida";
                string SpanishNew = "Aumenta en 1 el máximo de centinelas que puedes tener y aumenta la regeneración de vida";
                string FrenchOld = "Augmente votre nombre maximal de sentinelles et la régénération de santé";
                string FrenchNew = "Augmente votre nombre maximal de sbires de 1 et votre régénération de santé";
                string ItalianOld = "Aumenta il numero massimo di sentinelle e la tua rigenerazione vita";
                string ItalianNew = "Aumenta il numero massimo di sentinelle di 1 e la tua rigenerazione vita";
                string PolishOld = "Zwiększa maksymalną liczbę wartowników, a także zwiększa regenerację życia";
                string PolishNew = "Zwiększa maksymalną liczbę wartowników o 1 oraz twoją regenerację życia";
                string PortugeseOld = "Aumenta o número máximo de sentinelas e aumenta a regeneração de vida";
                string PortugeseNew = "Aumenta o número máximo de sentinelas em 1\nAumenta a regeneração de vida";
                string RussianOld = "Увеличивает ваше максимальное количество стражников и ускоряет восстановление здоровья";
                string RussianNew = "Увеличивает ваше максимальное количество стражников на 1 и ускоряет восстановление здоровья";
                string ChineseOld = "提高哨兵数量上限，提高生命再生速度";
                string ChineseNew = "哨兵数量上限提高1个，提高生命再生速度";
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
    public class SquireArmorLegs : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireGreaves)
                item.defense = 18;
        }
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireGreaves)
                player.meleeCrit -= 5;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SquireGreaves)
            {
                string GermanOld = "Um 15% erhöhter Günstlingsschaden, um 20% erhöhte kritische Nahkampfchance und Bewegungsgeschwindigkeit";
                string GermanNew = "Um 15% erhöhter Günstlingschaden, erhöhte kritische Nahkampf-Trefferchance und erhöhtes Bewegungstempo";
                string EnglishOld = "15% increased minion damage, 20% increased melee critical strike chance and movement speed";
                string EnglishNew = "15% increased minion damage, 15% increased melee critical strike chance and movement speed";
                string SpanishOld = "Aumenta un 15% el daño de súbditos, un 20% la probabilidad de impacto crítico cuerpo a cuerpo y la velocidad de movimiento";
                string SpanishNew = "Aumenta un 15% el daño de súbditos, un 15% la probabilidad de impacto crítico cuerpo a cuerpo y la velocidad de movimiento";
                string FrenchOld = "+15 % de dégâts des sbires, +20 % de chances de coup critique au corps à corps et de vitesse de déplacement";
                string FrenchNew = "+15 % de dégâts des sbires, +15 % de chances de coup critique au corps à corps et de vitesse de déplacement";
                string ItalianOld = "Danno dei seguaci aumentato del 15%, probabilità colpi critici in mischia e velocità di movimento aumentate del 20%";
                string ItalianNew = "Danno dei seguaci aumentato del 15%, probabilità colpi critici in mischia e velocità di movimento aumentate del 15%";
                string PolishOld = "15% zwiększone obrażenia sług, 20% zwiększona szansa na trafienie krytyczne w walce w zwarciu i szybkość poruszania się";
                string PolishNew = "15% zwiększone obrażenia sług, 15% zwiększona szansa na trafienie krytyczne w walce w zwarciu i szybkość poruszania się";
                string PortugeseOld = "15% de aumento nos danos por lacaios, 20% de aumento na chance de acerto físico crítico e na velocidade dos movimentos";
                string PortugeseNew = "15% de aumento no dano por lacaios, 15% de aumento na chance de ataque físico crítico e na velocidade dos movimentos";
                string RussianOld = "Увеличивает урон прислужников на 15 %, шанс критического удара в ближнем бою и скорость движения на 20 %";
                string RussianNew = "Увеличивает урон прислужников на 15 %, шанс критического удара в ближнем бою и скорость движения на 15 %";
                string ChineseOld = "仆从伤害增加15%，近战暴击率和移动速度各提高20%";
                string ChineseNew = "仆从伤害增加15%，近战暴击率和移动速度各提高15%";
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