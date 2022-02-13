using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
using Terraria.Localization;

namespace JourneyRecipes.Items.Armor
{
    #region Fossil Armor Head
    [AutoloadEquip(EquipType.Head)]
    public class FossilArmor : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilHelm)
            {
                player.rangedCrit += 4;
                player.thrownVelocity -= .2f;
            }
        }
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilHelm)
                item.defense = 4;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilHelm)
            {
                string GermanOld = "Wurfgeschwindigkeit erhöht um 20%";
                string GermanNew = "Um 4% erhöhte kritische Fernkampf-Trefferchance";
                string EnglishOld = "20% increased throwing velocity";
                string EnglishNew = "4% increased ranged critical strike chance";
                string SpanishOld = "Aumenta un 20% la velocidad de lanzamiento";
                string SpanishNew = "Aumenta un 4% la probabilidad de ataque crítico a distancia";
                string FrenchOld = "+20 % de rapidité de lancer";
                string FrenchNew = "+4 % de chances de coup critique à distance";
                string ItalianOld = "Velocità di lancio aumentata del 20%";
                string ItalianNew = "Probabilità di colpo critico a distanza aumentata del 4%";
                string PolishOld = "20% zwiększona prędkość rzutu";
                string PolishNew = "4% większa szansa na dystansowe trafienie krytyczne";
                string PortugeseOld = "20% de aumento na velocidade do arremesso";
                string PortugeseNew = "4% de aumento na chance de ataque à distância crítico";
                string RussianOld = "Увеличивает скорость бросания на 20 %";
                string RussianNew = "Увеличивает шанс критического дистанционного урона на 4 %";
                string ChineseOld = "投掷射速提高20%";
                string ChineseNew = "远程暴击率增加4%";
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
    #region Fossil Armor Body
    [AutoloadEquip(EquipType.Body)]
    public class FossilBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilShirt)
            {
                player.rangedDamage += .05f;
                player.thrownDamage -= .2f;
            }
        }
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilShirt)
                item.defense = 5;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilShirt)
            {
                string GermanOld = "Wurfschaden erhöht um 20%";
                string GermanNew = "Um 5% erhöhter Fernkampfschaden";
                string EnglishOld = "20% increased throwing damage";
                string EnglishNew = "5% increased ranged damage";
                string SpanishOld = "Aumenta un 20% el daño de lanzamiento";
                string SpanishNew = "Aumenta un 5% el daño de los ataques a distancia";
                string FrenchOld = "+20 % de dégâts de lancer";
                string FrenchNew = "+5 % de dégâts à distance";
                string ItalianOld = "Danni da lancio aumentati del 20%";
                string ItalianNew = "Danno boomerang aumentato del 5%";
                string PolishOld = "20% zwiększone obrażenia rzutu";
                string PolishNew = "5% zwiększone obrażenia dystansowe";
                string PortugeseOld = "20% de aumento nos danos por arremessos";
                string PortugeseNew = "5% de aumento nos danos por ataque à distância";
                string RussianOld = "Увеличивает урон от бросания на 20 %";
                string RussianNew = "Увеличивает дистанционный урон на 5 %";
                string ChineseOld = "投掷伤害增加20%";
                string ChineseNew = "远程伤害增加5%";
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
    #region Fossil Armor Legs
    [AutoloadEquip(EquipType.Legs)]
    public class FossilLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilPants)
            {
                player.rangedCrit += 4;
                player.thrownCrit -= 15;
            }
        }
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilPants)
                item.defense = 4;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.FossilPants)
            {
                string GermanOld = "Kritische Trefferchance beim Werfen um 15% erhöht";
                string GermanNew = "Um 4% erhöhte kritische Fernkampf-Trefferchance";
                string EnglishOld = "15% increased throwing critical strike chance";
                string EnglishNew = "4% increased ranged critical strike chance";
                string SpanishOld = "Aumenta un 15% la probabilidad de impacto crítico al lanzar";
                string SpanishNew = "Aumenta un 4% la probabilidad de ataque crítico a distancia";
                string FrenchOld = "+15 % de chances de coup critique au lancer";
                string FrenchNew = "+4 % de chances de coup critique à distance";
                string ItalianOld = "Possibilità colpo critico da lancio aumentata del 15%";
                string ItalianNew = "Probabilità di colpo critico a distanza aumentata del 4%";
                string PolishOld = "15% większa szansa na trafienie krytyczne rzutu";
                string PolishNew = "4% większa szansa na dystansowe trafienie krytyczne";
                string PortugeseOld = "15% de aumento na chance de acerto crítico no arremesso";
                string PortugeseNew = "4% de aumento na chance de ataque à distância crítico";
                string RussianOld = "Увеличивает шанс критического урона от бросания на 15 %";
                string RussianNew = "Увеличивает шанс критического дистанционного урона на 4 %";
                string ChineseOld = "投掷暴击率增加15%";
                string ChineseNew = "远程暴击率增加4%";
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
    public class FossilArmorSet : GlobalItem
    {
        const string Fossilset = "Fossil_armor_set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.FossilHelm && body.type == ItemID.FossilShirt && legs.type == ItemID.FossilPants)
            {
                return Fossilset;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowThrowingToRanged && set == Fossilset)
            {
                player.ammoCost80 = true;
                player.thrownCost50 = false;
                if (GameCulture.German.IsActive)
                {
                    player.setBonus = "20% Chance, keine Munition zu verbrauchen";
                }
                if (GameCulture.English.IsActive)
                {
                    player.setBonus = "20% chance to not consume ammo";
                }
                if (GameCulture.Spanish.IsActive)
                {
                    player.setBonus = "Probabilidad del 20% de no gastar munición";
                }
                if (GameCulture.French.IsActive)
                {
                    player.setBonus = "20 % de chances de ne pas utiliser de munitions";
                }
                if (GameCulture.Italian.IsActive)
                {
                    player.setBonus = "20% di probabilità di non consumare munizioni";
                }
                if (GameCulture.Polish.IsActive)
                {
                    player.setBonus = "20% szans niezużycia amunicji";
                }
                if (GameCulture.Portuguese.IsActive)
                {
                    player.setBonus = "20% de chance de não consumir munição";
                }
                if (GameCulture.Russian.IsActive)
                {
                    player.setBonus = "Шанс 20 % не потратить боеприпасы";
                }
                if (GameCulture.Chinese.IsActive)
                {
                    player.setBonus = "20%的几率不消耗弹药";
                }
            }
        }
    }
}