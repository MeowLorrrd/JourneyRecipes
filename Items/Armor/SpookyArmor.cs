using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Armor
{
    #region Spooky Head
    [AutoloadEquip(EquipType.Head)]
    public class SpookyArmorHead : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyHelmet)
                item.defense = 9;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyHelmet)
            {
                string GermanOld = "Erhöht die maximale Anzahl deiner Günstlinge";
                string GermanNew = "Erhöht die maximale Anzahl deiner Günstlinge um 1";
                string EnglishOld = "Increases your max number of minions";
                string EnglishNew = "Increases your max number of minions by 1";
                string SpanishOld = "Aumenta el máximo de súbditos que puedes tener";
                string SpanishNew = "Aumenta en 1 el máximo de súbditos que puedes tener";
                string FrenchOld = "Augmente votre nombre maximal de sbires";
                string FrenchNew = "Augmente votre nombre maximal de sbires de 1";
                string ItalianOld = "Aumenta il numero massimo dei tuoi seguaci";
                string ItalianNew = "Aumenta il numero massimo dei tuoi seguaci di 1";
                string PolishOld = "Zwiększa maksymalną liczbę sług gracza";
                string PolishNew = "Zwiększa maksymalną liczbę twoich sług o 1";
                string PortugeseOld = "Aumenta o número máximo de lacaios que você pode ter";
                string PortugeseNew = "Aumenta o número máximo de lacaios que você pode ter em 1";
                string RussianOld = "Увеличивает ваше максимальное количество питомцев";
                string RussianNew = "Увеличивает ваше максимальное количество питомцев на 1";
                string ChineseOld = "提高仆从数量上限";
                string ChineseNew = "仆从数量上限提高1个";
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
    #region Spooky Body
    [AutoloadEquip(EquipType.Body)]
    public class SpookyArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyBreastplate)
            {
                player.maxMinions += 1;
            }
        }
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyBreastplate)
                item.defense = 11;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyBreastplate)
            {
                string GermanOld = "Erhöht die maximale Anzahl deiner Günstlinge";
                string GermanNew = "Erhöht die maximale Anzahl deiner Günstlinge um 2";
                string EnglishOld = "Increases your max number of minions";
                string EnglishNew = "Increases your max number of minions by 2";
                string SpanishOld = "Aumenta el máximo de súbditos que puedes tener";
                string SpanishNew = "Aumenta en 2 el máximo de súbditos que puedes tener";
                string FrenchOld = "Augmente votre nombre maximal de sbires";
                string FrenchNew = "Augmente votre nombre maximal de sbires de 2";
                string ItalianOld = "Aumenta il numero massimo dei tuoi seguaci";
                string ItalianNew = "Aumenta il numero massimo dei tuoi seguaci di 2";
                string PolishOld = "Zwiększa maksymalną liczbę sług gracza";
                string PolishNew = "Zwiększa maksymalną liczbę twoich sług o 2";
                string PortugeseOld = "Aumenta o número máximo de lacaios que você pode ter";
                string PortugeseNew = "Aumenta o número máximo de lacaios que você pode ter em 2";
                string RussianOld = "Увеличивает ваше максимальное количество питомцев";
                string RussianNew = "Увеличивает ваше максимальное количество питомцев на 2";
                string ChineseOld = "提高仆从数量上限";
                string ChineseNew = "仆从数量上限提高2个";
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
    #region Spooky Feet
    [AutoloadEquip(EquipType.Legs)]
    public class SpookyArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyLeggings)
            {
                player.moveSpeed += .2f;
            }
        }
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyLeggings)
                item.defense = 10;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SpookyLeggings)
            {
                //Add +1 minion tip at Old1/New1
                //replace +11% minion damage with +11% minion damage AND\n movement speed at Old2
                string GermanOld1 = "Erhöht die maximale Anzahl deiner Günstlinge";
                string GermanOld2 = "Erhöht Günstlingschaden um 11%";
                string GermanNew1 = "Erhöht die maximale Anzahl deiner Günstlinge um 1";
                string GermanNew2 = "Erhöht Günstlingschaden um 11%\nBewegungstempo ist um 20% erhöht";//
                string EnglishOld1 = "Increases your max number of minions";
                string EnglishOld2 = "Increases minion damage by 11%";
                string EnglishNew1 = "Increases your max number of minions by 1";
                string EnglishNew2 = "Increases minion damage by 11%\n20% increased movement speed";//
                string SpanishOld1 = "Aumenta el máximo de súbditos que puedes tener";
                string SpanishOld2 = "Aumenta un 11% el daño de los súbditos";
                string SpanishNew1 = "Aumenta en 1 el máximo de súbditos que puedes tener";
                string SpanishNew2 = "Aumenta un 11% el daño de los súbditos\nAumenta un 20% la velocidad de movimiento";//
                string FrenchOld1 = "Augmente votre nombre maximal de sbires";
                string FrenchOld2 = "+11 % de dégâts de sbires";
                string FrenchNew1 = "Augmente votre nombre maximal de sbires de 1";
                string FrenchNew2 = "+11 % de dégâts de sbires\n+20 % de vitesse de déplacement";//
                string ItalianOld1 = "Aumenta il numero massimo dei tuoi seguaci";
                string ItalianOld2 = "Aumenta il danno dei seguaci dell'11%";
                string ItalianNew1 = "Aumenta il numero massimo dei tuoi seguaci di 1";
                string ItalianNew2 = "Aumenta il danno dei seguaci dell'11%\nVelocità di movimento aumentata del 20%";//
                string PolishOld1 = "Zwiększa maksymalną liczbę sług gracza";
                string PolishOld2 = "Zwiększa obrażenia sług o 11%";
                string PolishNew1 = "Zwiększa maksymalną liczbę twoich sług o 1";
                string PolishNew2 = "Zwiększa obrażenia sług o 11%\n20% zwiększona szybkość poruszania się";//
                string PortugeseOld1 = "Aumenta o número máximo de lacaios que você pode ter";
                string PortugeseOld2 = "Aumenta os danos causados por lacaios em 11%";
                string PortugeseNew1 = "Aumenta o número máximo de lacaios que você pode ter em 1";
                string PortugeseNew2 = "Aumenta os danos causados por lacaios em 11%\n20% de aumento na velocidade dos movimentos";//
                string RussianOld1 = "Увеличивает ваше максимальное количество питомцев";
                string RussianOld2 = "Увеличивает урон питомца на 11 %";
                string RussianNew1 = "Увеличивает ваше максимальное количество питомцев на 1";
                string RussianNew2 = "Увеличивает урон питомцев на 11 %\nУвеличивает скорость движения на 20 %";//
                string ChineseOld1 = "提高仆从数量上限";
                string ChineseOld2 = "仆从伤害增加11%";
                string ChineseNew1 = "仆从数量上限提高1个";
                string ChineseNew2 = "仆从伤害增加11%\n移动速度提高20%";//
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
}