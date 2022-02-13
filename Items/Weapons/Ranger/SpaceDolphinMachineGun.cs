using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JourneyRecipes.Items.Weapons.Ranger
{
    public class SpaceDolphinMachineGun : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.SDMG)
            {
                item.damage = 85;
            }
        }
        public override bool ConsumeAmmo(Item item, Player player)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.SDMG)
            {
                return Main.rand.NextBool(3);
            }
            return true;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.SDMG)
            { 
                string GermanOld = "50% Chance, keine Munition zu verbrauchen";
                string GermanNew = "66% Chance, keine Munition zu verbrauchen";
                string EnglishOld = "50% chance to not consume ammo";
                string EnglishNew = "66% chance to not consume ammo";
                string SpanishOld = "Probabilidad del 50% de no gastar munición";
                string SpanishNew = "Probabilidad del 66% de no gastar munición";
                string FrenchOld = "50 % de chances de ne pas utiliser de munitions";
                string FrenchNew = "66 % de chances de ne pas utiliser de munitions";
                string ItalianOld = "50% di probabilità di non consumare munizioni";
                string ItalianNew = "66% di probabilità di non consumare munizioni";
                string PolishOld = "50% szans niezużycia amunicji";
                string PolishNew = "66% szans niezużycia amunicji";
                string PortugeseOld = "50% de chance de não consumir munição";
                string PortugeseNew = "66% de chance de não consumir munição";
                string RussianOld = "Шанс 50 % не потратить боеприпасы";
                string RussianNew = "Шанс 66 % не потратить боеприпасы";
                string ChineseOld = "50%的几率不消耗弹药";
                string ChineseNew = "66%的几率不消耗弹药";
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