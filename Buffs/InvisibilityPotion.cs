using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs
{
    public class InvisibilityPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.InvisibilityPotion)
            {
                //item.buffType = BuffID.Invisibility;
                //item.buffTime = 10800;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowBuffStat && item.type == ItemID.InvisibilityPotion)
            {
                string GermanOld = "Macht unsichtbar";
                string GermanNew = "Macht dich unsichtbar und verringert die Spawnquote von Feinden";
                string EnglishOld = "Grants invisibility";
                string EnglishNew = "Grants invisibility and lowers the spawn rate of enemies";
                string SpanishOld = "Proporciona invisibilidad";
                string SpanishNew = "Proporciona invisibilidad y reduce la tasa de regeneración de los enemigos";
                string FrenchOld = "Rend invisible";
                string FrenchNew = "Rend invisible et réduit le taux d'apparition des ennemis";
                string ItalianOld = "Rende invisibili";
                string ItalianNew = "Conferisce invisibilità e riduce il ritmo di generazione dei nemici";
                string PolishOld = "Daje niewidzialność";
                string PolishNew = "Daje niewidzialność i zmniejsza tempo rodzenia się przeciwników";
                string PortugeseOld = "Oferece invisibilidade";
                string PortugeseNew = "Oferece invisibilidade e diminui a taxa de criação de inimigos";
                string RussianOld = "Дает невидимость";
                string RussianNew = "Дает невидимость и замедляет скорость воскрешения врагов";
                string ChineseOld = "可隐身";
                string ChineseNew = "可隐身并降低敌人的生成速度";
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
    public class InvisibilityPotionBuff : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            if (Config.Instance.allowBuffStat && type == BuffID.Invisibility)
            {
                player.GetModPlayer<JourneyRecipesPlayer>().PlayerInvis = true;
            }
        }
    }
}