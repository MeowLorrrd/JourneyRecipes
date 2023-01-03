using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

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
                switch (item.type)
                {
                    case 4:
                        item.damage = 12;
                        item.useTime = item.useAnimation = 20;
                        item.scale = 1.15f;
                        item.knockBack = 5.5f;
                        break;
                    case 24:
                        item.useTime = item.useAnimation = 20;
                        item.scale = 1;
                        item.knockBack = 5f;
                        break;
                    case 46:
                        item.damage = 18;
                        item.scale = 1.4f;
                        break;
                    case 55:
                        item.damage = 17;
                        item.useTime = item.useAnimation = 20;
                        break;
                    case 95:
                        item.damage = 13;
                        item.knockBack = 1f;
                        break;
                    case 96:
                        item.useTime = item.useAnimation = 32;
                        item.autoReuse = false;
                        break;
                    case 112:
                        item.mana = 12;
                        item.useTime = 16;
                        item.useAnimation = item.useTime;
                        break;
                    case 113:
                        //item.damage = 35;
                        break;
                    case 119:
                        item.damage = 49;
                        item.useTime = item.useAnimation = 20;
                        break;
                    case 121:
                        item.useTime = 30;
                        item.useAnimation = item.useTime;
                        item.damage = 40;
                        break;
                    case 127:
                        item.mana = 6;
                        item.damage = 17;
                        break;
                    case 154:
                        item.useAnimation = item.useTime;
                        break;
                    case 155:
                        item.damage = 26;
                        item.knockBack = 3f;
                        //item.damage = 24;
                        //Projectile??
                        break;
                    case 157:
                        item.damage = 27;
                        item.knockBack = 7f;
                        item.mana = 7;
                        item.shootSpeed = 12.5f;
                        break;
                    case 161:
                        item.damage = 16;
                        break;
                    case 164:
                        item.damage = 26;
                        item.useTime = item.useAnimation = 15;
                        break;
                    case 186:
                        item.damage = 10;
                        item.knockBack = 4f;
                        item.useTime = 27;
                        item.useAnimation = 27;
                        item.useStyle = 1;
                        item.melee = true;
                        break;
                    case 197:
                        item.knockBack = 3f;
                        break;
                    case 198:
                    case 199:
                    case 200:
                    case 201:
                    case 202:
                    case 203:
                        item.damage = 26;
                        item.useTime = item.useAnimation = 18;
                        break;
                    case 219:
                        item.damage = 33;
                        item.useTime = item.useAnimation = 17;
                        break;
                    case 234:
                        item.damage = 8;
                        break;
                    case 273:
                        item.autoReuse = true;
                        item.useTime = 21;
                        item.useAnimation = item.useTime;
                        break;
                    case 277:
                        item.damage = 14;
                        item.knockBack = 6f;
                        break;
                    case 281:
                        item.useTime = 25;
                        item.useAnimation = item.useTime;
                        break;
                    case 283:
                        item.damage = 4;
                        break;
                    case 284:
                        item.damage = 10;
                        item.useTime = item.useAnimation = 20;
                        break;
                    case 390:
                        item.damage = 45;
                        break;
                    case 406:
                        item.damage = 49;
                        break;
                    case 426:
                        item.damage = 70;
                        item.useTime = item.useAnimation = 35;
                        item.scale = 1.15f;
                        break;
                    case 434:
                        item.damage = 17;
                        break;
                    case 435:
                        item.damage = 35;
                        item.useTime = item.useAnimation = 23;
                        break;
                    case 436:
                        item.damage = 39;
                        item.useTime = item.useAnimation = 20;
                        break;
                    case 481:
                        item.damage = 42;
                        item.useTime = item.useAnimation = 18;
                        break;
                    case 482:
                        item.damage = 61;
                        item.useTime = item.useAnimation = 21;
                        item.scale = 1.25f;
                        break;
                    case 483:
                        item.damage = 40;
                        item.useTime = item.useAnimation = 19;
                        item.scale = 1.2f;
                        item.knockBack = 5f;
                        break;
                    case 484:
                        item.damage = 49;
                        item.damage = 50;
                        item.useTime = item.useAnimation = 20;
                        item.scale = 1.2f;
                        break;
                    case 494:
                        item.damage = 42;
                        item.knockBack = 2f;
                        item.mana = 5;
                        break;
                    case 518:
                        item.damage = 32;
                        item.mana = 5;
                        break;
                    case 506:
                        item.damage = 35;
                        break;
                    case 517:
                        item.damage = 35;
                        item.autoReuse = true;
                        item.shootSpeed = 12f;
                        break;
                    case 519:
                        item.damage = 55;
                        item.mana = 9;
                        item.useTime = 15;
                        item.useAnimation = item.useTime;
                        break;
                    case 537:
                        item.damage = 44;
                        break;
                    case 550:
                        item.damage = 61;
                        //PROJECTILE CHANGES
                        break;
                    case 561:
                        //  item.maxStack = 1;
                        //  item.damage = 60;
                        //  item.useTime = item.useAnimation = 14;
                        //SHOOT && PROJECTILE CHANGES
                        break;
                    case 578:
                        item.damage = 50;
                        item.useTime = item.useAnimation = 17;
                        break;
                    case 653:
                        item.damage = 11;
                        item.useTime = item.useAnimation = 19;
                        item.knockBack = 6f;
                        break;
                    case 656:
                        item.useTime = item.useAnimation = 19;
                        item.knockBack = 6f;
                        break;
                    case 659:
                        item.damage = 30;
                        item.useTime = item.useAnimation = 15;
                        item.autoReuse = true;
                        break;
                    case 670:
                        item.damage = 21;
                        item.useTime = item.useAnimation = 20;
                        break;
                    case 671:
                        item.damage = 105;
                        item.crit = 16;
                        //ONHIT CHANGES
                        break;
                    case 672:
                        item.damage = 53;
                        item.useTime = item.useAnimation = 16;
                        break;
                    case 682:
                        item.damage = 53;
                        item.autoReuse = true;
                        break;
                    case 683:
                        item.damage = 88;
                        break;
                    case 723:
                        item.scale = 1.3f;
                        item.useTime = 20;
                        item.useAnimation = item.useTime;
                        item.autoReuse = true;
                        item.useTurn = false;
                        //PROJECTILE && UseItem CHANGES
                        break;
                    case 725:
                        item.damage = 39;
                        item.autoReuse = true;
                        item.useTime = item.useAnimation = 14;
                        break;
                    case 726:
                        item.mana = 12;
                        item.useTime = item.useAnimation = 12;
                        break;
                    case 739:
                        item.mana = 5;
                        item.damage = 15;
                        item.useTime = item.useAnimation = 37;
                        break;
                    case 740:
                        item.mana = 5;
                        item.damage = 16;
                        item.useTime = item.useAnimation = 36;
                        break;
                    case 741:
                        item.mana = 6;
                        item.damage = 18;
                        item.autoReuse = true;
                        break;
                    case 758:
                        item.useTime = 20;
                        item.useAnimation = item.useTime;
                        break;
                    case 759:
                        item.damage = 55;
                        //PROJECTILE CHANGES
                        break;
                    case 788:
                        item.mana = 12;
                        item.damage = 35;
                        break;
                    case 800:
                        item.damage = 22;
                        item.useTime = item.useAnimation = 20;
                        item.knockBack = 2f;
                        break;
                    case 802:
                        item.damage = 17;
                        break;
                    case 881:
                        item.damage = 10;
                        item.useTime = item.useAnimation = 30;
                        break;
                    case 921:
                        item.damage = 11;
                        item.useTime = item.useAnimation = 19;
                        item.knockBack = 6f;
                        break;
                    case 946:
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
                        break;
                    case 988:
                        item.damage = 7;
                        break;
                    case 1121:
                        item.knockBack = 0.25f;
                        break;
                    case 1123:
                        item.damage = 30;
                        break;
                    case 1130:
                        item.damage = 12;
                        break;
                    case 1155:
                        item.knockBack = 0.25f;
                        item.shootSpeed = 9f;
                        //PROJECTILE CHANGES
                        break;
                    case 1166:
                        item.damage = 19;
                        item.scale = 1.2f;
                        item.knockBack = 5.5f;
                        break;
                    case 1178:
                        item.mana = 5;
                        break;
                    case 1179:
                        item.damage = 9;
                        break;
                    case 1185:
                        item.damage = 45;
                        item.damage = 49;
                        item.useTime = item.useAnimation = 22;
                        item.scale = 1.2f;
                        item.knockBack = 5.5f;
                        break;
                    case 1186:
                        item.damage = 44;
                        break;
                    case 1187:
                        item.damage = 37;
                        item.useTime = item.useAnimation = 22;
                        break;
                    case 1192:
                        item.damage = 59;
                        item.useTime = item.useAnimation = 22;
                        item.scale = 1.22f;
                        break;
                    case 1193:
                        item.damage = 46;
                        break;
                    case 1194:
                        item.damage = 40;
                        item.useTime = item.useAnimation = 19;
                        break;
                    case 1199:
                        item.damage = 61;
                        item.useTime = item.useAnimation = 20;
                        item.scale = 1.25f;
                        break;
                    case 1200:
                        item.damage = 48;
                        break;
                    case 1201:
                        item.damage = 43;
                        item.useTime = item.useAnimation = 17;
                        break;
                    case 1226:
                        item.damage = 95;
                        break;
                    case 1227:
                        item.damage = 57;
                        break;
                    case 1244:
                        item.damage = 30;
                        item.mana = 30;
                        break;
                    case 1255:
                        item.damage = 50;
                        item.useTime = item.useAnimation = 9;
                        item.autoReuse = true;
                        break;
                    case 1256:
                        item.mana = 30;
                        break;
                    case 1264:
                        item.damage = 60;
                        item.mana = 11;
                        item.useTime = item.useAnimation = 12;
                        item.shootSpeed = 9f;
                        break;
                    case 1295:
                        item.damage = 90;
                        item.useTime = item.useAnimation = 10;
                        break;
                    case 1297:
                        item.damage = 90;
                        break;
                    case 1302:
                        item.damage = 11;
                        break;
                    case 1304:
                        item.damage = 15;
                        item.useTime = item.useAnimation = 22;
                        item.scale = 1.2f;
                        item.knockBack = 5.5f;
                        break;
                    case 1306:
                        item.damage = 50;
                        item.shootSpeed = 12f;
                        break;
                    case 1324:
                        // item.maxStack = 1;
                        // item.damage = 45;
                        // item.value = Item.sellPrice(0, 12:;
                        break;
                    case 1325:
                        item.damage = 12;
                        break;
                    case 1327:
                        item.knockBack = 5f;
                        break;
                    case 1336:
                        item.damage = 30;
                        break;
                    case 1341:
                        item.damage = 19;
                        break;
                    case 1342:
                        item.damage = 15;
                        break;
                    case 1444:
                        item.damage = 80;
                        item.useTime = item.useTime = 15;
                        break;
                    case 1445:
                        item.damage = 70;
                        item.knockBack = 5f;
                        break;
                    case 1446:
                        item.damage = 65;
                        item.mana = 15;
                        break;
                    case 1513:
                        item.autoReuse = true;
                        break;
                    case 1553:
                        item.damage = 85;
                        break;
                    case 1571:
                        item.damage = 70;
                        break;
                    case 1784:
                        item.useTime = item.useAnimation = 25;
                        break;
                    case 1785:
                        item.damage = 60;
                        break;
                    case 1802://Raven Staff, double projectile speed in GlobalProjectile
                        item.damage = 55;
                        break;
                    case 1825:
                        item.damage = 20;
                        break;
                    case 1826:
                        item.damage = 150;
                        //ONHIT && PROJECTILE CHANGES
                        break;
                    case 1827:
                        item.damage = 14;
                        break;
                    case 1835:
                        item.useTime = item.useAnimation = 12;
                        break;
                    case 1909:
                        item.damage = 19;
                        break;
                    case 1910:
                        item.damage = 60;
                        break;
                    case 1918:
                        item.damage = 19;
                        break;
                    case 1947:
                        item.useTime = item.useAnimation = 30;
                        item.damage = 80;
                        break;
                    case 2223:
                        item.damage = 85;
                        item.useTime = item.useAnimation = 20;
                        break;
                    case 2273:
                        item.damage = 18;
                        item.useTime = item.useAnimation = 20;
                        item.scale = 1.1f;
                        break;
                    case 2330:
                        item.damage = 35;
                        item.knockBack = 8f;
                        break;
                    case 2364:
                        item.damage = 12;
                        break;
                    case 2424:
                        item.damage = 70;
                        item.useTime = item.useAnimation = 20;
                        item.knockBack = 8f;
                        break;
                    case 2517:
                        item.useTime = item.useAnimation = 19;
                        item.knockBack = 6f;
                        break;
                    case 2608:
                        item.damage = 25;
                        item.useTime = item.useAnimation = 20;
                        item.scale = 1.175f;
                        break;
                    case 2622:
                        item.damage = 85;
                        item.useTime = item.useAnimation = 40;
                        item.mana = 20;
                        break;
                    case 2623:
                        item.mana = 5;
                        item.shootSpeed = 15;
                        break;
                    case 2750:
                        item.mana = 9;
                        break;
                    case 2880:
                        item.damage = 100;
                        //PROJECTILE CHANGES
                        break;
                    case 2888:
                        item.damage = 23;
                        item.useTime = item.useAnimation = 23;
                        break;
                    case 3003:
                        item.damage = 8;
                        break;
                    case 3009:
                        item.damage = 14;
                        break;
                    case 3010:
                        item.damage = 9;
                        break;
                    case 3011:
                        item.damage = 10;
                        break;
                    case 3012:
                        item.damage = 59;
                        item.shootSpeed = 9f;
                        //PROJECTILE CHANGES?
                        break;
                    case 3014:
                        //PROJECTILE CHANGES
                        break;
                    case 3019:
                        item.damage = 22;
                        item.knockBack = 5.5f;
                        item.useTime = item.useAnimation = 13;
                        break;
                    case 3029://Daedalus Stormbow, shoot 20% slower while using Holy, Unholy, Hellfire, Jester arrows
                        item.damage = 38;
                        break;
                    case 3051:
                        item.damage = 25;
                        break;
                    case 3053:
                        item.damage = 32;
                        //PROJECTILE CHANGES
                        break;
                    case 3063:
                        item.useTime = item.useAnimation = 14;
                        break;
                    case 3065:
                        item.damage = 170;
                        break;
                    case 3069:
                        item.damage = 14;
                        item.crit = 10;
                        item.useTime = item.useAnimation = 26;
                        break;
                    case 3105:
                        item.damage = 52;
                        item.useTime = item.useAnimation = 45;
                        item.shootSpeed = 14f;
                        break;
                    case 3210:
                        item.useTime = item.useAnimation = 10;
                        break;
                    case 3258:
                        item.damage = 55;
                        item.useTime = item.useAnimation = 20;
                        break;
                    case 3281:
                        item.damage = 18;
                        break;
                    case 3284:
                        item.damage = 54;
                        break;
                    case 3291:
                        item.damage = 95;
                        item.crit = 10;
                        break;
                    case 3315:
                        item.damage = 39;
                        break;
                    case 3316:
                        item.damage = 49;
                        break;
                    case 3317:
                        item.damage = 28;
                        break;
                    case 3378:
                        item.damage = 20;
                        break;
                    case 3484:
                        item.damage = 16;
                        item.useTime = item.useAnimation = 17;
                        item.scale = 1.25f;
                        item.knockBack = 6.5f;
                        break;
                    case 3490:
                        item.damage = 14;
                        item.useTime = item.useAnimation = 19;
                        item.scale = 1.2f;
                        item.knockBack = 6f;
                        break;
                    case 3496:
                        item.damage = 13;
                        item.useTime = item.useAnimation = 20;
                        item.scale = 1.15f;
                        item.knockBack = 5.5f;
                        break;
                    case 3502:
                        item.damage = 10;
                        item.useTime = item.useAnimation = 20;
                        item.scale = 1.1f;
                        break;
                    case 3508:
                        item.damage = 9;
                        item.useTime = item.useAnimation = 21;
                        item.scale = 1.1f;
                        break;
                    case 3514:
                        item.damage = 14;
                        item.useTime = item.useAnimation = 20;
                        item.scale = 1.2f;
                        item.knockBack = 6f;
                        break;
                    case 3520:
                        item.damage = 15;
                        item.useTime = item.useAnimation = 18;
                        item.scale = 1.25f;
                        item.knockBack = 6.5f;
                        break;
                    case 3541:
                        item.knockBack = 0.25f;
                        break;
                    case 3542:
                        item.mana = 12;
                        item.useTime = item.useAnimation = 12;
                        item.knockBack = 3f;
                        break;
                    case 3764:
                    case 3765:
                    case 3766:
                    case 3767:
                    case 3768:
                    case 3769:
                        item.damage = 48;
                        item.useTime = item.useAnimation = 16;
                        //RECIPE CHANGES
                        break;
                    case 3570:
                        item.mana = 9;
                        break;
                    case 3772:
                        item.damage = 16;
                        item.scale = 1.1f;
                        break;
                    case 3779:
                        item.mana = 14;
                        item.useTime = item.useAnimation = 22;
                        break;
                    case 3787:
                        item.mana = 17;
                        break;
                    case 3788:
                        item.damage = 24;
                        item.useTime = item.useAnimation = 48;
                        break;
                    case 3823:
                        item.damage = 85;
                        item.scale = 1.13f;
                        item.useTime = item.useAnimation = 20;
                        break;
                    case 3827:
                        item.useTime = item.useAnimation = 20;
                        item.damage = 180;
                        break;
                    case 3835:
                        item.damage = 50;
                        //item.scale = 1.35f;
                        break;
                    case 3852:
                        item.damage = 36;
                        item.useTime = item.useAnimation = 25;
                        item.autoReuse = true;
                        //PROJECTILE CHANGES
                        break;
                    case 3854:
                        item.damage = 32;
                        item.useTime = item.useAnimation = 18;
                        break;
                    case 3858:
                        item.damage = 140;
                        break;
                    case 3870:
                        item.damage = 100;
                        break;
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
        public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (item.type == 1156)
            {
                for (int num130 = 0; num130 < 3; num130++)
                {
                    Vector2 vel = (player.MountedCenter - Main.MouseWorld) * -1;
                    vel.Normalize();
                    vel *= item.shootSpeed;
                    vel += new Vector2((float)Main.rand.Next(-40, 41) * 0.05f, (float)Main.rand.Next(-40, 41) * 0.05f);
                    Projectile.NewProjectile(player.Center.X, player.Center.Y, vel.X, vel.Y, item.shoot, item.damage, item.knockBack, player.whoAmI);
                }
                return false;
            }
            else if (item.type == 1306)
            {
                Vector2 vel = (player.MountedCenter - Main.MouseWorld) * -1;
                vel.Normalize();
                vel *= item.shootSpeed + 6;
                Projectile.NewProjectile(player.MountedCenter, vel, item.shoot, (int)(float)(item.damage * 0.5f), item.knockBack, player.whoAmI);
                return false;
            }
            else if (item.type == 3063)
            {
                Vector2 vel = (player.MountedCenter - Main.MouseWorld) * -1;
                vel.Normalize();
                vel *= item.shootSpeed;
                Projectile.NewProjectile(player.MountedCenter, vel, item.shoot, (int)((float)item.damage * 1.25f), item.knockBack, player.whoAmI);
                return false;
            }
            else if (item.type == 3065)
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