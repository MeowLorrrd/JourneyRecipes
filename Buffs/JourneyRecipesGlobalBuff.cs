using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace JourneyRecipes.Buffs
{
    public class JourneyRecipesGlobalBuffItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (ModContent.GetInstance<JourneyRecipesServerConfig>().AllowBuffDuration)
            {
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
        }
    }
    public class JourneyRecipesGlobalBuffStation : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            if (ModContent.GetInstance<JourneyRecipesServerConfig>().AllowBuffDuration)
            {
                if (type == BuffID.Sharpened || type == BuffID.Clairvoyance || type == BuffID.Bewitched || type == BuffID.AmmoBox)
                {
                    player.buffTime[buffIndex] = 2;
                    Main.buffNoTimeDisplay[type] = true;
                    Main.buffNoSave[type] = true;
                }
            }
            if (ModContent.GetInstance<JourneyRecipesServerConfig>().AllowBuffStat) if (type == BuffID.Thorns) player.thorns = 1f;
        }
    }

    public class JourneyRecipesGlobalBuffTile : GlobalTile
    {
        public override void RightClick(int i, int j, int type)
        {
            Player p = Main.LocalPlayer;
            if (ModContent.GetInstance<JourneyRecipesServerConfig>().AllowBuffDuration)
            {
                if (type == TileID.SharpeningStation)
                {
                    p.ClearBuff(BuffID.Sharpened);//remove buff first, as this happens in same frame and buff timer will never show (otherwise single frame of timer will appear)
                    p.AddBuff(BuffID.Sharpened, 2);//give 2 frame of buff, but in Update() will constantly refresh with 2 frames
                }
                if (type == TileID.BewitchingTable)
                {
                    p.ClearBuff(BuffID.Bewitched);
                    p.AddBuff(BuffID.Bewitched, 2);
                }
                if (type == TileID.AmmoBox)
                {
                    p.ClearBuff(BuffID.AmmoBox);
                    p.AddBuff(BuffID.AmmoBox, 2);
                }
                if (type == TileID.CrystalBall)
                {
                    p.ClearBuff(BuffID.Clairvoyance);
                    p.AddBuff(BuffID.Clairvoyance, 2);
                }
            }
        }
    }

}