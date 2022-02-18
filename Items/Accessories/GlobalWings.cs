using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.Initializers;
using Terraria.Modules;
using static Terraria.Player;
using Terraria.Utilities;
using Terraria.DataStructures;
using Terraria.IO;
using Terraria.ObjectData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace JourneyRecipes.Items.Accessories
{
    public class GlobalWings : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (Config.Instance.allowWingStat)
            {
                switch (item.type)
                {
                    case ItemID.LeafWings:
                        player.wingTimeMax = 100;
                        break;
                    case ItemID.FinWings:
                    case ItemID.FrozenWings:
                    case ItemID.HarpyWings:
                    case ItemID.FairyWings:
                        player.wingTimeMax = 130;
                        break;
                    case ItemID.Jetpack:
                        player.wingTimeMax = 150;
                        break;
                    case ItemID.BatWings:
                    case ItemID.BeeWings:
                    case ItemID.ButterflyWings:
                        player.wingTimeMax = 160;
                        break;
                    case ItemID.BoneWings:
                    case ItemID.MothronWings:
                    case ItemID.GhostWings:
                    case ItemID.BeetleWings:
                        player.wingTimeMax = 170;
                        break;
                    case ItemID.FestiveWings:
                    case ItemID.WingsNebula:
                    case ItemID.WingsVortex:
                        player.wingTimeMax = 180;
                        break;

                }
            }
        }
        public override void HorizontalWingSpeeds(Item item, Player player, ref float speed, ref float acceleration)
        {
            if (Config.Instance.allowWingStat)
            {
                if (!player.mount.Active && player.wingsLogic > 0 && player.velocity.Y != 0f)
                {
                    WingAirLogicTweaks(player);
                }/*
                switch (item.type)
                {
                    case ItemID.LeafWings:
                    case ItemID.AngelWings:
                    case ItemID.DemonWings:
                        speed = 6.260869565f;
                        break;
                    case ItemID.FairyWings:
                    case ItemID.FinWings:
                    case ItemID.FrozenWings:
                    case ItemID.HarpyWings:
                        speed = 6.652173913f;
                        break;
                    case ItemID.BatWings:
                    case ItemID.BeeWings:
                    case ItemID.ButterflyWings:
                    case ItemID.FlameWings:
                    case ItemID.BoneWings:
                    case ItemID.MothronWings:
                    case ItemID.GhostWings:
                    case ItemID.BeetleWings:
                    case ItemID.FestiveWings:
                    case ItemID.SpookyWings:
                    case ItemID.TatteredFairyWings:
                    case ItemID.SteampunkWings:
                        speed = 7.434782609f;
                        break;
                    case ItemID.Hoverboard:
                        speed = 6.456521739f;
                        break;
                    case ItemID.BetsyWings:
                        speed = 7.043478261f;
                        break;
                    case ItemID.FishronWings:
                        speed = 8.02173913f;
                        break;
                    case ItemID.WingsNebula:
                    case ItemID.WingsVortex:
                        speed = 6.456521739f;
                        break;
                    case ItemID.WingsSolar:
                    case ItemID.WingsStardust:
                        speed = 9f;
                        break;
                }*/

            }
        }
        public override void VerticalWingSpeeds(Item item, Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            if (Config.Instance.allowWingStat)
            {
                switch (item.type)
                {
                    case ItemID.BoneWings:
                    case ItemID.Hoverboard:
                    case ItemID.MothronWings:
                    case ItemID.GhostWings:
                    case ItemID.BeetleWings:
                        constantAscend = .1f;
                        ascentWhenFalling = .5f;
                        maxAscentMultiplier = 1.66f;
                        maxCanAscendMultiplier = .5f;
                        ascentWhenRising = .1f;
                        break;
                    case ItemID.FestiveWings:
                    case ItemID.SpookyWings:
                    case ItemID.TatteredFairyWings:
                    case ItemID.SteampunkWings:
                        constantAscend = .1f;
                        ascentWhenFalling = .5f;
                        maxAscentMultiplier = 1.805f;
                        maxCanAscendMultiplier = .5f;
                        ascentWhenRising = .1f;
                        break;
                    case ItemID.FishronWings:
                    case ItemID.BetsyWings:
                        constantAscend = .125f;
                        ascentWhenFalling = .75f;
                        maxAscentMultiplier = 2.5f;
                        maxCanAscendMultiplier = 1f;
                        ascentWhenRising = .15f;
                        break;
                    case ItemID.WingsNebula:
                    case ItemID.WingsVortex:
                        maxAscentMultiplier = 2.45f;
                        maxCanAscendMultiplier = 1f;
                        break;
                    case ItemID.WingsSolar:
                    case ItemID.WingsStardust:
                        constantAscend = .135f;
                        ascentWhenFalling = .85f;
                        maxAscentMultiplier = 3f;
                        maxCanAscendMultiplier = 1f;
                        ascentWhenRising = .15f;
                        break;
                }
            }
        }
        private void WingAirLogicTweaks(Player player)
        {

            if (player.wingsLogic < 1)
            {
                return;
            }
            bool flag = player.controlDown && player.controlJump && player.wingTime > 1;
            bool flag2 = player.wingTime > 1;
            if (player.wingsLogic == 22 && flag)
            {
                player.accRunSpeed = 10f;
            }
            else if (player.wingsLogic == 22 && !flag)
            {
                player.accRunSpeed = 6.4f;
            }
            else if (player.wingsLogic == 37 && flag)
            {
                player.accRunSpeed = 12f;
            }
            else if (player.wingsLogic == 37 && !flag)
            {
                player.accRunSpeed = 7f;
            }
            else if (player.wingsLogic == 30 && flag)
            {
                player.accRunSpeed = 12f;
            }
            else if (player.wingsLogic == 30 && !flag)
            {
                player.accRunSpeed = 6.6f;
            }
            else if (player.wingsLogic == 31 && flag)
            {
                player.accRunSpeed = 12f;
            }
            else if (player.wingsLogic == 31 && !flag)
            {
                player.accRunSpeed = 6.6f;
            }
            else if (player.wingsLogic == 1 && flag2)
            {
                player.accRunSpeed = 6.3f;
            }
            else if (player.wingsLogic == 2 && flag2)
            {
                player.accRunSpeed = 6.3f;
            }
            else if (player.wingsLogic == 13 && flag2)
            {
                player.accRunSpeed = 6.3f;
            }
            else if (player.wingsLogic == 6 && flag2)
            {
                player.accRunSpeed = 6.7f;
            }
            else if (player.wingsLogic == 25 && flag2)
            {
                player.accRunSpeed = 6.7f;
            }
            else if (player.wingsLogic == 10 && flag2)
            {
                player.accRunSpeed = 6.7f;
            }
            else if (player.wingsLogic == 7 && flag2)
            {
                player.accRunSpeed = 6.7f;
            }
            else if (player.wingsLogic == 14 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }
            else if (player.wingsLogic == 15 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }
            else if (player.wingsLogic == 5 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }
            else if (player.wingsLogic == 9 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }
            else if (player.wingsLogic == 8 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }
            else if (player.wingsLogic == 27 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }
            else if (player.wingsLogic == 11 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }
            else if (player.wingsLogic == 24 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }
            else if (player.wingsLogic == 23 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }
            else if (player.wingsLogic == 21 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }
            else if (player.wingsLogic == 20 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }
            else if (player.wingsLogic == 12 && flag2)
            {
                player.accRunSpeed = 7.5f;
            }

        }
    }
}