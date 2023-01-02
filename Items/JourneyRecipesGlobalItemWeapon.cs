using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using static Terraria.ID.ItemID;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemWeapon : GlobalItem
    {
        private readonly bool Config = GetInstance<JourneyRecipesServerConfig>().allowWeaponStat;
        public override bool InstancePerEntity => true;
        public override bool CloneNewInstances => true;
        public override void SetDefaults(Item item)
        {
            if (Config)
            {
                if (item.type == 27)
                {
                    item.autoReuse = true;
                }
                else if (item.type == 46)
                {
                    item.damage = 18;
                    item.scale = 1.4f;
                }
                else if (item.type == 112)
                {
                    item.mana = 12;
                    item.useTime = 16;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 121)
                {
                    item.useTime = 30;
                    item.useAnimation = item.useTime;
                    item.damage = 40;
                }
                else if (item.type == 127)
                {
                    item.mana = 6;
                    item.damage = 17;

                }
                else if (item.type == 154)
                {
                    item.useAnimation = item.useTime;//bug relating to this mod
                }
                else if (item.type == 155)
                {
                    item.damage = 26;
                    item.knockBack = 3f;
                }
                else if (item.type == 164)
                {
                    item.useTime = 10;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 186)
                {
                    item.damage = 10;
                    item.knockBack = 4f;
                    item.useTime = 27;
                    item.useAnimation = 27;
                    item.useStyle = 1;
                    item.melee = true;
                }
                else if (item.type == 198 || item.type == 199 || item.type == 200 || item.type == 201 || item.type == 202 || item.type == 203)
                {
                    item.damage = 26;
                    item.useTime = item.useAnimation = 18;
                }
                else if (item.type == 234)
                {
                    item.damage = 8;
                }
                else if (item.type == 273)
                {
                    item.autoReuse = true;
                    item.useTime = 21;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 277)
                {
                    item.damage = 14;
                    item.knockBack = 6f;
                }
                else if (item.type == 281)
                {
                    item.useTime = 25;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 283)
                {
                    item.damage = 4;
                }
                else if (item.type == 426)
                {
                    item.useTime = 29;
                    item.useAnimation = 30;
                    item.damage = 43;
                }
                else if (item.type == 434)
                {
                    item.damage = 17;
                }
                else if (item.type == 435)
                {
                    item.useTime = 24;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 436)
                {
                    item.useTime = 22;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 481)
                {
                    item.useTime = 19;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 482)
                {
                    item.damage = 56;
                    item.useTime = 26;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 484)
                {
                    item.damage = 49;
                }
                else if (item.type == 494)
                {
                    item.damage = 42;
                    item.knockBack = .25f;
                    item.mana = 5;
                }
                else if (item.type == 518)
                {
                    item.damage = 32;
                    item.mana = 5;
                }
                else if (item.type == 506)
                {
                    item.damage = 35;
                }
                else if (item.type == 519)
                {
                    item.damage = 50;
                    item.mana = 9;
                    item.useTime = 15;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 578)
                {
                    item.damage = 53;
                    item.useTime = 16;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 671)
                {
                    item.damage = 85;
                }
                else if (item.type == 682)
                {
                    item.damage = 50;
                }
                else if (item.type == 683)
                {
                    item.damage = 88;
                }
                else if (item.type == 723)
                {
                    item.scale = 1.3f;
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 725)
                {
                    item.damage = 39;
                    item.autoReuse = true;
                    item.useTime = 16;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 726)
                {
                    item.mana = 12;
                    item.useTime = 16;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 758)
                {
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 759)//Rocket Launcher, add 2x damage bonus to 1st direct hit on single target
                {
                    item.damage = 45;
                }
                else if (item.type == 788)
                {
                    item.mana = 12;
                    item.damage = 35;
                }
                else if (item.type == 946)
                {
                    item.useStyle = 3;
                    item.damage = 10;
                    item.melee = true;
                    item.useTime = 22;
                    item.useAnimation = 22;
                    item.knockBack = 5f;
                    item.width = 44;
                    item.height = 44;
                    item.rare = 1;
                    item.UseSound = SoundID.Item1;
                }
                else if (item.type == 1130)
                {
                    item.damage = 12;
                }
                else if (item.type == 1179)
                {
                    item.damage = 9;
                }
                else if (item.type == 1185)
                {
                    item.damage = 45;
                }
                else if (item.type == 1187)
                {
                    item.useTime = 23;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 1187)
                {

                }
                else if (item.type == 1192)
                {
                    item.damage = 50;
                    item.useTime = 25;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 1194)
                {
                    item.useTime = 21;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 1199)
                {
                    item.damage = 58;
                    item.useTime = 25;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 1201)
                {
                    item.useTime = 18;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 1226)
                {
                    item.damage = 95;
                }
                else if (item.type == 1227)
                {
                    item.damage = 57;
                }
                else if (item.type == 1255)
                {
                    item.damage = 50;
                }
                else if (item.type == 1264)
                {
                    item.damage = 60;
                    item.mana = 11;
                    item.useTime = 12;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 1295)
                {
                    item.damage = 80;
                    item.useTime = 10;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 1297)
                {
                    item.damage = 90;
                }
                else if (item.type == 1302)
                {
                    item.damage = 11;
                }
                else if (item.type == 1325)
                {
                    item.damage = 12;
                }
                else if (item.type == 1341)
                {
                    item.damage = 19;
                }
                else if (item.type == 1342)
                {
                    item.damage = 15;
                }
                else if (item.type == 1444)
                {
                    item.damage = 60;
                    item.useTime = 15;
                    item.useTime = item.useAnimation;
                }
                else if (item.type == 1446)
                {
                    item.damage = 65;
                    item.mana = 15;
                }
                else if (item.type == 1553)
                {
                    item.damage = 85;
                }
                else if (item.type == 1571)
                {
                    item.damage = 70;
                }
                else if (item.type == 1784)
                {
                    item.useTime = 25;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 1785)
                {
                    item.damage = 60;
                }
                else if (item.type == 1802)//Raven Staff, double projectile speed in GlobalProjectile
                {
                    item.damage = 55;
                }
                else if (item.type == 1835)
                {
                    item.useTime = 12;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 1910)
                {
                    item.damage = 60;
                }
                else if (item.type == 2223)
                {
                    item.damage = 85;
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 2364)
                {
                    item.damage = 12;
                }
                else if (item.type == 2424)
                {
                    item.damage = 70;
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                    item.knockBack = 8f;
                }
                else if (item.type == 2608)
                {
                    item.damage = 25;
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 2622)
                {
                    item.damage = 90;
                    item.useTime = 40;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 2888)
                {
                    item.damage = 23;
                    item.useTime = 24;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 3003)
                {
                    item.damage = 8;
                }
                else if (item.type == 3009)
                {
                    item.damage = 14;
                }
                else if (item.type == 3010)
                {
                    item.damage = 10;
                }
                else if (item.type == 3011)
                {
                    item.damage = 12;
                }
                else if (item.type == 3012)
                {
                    item.damage = 59;
                }
                else if (item.type == 3019)
                {
                    item.damage = 22;
                    item.knockBack = 5.5f;
                    item.useTime = 13;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 3029)//Daedalus Stormbow, shoot 20% slower while using Holy, Unholy, Hellfire, Jester arrows
                {
                    item.damage = 38;
                }
                else if (item.type == 3051)
                {
                    item.damage = 25;
                }
                else if (item.type == 3069)
                {
                    item.damage = 14;
                    item.crit = 10;
                    item.useTime = 26;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 3210)
                {
                    item.useTime = 10;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 3281)
                {
                    item.damage = 18;
                }
                else if (item.type == 3284)
                {
                    item.damage = 54;
                }
                else if (item.type == 3291)
                {
                    item.damage = 95;
                    item.crit = 10;
                }
                else if (item.type == 3315)
                {
                    item.damage = 39;
                }
                else if (item.type == 3316)
                {
                    item.damage = 49;
                }
                else if (item.type == 3378)
                {
                    item.damage = 20;
                }
                else if (item.type == 3542)
                {
                    item.mana = 12;
                    item.useTime = 12;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 3764 || item.type == 3765 || item.type == 3766 || item.type == 3767 || item.type == 3768 || item.type == 3769)
                {
                    item.damage = 48;
                    item.useTime = item.useAnimation = 16;
                    //RECIPE CHANGES
                }
                else if (item.type == 3779)
                {
                    item.mana = 14;
                    item.useTime = 22;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 3787)
                {
                    item.mana = 17;
                }
                else if (item.type == 3788)
                {
                    item.damage = 24;
                    item.useTime = 48;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 3823)
                {
                    item.damage = 85;
                    item.scale = 1.13f;
                    item.useTime = 20;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 3827)
                {
                    //item.damage = 180;
                }
                else if (item.type == 3835)
                {
                    item.damage = 50;
                    //item.scale = 1.35f;
                }
                else if (item.type == 3852)
                {
                    item.damage = 32;
                    item.useTime = 25;
                    item.useAnimation = item.useTime;
                    item.autoReuse = true;
                }
                else if (item.type == 3854)
                {
                    item.damage = 32;
                    item.useTime = 18;
                    item.useAnimation = item.useTime;
                }
                else if (item.type == 3858)
                {
                    item.damage = 140;
                }
                else if (item.type == 3870)
                {
                    item.damage = 100;
                }
                if (item.type == CopperBroadsword)
                {
                    item.damage = 9;
                    item.useTime = item.useAnimation = 21;
                    item.scale = 1.1f;
                }
                if (item.type == TinBroadsword)
                {
                    item.damage = 10;
                    item.useTime = item.useAnimation = 20;
                    item.scale = 1.1f;
                }
                if (item.type == IronBroadsword)
                {
                    item.damage = 12;
                    item.useTime = item.useAnimation = 20;
                    item.scale = 1.15f;
                    item.knockBack = 5.5f;
                }
                if (item.type == LeadBroadsword)
                {
                    item.damage = 13;
                    item.useTime = item.useAnimation = 20;
                    item.scale = 1.15f;
                    item.knockBack = 5.5f;
                }
                if (item.type == SilverBroadsword)
                {
                    item.damage = 14;
                    item.useTime = item.useAnimation = 20;
                    item.scale = 1.2f;
                    item.knockBack = 6f;
                }
                if (item.type == TungstenBroadsword)
                {
                    item.damage = 14;
                    item.useTime = item.useAnimation = 19;
                    item.scale = 1.2f;
                    item.knockBack = 6f;
                }
                if (item.type == GoldBroadsword)
                {
                    item.damage = 15;
                    item.useTime = item.useAnimation = 18;
                    item.scale = 1.25f;
                    item.knockBack = 6.5f;
                }
                if (item.type == PlatinumBroadsword)
                {
                    item.damage = 16;
                    item.useTime = item.useAnimation = 17;
                    item.scale = 1.25f;
                    item.knockBack = 6.5f;
                }
                if (item.type == CactusSword)
                {
                    item.damage = 10;
                    item.useTime = item.useAnimation = 30;
                }
                if (item.type == WoodenSword)
                {
                    item.useTime = item.useAnimation = 20;
                    item.scale = 1;
                    item.knockBack = 5f;
                }
                if (item.type == PalmWoodSword || item.type == RichMahoganySword)
                {
                    item.useTime = item.useAnimation = 19;
                    item.knockBack = 6f;
                }
                if (item.type == EbonwoodSword || item.type == ShadewoodSword)
                {
                    item.damage = 11;
                    item.useTime = item.useAnimation = 19;
                    item.knockBack = 6f;
                }
                if (item.type == WoodenBoomerang)
                {
                    item.damage = 10;
                    item.useTime = item.useAnimation = 20;
                }
                if (item.type == EnchantedBoomerang)
                {
                    item.damage = 17;
                    item.useTime = item.useAnimation = 20;
                }
                if (item.type == ZombieArm)
                {
                    item.damage = 15;
                    item.useTime = item.useAnimation = 22;
                    item.scale = 1.2f;
                    item.knockBack = 5.5f;
                }
                if (item.type == BoneSword)
                {
                    item.damage = 19;
                    item.scale = 1.2f;
                    item.knockBack = 5.5f;
                }
                if (item.type == IceBoomerang)
                {
                    item.damage = 21;
                    item.useTime = item.useAnimation = 20;
                }
                if (item.type == PurpleClubberfish)
                {
                    item.damage = 35;
                    item.knockBack = 8f;
                }
                if (item.type == FalconBlade)
                {
                    item.scale = 1.175f;
                }
                if (item.type == AntlionClaw)
                {
                    item.damage = 16;
                    item.scale = 1.1f;
                }
                if (item.type == Katana)
                {
                    item.damage = 18;
                    item.useTime = item.useAnimation = 20;
                    item.scale = 1.1f;
                }
                if (item.type == CandyCaneSword)
                {
                    item.damage = 19;
                }
                if (item.type == FruitcakeChakram)
                {
                    item.damage = 19;
                }
                if (item.type == BladedGlove)
                {
                    item.damage = 14;
                }
                if (item.type == BloodyMachete)
                {
                    item.damage = 20;
                }
                if (item.type == TheRottedFork)
                {
                    item.damage = 17;
                }
                if (item.type == BeeKeeper)
                {
                    item.damage = 30;
                }
                if (item.type == Muramasa)
                {
                    //item.damage = 24;
                    //Projectile??
                }
                if (item.type == Valor)
                {
                    item.damage = 28;
                }
                if (item.type == Flamarang)
                {
                    item.damage = 49;
                    item.useTime = item.useAnimation = 20;
                }
                if (item.type == BreakerBlade)
                {
                    item.damage = 70;
                    item.useTime = item.useAnimation = 35;
                    item.scale = 1.15f;
                    //ONHIT CHANGES
                }
                if (item.type == CobaltSword)
                {
                    item.damage = 40;
                    item.useTime = item.useAnimation = 19;
                    item.scale = 1.2f;
                    item.knockBack = 5f;
                }
                if (item.type == PalladiumSword)
                {
                    item.damage = 49;
                    item.useTime = item.useAnimation = 22;
                    item.scale = 1.2f;
                    item.knockBack = 5.5f;
                }
                if (item.type == MythrilSword)
                {
                    item.damage = 50;
                    item.useTime = item.useAnimation = 20;
                    item.scale = 1.2f;
                }
                if (item.type == OrichalcumSword)
                {
                    item.damage = 59;
                    item.useTime = item.useAnimation = 22;
                    item.scale = 1.22f;
                }
                if (item.type == AdamantiteSword)
                {
                    item.damage = 61;
                    item.useTime = item.useAnimation = 21;
                    item.scale = 1.25f;
                }
                if (item.type == TitaniumSword)
                {
                    item.damage = 61;
                    item.useTime = item.useAnimation = 20;
                    item.scale = 1.25f;
                }
                if (item.type == PearlwoodSword)
                {
                    item.damage = 30;
                    item.useTime = item.useAnimation = 15;
                    item.autoReuse = true;
                }
                if (item.type == CobaltNaginata)
                {
                    item.damage = 44;
                }
                if (item.type == PalladiumPike)
                {
                    item.damage = 44;
                }
                if (item.type == MythrilHalberd)
                {
                    item.damage = 45;
                }
                if (item.type == OrichalcumHalberd)
                {
                    item.damage = 46;
                }
                if (item.type == AdamantiteGlaive)
                {
                    item.damage = 49;
                }
                if (item.type == TitaniumTrident)
                {
                    item.damage = 48;
                }
                if (item.type == Cutlass)
                {
                    item.damage = 53;
                    item.useTime = item.useAnimation = 16;
                }
                if (item.type == IceSickle)
                {
                    item.damage = 50;
                    item.shootSpeed = 12f;
                }
                if (item.type == SlapHand)
                {
                    item.damage = 55;
                    item.useTime = item.useAnimation = 20;
                }
                if (item.type == ChainGuillotines)
                {
                    //?
                }
                if (item.type == Bananarang)
                {
                    /* item.maxStack = 1;
                     item.damage = 45;
                     item.value = Item.sellPrice(0, 12);//in weapon changes bc balancing*/
                }
                if (item.type == BeamSword)
                {
                    item.autoReuse = true;
                    item.useTurn = false;
                    //PROJECTILE && UseItem CHANGES
                }
                if (item.type == Gungnir)
                {
                    item.damage = 61;
                    //PROJECTILE CHANGES
                }
                if (item.type == LightDisc)
                {
                    /*item.maxStack = 1;
                    item.damage = 60;
                    item.useTime = item.useAnimation = 14;*/
                    //SHOOT && PROJECTILE CHANGES
                }
                if (item.type == DeathSickle)
                {
                    item.knockBack = 5f;
                }
                if (item.type == PaladinsHammer)
                {
                    item.autoReuse = true;
                }
                if (item.type == Keybrand)
                {
                    item.damage = 105;
                    item.crit = 13;
                    //ONHIT CHANGES
                }
                if (item.type == TheHorsemansBlade)
                {
                    item.damage = 150;
                    //ONHIT && PROJECTILE CHANGES
                }
                if (item.type == NorthPole)
                {
                    item.useTime = item.useAnimation = 30;
                    item.damage = 80;
                }
                if (item.type == InfluxWaver)
                {
                    item.damage = 100;
                    //PROJECTILE CHANGES
                }
                if (item.type == 3827)
                {
                    item.useTime = item.useAnimation = 20;
                    item.damage = 180;
                }
                if (item.type == StarWrath)
                {
                    item.damage = 170;
                }
                if (item.type == Meowmere)
                {
                    item.useTime = item.useAnimation = 14;
                }
                if (item.type == FlintlockPistol)
                {
                    item.damage = 13;
                    item.knockBack = 1f;
                }
                if (item.type == Musket)
                {
                    item.useTime = item.useAnimation = 32;
                    item.autoReuse = false;
                }
                if (item.type == TheUndertaker)
                {
                    item.damage = 22;
                    item.useTime = item.useAnimation = 20;
                    item.knockBack = 2f;
                }
                if (item.type == SpikyBall)
                {
                    item.damage = 16;
                }
                if (item.type == StarCannon)
                {
                    item.knockBack = 3f;
                }
                if (item.type == BeesKnees)
                {
                    item.useTime = item.useAnimation = 23;
                }
                if (item.type == Handgun)
                {
                    item.damage = 26;
                    item.useTime = item.useAnimation = 15;
                }
                if (item.type == PhoenixBlaster)
                {
                    item.damage = 33;
                    item.useTime = item.useAnimation = 17;
                }
                if (item.type == CobaltRepeater)
                {
                    item.damage = 35;
                    item.useTime = item.useAnimation = 23;
                }
                if (item.type == PalladiumRepeater)
                {
                    item.damage = 37;
                    item.useTime = item.useAnimation = 22;
                }
                if (item.type == MythrilRepeater)
                {
                    item.damage = 39;
                    item.useTime = item.useAnimation = 20;
                }
                if (item.type == OrichalcumRepeater)
                {
                    item.damage = 40;
                    item.useTime = item.useAnimation = 19;
                }
                if (item.type == AdamantiteRepeater)
                {
                    item.damage = 42;
                    item.useTime = item.useAnimation = 18;
                }
                if (item.type == TitaniumRepeater)
                {
                    item.damage = 43;
                    item.useTime = item.useAnimation = 17;
                }
                if (item.type == Marrow)
                {
                    item.damage = 53;
                    item.autoReuse = true;
                }
                if (item.type == IceBow)
                {
                    item.useTime = item.useAnimation = 14;
                }
                if (item.type == HallowedRepeater)
                {
                    item.damage = 50;
                    item.useTime = item.useAnimation = 17;
                }
                if (item.type == VenusMagnum)
                {
                    item.useTime = item.useAnimation = 9;
                    item.autoReuse = true;
                }
                if (item.type == RocketLauncher)
                {
                    item.damage = 55;
                }
                if (item.type == CursedDart)
                {
                    item.damage = 9;
                }
                if (item.type == IchorDart)
                {
                    item.damage = 10;
                }
                if (item.type == FrostburnArrow)
                {
                    item.damage = 7;
                }
                if (item.type == AmethystStaff)
                {
                    item.mana = 5;
                    item.damage = 15;
                    item.useTime = item.useAnimation = 37;
                }
                if (item.type == TopazStaff)
                {
                    item.mana = 5;
                    item.damage = 16;
                    item.useTime = item.useAnimation = 36;
                }
                if (item.type == SapphireStaff)
                {
                    item.mana = 6;
                    item.damage = 18;
                    item.autoReuse = true;
                }
                if (item.type == CrimsonRod)
                {
                    item.mana = 30;
                }
                if (item.type == BeeGun)
                {
                    item.knockBack = 0.25f;
                }
                if (item.type == MagicMissile)
                {
                    //item.damage = 35;
                }
                if (item.type == AquaScepter)
                {
                    item.damage = 27;
                    item.knockBack = 7f;
                    item.mana = 7;
                    item.shootSpeed = 12.5f;
                }
                if (item.type == MagicDagger)
                {
                    item.damage = 35;
                    item.autoReuse = true;
                    item.shootSpeed = 12f;
                }
                if (item.type == CursedFlames)
                {
                    item.damage = 55;
                }
                if (item.type == FlowerofFrost)
                {
                    //PROJECTILE CHANGES
                }
                if (item.type == GoldenShower)
                {
                    item.damage = 30;
                }
                if (item.type == MeteorStaff)
                {
                    item.mana = 9;
                }
                if (item.type == FrostStaff)
                {
                    item.useTime = item.useAnimation = 12;
                    //PROJECTILE CHANGES
                }
                if (item.type == ShadowFlameHexDoll)
                {
                    item.damage = 32;
                    //PROJECTILE CHANGES
                }
                if (item.type == NimbusRod)
                {
                    item.damage = 30;
                    item.mana = 30;
                }
                if (item.type == ClingerStaff)
                {
                    //PROJECTILE CHANGES
                }
                if (item.type == MagicalHarp)
                {
                    item.knockBack = 2f;
                }
                if (item.type == 3852)
                {
                    item.damage = 36;
                    //PROJECTILE CHANGES
                }
                if (item.type == WaspGun)
                {
                    item.knockBack = 0.25f;
                    //PROJECTILE CHANGES
                }
                if (item.type == LeafBlower)
                {
                    item.mana = 5;
                }
                if (item.type == InfernoFork)
                {
                    item.damage = 70;
                    item.knockBack = 5f;
                }
                if (item.type == ShadowbeamStaff)
                {
                    item.damage = 80;
                }
                if (item.type == ToxicFlask)
                {
                    item.damage = 52;
                    item.useTime = item.useAnimation = 45;
                    item.shootSpeed = 14f;
                }
                if (item.type == HeatRay)
                {
                    item.damage = 90;
                }
                if (item.type == BubbleGun)
                {
                    item.mana = 5;
                    item.shootSpeed = 15;
                }
                if (item.type == RazorbladeTyphoon)
                {
                    item.damage = 85;
                    item.mana = 20;
                }
                if (item.type == NebulaBlaze)
                {
                    item.knockBack = 3f;
                }
                if (item.type == LunarFlareBook)
                {
                    item.mana = 9;
                }
                if (item.type == LastPrism)
                {
                    item.knockBack = 0.25f;
                }
            }
        }
        public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Config)
            {
                if (item.type == 1264)
                {
                    target.AddBuff(44, 480);
                }
            }
        }
        public override int ChoosePrefix(Item item, Terraria.Utilities.UnifiedRandom rand)
        {
            if (Config)
            {
                int[] prefix = new int[] { //prefix ids
                81, 59, 4 , 37, 60,
                20, 55, 46, 2 , 44,
                38, 5 , 54, 3 , 1 ,
                61, 53, 6 , 42, 51,
                12, 57, 36, 45, 15,
                14, 49, 9 , 47, 40,
                10, 7 , 56, 48, 13,
                41, 11, 50, 8 , 39 };
                //int[] prefix2 = new int[] { 59, 37, 60, 55, 54, 38, 61, 53, 36, 40, 56, 41, 39 };
                if (item.type == 186 || item.type == 946)
                {
                    return rand.Next(prefix);
                }
                if (item.type == 561)
                {
                    //return rand.Next(prefix2);
                }
            }
            return base.ChoosePrefix(item, rand);
        }
        public override bool ConsumeAmmo(Item item, Player player)
        {
            if (Config)
            {
                if (item.type == 1553)
                {
                    return Main.rand.NextBool(3);
                }
            }
            return base.ConsumeAmmo(item, player);
        }
        public override void UseStyle(Item item, Player player)
        {
            if (Config)
            {
                if (item.type == 946)
                {
                    player.itemRotation = player.direction == 1 ? 1.575f : -1.575f;
                    player.itemLocation -= player.direction == 1 ? new Vector2(5, 25) : new Vector2(-5, 25);
                }
            }
        }
        public override void UseItemHitbox(Item item, Player player, ref Rectangle hitbox, ref bool noHitbox)
        {
            if (Config)
            {
                if (item.type == 946)
                    hitbox = new Rectangle(hitbox.X, (int)player.MountedCenter.Y - 20, hitbox.Width, hitbox.Height + 10);
            }
            base.UseItemHitbox(item, player, ref hitbox, ref noHitbox);
        }
        public override bool CanUseItem(Item item, Player player)
        {
            if (Config)
            {
                if (item.type == LightDisc)
                    return player.ownedProjectileCounts[item.shoot] < 6;
                //? doesnt work lol
            }
            return base.CanUseItem(item, player);
        }
        public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (item.type == 1306)
            {
                Vector2 vel = (player.MountedCenter - Main.MouseWorld) * -1;
                vel.Normalize();
                vel *= item.shootSpeed + 6;
                Projectile.NewProjectile(player.MountedCenter, vel, item.shoot, (int)(float)(item.damage * 0.5f), item.knockBack, player.whoAmI);
                return false;
            }
            else if (item.type == Meowmere)
            {
                Vector2 vel = (player.MountedCenter - Main.MouseWorld) * -1;
                vel.Normalize();
                vel *= item.shootSpeed;
                Projectile.NewProjectile(player.MountedCenter, vel, item.shoot, (int)((float)item.damage * 1.25f), item.knockBack, player.whoAmI);
                return false;
            }
            else if (item.type == StarWrath)
            {
                Vector2 vector17 = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY);
                float num41 = vector17.Y;
                if (num41 > player.Center.Y - 200f)
                {
                    num41 = player.Center.Y - 200f;
                }
                for (int num42 = 0; num42 < 3; num42++)
                {
                    Vector2 pointPoisition = player.Center + new Vector2(-Main.rand.Next(0, 401) * player.direction, -600f);
                    pointPoisition.Y -= 100 * num42;
                    Vector2 vector18 = vector17 - pointPoisition;
                    if (vector18.Y < 0f)
                    {
                        vector18.Y *= -1f;
                    }
                    if (vector18.Y < 20f)
                    {
                        vector18.Y = 20f;
                    }
                    vector18.Normalize();
                    vector18 *= item.shootSpeed;
                    float num2 = vector18.X;
                    float num3 = vector18.Y;
                    float speedX6 = num2;
                    float speedY8 = num3 + (float)Main.rand.Next(-40, 41) * 0.02f;
                    Projectile.NewProjectile(new Vector2(pointPoisition.X, pointPoisition.Y), new Vector2(speedX6, speedY8), item.shoot, (int)((float)item.damage * 1f), item.knockBack, player.whoAmI, 0f, num41);
                }
                return false;
            }
           /* else if (item.type == 3852)
            {
                float num2 = (float)Main.mouseX + Main.screenPosition.X - player.Center.X;
                float num3 = (float)Main.mouseY + Main.screenPosition.Y - player.Center.Y;
                if (player.altFunctionUse == 2)
                {
                    Projectile.NewProjectile(player.Center.X, player.Bottom.Y - 100f, (float)player.direction * item.shootSpeed, 0f, 704, (int)((float)item.damage * 1.75f), item.knockBack, player.whoAmI);
                }
                else
                {
                    Projectile.NewProjectile(player.Center.X, player.Center.Y, num2, num3, item.shoot, item.damage, item.knockBack, player.whoAmI);
                }
                return false;
            }*/
            return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        }
    }
}