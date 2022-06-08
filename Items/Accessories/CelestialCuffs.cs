using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Collections.Generic;
using Terraria.Localization;

namespace JourneyRecipes.Items.Accessories
{
    public class CelestialCuffs : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.CelestialCuffs)
                player.statManaMax2 += 20;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            /*if (Config.Instance.allowAccessoryStat && item.type == ItemID.CelestialCuffs)
            {
                string GermanOld = "Stellt bei Beschädigung Mana wieder her";
                string GermanNew = "Stellt bei erlittenem Schaden Mana wieder her\nErhöht maximales Mana um 20";
                string EnglishOld = "Restores mana when damaged";
                string EnglishNew = "Restores mana when damaged\nIncreases maximum mana by 20";
                string SpanishOld = "Recupera maná al sufrir daños";
                string SpanishNew = "Recupera maná al sufrir daños\nAumenta el maná máximo en 20";
                string FrenchOld = "Restaure du mana quand le joueur est blessé";
                string FrenchNew = "Restaure du mana quand le porteur subit des dégâts +20 points de mana max";
                string ItalianOld = "Ripristinano il mana quando vengono danneggiate";
                string ItalianNew = "Ripristina il mana quando si ricevono danni\nAumenta il mana massimo di 20";
                string PolishOld = "Przy otrzymaniu obrażeń odnawia manę";
                string PolishNew = "Po otrzymaniu obrażeń odnawia manę\nZwiększa maksymalną liczbę punktów many o 20";
                string PortugeseOld = "Restaura mana quando sofrer danos";
                string PortugeseNew = "Restaura mana quando sofrer dano\nAumenta a mana máxima em 20";
                string RussianOld = "При уроне восстанавливает ману";
                string RussianNew = "При уроне восстанавливает манну\nУвеличивает максимум маны на 20";
                string ChineseOld = "受伤时恢复魔力";
                string ChineseNew = "受到伤害后恢复魔力\n最大魔力值增加20";
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
            }*/
        }
    }
}