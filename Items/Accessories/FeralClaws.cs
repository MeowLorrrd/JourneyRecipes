using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using Terraria.Localization;

namespace JourneyRecipes.Items.Accessories
{
    [AutoloadEquip]
    public class FeralClaws : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (Config.Instance.allowAccessoryStat && (item.type == ItemID.FeralClaws || item.type == ItemID.PowerGlove || item.type == ItemID.MechanicalGlove || item.type == ItemID.FireGauntlet))
            {
                player.GetModPlayer<JourneyRecipesPlayer>().PlayerFeral = true;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowAccessoryStat && (item.type == ItemID.FeralClaws || item.type == ItemID.PowerGlove))//Tooltip for Feral Claws and Power glove, mentioning that they have autoswing
            {
                string GermanOld = "Um 12% erhöhtes Nahkampftempo";
                string GermanNew = "Um 12% erhöhtes Nahkampftempo\nAktiviert automatisches Schwingen für Nahkampfwaffen";
                string EnglishOld = "12% increased melee speed";
                string EnglishNew = "12% increased melee speed\nEnables auto swing for melee weapons";
                string SpanishOld = "Aumenta un 12% la velocidad del cuerpo a cuerpo";
                string SpanishNew = "Aumenta un 12% la velocidad del cuerpo a cuerpo\nPermite el uso automático de las armas cuerpo a cuerpo";
                string FrenchOld = "+12 % de vitesse au corps à corps";
                string FrenchNew = "+12 % de vitesse au corps à corps\nActive l'utilisation automatique des armes de mêlée";
                string ItalianOld = "Velocità nel corpo a corpo aumentata del 12%";
                string ItalianNew = "Aumenta la velocità in mischia del 12%\nAttiva l'uso automatico delle armi da mischia";
                string PolishOld = "12% zwiększona szybkość walki w zwarciu";
                string PolishNew = "12% zwiększona szybkość walki w zwarciu\nUmożliwia automatyczny atak broni do walki w zwarciu";
                string PortugeseOld = "12% de aumento na velocidade do ataque físico";
                string PortugeseNew = "12% de aumento na velocidade de ataque físico\nPermite o ataque automático com armas de ataque físico";
                string RussianOld = "Увеличивает скорость ближнего боя на 12 %";
                string RussianNew = "Увеличивает скорость ближнего боя на 12 %\nАктивирует автоматическую атаку ближнего боя";
                string ChineseOld = "近战速度提高12%";
                string ChineseNew = "近战速度提高12%\n为近战武器启用自动摆动";
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
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.MechanicalGlove)//Tooltip for Mechanical Glove, as this lil bastard has a weird one
            {
                string GermanOld = "Um 12% erhöhter Schaden und Nahkampfgeschwindigkeit";
                string GermanNew = "Um 12% erhöhter Nahkampfschaden & erhöhtes Nahkampftempo\nAktiviert automatisches Schwingen für Nahkampfwaffen";
                string EnglishOld = "12% increased damage and melee speed";
                string EnglishNew = "12% increased melee damage and speed\nEnables auto swing for melee weapons";
                string SpanishOld = "Aumenta un 12% el daño y la velocidad del cuerpo a cuerpo";
                string SpanishNew = "Aumenta un 12% la velocidad y el daño del cuerpo a cuerpo\nActiva el ataque automático de las armas cuerpo a cuerpo";
                string FrenchOld = "+12 % de dégâts et de vitesse de déplacement";
                string FrenchNew = "+12 % de dégâts et de vitesse au corps à corps\nActive l'utilisation automatique des armes de mêlée";
                string ItalianOld = "Danni e velocità in mischia aumentano del 12%";
                string ItalianNew = "Velocità e danni in mischia aumentati del 12%\nAttiva l'uso automatico delle armi da mischia";
                string PolishOld = "12% zwiększone obrażenia oraz szybkość ataku w zwarciu";
                string PolishNew = "12% zwiększone obrażenia i szybkość w walce w zwarciu\nUmożliwia automatyczny atak broni do walki w zwarciu";
                string PortugeseOld = "12% de aumento nos danos e na velocidade dos ataques físicos";
                string PortugeseNew = "12% de aumento no dano por ataques físicos\nPermite o ataque automático com armas de ataque físico";
                string RussianOld = "Увеличивает урон и скорость ближнего боя на 12 %";
                string RussianNew = "Увеличивает урон и скорость ближнего боя на 12 %\nАктивирует автоматическую атаку ближнего боя";
                string ChineseOld = "伤害和近战速度各增加12%";
                string ChineseNew = "近战伤害和速度各增加12%\n为近战武器启用自动摆动";
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
            if (Config.Instance.allowAccessoryStat && item.type == ItemID.FireGauntlet)//Tooltip for Fire G, showing 12% melee damage, speed, autoswing
            {
                string GermanOld = "Um 10% erhöhter Nahkampfschaden und -geschwindigkeit";
                string GermanNew = "Um 12% erhöhter Nahkampfschaden & erhöhtes Nahkampftempo\nAktiviert automatisches Schwingen für Nahkampfwaffen";
                string EnglishOld = "10% increased melee damage and speed";
                string EnglishNew = "12% increased melee damage and speed\nEnables auto swing for melee weapons";
                string SpanishOld = "Aumenta un 10% la velocidad y el daño del cuerpo a cuerpo";
                string SpanishNew = "Aumenta un 12% la velocidad y el daño del cuerpo a cuerpo\nActiva el ataque automático de las armas cuerpo a cuerpo";
                string FrenchOld = "+10 % de vitesse et de dégâts au corps à corps";
                string FrenchNew = "+12 % de dégâts et de vitesse au corps à corps\nActive l'utilisation automatique des armes de mêlée";
                string ItalianOld = "Danno in mischia e velocità aumentano del 10%";
                string ItalianNew = "Velocità e danni in mischia aumentati del 12%\nAttiva l'uso automatico delle armi da mischia";
                string PolishOld = "10% zwiększone obrażenia w walce w zwarciu oraz szybkość";
                string PolishNew = "12% zwiększone obrażenia i szybkość walki w zwarciu\nUmożliwia automatyczny atak broni do walki w zwarciu";
                string PortugeseOld = "10% de aumento nos danos por ataque físico e na velocidade";
                string PortugeseNew = "12% de aumento no dano por ataques físicos\nPermite o ataque automático com armas de ataque físico";
                string RussianOld = "Увеличивает урон и скорость ближнего боя на 10 %";
                string RussianNew = "Увеличивает урон и скорость ближнего боя на 12 %\nАктивирует автоматическую атаку ближнего боя";
                string ChineseOld = "近战伤害和速度各增加10%";
                string ChineseNew = "近战伤害和速度各增加12%\n为近战武器启用自动摆动";
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
    public class FeralClawsProjectileHandler : GlobalProjectile
    {
        public override void AI(Projectile projectile)
            //code from omniswing source code
            //fixes spear ai
        {
            if (Config.Instance.allowAccessoryStat)
            {
                if (projectile.aiStyle == 19 || projectile.aiStyle == 699)
                {
                    projectile.timeLeft = Main.player[projectile.owner].itemAnimation;
                    projectile.netUpdate = true;
                }
            }
        }
    }
}