using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Accessories
{
    public class MagicQuiver : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.MagicQuiver)
            {
                string GermanOld = "";
                string GermanNew = "";
                string EnglishOld = "";
                string EnglishNew = "";
                string SpanishOld = "";
                string SpanishNew = "";
                string FrenchOld = "";
                string FrenchNew = "";
                string ItalianOld = "";
                string ItalianNew = "";
                string PolishOld = "";
                string PolishNew = "";
                string PortugeseOld = "";
                string PortugeseNew = "";
                string RussianOld = "";
                string RussianNew = "";
                string ChineseOld = "";
                string ChineseNew = "";
                #region new tooltip stuff
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
                #endregion d
            }
        }
    }
}
