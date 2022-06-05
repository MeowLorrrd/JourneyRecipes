using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Armor
{
    #region Solar Head
    [AutoloadEquip(EquipType.Head)]
    public class SolarArmorHead : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareHelmet)
            {
                player.meleeCrit += 9;
            }
        }
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareHelmet)
                item.lifeRegen = 2;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareHelmet)
            {
                string GermanOld = "Um 17% erhöhte kritische Nahkampf-Trefferchance";
                string GermanNew = "Um 26% erhöhte kritische Nahkampf-Trefferchance\nGeringe Lebensregeneration";
                string EnglishOld = "17% increased melee critical strike chance";
                string EnglishNew = "26% increased melee critical strike chance\nGrants minor life regeneration";
                string SpanishOld = "Aumenta un 17% la probabilidad de ataque crítico en el cuerpo a cuerpo";
                string SpanishNew = "Aumenta un 26% la probabilidad de daño cuerpo a cuerpo\nOtorga una regeneración de vida menor";
                string FrenchOld = "+7 % de chances de coup critique au corps à corps";
                string FrenchNew = "+26 % de chances de coup critique au corps à corps\nOctroie une petite régénération de vie";
                string ItalianOld = "Possibilità di colpo critico nel corpo a corpo aumentata del 17%";
                string ItalianNew = "Possibilità di colpo critico in mischia aumentata del 26%\nDona poca rigenerazione vita";
                string PolishOld = "17% większa szansa na trafienie krytyczne w walce w zwarciu";
                string PolishNew = "26% zwiększona szansa na trafienie krytyczne w walce w zwarciu\nZapewnia niewielką regenerację życia";
                string PortugeseOld = "17% de aumento na chance de acerto crítico em ataque físico";
                string PortugeseNew = "26% de aumento na chance de acerto crítico em ataque físico\nConcede uma pequena regeneração de vida";
                string RussianOld = "Увеличивает шанс критического урона в ближнем бою на 17 %";
                string RussianNew = "Увеличивает шанс критического урона в ближнем бою на 26 %\nДает небольшое восстановление жизни";
                string ChineseOld = "近战暴击率增加17%";
                string ChineseNew = "近战暴击率增加26%\n可小幅提高生命再生速度";
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
    #region Solar Chest
    [AutoloadEquip(EquipType.Body)]
    public class SolarArmorBody : GlobalItem
    {
        public override void UpdateEquip(Item item, Player player)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareBreastplate)
            {
                player.meleeDamage += .07f;
            }
        }
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareBreastplate)
                item.lifeRegen = 2;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareBreastplate)
            {
                string GermanOld = "Um 22% erhöhter Nahkampfschaden";
                string GermanNew = "Um 29% erhöhter Nahkampfschaden\nGeringe Lebensregeneration";
                string EnglishOld = "22% increased melee damage";
                string EnglishNew = "29% increased melee damage\nGrants minor life regeneration";
                string SpanishOld = "Aumenta un 22% el daño cuerpo a cuerpo";
                string SpanishNew = "Aumenta un 29% el daño cuerpo a cuerpo\nOtorga una regeneración de vida menor";
                string FrenchOld = "+22 % de dégâts au corps à corps";
                string FrenchNew = "+29 % de dégâts au corps à corps\nOctroie une petite régénération de vie";
                string ItalianOld = "Danno da mischia aumentato del 22%";
                string ItalianNew = "Danno da mischia aumentato del 29%\nDona poca rigenerazione vita";
                string PolishOld = "22% zwiększone obrażenia w walce w zwarciu";
                string PolishNew = "29% zwiększone obrażenia w walce w zwarciu\nZapewnia niewielką regenerację życia";
                string PortugeseOld = "22% de aumento nos danos por ataques físicos";
                string PortugeseNew = "29% de aumento nos danos por ataque físico\nConcede uma pequena regeneração de vida";
                string RussianOld = "Увеличивает урон в ближнем бою на 22 %";
                string RussianNew = "Увеличивает урон в ближнем бою на 29 %\nДает небольшое восстановление жизни";
                string ChineseOld = "近战伤害增加22%";
                string ChineseNew = "近战伤害增加29%\n可小幅提高生命再生速度";
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
    #region Solar Feet
    [AutoloadEquip(EquipType.Legs)]
    public class SolarArmorLegs : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareHelmet)
                item.lifeRegen = 2;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.SolarFlareLeggings)
            {
                string GermanOld = "Um 15% erhöhte Bewegungs- und Nahkampfgeschwindigkeit";
                string GermanNew = "Um 15% erhöhtes Bewegungs- und Nahkampftempo\nGeringe Lebensregeneration";
                string EnglishOld = "15% increased movement and melee speed";
                string EnglishNew = "15% increased movement and melee speed\nGrants minor life regeneration";
                string SpanishOld = "Aumenta un 15% la velocidad de movimiento y del cuerpo a cuerpo";
                string SpanishNew = "Aumenta un 15% la velocidad de movimiento y cuerpo a cuerpo\nOtorga una regeneración de vida menor";
                string FrenchOld = "+15 % de vitesse de mouvement et au corps à corps";
                string FrenchNew = "+15 % de vitesse de déplacement et au corps à corps\nOctroie une petite régénération de vie";
                string ItalianOld = "Movimento e velocità in mischia aumentano del 15%";
                string ItalianNew = "Movimento e velocità in mischia aumentano del 15%\nDona poca rigenerazione vita";
                string PolishOld = "15% zwiększona szybkość poruszania się i walki w zwarciu";
                string PolishNew = "15% zwiększona szybkość poruszania się oraz walki w zwarciu\nZapewnia niewielką regenerację życia";
                string PortugeseOld = "15% de aumento na velocidade dos movimentos e dos ataques físicos";
                string PortugeseNew = "15% de aumento na velocidade dos movimentos e dos ataques físicos\nConcede uma pequena regeneração de vida";
                string RussianOld = "Увеличивает скорость движения и ближнего боя на 15 %";
                string RussianNew = "Увеличивает скорость движения и ближнего боя на 15 %\nДает небольшое восстановление жизни";
                string ChineseOld = "移动和近战速度各提高15%";
                string ChineseNew = "移动和近战速度各提高15%\n可小幅提高生命再生速度";
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
    public class SolarArmorSet : GlobalItem
    {
        const string SolarArmorSetBonus = "Solar_armor";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.SolarFlareHelmet && body.type == ItemID.SolarFlareBreastplate && legs.type == ItemID.SolarFlareLeggings)
            {
                return SolarArmorSetBonus;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == SolarArmorSetBonus)
            {
                player.endurance += .12f;
                player.solarCounter += 1;
                if (GameCulture.German.IsActive)
                {
                    player.setBonus = "Sonnenschilde laden sich mit der Zeit auf, beschützen dich & lassen dich sprinten\nMit einer Ladung kannst du Feinden, die du berührst, Schaden zufügen\nVerbraucht Ladungen für Explosionen & um Feinden Schaden zuzufügen";
                }
                if (GameCulture.English.IsActive)
                {
                    player.setBonus = "Solar shields charge over time to protect you & let you dash\nA charge is used to damage enemies you touch\nConsumed charges explode & damage enemies";
                }
                if (GameCulture.Spanish.IsActive)
                {
                    player.setBonus = "Los escudos solares se cargan con el tiempo para protegerte y dejarte correr\nSe usa una carga para dañar a los enemigos a los que toques\nLas cargas consumidas explotan y dañan a los enemigos";
                }
                if (GameCulture.French.IsActive)
                {
                    player.setBonus = "Les boucliers solaires se chargent avec le temps pour vous protéger et pour vous permettre de foncer\nUne charge est utilisée pour infliger des dégâts aux ennemis touchés\nLes charges consommées explosent et infligent des dégâts aux ennemis";
                }
                if (GameCulture.Italian.IsActive)
                {
                    player.setBonus = "Gli scudi solari si caricano nel tempo per proteggerti e ti consentono di scattare\nUna carica viene utilizzata per danneggiare i nemici che tocchi\nLe cariche consumate esplodono e infliggono danni ai nemici";
                }
                if (GameCulture.Polish.IsActive)
                {
                    player.setBonus = "Tarcze słoneczne ładują się wraz z upływem czasu, zapewniając ci ochronę i pozwalając wykonać zryw\nBy zadać obrażenia przeciwnikom, których dotkniesz, wykorzystujesz ładunek\nWykorzystane ładunki wybuchają i ranią wrogów";
                }
                if (GameCulture.Portuguese.IsActive)
                {
                    player.setBonus = "Escudos solares carregam com o tempo para proteger você. Eles também permitem que você corra\nUma carga é gasta para causar dano nos inimigos que você tocar\nCargas gastas explodem e causam dano nos inimigos";
                }
                if (GameCulture.Russian.IsActive)
                {
                    player.setBonus = "Солнечные щиты заряжаются со временем, защищают вас и позволяют совершать рывок.\nКасаясь врага, вы расходуете один заряд и наносите ему урон.\nИзрасходованные заряды взрываются и наносят врагам урон.";
                }
                if (GameCulture.Chinese.IsActive)
                {
                    player.setBonus = "日耀护盾可以随着时间推移补充能量，保护你，让你能猛冲\n能量可以用来伤害你触碰到的敌人\n消耗的能量会爆炸并伤害敌人";
                }
            }
        }
    }
    public class SolarBuff : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            if (Config.Instance.allowArmorStat && (type == BuffID.SolarShield1 || type == BuffID.SolarShield2 || type == BuffID.SolarShield3)) player.endurance += .2f;
        }
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            base.ModifyBuffTip(type, ref tip, ref rare);
            if (Config.Instance.allowArmorStat && type == BuffID.SolarShield1 || type == BuffID.SolarShield2 || type == BuffID.SolarShield3) tip = "Damage taken reduced by 20%, repel enemies when taking damage";
        }
    }
}