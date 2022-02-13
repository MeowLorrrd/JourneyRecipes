using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.Localization;

namespace JourneyRecipes.Items.Armor
{
    #region NingaeArmor
    [AutoloadEquip(EquipType.Head)]
    public class NingaeArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaHood)
            {
                player.thrownVelocity -= .15f;
                player.magicCrit += 3;
                player.meleeCrit += 3;
                player.rangedCrit += 3;
                
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaHood)
            {
                string GermanOld = "Wurfgeschwindigkeit erhöht um 15%";
                string GermanNew = "Kritische Trefferchance um 3% erhöht";
                string EnglishOld = "15% increased throwing velocity";
                string EnglishNew = "3% increased critical strike chance";
                string SpanishOld = "Aumenta un 15% la velocidad de lanzamiento";
                string SpanishNew = "Aumenta un 3% la probabilidad de ataque crítico";
                string FrenchOld = "+15 % de vitesse de lancer";
                string FrenchNew = "+3 % de chances de coup critique";
                string ItalianOld = "Velocità di lancio aumentata del 15%";
                string ItalianNew = "Possibilità di colpo critico aumentata del 3%";
                string PolishOld = "15% zwiększona prędkość rzutu";
                string PolishNew = "3% większa szansa na trafienie krytyczne";
                string PortugeseOld = "15% de aumento na velocidade do arremesso";
                string PortugeseNew = "3% de aumento na chance de acerto crítico";
                string RussianOld = "Увеличивает скорость бросания на 15 %";
                string RussianNew = "Увеличивает шанс критического урона на 3 %";
                string ChineseOld = "投掷射速提高15%";
                string ChineseNew = "暴击率增加3%";
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

    [AutoloadEquip(EquipType.Body)]
    public class NingaeArmorChest : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaShirt)
            {
                player.thrownDamage -= .15f;
                player.magicCrit += 3;
                player.meleeCrit += 3;
                player.rangedCrit += 3;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaShirt)
            {
                string GermanOld = "Wurfschaden erhöht um 15%";
                string GermanNew = "Kritische Trefferchance um 3% erhöht";
                string EnglishOld = "15% increased throwing damage";
                string EnglishNew = "3% increased critical strike chance";
                string SpanishOld = "Aumenta un 15% el daño de lanzamiento";
                string SpanishNew = "Aumenta un 3% la probabilidad de ataque crítico";
                string FrenchOld = "+15 % de dégâts de lancer";
                string FrenchNew = "+3 % de chances de coup critique";
                string ItalianOld = "Danni da lancio aumentati del 15%";
                string ItalianNew = "Possibilità di colpo critico aumentata del 3%";
                string PolishOld = "15% zwiększone obrażenia rzutu";
                string PolishNew = "3% większa szansa na trafienie krytyczne";
                string PortugeseOld = "15% de aumento nos danos por arremessos";
                string PortugeseNew = "3% de aumento na chance de acerto crítico";
                string RussianOld = "Увеличивает урон от бросания на 15 %";
                string RussianNew = "Увеличивает шанс критического урона на 3 %";
                string ChineseOld = "投掷伤害增加15%";
                string ChineseNew = "暴击率增加3%";
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
    public class NingaeArmorLegs : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaPants)
            {
                player.thrownCrit -= 10;
                player.magicCrit += 3;
                player.meleeCrit += 3;
                player.rangedCrit += 3;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowThrowingToRanged && item.type == ItemID.NinjaPants)
            {
                string GermanOld = "Kritische Trefferchance beim Werfen um 10% erhöht";
                string GermanNew = "Kritische Trefferchance um 3% erhöht";
                string EnglishOld = "10% increased throwing critical strike chance";
                string EnglishNew = "3% increased critical strike chance";
                string SpanishOld = "Aumenta un 10% la probabilidad de impacto crítico al lanzar";
                string SpanishNew = "Aumenta un 3% la probabilidad de ataque crítico";
                string FrenchOld = "+10 % de chances de coup critique au lancer";
                string FrenchNew = "+3 % de chances de coup critique";
                string ItalianOld = "Possibilità colpo critico da lancio aumentata del 10%";
                string ItalianNew = "Possibilità di colpo critico aumentata del 3%";
                string PolishOld = "10% większa szansa na trafienie krytyczne rzutu";
                string PolishNew = "3% większa szansa na trafienie krytyczne";
                string PortugeseOld = "10% de aumento na chance de acerto crítico no arremesso";
                string PortugeseNew = "3% de aumento na chance de acerto crítico";
                string RussianOld = "Увеличивает шанс критического урона от бросания на 10 %";
                string RussianNew = "Увеличивает шанс критического урона на 3 %";
                string ChineseOld = "投掷暴击率增加10%";
                string ChineseNew = "暴击率增加3%";
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
    public class NingaeArmorSet : GlobalItem
    {
        const string Ninjaset = "Ninja_armor_set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.NinjaHood && body.type == ItemID.NinjaShirt && legs.type == ItemID.NinjaPants)
            {
                return Ninjaset;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowThrowingToRanged && set == Ninjaset)
            {
                player.moveSpeed += .2f;
                player.thrownCost33 = false;
                if (GameCulture.German.IsActive)
                {
                    player.setBonus = "Um 20% erhöhtes Bewegungstempo";
                }
                if (GameCulture.English.IsActive)
                {
                    player.setBonus = "20% increased movement speed";
                }
                if (GameCulture.Spanish.IsActive)
                {
                    player.setBonus = "Aumenta en un 20% la velocidad de movimiento";
                }
                if (GameCulture.French.IsActive)
                {
                    player.setBonus = "+20 % de vitesse de déplacement";
                }
                if (GameCulture.Italian.IsActive)
                {
                    player.setBonus = "Velocità di movimento aumentata del 20%";
                }
                if (GameCulture.Polish.IsActive)
                {
                    player.setBonus = "20% zwiększona szybkość poruszania się";
                }
                if (GameCulture.Portuguese.IsActive)
                {
                    player.setBonus = "20% de aumento na velocidade dos movimentos";
                }
                if (GameCulture.Russian.IsActive)
                {
                    player.setBonus = "Увеличивает скорость движения на 20 %";
                }
                if (GameCulture.Chinese.IsActive)
                {
                    player.setBonus = "移动速度提高20%";
                }
            }
        }
    }
}