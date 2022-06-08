using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

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
                        if (!player.controlDown)
                        {
                            constantAscend = .15f;
                            break;
                        }
                        break;
                    case ItemID.WingsSolar:
                    case ItemID.WingsStardust:
                        constantAscend = .135f;
                        ascentWhenFalling = .85f;
                        maxAscentMultiplier = 3f;
                        maxCanAscendMultiplier = 1f;
                        ascentWhenRising = .15f;
                        break;
                    //code taken from Terraria (1.4.2.3) source code
                }
            }
        }
        public override void HorizontalWingSpeeds(Item item, Player player, ref float speed, ref float acceleration)
        {
            if (Config.Instance.allowWingStat)//checks if wing config is enabled
            {
                if (!player.mount.Active && player.wingsLogic > 0 && player.velocity.Y != 0f)//checks if player is not on mount, if is vanilla wing and if player is moving up or down (Y could be small number, just not 0)
                {
                    WingAirLogicTweaks(player);
                }
                #region unused wing code
                /* yeah probably don't use this
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
                #endregion
            }
        }
        private void WingAirLogicTweaks(Player player)//code taken from Terraria (1.4.3.2) source code
        {

            if (player.wingsLogic < 1)//checks if vanilla wing, otherwise change nothing
            {
                return;
            }
            #region wing bools
            bool flag = player.controlDown && player.controlJump && player.wingTime > 1;//checks if player is hovering and has wingtime left
            bool flag2 = player.controlJump && player.wingTime > 1;//checks if player is flying and has wingtime left
            bool flag3 = player.wingsLogic == 22 || player.wingsLogic == 28 || player.wingsLogic == 30 || player.wingsLogic == 31 || player.wingsLogic == 33 || player.wingsLogic == 35 || player.wingsLogic == 37 || player.wingsLogic == 45;//checks if player CAN hover with these vanilla wings
            #endregion

            #region Hover-able wings
            if (flag2 && flag3 && !player.merman)
            {
                
                if (flag)
                {
                    player.velocity.Y *= 0.9f;
                    if (player.velocity.Y > -2f && player.velocity.Y < 1f)
                    {
                        player.velocity.Y = 1E-05f;
                    }
                    //^^code from 1.4 source code that doesn't let player float up while hovering (try it it super annoying)
                    switch (player.wingsLogic)
                    {
                        case 22:
                            player.accRunSpeed = 10f;
                            break;
                        case 30:
                        case 31:
                            player.accRunSpeed = 12f;
                            break;
                        case 37:
                            player.accRunSpeed = 12f;
                            break;
                    }
                }
                else if (!flag)
                {
                    switch (player.wingsLogic)
                    {
                        case 22:
                            player.accRunSpeed = 6.4f;
                            player.maxRunSpeed = 6.4f;
                            break;
                        case 30:
                        case 31:
                            player.accRunSpeed = 6.8f;
                            player.maxRunSpeed = 6.8f;
                            break;
                        case 37:
                            player.accRunSpeed = 7.2f;
                            player.maxRunSpeed = 7.2f;
                            break;
                    }
                }
            }
            #endregion
            #region Non-hover-able wings
            else if (flag2 && !flag3 && !player.merman)
            {
                switch (player.wingsLogic)
                {
                    case 1:
                    case 2:
                    case 13:
                        player.accRunSpeed = 6.3f;
                        break;
                    case 6:
                    case 7:
                    case 10:
                    case 25:
                        player.accRunSpeed = 6.7f;
                        break;
                    case 5:
                    case 8:
                    case 9:
                    case 11:
                    case 12:
                    case 14:
                    case 15:
                    case 20:
                    case 21:
                    case 23:
                    case 24:
                    case 27:
                        player.accRunSpeed = 7.5f;
                        break;
                }
            }
            #endregion
        }
    }
}