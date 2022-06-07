using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using System.Collections.Generic;
namespace JourneyRecipes.Buffs
{
    public class JourneyRecipesGlobalBuffItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            bool bt = Config.Instance.allowBuffDuration;
            if (bt)//no {} needed as this will simply check in order to execute switch
            switch (item.type)
            {
                case ItemID.CratePotion:
                case ItemID.GravitationPotion:
                case ItemID.InvisibilityPotion:
                    item.buffTime = 10800;
                    break;
                case ItemID.EndurancePotion:
                case ItemID.GillsPotion:
                case ItemID.InfernoPotion:
                case ItemID.MagicPowerPotion:
                case ItemID.RagePotion:
                case ItemID.WrathPotion:
                    item.buffTime = 14400;
                    break;
                case ItemID.SpelunkerPotion:
                    item.buffTime = 18000;
                    break;
                case ItemID.ObsidianSkinPotion:
                    item.buffTime = 21600;
                    break;
                case ItemID.BattlePotion:
                    item.buffTime = 25200;
                    break;
                case ItemID.AmmoReservationPotion:
                case ItemID.ArcheryPotion:
                case ItemID.CalmingPotion:
                case ItemID.FishingPotion:
                case ItemID.FlipperPotion:
                case ItemID.HeartreachPotion:
                case ItemID.HunterPotion:
                case ItemID.IronskinPotion:
                case ItemID.LifeforcePotion:
                case ItemID.ManaRegenerationPotion:
                case ItemID.RegenerationPotion:
                case ItemID.SonarPotion:
                case ItemID.SummoningPotion:
                case ItemID.SwiftnessPotion:
                case ItemID.ThornsPotion:
                case ItemID.TitanPotion:
                    item.buffTime = 28800;
                    break;
                case ItemID.TrapsightPotion:
                case ItemID.FeatherfallPotion:
                case ItemID.MiningPotion:
                case ItemID.NightOwlPotion:
                case ItemID.ShinePotion:
                case ItemID.WaterWalkingPotion:
                    item.buffTime = 36000;
                    break;
                case ItemID.WarmthPotion:
                    item.buffTime = 54000;
                    break;
                case ItemID.BuilderPotion:
                    item.buffTime = 162000;
                    break;
            }
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.FishingPotion)
            {
                #region strings
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
                #endregion
                #region insert new tooltips
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
    public class JourneyRecipesGlobalBuff : GlobalBuff
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            if (type == BuffID.ParryDamageBuff)//no config, because tooltip fix
            {
                if (GameCulture.German.IsActive) tip = "Um 400% erhöhter Schaden für den nächsten Nahkampfangriff";//no {} is needed as 1 line of code is required
                if (GameCulture.English.IsActive) tip = "400% increased damage for next melee strike";
                if (GameCulture.Spanish.IsActive) tip = "Un 400% más de daño en el próximo ataque cuerpo a cuerpo";
                if (GameCulture.French.IsActive) tip = "+400 % de dégâts pour la prochaine attaque au corps à corps";
                if (GameCulture.Italian.IsActive) tip = "Danni per il prossimo attacco in mischia aumentati del 400%";
                if (GameCulture.Polish.IsActive) tip = "400% zwiększone obrażenia następnego ataku w walce w zwarciu";
                if (GameCulture.Portuguese.IsActive) tip = "Aumento de 400% nos danos para o próximo ataque físico";
                if (GameCulture.Russian.IsActive) tip = "+400 % к урону от следующего удара ближнего боя";
                if (GameCulture.Chinese.IsActive) tip = "下次近战暴击伤害增加400%";
            }
            if (type == BuffID.Fishing)//No config needed because no buff duration change, just tooltip
            {
                if (GameCulture.German.IsActive) tip = "Erhöhte Angelkraft";
                if (GameCulture.English.IsActive) tip = "Increased fishing power";
                if (GameCulture.Spanish.IsActive) tip = "Aumenta la capacidad de pesca";
                if (GameCulture.French.IsActive) tip = "Augmente la puissance de pêche";
                if (GameCulture.Italian.IsActive) tip = "Potenza pesca aumentata";
                if (GameCulture.Polish.IsActive) tip = "Zwiększanie mocy wędkarstwa";
                if (GameCulture.Portuguese.IsActive) tip = "Maior poder de pescaria";
                if (GameCulture.Russian.IsActive) tip = "Рыболовная сила увеличена";
                if (GameCulture.Chinese.IsActive) tip = "渔力提高";
            }
        }
        public override void Update(int type, Player player, ref int buffIndex)
        {
            bool bs = Config.Instance.allowBuffStat;
            if (bs)
            {
                if (type == BuffID.Thorns) player.thorns = 1f;
                if (type == BuffID.Sharpened) player.GetModPlayer<JourneyRecipesPlayer>().Sharpened = true;
            }
        }
    }
    public class JourneyRecipesGlobalBuffStation : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            bool bt = Config.Instance.allowBuffDuration;
            if (bt)
            {
                if (type == BuffID.Sharpened || type == BuffID.Clairvoyance || type == BuffID.Bewitched || type == BuffID.AmmoBox)
                {
                    player.buffTime[buffIndex] = 1;
                    Main.buffNoTimeDisplay[type] = true;
                    Main.buffNoSave[type] = true;
                }
            }
        }
    }
    public class JourneyRecipesGlobalBuffTile : GlobalTile
    {
        public override void RightClick(int i, int j, int type)
        {
            bool bt = Config.Instance.allowBuffDuration;
            Player p = Main.LocalPlayer;
            if (bt)
            {
                if (type == TileID.SharpeningStation)
                {
                    p.ClearBuff(BuffID.Sharpened);//remove buff first, as this happens in same frame and buff timer will never show (otherwise single frame of timer will appear)
                    p.AddBuff(BuffID.Sharpened, 1);//give 1 frame of buff, but in Update() will constantly refresh with 1 frame
                }
                if (type == TileID.BewitchingTable)
                {
                    p.ClearBuff(BuffID.Bewitched);
                    p.AddBuff(BuffID.Bewitched, 1);
                }
                if (type == TileID.AmmoBox)
                {
                    p.ClearBuff(BuffID.AmmoBox);
                    p.AddBuff(BuffID.AmmoBox, 1);
                }
                if (type == TileID.CrystalBall)
                {
                    p.ClearBuff(BuffID.Clairvoyance);
                    p.AddBuff(BuffID.Clairvoyance, 1);
                }
            }
        }
    }
}