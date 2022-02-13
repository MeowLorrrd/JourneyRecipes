using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Collections.Generic;
using Terraria.Localization;

namespace JourneyRecipes.Items.Accessories
{
    public class LavaWaders : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.LavaWaders)
                player.lavaRose = true;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.LavaWaders)
            {
                string GermanOld = "Macht immun gegen Feuerblöcke und 7 Sekunden lang gegen Lava";
                string GermanNew = "Macht immun gegen Feuer-Blöcke und verleiht 7 Sekunden Immunität gegen Lava\nReduziert den Schaden beim Berühren von Lava";
                string EnglishOld = "Grants immunity to fire blocks and 7 seconds of immunity to lava";
                string EnglishNew = "Grants immunity to fire blocks and 7 seconds of immunity to lava\nReduces damage from touching lava";
                string SpanishOld = "Otorga inmunidad a los bloques de fuego y 7 segundos de inmunidad a la lava";
                string SpanishNew = "Ofrece inmunidad ante los bloques de fuego y 7 segundos de inmunidad a la lava\nReduce el daño al tocar lava";
                string FrenchOld = "Immunisent contre les blocs de feu et immunisent pendant 7 secondes à la lave";
                string FrenchNew = "Immunisent contre les blocs de feu et pendant 7 secondes contre la lave\nRéduisent les dégâts au contact de la lave";
                string ItalianOld = "Rende immuni dai blocchi di fuoco e dona 7 secondi di immunità dalla lava";
                string ItalianNew = "Rende immuni dai blocchi di fuoco e dona 7 secondi di immunità dalla lava\nRiduce il danno ricevuto toccando la lava";
                string PolishOld = "Daje odporność na bloki ognia i 7-sekundową odporność na lawę";
                string PolishNew = "Zapewnia odporność na bloki ognia oraz 7 sekund odporności na lawę\nObniża obrażenia spowodowane dotknięciem lawy";
                string PortugeseOld = "Oferece imunidade a blocos de fogo e 7 segundos de imunidade a lava";
                string PortugeseNew = "Oferece imunidade a blocos de fogo e 7 segundos de imunidade a lava\nReduz dano sofrido ao entrar em contato com lava";
                string RussianOld = "Дает иммунитет к огненным блокам и 7 секунд иммунитета к лаве";
                string RussianNew = "Дает иммунитет к огненным блокам и 7 секунд иммунитета к лаве\nСнижает урон от прикосновения к лаве";
                string ChineseOld = "对火块免疫并在7秒内对熔岩免疫";
                string ChineseNew = "对火块免疫并在7秒内对熔岩免疫\n减少因触碰熔岩而受到的伤害";
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