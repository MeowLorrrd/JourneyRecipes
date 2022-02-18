using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class ForbiddenArmorHead : GlobalItem
    {
    }
    [AutoloadEquip(EquipType.Body)]
    public class ForbiddenArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.AncientBattleArmorShirt)
            {
                player.maxMinions += 1;
                player.statManaMax2 -= 40;
                player.minionDamage += .1f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.AncientBattleArmorShirt)
            {
                string GermanOld = "Erhöht das Höchstmana um 80";
                string GermanNew = "Erhöht maximales Mana um 40\nUm 10% erhöhter Günstlingschaden\nErhöht die maximale Anzahl deiner Günstlinge um 1";
                string EnglishOld = "Increases maximum mana by 80";
                string EnglishNew = "Increases maximum mana by 40\n10% increased minion damage\nIncreases your max number of minions by 1";
                string SpanishOld = "Aumenta el maná máximo en 80";
                string SpanishNew = "Aumenta en 40 el máximo de maná\nAumenta un 10% el daño de los súbditos\nAumenta en 1 el máximo de súbditos que puedes tener";
                string FrenchOld = "+80 points de mana max";
                string FrenchNew = "+40 points de mana max\n+10 % de dégâts de sbires\nAugmente votre nombre maximal de sbires de 1";
                string ItalianOld = "Aumenta il mana massimo di 80";
                string ItalianNew = "Aumenta il mana massimo di 40\nDanno dei seguaci aumentato del 10%\nAumenta il numero massimo dei tuoi seguaci di 1";
                string PolishOld = "Zwiększa maksymalną liczbę punktów many o 80";
                string PolishNew = "Zwiększa maksymalną liczbę punktów many o 40 punktów\n10% zwiększone obrażenia sług\nZwiększa maksymalną liczbę twoich sług o 1";
                string PortugeseOld = "Aumenta a mana máxima em 80";
                string PortugeseNew = "Aumenta o máximo de mana em 40\n10% de aumento no dano por lacaios\nAumenta o número máximo de lacaios que você pode ter em 1";
                string RussianOld = "Увеличивает максимум маны на 80";
                string RussianNew = "Увеличивает максимум манны на 40\nУвеличивает урон прислужников на 10 %\nУвеличивает ваше максимальное количество питомцев на 1";
                string ChineseOld = "最大魔力值增加80";
                string ChineseNew = "最大魔力值增加40\n仆从伤害增加10%\n仆从数量上限提高1个";
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
    public class ForbiddenArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.AncientBattleArmorPants)
            {
                player.maxMinions -= 1;
                player.statManaMax2 += 40;
                player.magicDamage += .1f;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.AncientBattleArmorPants)
            {
                string GermanOld = "Erhöht die maximale Anzahl deiner Günstlinge";
                string GermanNew = "Erhöht maximales Mana um 40\nUm 10% erhöhter Magieschaden\nErhöht die maximale Anzahl deiner Günstlinge um 1";
                string EnglishOld = "Increases your max number of minions";
                string EnglishNew = "Increases maximum mana by 40\n10% increased magic damage\nIncreases your max number of minions by 1";
                string SpanishOld = "Aumenta el máximo de súbditos que puedes tener";
                string SpanishNew = "Aumenta en 40 el máximo de maná\nAumenta un 10% el daño de los ataques mágicos\nAumenta en 1 el máximo de súbditos que puedes tener";
                string FrenchOld = "Augmente votre nombre maximal de sbires";
                string FrenchNew = "+40 points de mana max\n+10 % de dégâts magiques\nAugmente votre nombre maximal de sbires de 1";
                string ItalianOld = "Aumenta il numero massimo dei tuoi seguaci";
                string ItalianNew = "Aumenta il mana massimo di 40\nDanno magico aumentato del 10%\nAumenta il numero massimo dei tuoi seguaci di 1";
                string PolishOld = "Zwiększa maksymalną liczbę sług gracza";
                string PolishNew = "Zwiększa maksymalną liczbę punktów many 40 punktów\n10% zwiększone obrażenia magiczne\nZwiększa maksymalną liczbę twoich sług o 1";
                string PortugeseOld = "Aumenta o número máximo de lacaios que você pode ter";
                string PortugeseNew = "Aumenta o máximo de mana em 40\n10% de aumento no dano por magia\nAumenta o número máximo de lacaios que você pode ter em 1";
                string RussianOld = "Увеличивает ваше максимальное количество питомцев";
                string RussianNew = "Увеличивает максимум манны на 40\nУвеличивает магический урон на 10 %\nУвеличивает ваше максимальное количество питомцев на 1";
                string ChineseOld = "提高仆从数量上限";
                string ChineseNew = "最大魔力值增加40\n魔法伤害增加10%\n仆从数量上限提高1个";
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