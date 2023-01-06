using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using JourneyRecipes.Items;
using static Terraria.ModLoader.ModContent;
using Terraria.Localization;

namespace JourneyRecipes
{
    public class JourneyRecipes : Mod
    {
        internal JourneyRecipes instance;
        public override uint ExtraPlayerBuffSlots => (uint)(GetInstance<JourneyRecipesServerConfig>().AllowBuffStat ? 44 : 22);
        public override void AddRecipes()//the actual focus of this mod, just ctrl+c ctrl+v
        {
            base.AddRecipes();
            if (!Main.dedServ)
            {
                RecipeGroup IceBlockRecipeGroup = new RecipeGroup(() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.IceBlock)}", new int[]
                {
                    ItemID.IceBlock, ItemID.PinkIceBlock, ItemID.PurpleIceBlock, ItemID.RedIceBlock
                });
                RecipeGroup.RegisterGroup("JourneyRecipes:IceBlockRecipeGroup", IceBlockRecipeGroup);
                if (GetInstance<Config>().allowToolRecipes)
                {
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            switch (recipe.createItem.type)
                            {
                                case ItemID.CopperPickaxe:
                                    editor.SetIngredientStack(ItemID.Wood, 3);
                                    editor.SetIngredientStack(ItemID.CopperBar, 8);
                                    break;
                                case ItemID.CopperAxe:
                                    editor.SetIngredientStack(ItemID.CopperBar, 6);
                                    break;
                                case ItemID.CopperHammer:
                                    editor.SetIngredientStack(ItemID.CopperBar, 8);
                                    break;
                                case ItemID.TinPickaxe:
                                case ItemID.TinHammer:
                                    editor.SetIngredientStack(ItemID.TinBar, 8);
                                    break;
                                case ItemID.TinAxe:
                                    editor.SetIngredientStack(ItemID.TinBar, 6);
                                    break;
                                case ItemID.IronPickaxe:
                                    editor.SetIngredientStack(ItemID.IronBar, 10);
                                    break;
                                case ItemID.IronAxe:
                                case ItemID.IronHammer:
                                    editor.SetIngredientStack(ItemID.IronBar, 8);
                                    break;
                                case ItemID.LeadPickaxe:
                                    editor.SetIngredientStack(ItemID.LeadBar, 10);
                                    break;
                                case ItemID.LeadAxe:
                                case ItemID.LeadHammer:
                                    editor.SetIngredientStack(ItemID.LeadBar, 8);
                                    break;
                                case ItemID.SilverPickaxe:
                                    editor.SetIngredientStack(ItemID.SilverBar, 10);
                                    break;
                                case ItemID.SilverAxe:
                                case ItemID.SilverHammer:
                                    editor.SetIngredientStack(ItemID.SilverBar, 8);
                                    break;
                                case ItemID.TungstenPickaxe:
                                    editor.SetIngredientStack(ItemID.TungstenBar, 10);
                                    break;
                                case ItemID.TungstenAxe:
                                case ItemID.TungstenHammer:
                                    editor.SetIngredientStack(ItemID.TungstenBar, 8);
                                    break;
                                case ItemID.GoldPickaxe:
                                    editor.SetIngredientStack(ItemID.GoldBar, 10);
                                    break;
                                case ItemID.GoldAxe:
                                case ItemID.GoldHammer:
                                    editor.SetIngredientStack(ItemID.GoldBar, 8);
                                    break;
                                case ItemID.PlatinumPickaxe:
                                    editor.SetIngredientStack(ItemID.PlatinumBar, 10);
                                    break;
                                case ItemID.PlatinumAxe:
                                case ItemID.PlatinumHammer:
                                    editor.SetIngredientStack(ItemID.PlatinumBar, 8);
                                    break;
                            }
                        }
                    }
                }
                if (GetInstance<Config>().allowWeaponRecipe)
                {
                    ModRecipe r = new ModRecipe(this);
                    r.AddIngredient(ItemID.MusketBall, 70);
                    r.AddIngredient(ItemID.TungstenBar);
                    r.AddTile(TileID.Anvils);
                    r.SetResult(ItemID.SilverBullet, 70);
                    r.AddRecipe();
                    r = new ModRecipe(this);
                    r.AddIngredient(ItemID.WoodenBoomerang);
                    r.AddIngredient(ItemID.FallenStar);
                    r.SetResult(ItemID.EnchantedBoomerang);
                    r.AddRecipe();
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            switch (recipe.createItem.type)
                            {
                                case ItemID.CopperBroadsword:
                                    editor.SetIngredientStack(ItemID.CopperBar, 6);
                                    break;
                                case ItemID.CopperShortsword:
                                    editor.SetIngredientStack(ItemID.CopperBar, 5);
                                    break;
                                case ItemID.TinBroadsword:
                                    editor.SetIngredientStack(ItemID.TinBar, 6);
                                    break;
                                case ItemID.TinShortsword:
                                    editor.SetIngredientStack(ItemID.TinBar, 5);
                                    break;
                                case ItemID.IronShortsword:
                                    editor.SetIngredientStack(ItemID.IronBar, 6);
                                    break;
                                case ItemID.LeadShortsword:
                                    editor.SetIngredientStack(ItemID.LeadBar, 6);
                                    break;
                                case ItemID.GoldShortsword:
                                    editor.SetIngredientStack(ItemID.GoldBar, 6);
                                    break;
                                case ItemID.PlatinumShortsword:
                                    editor.SetIngredientStack(ItemID.PlatinumBar, 6);
                                    break;
                                case ItemID.JungleYoyo:
                                    editor.SetIngredientStack(ItemID.Stinger, 12);
                                    editor.SetIngredientStack(ItemID.JungleSpores, 9);
                                    break;
                                case ItemID.BluePhasesaber:
                                case ItemID.GreenPhasesaber:
                                case ItemID.PurplePhasesaber:
                                case ItemID.RedPhasesaber:
                                case ItemID.WhitePhasesaber:
                                case ItemID.YellowPhasesaber:
                                    editor.SetIngredientStack(ItemID.CrystalShard, 25);
                                    break;
                                case ItemID.CobaltSword:
                                    editor.SetIngredientStack(ItemID.CobaltBar, 8);
                                    break;
                                case ItemID.PalladiumSword:
                                    editor.SetIngredientStack(ItemID.PalladiumBar, 10);
                                    break;
                                case ItemID.MythrilSword:
                                    editor.SetIngredientStack(ItemID.MythrilBar, 8);
                                    break;
                                case ItemID.OrichalcumSword:
                                    editor.SetIngredientStack(ItemID.OrichalcumBar, 10);
                                    break;
                            }
                        }
                    }
                }
                if (GetInstance<Config>().allowArmorRecipes)
                {
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            switch (recipe.createItem.type)
                            {
                                case ItemID.CopperHelmet:
                                    editor.SetIngredientStack(ItemID.CopperBar, 12);
                                    break;
                                case ItemID.CopperChainmail:
                                    editor.SetIngredientStack(ItemID.CopperBar, 20);
                                    break;
                                case ItemID.CopperGreaves:
                                    editor.SetIngredientStack(ItemID.CopperBar, 16);
                                    break;
                                case ItemID.TinHelmet:
                                    editor.SetIngredientStack(ItemID.TinBar, 12);
                                    break;
                                case ItemID.TinChainmail:
                                    editor.SetIngredientStack(ItemID.TinBar, 20);
                                    break;
                                case ItemID.TinGreaves:
                                    editor.SetIngredientStack(ItemID.TinBar, 16);
                                    break;
                                case ItemID.IronHelmet:
                                    editor.SetIngredientStack(ItemID.IronBar, 15);
                                    break;
                                case ItemID.IronChainmail:
                                    editor.SetIngredientStack(ItemID.IronBar, 25);
                                    break;
                                case ItemID.IronGreaves:
                                    editor.SetIngredientStack(ItemID.IronBar, 20);
                                    break;
                                case ItemID.LeadHelmet:
                                    editor.SetIngredientStack(ItemID.LeadBar, 15);
                                    break;
                                case ItemID.LeadChainmail:
                                    editor.SetIngredientStack(ItemID.LeadBar, 25);
                                    break;
                                case ItemID.LeadGreaves:
                                    editor.SetIngredientStack(ItemID.LeadBar, 20);
                                    break;
                                case ItemID.SilverHelmet:
                                    editor.SetIngredientStack(ItemID.SilverBar, 15);
                                    break;
                                case ItemID.SilverChainmail:
                                    editor.SetIngredientStack(ItemID.SilverBar, 25);
                                    break;
                                case ItemID.SilverGreaves:
                                    editor.SetIngredientStack(ItemID.SilverBar, 20);
                                    break;
                                case ItemID.TungstenHelmet:
                                    editor.SetIngredientStack(ItemID.TungstenBar, 15);
                                    break;
                                case ItemID.TungstenChainmail:
                                    editor.SetIngredientStack(ItemID.TungstenBar, 25);
                                    break;
                                case ItemID.TungstenGreaves:
                                    editor.SetIngredientStack(ItemID.TungstenBar, 20);
                                    break;
                                case ItemID.GoldHelmet:
                                    editor.SetIngredientStack(ItemID.GoldBar, 20);
                                    break;
                                case ItemID.GoldChainmail:
                                    editor.SetIngredientStack(ItemID.GoldBar, 30);
                                    break;
                                case ItemID.GoldGreaves:
                                    editor.SetIngredientStack(ItemID.GoldBar, 25);
                                    break;
                                case ItemID.PlatinumHelmet:
                                    editor.SetIngredientStack(ItemID.PlatinumBar, 20);
                                    break;
                                case ItemID.PlatinumChainmail:
                                    editor.SetIngredientStack(ItemID.PlatinumBar, 30);
                                    break;
                                case ItemID.PlatinumGreaves:
                                    editor.SetIngredientStack(ItemID.PlatinumBar, 25);
                                    break;
                            }
                        }
                    }
                }
                #region Accessory Recipe
                if (GetInstance<Config>().allowAccessoryRecipe)
                {
                    ModRecipe r = new ModRecipe(this);
                    r.AddIngredient(ItemID.PanicNecklace);
                    r.AddIngredient(ItemID.ManaCrystal);
                    r.AddTile(TileID.TinkerersWorkbench);
                    r.SetResult(ItemID.BandofStarpower);
                    r.AddRecipe();
                    r = new ModRecipe(this);
                    r.AddIngredient(ItemID.BandofStarpower);
                    r.AddIngredient(ItemID.LifeCrystal);
                    r.AddTile(TileID.TinkerersWorkbench);
                    r.SetResult(ItemID.PanicNecklace);
                    r.AddRecipe();
                    r = new ModRecipe(this);
                    r.AddIngredient(ItemID.CloudinaBottle);
                    r.AddIngredient(3783);
                    r.AddTile(TileID.CrystalBall);
                    r.SetResult(ItemID.SandstorminaBottle);
                    r.AddRecipe();
                    r = new ModRecipe(this);
                    r.AddIngredient(ItemID.CloudinaBottle);
                    r.AddIngredient(2161);
                    r.AddTile(TileID.CrystalBall);
                    r.SetResult(ItemID.BlizzardinaBottle);
                    r.AddRecipe();
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            switch (recipe.createItem.type)
                            {
                                case ItemID.LavaWaders:
                                    editor.AddIngredient(ItemID.ObsidianRose);
                                    break;
                                case ItemID.FairyWings:
                                    editor.SetIngredientStack(ItemID.PixieDust, 99);
                                    break;
                                case ItemID.DemonWings:
                                    editor.SetIngredientStack(ItemID.SoulofNight, 15);
                                    break;
                                case ItemID.AngelWings:
                                    editor.SetIngredientStack(ItemID.SoulofLight, 15);
                                    break;
                            }
                        }
                    }
                }
                #endregion
                #region Bar Recipe
                if (GetInstance<Config>().allowBarRecipes)
                {
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            switch (recipe.createItem.type)
                            {
                                case ItemID.AdamantiteBar:
                                    editor.SetIngredientStack(ItemID.AdamantiteOre, 4);
                                    break;
                                case ItemID.TitaniumBar:
                                    editor.SetIngredientStack(ItemID.TitaniumOre, 4);
                                    break;
                                case ItemID.ChlorophyteBar:
                                    editor.SetIngredientStack(ItemID.ChlorophyteOre, 5);
                                    break;
                            }
                        }
                    }
                }
                #endregion
                #region Dye Recipe
                if (GetInstance<Config>().allowDyeRecipes)
                {
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            switch (recipe.createItem.type)
                            {
                                case ItemID.RedDye:
                                    editor.SetResult(ItemID.RedDye, 2);
                                    break;
                                case ItemID.OrangeDye:
                                    editor.SetResult(ItemID.OrangeDye, 2);
                                    break;
                                case ItemID.YellowDye:
                                    editor.SetResult(ItemID.YellowDye, 2);
                                    break;
                                case ItemID.LimeDye:
                                    editor.SetResult(ItemID.LimeDye, 2);
                                    break;
                                case ItemID.GreenDye:
                                    editor.SetResult(ItemID.GreenDye, 2);
                                    break;
                                case ItemID.TealDye:
                                    editor.SetResult(ItemID.TealDye, 2);
                                    break;
                                case ItemID.CyanDye:
                                    editor.SetResult(ItemID.CyanDye, 2);
                                    break;
                                case ItemID.SkyBlueDye:
                                    editor.SetResult(ItemID.SkyBlueDye, 2);
                                    break;
                                case ItemID.BlueDye:
                                    editor.SetResult(ItemID.BlueDye, 2);
                                    break;
                                case ItemID.PurpleDye:
                                    editor.SetResult(ItemID.PurpleDye, 2);
                                    break;
                                case ItemID.VioletDye:
                                    editor.SetResult(ItemID.VioletDye, 2);
                                    break;
                                case ItemID.PinkDye:
                                    editor.SetResult(ItemID.PinkDye, 2);
                                    break;
                                case ItemID.BlackDye:
                                    editor.SetResult(ItemID.BlackDye, 2);
                                    break;
                            }
                        }
                    }
                }
                #endregion 
                #region Platform Recipe
                if (GetInstance<Config>().allowPlatformRecipes)
                {
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            for (int num = 0; num < Recipe.maxRequirements; num++)
                            {
                                switch (recipe.createItem.type)
                                {
                                    case ItemID.BonePlatform:
                                        editor.DeleteTile(TileID.BoneWelder);
                                        break;
                                    case ItemID.Bone:
                                        if (recipe.requiredItem[num].type == ItemID.BonePlatform)
                                        {
                                            editor.DeleteTile(TileID.BoneWelder);
                                        }
                                        break;
                                    case ItemID.HoneyPlatform:
                                        editor.DeleteTile(TileID.HoneyDispenser);
                                        break;
                                    case ItemID.HoneyBlock:
                                        if (recipe.requiredItem[num].type == ItemID.HoneyPlatform)
                                        {
                                            editor.DeleteTile(TileID.HoneyDispenser);
                                        }
                                        break;
                                    case ItemID.SkywarePlatform:
                                        editor.DeleteTile(TileID.SkyMill);
                                        break;
                                    case ItemID.SunplateBlock:
                                        if (recipe.requiredItem[num].type == ItemID.SkywarePlatform)
                                        {
                                            editor.DeleteTile(TileID.SkyMill);
                                        }
                                        break;
                                    case ItemID.SteampunkPlatform:
                                        editor.DeleteTile(TileID.SteampunkBoiler);
                                        break;
                                    case ItemID.Cog:
                                        if (recipe.requiredItem[num].type == ItemID.SteampunkPlatform)
                                        {
                                            editor.DeleteTile(TileID.SteampunkBoiler);
                                        }
                                        break;
                                    case ItemID.CactusPlatform:
                                        editor.DeleteTile(TileID.WorkBenches);
                                        break;
                                    case ItemID.Cactus:
                                        if (recipe.requiredItem[num].type == ItemID.CactusPlatform)
                                        {
                                            editor.DeleteTile(TileID.WorkBenches);
                                        }
                                        break;
                                    case ItemID.GlassPlatform:
                                        editor.DeleteTile(TileID.WorkBenches);
                                        break;
                                    case ItemID.Glass:
                                        if (recipe.requiredItem[num].type == ItemID.GlassPlatform)
                                        {
                                            editor.DeleteTile(TileID.WorkBenches);
                                        }
                                        break;
                                    case ItemID.MushroomPlatform:
                                        editor.DeleteTile(TileID.WorkBenches);
                                        break;
                                    case ItemID.GlowingMushroom:
                                        if (recipe.requiredItem[num].type == ItemID.MushroomPlatform)
                                        {
                                            editor.DeleteTile(TileID.WorkBenches);
                                        }
                                        break;
                                    case ItemID.PumpkinPlatform:
                                        editor.DeleteTile(TileID.WorkBenches);
                                        break;
                                    case ItemID.Pumpkin:
                                        if (recipe.requiredItem[num].type == ItemID.PumpkinPlatform)
                                        {
                                            editor.DeleteTile(TileID.WorkBenches);
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
                #endregion
                #region Tile Recipe
                if (GetInstance<Config>().allowTileRecipes)
                {
                    ModRecipe r = new ModRecipe(this);
                    r.AddIngredient(ItemID.SandBlock);
                    r.AddIngredient(ItemID.StoneBlock);
                    r.AddTile(TileID.Solidifier);
                    r.SetResult(ItemID.Sandstone);
                    r.AddRecipe();
                    r = new ModRecipe(this);
                    r.AddIngredient(ItemID.SandBlock);
                    r.AddIngredient(ItemID.DirtBlock);
                    r.AddTile(TileID.Solidifier);
                    r.SetResult(ItemID.HardenedSand);
                    r.AddRecipe();
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            switch (recipe.createItem.type)
                            {
                                case ItemID.Boulder:
                                    editor.DeleteTile(TileID.TinkerersWorkbench);
                                    editor.AddTile(TileID.HeavyWorkBench);
                                    break;
                                case ItemID.ClayPot:
                                    editor.SetIngredientStack(ItemID.ClayBlock, 5);
                                    break;
                                case ItemID.CobaltBrick:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.CobaltBrick, 5);
                                    break;
                                case ItemID.PalladiumColumn:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.PalladiumColumn, 5);
                                    break;
                                case ItemID.MythrilBrick:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.MythrilBrick, 5);
                                    break;
                                case ItemID.BubblegumBlock:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.BubblegumBlock, 5);
                                    break;
                                case ItemID.AdamantiteBeam:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.AdamantiteBeam, 5);
                                    break;
                                case ItemID.TitanstoneBlock:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.TitanstoneBlock, 5);
                                    break;
                                case ItemID.ChlorophyteBrick:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.ChlorophyteBrick, 5);
                                    break;
                                case ItemID.CopperBrick:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.CopperBrick, 5);
                                    break;
                                case ItemID.TinBrick:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.TinBrick, 5);
                                    break;
                                case ItemID.TungstenBrick:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.TungstenBrick, 5);
                                    break;
                                case ItemID.SilverBrick:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.SilverBrick, 5);
                                    break;
                                case ItemID.GoldBrick:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.GoldBrick, 5);
                                    break;
                                case ItemID.PlatinumBrick:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.PlatinumBrick, 5);
                                    break;
                                case ItemID.MeteoriteBrick:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.MeteoriteBrick, 5);
                                    break;
                                case ItemID.CopperPlating:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.CopperPlating, 5);
                                    break;
                                case ItemID.TinPlating:
                                    editor.SetIngredientStack(ItemID.StoneBlock, 5);
                                    editor.SetResult(ItemID.TinPlating, 5);
                                    break;
                                case ItemID.SpookyBed:
                                case ItemID.SpookyPiano:
                                case ItemID.PumpkinBed:
                                case ItemID.PumpkinPiano:
                                case ItemID.PumpkinBookcase:
                                case ItemID.CactusBed:
                                case ItemID.CactusPiano:
                                case ItemID.CactusBookcase:
                                    editor.DeleteTile(TileID.WorkBenches);
                                    editor.AddTile(TileID.Sawmill);
                                    break;
                                case ItemID.CactusChandelier:
                                case ItemID.SpookyChandelier:
                                    editor.DeleteTile(TileID.WorkBenches);
                                    editor.AddTile(TileID.Anvils);
                                    break;
                            }
                        }
                    }
                }
                #endregion
                #region Torch Recipe
                if (GetInstance<Config>().allowTorchRecipes)
                {
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            switch (recipe.createItem.type)
                            {
                                case ItemID.BlueTorch:
                                    editor.SetIngredientStack(ItemID.Torch, 10);
                                    editor.SetResult(ItemID.BlueTorch, 10);
                                    break;
                                case ItemID.GreenTorch:
                                    editor.SetIngredientStack(ItemID.Torch, 10);
                                    editor.SetResult(ItemID.GreenTorch, 10);
                                    break;
                                case ItemID.OrangeTorch:
                                    editor.SetIngredientStack(ItemID.Torch, 10);
                                    editor.SetResult(ItemID.OrangeTorch, 10);
                                    break;
                                case ItemID.PurpleTorch:
                                    editor.SetIngredientStack(ItemID.Torch, 10);
                                    editor.SetResult(ItemID.PurpleTorch, 10);
                                    break;
                                case ItemID.RedTorch:
                                    editor.SetIngredientStack(ItemID.Torch, 10);
                                    editor.SetResult(ItemID.RedTorch, 10);
                                    break;
                                case ItemID.WhiteTorch:
                                    editor.SetIngredientStack(ItemID.Torch, 10);
                                    editor.SetResult(ItemID.WhiteTorch, 10);
                                    break;
                                case ItemID.YellowTorch:
                                    editor.SetIngredientStack(ItemID.Torch, 10);
                                    editor.SetResult(ItemID.YellowTorch, 10);
                                    break;
                            }
                            if (recipe.createItem.type == ItemID.IceTorch)
                            {
                                editor.AcceptRecipeGroup("JourneyRecipes:IceBlockRecipeGroup");
                            }
                        }
                    }
                }
                #endregion
                #region Chest Recipe
                if (GetInstance<Config>().allowChestRecipes)
                {
                    ModRecipe FrozenChest = new ModRecipe(this);
                    FrozenChest.AddIngredient(ItemID.IceBlock, 8);
                    FrozenChest.AddRecipeGroup("IronBar", 2);
                    FrozenChest.AddTile(TileID.IceMachine);
                    FrozenChest.SetResult(ItemID.IceChest);
                    FrozenChest.AddRecipe();

                    ModRecipe SkywareChest = new ModRecipe(this);
                    SkywareChest.AddIngredient(ItemID.SunplateBlock, 8);
                    SkywareChest.AddRecipeGroup("IronBar", 2);
                    SkywareChest.AddTile(TileID.SkyMill);
                    SkywareChest.SetResult(ItemID.SkywareChest);
                    SkywareChest.AddRecipe();

                    ModRecipe LihzahrdChest = new ModRecipe(this);
                    LihzahrdChest.AddIngredient(ItemID.LihzahrdBrick, 8);
                    LihzahrdChest.AddRecipeGroup("IronBar", 2);
                    LihzahrdChest.AddTile(TileID.LihzahrdFurnace);
                    LihzahrdChest.SetResult(ItemID.LihzahrdChest);
                    LihzahrdChest.AddRecipe();

                    ModRecipe LivingWoodChest = new ModRecipe(this);
                    LivingWoodChest.AddIngredient(ItemID.Wood, 8);
                    LivingWoodChest.AddRecipeGroup("IronBar", 2);
                    LivingWoodChest.AddTile(TileID.LivingLoom);
                    LivingWoodChest.SetResult(ItemID.LivingWoodChest);
                    LivingWoodChest.AddRecipe();
                }
                #endregion
                #region Terra Blade Recipe
                if (GetInstance<Config>().TerraBladeStuffRecipes)
                {
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            for (int num = 0; num < Recipe.maxRequirements; num++)
                            {
                                switch (recipe.createItem.type)
                                {

                                    case ItemID.TrueExcalibur:
                                        editor.DeleteIngredient(ItemID.BrokenHeroSword);
                                        editor.AddIngredient(ItemID.ChlorophyteBar, 24);
                                        break;
                                    case ItemID.TrueNightsEdge:
                                        editor.DeleteIngredient(ItemID.BrokenHeroSword);
                                        editor.AddIngredient(ItemID.SoulofFright, 20);
                                        editor.AddIngredient(ItemID.SoulofMight, 20);
                                        editor.AddIngredient(ItemID.SoulofSight, 20);
                                        break;
                                    case ItemID.TerraBlade:
                                        if (recipe.requiredItem[num].type == ItemID.TrueExcalibur && recipe.requiredItem[num].type == ItemID.TrueNightsEdge)
                                        {
                                            editor.AddIngredient(ItemID.BrokenHeroSword);
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
                #endregion
                #region Throwing Stuff
                if (GetInstance<Config>().AllowThrowingToRangedRecipes)
                {
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            switch (recipe.createItem.type)
                            {
                                case ItemID.FossilHelm:
                                    editor.SetIngredientStack(ItemID.FossilOre, 15);
                                    break;
                                case ItemID.FossilShirt:
                                    editor.SetIngredientStack(ItemID.FossilOre, 25);
                                    break;
                                case ItemID.FossilPants:
                                    editor.SetIngredientStack(ItemID.FossilOre, 20);
                                    break;
                                case ItemID.BoneJavelin:
                                    editor.SetResult(ItemID.BoneJavelin, 20);
                                    break;
                                case ItemID.BoneDagger:
                                    editor.SetResult(ItemID.BoneDagger, 30);
                                    break;
                            }
                        }
                    }
                }
                #endregion
                #region Potion Recipe
                if (GetInstance<Config>().allowBuffRecipes)
                {
                    foreach (var recipe in Main.recipe)
                    {
                        if (recipe != null && recipe.createItem != null)
                        {
                            var editor = new RecipeEditor(recipe);
                            switch (recipe.createItem.type)
                            {
                                case ItemID.CratePotion:
                                    editor.DeleteIngredient(ItemID.Deathweed);
                                    editor.AddIngredient(ItemID.Shiverthorn);
                                    editor.AddIngredient(ItemID.Waterleaf);
                                    break;
                                case ItemID.ThornsPotion:
                                    editor.DeleteIngredient(ItemID.WormTooth);
                                    editor.DeleteIngredient(ItemID.Stinger);
                                    break;
                            }
                        }
                    }
                }
                #endregion
                ModifiedItemTooltips.EditTooltips();
            }
        }
        public override void Load()
        {
            instance = this;
            if (!Main.dedServ)                                  //sprites
            {
                Main.instance.LoadProjectile(ProjectileID.ToxicCloud);
                Main.instance.LoadProjectile(ProjectileID.ToxicCloud2);
                Main.instance.LoadProjectile(ProjectileID.ToxicCloud3);
                Main.projectileTexture[ProjectileID.ToxicCloud] = GetTexture("Resprite/Projectile_511");
                Main.projectileTexture[ProjectileID.ToxicCloud2] = GetTexture("Resprite/Projectile_512");
                Main.projectileTexture[ProjectileID.ToxicCloud3] = GetTexture("Resprite/Projectile_513");

                Main.instance.LoadTiles(TileID.DyePlants);
                Main.tileTexture[TileID.DyePlants] = GetTexture("Resprite/Tiles_227");

                #region npcs
                Main.instance.LoadNPC(NPCID.AngryBones);                                    //load all called NPCs first
                Main.instance.LoadNPC(NPCID.Harpy);
                Main.instance.LoadNPC(NPCID.Vulture);
                Main.instance.LoadNPC(NPCID.Demon);
                Main.instance.LoadNPC(NPCID.VoodooDemon);
                Main.instance.LoadNPC(NPCID.Mummy);
                Main.instance.LoadNPC(NPCID.DarkMummy);
                Main.instance.LoadNPC(NPCID.LightMummy);
                Main.instance.LoadNPC(NPCID.Wolf);
                Main.instance.LoadNPC(NPCID.QueenBee);
                Main.instance.LoadNPC(NPCID.JungleCreeper);
                Main.instance.LoadNPC(NPCID.JungleCreeperWall);
                Main.instance.LoadNPC(NPCID.BloodFeeder);
                Main.instance.LoadNPC(NPCID.IceGolem);
                Main.instance.LoadNPC(NPCID.Eyezor);
                Main.instance.LoadNPC(NPCID.ZombieMushroom);
                Main.instance.LoadNPC(NPCID.ZombieMushroomHat);
                Main.instance.LoadNPC(NPCID.FungoFish);
                Main.instance.LoadNPC(NPCID.MushiLadybug);
                Main.instance.LoadNPC(NPCID.FungiBulb);
                Main.instance.LoadNPC(NPCID.GiantFungiBulb);
                Main.instance.LoadNPC(NPCID.Plantera);
                Main.instance.LoadNPC(NPCID.PlanterasHook);
                Main.instance.LoadNPC(NPCID.PlanterasTentacle);
                Main.instance.LoadNPC(NPCID.Spore);
                Main.instance.LoadNPC(NPCID.Creeper);
                Main.instance.LoadNPC(NPCID.RustyArmoredBonesAxe);
                Main.instance.LoadNPC(NPCID.RustyArmoredBonesFlail);
                Main.instance.LoadNPC(NPCID.RustyArmoredBonesSword);
                Main.instance.LoadNPC(NPCID.RustyArmoredBonesSwordNoArmor);
                Main.instance.LoadNPC(NPCID.BlueArmoredBones);
                Main.instance.LoadNPC(NPCID.BlueArmoredBonesMace);
                Main.instance.LoadNPC(NPCID.BlueArmoredBonesNoPants);
                Main.instance.LoadNPC(NPCID.BlueArmoredBonesSword);
                Main.instance.LoadNPC(NPCID.HellArmoredBones);
                Main.instance.LoadNPC(NPCID.HellArmoredBonesSpikeShield);
                Main.instance.LoadNPC(NPCID.HellArmoredBonesMace);
                Main.instance.LoadNPC(NPCID.HellArmoredBonesSword);
                Main.instance.LoadNPC(NPCID.RaggedCaster);
                Main.instance.LoadNPC(NPCID.RaggedCasterOpenCoat);
                Main.instance.LoadNPC(NPCID.Necromancer);
                Main.instance.LoadNPC(NPCID.NecromancerArmored);
                Main.instance.LoadNPC(NPCID.DiabolistRed);
                Main.instance.LoadNPC(NPCID.DiabolistWhite);
                Main.instance.LoadNPC(NPCID.BoneLee);
                Main.instance.LoadNPC(NPCID.Paladin);
                Main.instance.LoadNPC(NPCID.SkeletonSniper);
                Main.instance.LoadNPC(NPCID.TacticalSkeleton);
                Main.instance.LoadNPC(NPCID.SkeletonCommando);
                Main.instance.LoadNPC(NPCID.Everscream);
                Main.npcTexture[NPCID.AngryBones] = GetTexture("Resprite/NPC_31");          //then replace their sprites with own
                Main.npcTexture[NPCID.Harpy] = GetTexture("Resprite/NPC_48");
                Main.npcFrameCount[NPCID.Harpy] = 6;                                        //and if needed, change number of animation frames
                Main.npcTexture[NPCID.Vulture] = GetTexture("Resprite/NPC_61");
                Main.npcFrameCount[NPCID.Vulture] = 6;
                Main.npcTexture[NPCID.Demon] = GetTexture("Resprite/NPC_62");
                Main.npcFrameCount[NPCID.Demon] = 5;
                Main.npcTexture[NPCID.VoodooDemon] = GetTexture("Resprite/NPC_66");
                Main.npcFrameCount[NPCID.VoodooDemon] = 5;
                Main.npcTexture[NPCID.Mummy] = GetTexture("Resprite/NPC_78");
                Main.npcFrameCount[NPCID.Mummy] = 16;
                Main.npcTexture[NPCID.DarkMummy] = GetTexture("Resprite/NPC_79");
                Main.npcFrameCount[NPCID.DarkMummy] = 16;
                Main.npcTexture[NPCID.LightMummy] = GetTexture("Resprite/NPC_80");
                Main.npcFrameCount[NPCID.LightMummy] = 16;
                Main.npcTexture[NPCID.Wolf] = GetTexture("Resprite/NPC_155");
                Main.npcFrameCount[NPCID.Wolf] = 13;
                Main.npcTexture[NPCID.QueenBee] = GetTexture("Resprite/NPC_222");
                Main.npcTexture[NPCID.JungleCreeper] = GetTexture("Resprite/NPC_236");
                Main.npcFrameCount[NPCID.JungleCreeper] = 5;
                Main.npcTexture[NPCID.JungleCreeperWall] = GetTexture("Resprite/NPC_237");
                Main.npcFrameCount[NPCID.JungleCreeperWall] = 4;
                Main.npcTexture[NPCID.BloodFeeder] = GetTexture("Resprite/NPC_241");
                Main.npcTexture[NPCID.IceGolem] = GetTexture("Resprite/NPC_243");
                Main.npcTexture[NPCID.Eyezor] = GetTexture("Resprite/NPC_251");
                Main.npcTexture[NPCID.ZombieMushroom] = GetTexture("Resprite/NPC_254");
                Main.npcTexture[NPCID.ZombieMushroomHat] = GetTexture("Resprite/NPC_255");
                Main.npcTexture[NPCID.FungoFish] = GetTexture("Resprite/NPC_256");
                Main.npcTexture[NPCID.MushiLadybug] = GetTexture("Resprite/NPC_258");
                Main.npcTexture[NPCID.FungiBulb] = GetTexture("Resprite/NPC_259");
                Main.npcTexture[NPCID.GiantFungiBulb] = GetTexture("Resprite/NPC_260");
                Main.npcTexture[NPCID.Plantera] = GetTexture("Resprite/NPC_262");
                Main.npcTexture[NPCID.PlanterasHook] = GetTexture("Resprite/NPC_263");
                Main.npcTexture[NPCID.PlanterasTentacle] = GetTexture("Resprite/NPC_264");
                Main.npcTexture[NPCID.Spore] = GetTexture("Resprite/NPC_265");
                Main.npcTexture[NPCID.Creeper] = GetTexture("Resprite/NPC_267");
                Main.npcTexture[NPCID.RustyArmoredBonesAxe] = GetTexture("Resprite/NPC_269");
                Main.npcTexture[NPCID.RustyArmoredBonesFlail] = GetTexture("Resprite/NPC_270");
                Main.npcTexture[NPCID.RustyArmoredBonesSword] = GetTexture("Resprite/NPC_271");
                Main.npcTexture[NPCID.RustyArmoredBonesSwordNoArmor] = GetTexture("Resprite/NPC_272");
                Main.npcTexture[NPCID.BlueArmoredBones] = GetTexture("Resprite/NPC_273");
                Main.npcTexture[NPCID.BlueArmoredBonesMace] = GetTexture("Resprite/NPC_274");
                Main.npcTexture[NPCID.BlueArmoredBonesNoPants] = GetTexture("Resprite/NPC_275");
                Main.npcFrameCount[NPCID.BlueArmoredBonesNoPants] = 16;
                Main.npcTexture[NPCID.BlueArmoredBonesSword] = GetTexture("Resprite/NPC_276");
                Main.npcTexture[NPCID.HellArmoredBones] = GetTexture("Resprite/NPC_277");
                Main.npcTexture[NPCID.HellArmoredBonesSpikeShield] = GetTexture("Resprite/NPC_278");
                Main.npcTexture[NPCID.HellArmoredBonesMace] = GetTexture("Resprite/NPC_279");
                Main.npcTexture[NPCID.HellArmoredBonesSword] = GetTexture("Resprite/NPC_280");
                Main.npcTexture[NPCID.RaggedCaster] = GetTexture("Resprite/NPC_281");
                Main.npcTexture[NPCID.RaggedCasterOpenCoat] = GetTexture("Resprite/NPC_282");
                Main.npcTexture[NPCID.Necromancer] = GetTexture("Resprite/NPC_283");
                Main.npcTexture[NPCID.NecromancerArmored] = GetTexture("Resprite/NPC_284");
                Main.npcTexture[NPCID.DiabolistRed] = GetTexture("Resprite/NPC_285");
                Main.npcTexture[NPCID.DiabolistWhite] = GetTexture("Resprite/NPC_286");
                Main.npcTexture[NPCID.BoneLee] = GetTexture("Resprite/NPC_287");            //or be a dumb nut like me and edit the sprites to match 1.3 textures ah
                Main.npcTexture[NPCID.Paladin] = GetTexture("Resprite/NPC_290");
                Main.npcTexture[NPCID.SkeletonSniper] = GetTexture("Resprite/NPC_291");
                Main.npcTexture[NPCID.TacticalSkeleton] = GetTexture("Resprite/NPC_292");
                Main.npcTexture[NPCID.SkeletonCommando] = GetTexture("Resprite/NPC_293");
                Main.npcTexture[NPCID.Everscream] = GetTexture("Resprite/NPC_344");
                #endregion
            }
        }
        public override void Unload()
        {
            base.Unload();
            ModifiedItemTooltips.ResetTooltips();
            instance = null;
            if (!Main.dedServ)
            {
                Main.projectileLoaded[ProjectileID.ToxicCloud] = false;
                Main.projectileLoaded[ProjectileID.ToxicCloud2] = false;
                Main.projectileLoaded[ProjectileID.ToxicCloud3] = false;

                Main.tileFrame[TileID.DyePlants] = 0;
                Main.tileSetsLoaded[TileID.DyePlants] = false;                              //forces game to reload texture for this tile, as this declares that it is not loaded

                Main.NPCLoaded[NPCID.AngryBones] = false;                                   //same as tileSetsLoaded, but for NPCs
                Main.NPCLoaded[NPCID.Harpy] = false;
                Main.npcFrameCount[NPCID.Harpy] = 4;                                        //use 1.3 animation framecount, which has a different framecount than 1.4 sprites
                Main.NPCLoaded[NPCID.Vulture] = false;
                Main.npcFrameCount[NPCID.Vulture] = 3;
                Main.NPCLoaded[NPCID.Demon] = false;
                Main.npcFrameCount[NPCID.Demon] = 2;
                Main.NPCLoaded[NPCID.VoodooDemon] = false;
                Main.npcFrameCount[NPCID.VoodooDemon] = 2;
                Main.NPCLoaded[NPCID.Mummy] = false;
                Main.npcFrameCount[NPCID.Mummy] = 15;
                Main.NPCLoaded[NPCID.DarkMummy] = false;
                Main.npcFrameCount[NPCID.DarkMummy] = 15;
                Main.NPCLoaded[NPCID.LightMummy] = false;
                Main.npcFrameCount[NPCID.LightMummy] = 15;
                Main.NPCLoaded[NPCID.Wolf] = false;
                Main.npcFrameCount[NPCID.Wolf] = 9;
                Main.NPCLoaded[NPCID.QueenBee] = false;
                Main.NPCLoaded[NPCID.JungleCreeper] = false;
                Main.npcFrameCount[NPCID.JungleCreeper] = 3;
                Main.NPCLoaded[NPCID.JungleCreeperWall] = false;
                Main.npcFrameCount[NPCID.JungleCreeperWall] = 4;
                Main.NPCLoaded[NPCID.BloodFeeder] = false;
                Main.NPCLoaded[NPCID.IceGolem] = false;
                Main.NPCLoaded[NPCID.Eyezor] = false;
                Main.NPCLoaded[NPCID.ZombieMushroom] = false;
                Main.NPCLoaded[NPCID.ZombieMushroomHat] = false;
                Main.NPCLoaded[NPCID.FungoFish] = false;
                Main.NPCLoaded[NPCID.MushiLadybug] = false;
                Main.NPCLoaded[NPCID.FungiBulb] = false;
                Main.NPCLoaded[NPCID.GiantFungiBulb] = false;
                Main.NPCLoaded[NPCID.Plantera] = false;
                Main.NPCLoaded[NPCID.PlanterasHook] = false;
                Main.NPCLoaded[NPCID.PlanterasTentacle] = false;
                Main.NPCLoaded[NPCID.Spore] = false;
                Main.NPCLoaded[NPCID.Creeper] = false;
                Main.NPCLoaded[NPCID.RustyArmoredBonesAxe] = false;
                Main.NPCLoaded[NPCID.RustyArmoredBonesFlail] = false;
                Main.NPCLoaded[NPCID.RustyArmoredBonesSword] = false;
                Main.NPCLoaded[NPCID.RustyArmoredBonesSwordNoArmor] = false;
                Main.NPCLoaded[NPCID.BlueArmoredBones] = false;
                Main.NPCLoaded[NPCID.BlueArmoredBonesMace] = false;
                Main.NPCLoaded[NPCID.BlueArmoredBonesNoPants] = false;
                Main.npcFrameCount[NPCID.BlueArmoredBonesNoPants] = 15;
                Main.NPCLoaded[NPCID.BlueArmoredBonesSword] = false;
                Main.NPCLoaded[NPCID.HellArmoredBones] = false;
                Main.NPCLoaded[NPCID.HellArmoredBonesSpikeShield] = false;
                Main.NPCLoaded[NPCID.HellArmoredBonesMace] = false;
                Main.NPCLoaded[NPCID.HellArmoredBonesSword] = false;
                Main.NPCLoaded[NPCID.RaggedCaster] = false;
                Main.NPCLoaded[NPCID.RaggedCasterOpenCoat] = false;
                Main.NPCLoaded[NPCID.Necromancer] = false;
                Main.NPCLoaded[NPCID.NecromancerArmored] = false;
                Main.NPCLoaded[NPCID.DiabolistRed] = false;
                Main.NPCLoaded[NPCID.DiabolistWhite] = false;
                Main.NPCLoaded[NPCID.BoneLee] = false;
                Main.NPCLoaded[NPCID.Paladin] = false;
                Main.NPCLoaded[NPCID.SkeletonSniper] = false;//should use FrameCount, but fotoshopped works too oops
                Main.NPCLoaded[NPCID.TacticalSkeleton] = false;
                Main.NPCLoaded[NPCID.SkeletonCommando] = false;
                Main.NPCLoaded[NPCID.Everscream] = false;
            }
        }
    }
}