using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class ShroomiteArmorBody : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.ShroomiteBreastplate)
            {
                string GermanOld = "Um 13% erhöhte kritische Fernkampf-Trefferchance";
                string GermanNew = "Um 13% erhöhter Fernkampfschaden & erhöhte kritische Trefferchance";
                string EnglishOld = "13% increased ranged critical strike chance";
                string EnglishNew = "13% increased ranged damage & critical strike chance";
                string SpanishOld = "Aumenta un 13% la probabilidad de asestar ataques críticos a distancia";
                string SpanishNew = "Aumenta un 13% el daño a distancia y la probabilidad de impacto crítico";
                string FrenchOld = "+13 % de chances de coup critique à distance";
                string FrenchNew = "+13 % de dégâts à distance et de chances de coup critique";
                string ItalianOld = "Possibilità di colpo critico a distanza aumentata del 13%";
                string ItalianNew = "13% in più di probabilità di colpo critico e danni dalla distanza";
                string PolishOld = "13% większa szansa na dystansowe trafienie krytyczne";
                string PolishNew = "13% zwiększone obrażenia dystansowe oraz szansa na trafienie krytyczne";
                string PortugeseOld = "13% de aumento na chance de acerto crítico à distância";
                string PortugeseNew = "13% de aumento nos danos por ataque à distância e na chance de ataque crítico";
                string RussianOld = "Увеличивает шанс дистанционного критического удара на 13 %";
                string RussianNew = "Увеличивает на 13 % дистанционный урон и шанс критического урона";
                string ChineseOld = "远程暴击率增加13%";
                string ChineseNew = "远程伤害和暴击率各增加13%";
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