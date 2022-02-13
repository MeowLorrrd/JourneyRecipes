using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class MeteoriteArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorHelmet)
                player.magicDamage += .02f;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorHelmet)
            {
                {
                    string GermanOld = "Um 7% erhöhter magischer Schaden";
                    string GermanNew = "Um 9% erhöhter Magieschaden";
                    string EnglishOld = "7% increased magic damage";
                    string EnglishNew = "9% increased magic damage";
                    string SpanishOld = "Aumenta el daño de los ataques mágicos en un 7%";
                    string SpanishNew = "Aumenta el daño de los ataques mágicos en un 9%";
                    string FrenchOld = "+7 % de dégâts magiques";
                    string FrenchNew = "+9 % de dégâts magiques";
                    string ItalianOld = "Danno magico aumentato del 7%";
                    string ItalianNew = "Danno magico aumentato del 9%";
                    string PolishOld = "7% zwiększone obrażenia magiczne";
                    string PolishNew = "9% zwiększone obrażenia magiczne";
                    string PortugeseOld = "7% de aumento nos danos por magia";
                    string PortugeseNew = "9% de aumento no dano por magia";
                    string RussianOld = "Увеличивает магический урон на 7 %";
                    string RussianNew = "Увеличивает магический урон на 9 %";
                    string ChineseOld = "魔法伤害增加7%";
                    string ChineseNew = "魔法伤害增加9%";
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
    [AutoloadEquip(EquipType.Body)]
    public class MeteoriteArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorSuit)
                player.magicDamage += .02f;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorSuit)
            {
                {
                    string GermanOld = "Um 7% erhöhter magischer Schaden";
                    string GermanNew = "Um 9% erhöhter Magieschaden";
                    string EnglishOld = "7% increased magic damage";
                    string EnglishNew = "9% increased magic damage";
                    string SpanishOld = "Aumenta el daño de los ataques mágicos en un 7%";
                    string SpanishNew = "Aumenta el daño de los ataques mágicos en un 9%";
                    string FrenchOld = "+7 % de dégâts magiques";
                    string FrenchNew = "+9 % de dégâts magiques";
                    string ItalianOld = "Danno magico aumentato del 7%";
                    string ItalianNew = "Danno magico aumentato del 9%";
                    string PolishOld = "7% zwiększone obrażenia magiczne";
                    string PolishNew = "9% zwiększone obrażenia magiczne";
                    string PortugeseOld = "7% de aumento nos danos por magia";
                    string PortugeseNew = "9% de aumento no dano por magia";
                    string RussianOld = "Увеличивает магический урон на 7 %";
                    string RussianNew = "Увеличивает магический урон на 9 %";
                    string ChineseOld = "魔法伤害增加7%";
                    string ChineseNew = "魔法伤害增加9%";
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
    [AutoloadEquip(EquipType.Legs)]
    public class MeteoriteArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorLeggings)
                player.magicDamage += .02f;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.MeteorLeggings)
            {
                {
                    string GermanOld = "Um 7% erhöhter magischer Schaden";
                    string GermanNew = "Um 9% erhöhter Magieschaden";
                    string EnglishOld = "7% increased magic damage";
                    string EnglishNew = "9% increased magic damage";
                    string SpanishOld = "Aumenta el daño de los ataques mágicos en un 7%";
                    string SpanishNew = "Aumenta el daño de los ataques mágicos en un 9%";
                    string FrenchOld = "+7 % de dégâts magiques";
                    string FrenchNew = "+9 % de dégâts magiques";
                    string ItalianOld = "Danno magico aumentato del 7%";
                    string ItalianNew = "Danno magico aumentato del 9%";
                    string PolishOld = "7% zwiększone obrażenia magiczne";
                    string PolishNew = "9% zwiększone obrażenia magiczne";
                    string PortugeseOld = "7% de aumento nos danos por magia";
                    string PortugeseNew = "9% de aumento no dano por magia";
                    string RussianOld = "Увеличивает магический урон на 7 %";
                    string RussianNew = "Увеличивает магический урон на 9 %";
                    string ChineseOld = "魔法伤害增加7%";
                    string ChineseNew = "魔法伤害增加9%";
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
}