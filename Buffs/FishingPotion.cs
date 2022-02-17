using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace JourneyRecipes.Buffs
{
    public class FishingPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.FishingPotion)
            {
                item.buffType = BuffID.Fishing;
                item.buffTime = 28800;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.FishingPotion)
            {
                string GermanOld = "Verbessert Angelfähigkeit";
                string GermanNew = "Erhöht Angelkraft";
                string EnglishOld = "Increases fishing skill";
                string EnglishNew = "Increases fishing power";
                string SpanishOld = "Aumenta la habilidad de pesca";
                string SpanishNew = "Aumenta la capacidad de pesca";
                string FrenchOld = "Améliore les compétences de pêche";
                string FrenchNew = "Augmente la puissance de pêche";
                string ItalianOld = "Migliora le capacità di pesca";
                string ItalianNew = "Migliora la potenza pesca";
                string PolishOld = "Zwiększa umiejętności wędkarskie";
                string PolishNew = "Zwiększa moc wędkarstwa";
                string PortugeseOld = "Aumenta as habilidades de pescaria";
                string PortugeseNew = "Aumenta o poder de pescaria";
                string RussianOld = "Увеличивает навык рыбной ловли";
                string RussianNew = "Увеличивает рыболовную силу";
                string ChineseOld = "提高钓鱼技能";
                string ChineseNew = "提高渔力";
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
    public class FishingPotionBuff : GlobalBuff
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            if (type == BuffID.Fishing)//No config needed because no buff duration change, just tooltip
            {
                if (GameCulture.German.IsActive)
                    tip = "Erhöhte Angelkraft";
                if (GameCulture.English.IsActive)
                    tip = "Increased fishing power";
                if (GameCulture.Spanish.IsActive)
                    tip = "Aumenta la capacidad de pesca";
                if (GameCulture.French.IsActive)
                    tip = "Augmente la puissance de pêche";
                if (GameCulture.Italian.IsActive)
                    tip = "Potenza pesca aumentata";
                if (GameCulture.Polish.IsActive)
                    tip = "Zwiększanie mocy wędkarstwa";
                if (GameCulture.Portuguese.IsActive)
                    tip = "Maior poder de pescaria";
                if (GameCulture.Russian.IsActive)
                    tip = "Рыболовная сила увеличена";
                if (GameCulture.Chinese.IsActive)
                    tip = "渔力提高";
            }
        }
    }
}