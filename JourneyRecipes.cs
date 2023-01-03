using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using JourneyRecipes.Items;
using static Terraria.ModLoader.ModContent;

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
                #region Tools, Weapons, Armor Recipe
                #region Copper
                if (GetInstance<Config>().allowToolRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder CopperPickaxeR = new RecipeFinder();
                    CopperPickaxeR.AddIngredient(ItemID.CopperBar, 12);
                    CopperPickaxeR.AddRecipeGroup("Wood", 4);
                    CopperPickaxeR.AddTile(TileID.Anvils);
                    CopperPickaxeR.SetResult(ItemID.CopperPickaxe);
                    Recipe CopperPickaxeRR = CopperPickaxeR.FindExactRecipe();
                    if (CopperPickaxeRR != null)
                    {
                        RecipeEditor CopperPickaxeE = new RecipeEditor(CopperPickaxeRR);
                        CopperPickaxeE.DeleteRecipe();
                    }
                    ModRecipe CopperPickaxe = new ModRecipe(this);
                    CopperPickaxe.AddIngredient(ItemID.CopperBar, 8);
                    CopperPickaxe.AddIngredient(ItemID.Wood, 3);
                    CopperPickaxe.anyWood = true;
                    CopperPickaxe.AddTile(TileID.Anvils);
                    CopperPickaxe.SetResult(ItemID.CopperPickaxe);
                    CopperPickaxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder CopperAxeR = new RecipeFinder();
                    CopperAxeR.AddIngredient(ItemID.CopperBar, 9);
                    CopperAxeR.AddRecipeGroup("Wood", 3);
                    CopperAxeR.AddTile(TileID.Anvils);
                    CopperAxeR.SetResult(ItemID.CopperAxe);
                    Recipe CopperAxeRR = CopperAxeR.FindExactRecipe();
                    if (CopperAxeRR != null)
                    {
                        RecipeEditor CopperAxeE = new RecipeEditor(CopperAxeRR);
                        CopperAxeE.DeleteRecipe();
                    }
                    ModRecipe CopperAxe = new ModRecipe(this);
                    CopperAxe.AddIngredient(ItemID.CopperBar, 6);
                    CopperAxe.AddIngredient(ItemID.Wood, 3);
                    CopperAxe.anyWood = true;
                    CopperAxe.AddTile(TileID.Anvils);
                    CopperAxe.SetResult(ItemID.CopperAxe);
                    CopperAxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder CopperHammerR = new RecipeFinder();
                    CopperHammerR.AddIngredient(ItemID.CopperBar, 10);
                    CopperHammerR.AddRecipeGroup("Wood", 3);
                    CopperHammerR.AddTile(TileID.Anvils);
                    CopperHammerR.SetResult(ItemID.CopperHammer);
                    Recipe CopperHammerRR = CopperHammerR.FindExactRecipe();
                    if (CopperHammerRR != null)
                    {
                        RecipeEditor CopperHammerE = new RecipeEditor(CopperHammerRR);
                        CopperHammerE.DeleteRecipe();
                    }
                    ModRecipe CopperHammer = new ModRecipe(this);
                    CopperHammer.AddIngredient(ItemID.CopperBar, 8);
                    CopperHammer.AddIngredient(ItemID.Wood, 3);
                    CopperHammer.anyWood = true;
                    CopperHammer.AddTile(TileID.Anvils);
                    CopperHammer.SetResult(ItemID.CopperHammer);
                    CopperHammer.AddRecipe();
                }
                if (GetInstance<Config>().allowWeaponRecipe)
                {
                    _ = new RecipeFinder();
                    RecipeFinder CopperBroadswordR = new RecipeFinder();
                    CopperBroadswordR.AddIngredient(ItemID.CopperBar, 8);
                    CopperBroadswordR.AddTile(TileID.Anvils);
                    CopperBroadswordR.SetResult(ItemID.CopperBroadsword);
                    Recipe CopperBroadswordRR = CopperBroadswordR.FindExactRecipe();
                    if (CopperBroadswordRR != null)
                    {
                        RecipeEditor CopperBroadswordE = new RecipeEditor(CopperBroadswordRR);
                        CopperBroadswordE.DeleteRecipe();
                    }
                    ModRecipe CopperBroadsword = new ModRecipe(this);
                    CopperBroadsword.AddIngredient(ItemID.CopperBar, 6);
                    CopperBroadsword.AddTile(TileID.Anvils);
                    CopperBroadsword.SetResult(ItemID.CopperBroadsword);
                    CopperBroadsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder CopperShortswordR = new RecipeFinder();
                    CopperShortswordR.AddIngredient(ItemID.CopperBar, 7);
                    CopperShortswordR.AddTile(TileID.Anvils);
                    CopperShortswordR.SetResult(ItemID.CopperShortsword);
                    Recipe CopperShortswordRR = CopperShortswordR.FindExactRecipe();
                    if (CopperShortswordRR != null)
                    {
                        RecipeEditor CopperShortswordE = new RecipeEditor(CopperShortswordRR);
                        CopperShortswordE.DeleteRecipe();
                    }
                    ModRecipe CopperShortsword = new ModRecipe(this);
                    CopperShortsword.AddIngredient(ItemID.CopperBar, 5);
                    CopperShortsword.AddTile(TileID.Anvils);
                    CopperShortsword.SetResult(ItemID.CopperShortsword);
                    CopperShortsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder CopperBowR = new RecipeFinder();
                    CopperBowR.AddIngredient(ItemID.CopperBar, 7);
                    CopperBowR.AddTile(TileID.Anvils);
                    CopperBowR.SetResult(ItemID.CopperBow);
                    Recipe CopperBowRR = CopperBowR.FindExactRecipe();
                    if (CopperBowRR != null)
                    {
                        RecipeEditor CopperBowE = new RecipeEditor(CopperBowRR);
                        CopperBowE.DeleteRecipe();
                    }
                    ModRecipe CopperBow = new ModRecipe(this);
                    CopperBow.AddIngredient(ItemID.CopperBar, 7);
                    CopperBow.AddTile(TileID.Anvils);
                    CopperBow.SetResult(ItemID.CopperBow);
                    CopperBow.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder AmethystStaffR = new RecipeFinder();
                    AmethystStaffR.AddIngredient(ItemID.CopperBar, 10);
                    AmethystStaffR.AddIngredient(ItemID.Amethyst, 8);
                    AmethystStaffR.AddTile(TileID.Anvils);
                    AmethystStaffR.SetResult(ItemID.AmethystStaff);
                    Recipe AmethystStaffRR = AmethystStaffR.FindExactRecipe();
                    if (AmethystStaffRR != null)
                    {
                        RecipeEditor AmethystStaffE = new RecipeEditor(AmethystStaffRR);
                        AmethystStaffE.DeleteRecipe();
                    }
                    ModRecipe AmethystStaff = new ModRecipe(this);
                    AmethystStaff.AddIngredient(ItemID.CopperBar, 10);
                    AmethystStaff.AddIngredient(ItemID.Amethyst, 8);
                    AmethystStaff.AddTile(TileID.Anvils);
                    AmethystStaff.SetResult(ItemID.AmethystStaff);
                    AmethystStaff.AddRecipe();
                }
                if (GetInstance<Config>().allowArmorRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder CopperHelmetR = new RecipeFinder();
                    CopperHelmetR.AddIngredient(ItemID.CopperBar, 15);
                    CopperHelmetR.AddTile(TileID.Anvils);
                    CopperHelmetR.SetResult(ItemID.CopperHelmet);
                    Recipe CopperHelmetRR = CopperHelmetR.FindExactRecipe();
                    if (CopperHelmetRR != null)
                    {
                        RecipeEditor CopperHelmetE = new RecipeEditor(CopperHelmetRR);
                        CopperHelmetE.DeleteRecipe();
                    }
                    ModRecipe CopperHelmet = new ModRecipe(this);
                    CopperHelmet.AddIngredient(ItemID.CopperBar, 12);
                    CopperHelmet.AddTile(TileID.Anvils);
                    CopperHelmet.SetResult(ItemID.CopperHelmet);
                    CopperHelmet.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder CopperChainmailR = new RecipeFinder();
                    CopperChainmailR.AddIngredient(ItemID.CopperBar, 25);
                    CopperChainmailR.AddTile(TileID.Anvils);
                    CopperChainmailR.SetResult(ItemID.CopperChainmail);
                    Recipe CopperChainmailRR = CopperChainmailR.FindExactRecipe();
                    if (CopperChainmailRR != null)
                    {
                        RecipeEditor CopperChainmailE = new RecipeEditor(CopperChainmailRR);
                        CopperChainmailE.DeleteRecipe();
                    }
                    ModRecipe CCM = new ModRecipe(this);
                    CCM.AddIngredient(ItemID.CopperBar, 20);
                    CCM.AddTile(TileID.Anvils);
                    CCM.SetResult(ItemID.CopperChainmail);
                    CCM.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder CopperGreavesR = new RecipeFinder();
                    CopperGreavesR.AddIngredient(ItemID.CopperBar, 20);
                    CopperGreavesR.AddTile(TileID.Anvils);
                    CopperGreavesR.SetResult(ItemID.CopperGreaves);
                    Recipe CopperGreavesRR = CopperGreavesR.FindExactRecipe();
                    if (CopperGreavesR != null)
                    {
                        RecipeEditor CopperGreavesE = new RecipeEditor(CopperGreavesRR);
                        CopperGreavesE.DeleteRecipe();
                    }
                    ModRecipe CopperGreaves = new ModRecipe(this);
                    CopperGreaves.AddIngredient(ItemID.CopperBar, 16);
                    CopperGreaves.AddTile(TileID.Anvils);
                    CopperGreaves.SetResult(ItemID.CopperGreaves);
                    CopperGreaves.AddRecipe();
                }
                #endregion
                #region Tin
                if (GetInstance<Config>().allowToolRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder TinPickaxeR = new RecipeFinder();
                    TinPickaxeR.AddIngredient(ItemID.TinBar, 12);
                    TinPickaxeR.AddRecipeGroup("Wood", 4);
                    TinPickaxeR.AddTile(TileID.Anvils);
                    TinPickaxeR.SetResult(ItemID.TinPickaxe);
                    Recipe TinPickaxeRR = TinPickaxeR.FindExactRecipe();
                    if (TinPickaxeRR != null)
                    {
                        RecipeEditor TinPickaxeE = new RecipeEditor(TinPickaxeRR);
                        TinPickaxeE.DeleteRecipe();
                    }
                    ModRecipe TinPickaxe = new ModRecipe(this);
                    TinPickaxe.AddIngredient(ItemID.TinBar, 8);
                    TinPickaxe.AddRecipeGroup("Wood", 4);
                    TinPickaxe.AddTile(TileID.Anvils);
                    TinPickaxe.SetResult(ItemID.TinPickaxe);
                    TinPickaxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TinAxeR = new RecipeFinder();
                    TinAxeR.AddIngredient(ItemID.TinBar, 9);
                    TinAxeR.AddRecipeGroup("Wood", 3);
                    TinAxeR.AddTile(TileID.Anvils);
                    TinAxeR.SetResult(ItemID.TinAxe);
                    Recipe TinAxeRR = TinAxeR.FindExactRecipe();
                    if (TinAxeRR != null)
                    {
                        RecipeEditor TinAxeE = new RecipeEditor(TinAxeRR);
                        TinAxeE.DeleteRecipe();
                    }
                    ModRecipe TinAxe = new ModRecipe(this);
                    TinAxe.AddIngredient(ItemID.TinBar, 6);
                    TinAxe.AddRecipeGroup("Wood", 4);
                    TinAxe.AddTile(TileID.Anvils);
                    TinAxe.SetResult(ItemID.TinAxe);
                    TinAxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TinHammerR = new RecipeFinder();
                    TinHammerR.AddIngredient(ItemID.TinBar, 10);
                    TinHammerR.AddRecipeGroup("Wood", 3);
                    TinHammerR.AddTile(TileID.Anvils);
                    TinHammerR.SetResult(ItemID.TinHammer);
                    Recipe TinHammerRR = TinHammerR.FindExactRecipe();
                    if (TinHammerRR != null)
                    {
                        RecipeEditor TinHammerE = new RecipeEditor(TinHammerRR);
                        TinHammerE.DeleteRecipe();
                    }
                    ModRecipe TinHammer = new ModRecipe(this);
                    TinHammer.AddIngredient(ItemID.TinBar, 8);
                    TinHammer.AddRecipeGroup("Wood", 3);
                    TinHammer.AddTile(TileID.Anvils);
                    TinHammer.SetResult(ItemID.TinHammer);
                    TinHammer.AddRecipe();
                }
                if (GetInstance<Config>().allowWeaponRecipe)
                {
                    _ = new RecipeFinder();
                    RecipeFinder TinBroadswordR = new RecipeFinder();
                    TinBroadswordR.AddIngredient(ItemID.TinBar, 8);
                    TinBroadswordR.AddTile(TileID.Anvils);
                    TinBroadswordR.SetResult(ItemID.TinBroadsword);
                    Recipe TinBroadswordRR = TinBroadswordR.FindExactRecipe();
                    if (TinBroadswordRR != null)
                    {
                        RecipeEditor TinBroadswordE = new RecipeEditor(TinBroadswordRR);
                        TinBroadswordE.DeleteRecipe();
                    }
                    ModRecipe TinBroadsword = new ModRecipe(this);
                    TinBroadsword.AddIngredient(ItemID.TinBar, 6);
                    TinBroadsword.AddTile(TileID.Anvils);
                    TinBroadsword.SetResult(ItemID.TinBroadsword);
                    TinBroadsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TinShorswordR = new RecipeFinder();
                    TinShorswordR.AddIngredient(ItemID.TinBar, 7);
                    TinShorswordR.AddTile(TileID.Anvils);
                    TinShorswordR.SetResult(ItemID.TinShortsword);
                    Recipe TinShorswordRR = TinShorswordR.FindExactRecipe();
                    if (TinShorswordRR != null)
                    {
                        RecipeEditor TinShorswordE = new RecipeEditor(TinShorswordRR);
                        TinShorswordE.DeleteRecipe();
                    }
                    ModRecipe TinShortsword = new ModRecipe(this);
                    TinShortsword.AddIngredient(ItemID.TinBar, 5);
                    TinShortsword.AddTile(TileID.Anvils);
                    TinShortsword.SetResult(ItemID.TinShortsword);
                    TinShortsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TinBowR = new RecipeFinder();
                    TinBowR.AddIngredient(ItemID.TinBar, 7);
                    TinBowR.AddTile(TileID.Anvils);
                    TinBowR.SetResult(ItemID.TinBow);
                    Recipe TinBowRR = TinBowR.FindExactRecipe();
                    if (TinBowRR != null)
                    {
                        RecipeEditor TinBowE = new RecipeEditor(TinBowRR);
                        TinBowE.DeleteRecipe();
                    }
                    ModRecipe TinBow = new ModRecipe(this);
                    TinBow.AddIngredient(ItemID.TinBar, 7);
                    TinBow.AddTile(TileID.Anvils);
                    TinBow.SetResult(ItemID.TinBow);
                    TinBow.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TopazStaffR = new RecipeFinder();
                    TopazStaffR.AddIngredient(ItemID.TinBar, 10);
                    TopazStaffR.AddIngredient(ItemID.Topaz, 8);
                    TopazStaffR.AddTile(TileID.Anvils);
                    TopazStaffR.SetResult(ItemID.TopazStaff);
                    Recipe TopazStaffRR = TopazStaffR.FindExactRecipe();
                    if (TopazStaffRR != null)
                    {
                        RecipeEditor TopazStaffE = new RecipeEditor(TopazStaffRR);
                        TopazStaffE.DeleteRecipe();
                    }
                    ModRecipe TopazStaff = new ModRecipe(this);
                    TopazStaff.AddIngredient(ItemID.TinBar, 10);
                    TopazStaff.AddIngredient(ItemID.Topaz, 8);
                    TopazStaff.AddTile(TileID.Anvils);
                    TopazStaff.SetResult(ItemID.TopazStaff);
                    TopazStaff.AddRecipe();
                }
                if (GetInstance<Config>().allowArmorRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder TinHelmetR = new RecipeFinder();
                    TinHelmetR.AddIngredient(ItemID.TinBar, 15);
                    TinHelmetR.AddTile(TileID.Anvils);
                    TinHelmetR.SetResult(ItemID.TinHelmet);
                    Recipe TinHelmetRR = TinHelmetR.FindExactRecipe();
                    if (TinHelmetRR != null)
                    {
                        RecipeEditor TinHelmetE = new RecipeEditor(TinHelmetRR);
                        TinHelmetE.DeleteRecipe();
                    }
                    ModRecipe TinHelmet = new ModRecipe(this);
                    TinHelmet.AddIngredient(ItemID.TinBar, 12);
                    TinHelmet.AddTile(TileID.Anvils);
                    TinHelmet.SetResult(ItemID.TinHelmet);
                    TinHelmet.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TinChainmailR = new RecipeFinder();
                    TinChainmailR.AddIngredient(ItemID.TinBar, 25);
                    TinChainmailR.AddTile(TileID.Anvils);
                    TinChainmailR.SetResult(ItemID.TinChainmail);
                    Recipe TinChainmailRR = TinChainmailR.FindExactRecipe();
                    if (TinChainmailRR != null)
                    {
                        RecipeEditor TinChainmailE = new RecipeEditor(TinChainmailRR);
                        TinChainmailE.DeleteRecipe();
                    }
                    ModRecipe TinChainmail = new ModRecipe(this);
                    TinChainmail.AddIngredient(ItemID.TinBar, 20);
                    TinChainmail.AddTile(TileID.Anvils);
                    TinChainmail.SetResult(ItemID.TinChainmail);
                    TinChainmail.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TinGreavesR = new RecipeFinder();
                    TinGreavesR.AddIngredient(ItemID.TinBar, 20);
                    TinGreavesR.AddTile(TileID.Anvils);
                    TinGreavesR.SetResult(ItemID.TinGreaves);
                    Recipe TinGreavesRR = TinGreavesR.FindExactRecipe();
                    if (TinGreavesRR != null)
                    {
                        RecipeEditor TinGreavesE = new RecipeEditor(TinGreavesRR);
                        TinGreavesE.DeleteRecipe();
                    }
                    ModRecipe TinGreaves = new ModRecipe(this);
                    TinGreaves.AddIngredient(ItemID.TinBar, 16);
                    TinGreaves.AddTile(TileID.Anvils);
                    TinGreaves.SetResult(ItemID.TinGreaves);
                    TinGreaves.AddRecipe();
                }
                #endregion
                #region Iron
                if (GetInstance<Config>().allowToolRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder IronPickaxeR = new RecipeFinder();
                    IronPickaxeR.AddIngredient(ItemID.IronBar, 12);
                    IronPickaxeR.AddRecipeGroup("Wood", 3);
                    IronPickaxeR.AddTile(TileID.Anvils);
                    IronPickaxeR.SetResult(ItemID.IronPickaxe);
                    Recipe IronPickaxeRR = IronPickaxeR.FindExactRecipe();
                    if (IronPickaxeRR != null)
                    {
                        RecipeEditor IronPickaxeE = new RecipeEditor(IronPickaxeRR);
                        IronPickaxeE.DeleteRecipe();
                    }
                    ModRecipe IronPickaxe = new ModRecipe(this);
                    IronPickaxe.AddIngredient(ItemID.IronBar, 10);
                    IronPickaxe.AddRecipeGroup("Wood", 3);
                    IronPickaxe.AddTile(TileID.Anvils);
                    IronPickaxe.SetResult(ItemID.IronPickaxe);
                    IronPickaxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder IronAxeR = new RecipeFinder();
                    IronAxeR.AddIngredient(ItemID.IronBar, 9);
                    IronAxeR.AddRecipeGroup("Wood", 3);
                    IronAxeR.AddTile(TileID.Anvils);
                    IronAxeR.SetResult(ItemID.IronAxe);
                    Recipe IronAxeRR = IronAxeR.FindExactRecipe();
                    if (IronAxeRR != null)
                    {
                        RecipeEditor IronAxeE = new RecipeEditor(IronAxeRR);
                        IronAxeE.DeleteRecipe();
                    }
                    ModRecipe IronAxe = new ModRecipe(this);
                    IronAxe.AddIngredient(ItemID.IronBar, 8);
                    IronAxe.AddRecipeGroup("Wood", 3);
                    IronAxe.AddTile(TileID.Anvils);
                    IronAxe.SetResult(ItemID.IronAxe);
                    IronAxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder IronHammerR = new RecipeFinder();
                    IronHammerR.AddIngredient(ItemID.IronBar, 10);
                    IronHammerR.AddRecipeGroup("Wood", 3);
                    IronHammerR.AddTile(TileID.Anvils);
                    IronHammerR.SetResult(ItemID.IronHammer);
                    Recipe IronHammerRR = IronHammerR.FindExactRecipe();
                    if (IronHammerRR != null)
                    {
                        RecipeEditor IronHammerE = new RecipeEditor(IronHammerRR);
                        IronHammerE.DeleteRecipe();
                    }
                    ModRecipe IronHammer = new ModRecipe(this);
                    IronHammer.AddIngredient(ItemID.IronBar, 8);
                    IronHammer.AddRecipeGroup("Wood", 3);
                    IronHammer.AddTile(TileID.Anvils);
                    IronHammer.SetResult(ItemID.IronHammer);
                    IronHammer.AddRecipe();
                }
                if (GetInstance<Config>().allowWeaponRecipe)
                {
                    _ = new RecipeFinder();
                    RecipeFinder IronBroadswordR = new RecipeFinder();
                    IronBroadswordR.AddIngredient(ItemID.IronBar, 8);
                    IronBroadswordR.AddTile(TileID.Anvils);
                    IronBroadswordR.SetResult(ItemID.IronBroadsword);
                    Recipe IronBroadswordRR = IronBroadswordR.FindExactRecipe();
                    if (IronBroadswordRR != null)
                    {
                        RecipeEditor IronBroadswordE = new RecipeEditor(IronBroadswordRR);
                        IronBroadswordE.DeleteRecipe();
                    }
                    ModRecipe IronBroadsword = new ModRecipe(this);
                    IronBroadsword.AddIngredient(ItemID.IronBar, 8);
                    IronBroadsword.AddTile(TileID.Anvils);
                    IronBroadsword.SetResult(ItemID.IronBroadsword);
                    IronBroadsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder IronShortswordR = new RecipeFinder();
                    IronShortswordR.AddIngredient(ItemID.IronBar, 7);
                    IronShortswordR.AddTile(TileID.Anvils);
                    IronShortswordR.SetResult(ItemID.IronShortsword);
                    Recipe IronShortswordRR = IronShortswordR.FindExactRecipe();
                    if (IronShortswordRR != null)
                    {
                        RecipeEditor IronShortswordE = new RecipeEditor(IronShortswordRR);
                        IronShortswordE.DeleteRecipe();
                    }
                    ModRecipe IronShortsword = new ModRecipe(this);
                    IronShortsword.AddIngredient(ItemID.IronBar, 6);
                    IronShortsword.AddTile(TileID.Anvils);
                    IronShortsword.SetResult(ItemID.IronShortsword);
                    IronShortsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder IronBowR = new RecipeFinder();
                    IronBowR.AddIngredient(ItemID.IronBar, 7);
                    IronBowR.AddTile(TileID.Anvils);
                    IronBowR.SetResult(ItemID.IronBow);
                    Recipe IronBowRR = IronBowR.FindExactRecipe();
                    if (IronBowRR != null)
                    {
                        RecipeEditor IronBowE = new RecipeEditor(IronBowRR);
                        IronBowE.DeleteRecipe();
                    }
                    ModRecipe IronBow = new ModRecipe(this);
                    IronBow.AddIngredient(ItemID.IronBar, 7);
                    IronBow.AddTile(TileID.Anvils);
                    IronBow.SetResult(ItemID.IronBow);
                    IronBow.AddRecipe();
                }
                if (GetInstance<Config>().allowArmorRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder IronHelmetR = new RecipeFinder();
                    IronHelmetR.AddIngredient(ItemID.IronBar, 20);
                    IronHelmetR.AddTile(TileID.Anvils);
                    IronHelmetR.SetResult(ItemID.IronHelmet);
                    Recipe IronHelmetRR = IronHelmetR.FindExactRecipe();
                    if (IronHelmetRR != null)
                    {
                        RecipeEditor IronHelmetE = new RecipeEditor(IronHelmetRR);
                        IronHelmetE.DeleteRecipe();
                    }
                    ModRecipe IronHelmet = new ModRecipe(this);
                    IronHelmet.AddIngredient(ItemID.IronBar, 15);
                    IronHelmet.AddTile(TileID.Anvils);
                    IronHelmet.SetResult(ItemID.IronHelmet);
                    IronHelmet.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder IronChainmailR = new RecipeFinder();
                    IronChainmailR.AddIngredient(ItemID.IronBar, 30);
                    IronChainmailR.AddTile(TileID.Anvils);
                    IronChainmailR.SetResult(ItemID.IronChainmail);
                    Recipe IronChainmailRR = IronChainmailR.FindExactRecipe();
                    if (IronChainmailRR != null)
                    {
                        RecipeEditor IronChainmailE = new RecipeEditor(IronChainmailRR);
                        IronChainmailE.DeleteRecipe();
                    }
                    ModRecipe IronChainmail = new ModRecipe(this);
                    IronChainmail.AddIngredient(ItemID.IronBar, 25);
                    IronChainmail.AddTile(TileID.Anvils);
                    IronChainmail.SetResult(ItemID.IronChainmail);
                    IronChainmail.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder IronGreavesR = new RecipeFinder();
                    IronGreavesR.AddIngredient(ItemID.IronBar, 25);
                    IronGreavesR.AddTile(TileID.Anvils);
                    IronGreavesR.SetResult(ItemID.IronGreaves);
                    Recipe IronGreavesRR = IronGreavesR.FindExactRecipe();
                    if (IronGreavesRR != null)
                    {
                        RecipeEditor IronGreavesE = new RecipeEditor(IronGreavesRR);
                        IronGreavesE.DeleteRecipe();
                    }
                    ModRecipe IronGreaves = new ModRecipe(this);
                    IronGreaves.AddIngredient(ItemID.IronBar, 20);
                    IronGreaves.AddTile(TileID.Anvils);
                    IronGreaves.SetResult(ItemID.IronGreaves);
                    IronGreaves.AddRecipe();
                }
                #endregion
                #region Lead
                if (GetInstance<Config>().allowToolRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder LeadPickaxeR = new RecipeFinder();
                    LeadPickaxeR.AddIngredient(ItemID.LeadBar, 12);
                    LeadPickaxeR.AddRecipeGroup("Wood", 3);
                    LeadPickaxeR.AddTile(TileID.Anvils);
                    LeadPickaxeR.SetResult(ItemID.LeadPickaxe);
                    Recipe LeadPickaxeRR = LeadPickaxeR.FindExactRecipe();
                    if (LeadPickaxeRR != null)
                    {
                        RecipeEditor LeadPickaxeE = new RecipeEditor(LeadPickaxeRR);
                        LeadPickaxeE.DeleteRecipe();
                    }
                    ModRecipe LeadPickaxe = new ModRecipe(this);
                    LeadPickaxe.AddIngredient(ItemID.LeadBar, 10);
                    LeadPickaxe.AddRecipeGroup("Wood", 3);
                    LeadPickaxe.AddTile(TileID.Anvils);
                    LeadPickaxe.SetResult(ItemID.LeadPickaxe);
                    LeadPickaxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder LeadAxeR = new RecipeFinder();
                    LeadAxeR.AddIngredient(ItemID.LeadBar, 9);
                    LeadAxeR.AddRecipeGroup("Wood", 3);
                    LeadAxeR.AddTile(TileID.Anvils);
                    LeadAxeR.SetResult(ItemID.LeadAxe);
                    Recipe LeadAxeRR = LeadAxeR.FindExactRecipe();
                    if (LeadAxeRR != null)
                    {
                        RecipeEditor LeadAxeE = new RecipeEditor(LeadAxeRR);
                        LeadAxeE.DeleteRecipe();
                    }
                    ModRecipe LeadAxe = new ModRecipe(this);
                    LeadAxe.AddIngredient(ItemID.LeadBar, 9);
                    LeadAxe.AddRecipeGroup("Wood", 3);
                    LeadAxe.AddTile(TileID.Anvils);
                    LeadAxe.SetResult(ItemID.LeadAxe);
                    LeadAxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder LeadHammerR = new RecipeFinder();
                    LeadHammerR.AddIngredient(ItemID.LeadBar, 10);
                    LeadHammerR.AddRecipeGroup("Wood", 3);
                    LeadHammerR.AddTile(TileID.Anvils);
                    LeadHammerR.SetResult(ItemID.LeadHammer);
                    Recipe LeadHammerRR = LeadHammerR.FindExactRecipe();
                    if (LeadHammerRR != null)
                    {
                        RecipeEditor LeadHammerE = new RecipeEditor(LeadHammerRR);
                        LeadHammerE.DeleteRecipe();
                    }
                    ModRecipe LeadHammer = new ModRecipe(this);
                    LeadHammer.AddIngredient(ItemID.LeadBar, 8);
                    LeadHammer.AddRecipeGroup("Wood", 3);
                    LeadHammer.AddTile(TileID.Anvils);
                    LeadHammer.SetResult(ItemID.LeadHammer);
                    LeadHammer.AddRecipe();
                }
                if (GetInstance<Config>().allowWeaponRecipe)
                {
                    _ = new RecipeFinder();
                    RecipeFinder LeadBroadswordR = new RecipeFinder();
                    LeadBroadswordR.AddIngredient(ItemID.LeadBar, 8);
                    LeadBroadswordR.AddTile(TileID.Anvils);
                    LeadBroadswordR.SetResult(ItemID.LeadBroadsword);
                    Recipe LeadBroadswordRR = LeadBroadswordR.FindExactRecipe();
                    if (LeadBroadswordRR != null)
                    {
                        RecipeEditor LeadBroadswordE = new RecipeEditor(LeadBroadswordRR);
                        LeadBroadswordE.DeleteRecipe();
                    }
                    ModRecipe LeadBroadsword = new ModRecipe(this);
                    LeadBroadsword.AddIngredient(ItemID.LeadBar, 8);
                    LeadBroadsword.AddTile(TileID.Anvils);
                    LeadBroadsword.SetResult(ItemID.LeadBroadsword);
                    LeadBroadsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder LeadShortswordR = new RecipeFinder();
                    LeadShortswordR.AddIngredient(ItemID.LeadBar, 7);
                    LeadShortswordR.AddTile(TileID.Anvils);
                    LeadShortswordR.SetResult(ItemID.LeadShortsword);
                    Recipe LeadShortswordRR = LeadShortswordR.FindExactRecipe();
                    if (LeadShortswordRR != null)
                    {
                        RecipeEditor LeadShortswordE = new RecipeEditor(LeadShortswordRR);
                        LeadShortswordE.DeleteRecipe();
                    }
                    ModRecipe LeadShortsword = new ModRecipe(this);
                    LeadShortsword.AddIngredient(ItemID.LeadBar, 6);
                    LeadShortsword.AddTile(TileID.Anvils);
                    LeadShortsword.SetResult(ItemID.LeadShortsword);
                    LeadShortsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder LeadBowR = new RecipeFinder();
                    LeadBowR.AddIngredient(ItemID.LeadBar, 7);
                    LeadBowR.AddTile(TileID.Anvils);
                    LeadBowR.SetResult(ItemID.LeadBow);
                    Recipe LeadBowRR = LeadBowR.FindExactRecipe();
                    if (LeadBowRR != null)
                    {
                        RecipeEditor LeadBowE = new RecipeEditor(LeadBowRR);
                        LeadBowE.DeleteRecipe();
                    }
                    ModRecipe LeadBow = new ModRecipe(this);
                    LeadBow.AddIngredient(ItemID.LeadBar, 7);
                    LeadBow.AddTile(TileID.Anvils);
                    LeadBow.SetResult(ItemID.LeadBow);
                    LeadBow.AddRecipe();
                }
                if (GetInstance<Config>().allowArmorRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder LeadHelmetR = new RecipeFinder();
                    LeadHelmetR.AddIngredient(ItemID.LeadBar, 20);
                    LeadHelmetR.AddTile(TileID.Anvils);
                    LeadHelmetR.SetResult(ItemID.LeadHelmet);
                    Recipe LeadHelmetRR = LeadHelmetR.FindExactRecipe();
                    if (LeadHelmetRR != null)
                    {
                        RecipeEditor LeadHelmetE = new RecipeEditor(LeadHelmetRR);
                        LeadHelmetE.DeleteRecipe();
                    }
                    ModRecipe LeadHelmet = new ModRecipe(this);
                    LeadHelmet.AddIngredient(ItemID.LeadBar, 15);
                    LeadHelmet.AddTile(TileID.Anvils);
                    LeadHelmet.SetResult(ItemID.LeadHelmet);
                    LeadHelmet.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder LeadChainmailR = new RecipeFinder();
                    LeadChainmailR.AddIngredient(ItemID.LeadBar, 30);
                    LeadChainmailR.AddTile(TileID.Anvils);
                    LeadChainmailR.SetResult(ItemID.LeadChainmail);
                    Recipe LeadChainmailRR = LeadChainmailR.FindExactRecipe();
                    if (LeadChainmailRR != null)
                    {
                        RecipeEditor LeadChainmailE = new RecipeEditor(LeadChainmailRR);
                        LeadChainmailE.DeleteRecipe();
                    }
                    ModRecipe LeadChainmail = new ModRecipe(this);
                    LeadChainmail.AddIngredient(ItemID.LeadBar, 25);
                    LeadChainmail.AddTile(TileID.Anvils);
                    LeadChainmail.SetResult(ItemID.LeadChainmail);
                    LeadChainmail.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder LeadGreavesR = new RecipeFinder();
                    LeadGreavesR.AddIngredient(ItemID.LeadBar, 25);
                    LeadGreavesR.AddTile(TileID.Anvils);
                    LeadGreavesR.SetResult(ItemID.LeadGreaves);
                    Recipe LeadGreavesRR = LeadGreavesR.FindExactRecipe();
                    if (LeadGreavesRR != null)
                    {
                        RecipeEditor LeadGreavesE = new RecipeEditor(LeadGreavesRR);
                        LeadGreavesE.DeleteRecipe();
                    }
                    ModRecipe LeadGreaves = new ModRecipe(this);
                    LeadGreaves.AddIngredient(ItemID.LeadBar, 20);
                    LeadGreaves.AddTile(TileID.Anvils);
                    LeadGreaves.SetResult(ItemID.LeadGreaves);
                    LeadGreaves.AddRecipe();
                }
                #endregion
                #region Silver
                if (GetInstance<Config>().allowToolRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder SilverPickaxeR = new RecipeFinder();
                    SilverPickaxeR.AddIngredient(ItemID.SilverBar, 12);
                    SilverPickaxeR.AddRecipeGroup("Wood", 4);
                    SilverPickaxeR.AddTile(TileID.Anvils);
                    SilverPickaxeR.SetResult(ItemID.SilverPickaxe);
                    Recipe SilverPickaxeRR = SilverPickaxeR.FindExactRecipe();
                    if (SilverPickaxeRR != null)
                    {
                        RecipeEditor SilverPickaxeE = new RecipeEditor(SilverPickaxeRR);
                        SilverPickaxeE.DeleteRecipe();
                    }
                    ModRecipe SilverPickaxe = new ModRecipe(this);
                    SilverPickaxe.AddIngredient(ItemID.SilverBar, 12);
                    SilverPickaxe.AddRecipeGroup("Wood", 4);
                    SilverPickaxe.AddTile(TileID.Anvils);
                    SilverPickaxe.SetResult(ItemID.SilverPickaxe);
                    SilverPickaxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder SilverAxeR = new RecipeFinder();
                    SilverAxeR.AddIngredient(ItemID.SilverBar, 9);
                    SilverAxeR.AddRecipeGroup("Wood", 3);
                    SilverAxeR.AddTile(TileID.Anvils);
                    SilverAxeR.SetResult(ItemID.SilverAxe);
                    Recipe SilverAxeRR = SilverAxeR.FindExactRecipe();
                    if (SilverAxeRR != null)
                    {
                        RecipeEditor SilverAxeE = new RecipeEditor(SilverAxeRR);
                        SilverAxeE.DeleteRecipe();
                    }
                    ModRecipe SilverAxe = new ModRecipe(this);
                    SilverAxe.AddIngredient(ItemID.SilverBar, 8);
                    SilverAxe.AddRecipeGroup("Wood", 3);
                    SilverAxe.AddTile(TileID.Anvils);
                    SilverAxe.SetResult(ItemID.SilverAxe);
                    SilverAxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder SilverHammerR = new RecipeFinder();
                    SilverHammerR.AddIngredient(ItemID.SilverBar, 10);
                    SilverHammerR.AddRecipeGroup("Wood", 3);
                    SilverHammerR.AddTile(TileID.Anvils);
                    SilverHammerR.SetResult(ItemID.SilverHammer);
                    Recipe SilverHammerRR = SilverHammerR.FindExactRecipe();
                    if (SilverHammerRR != null)
                    {
                        RecipeEditor SilverHammerE = new RecipeEditor(SilverHammerRR);
                        SilverHammerE.DeleteRecipe();
                    }
                    ModRecipe SilverHammer = new ModRecipe(this);
                    SilverHammer.AddIngredient(ItemID.SilverBar, 8);
                    SilverHammer.AddRecipeGroup("Wood", 3);
                    SilverHammer.AddTile(TileID.Anvils);
                    SilverHammer.SetResult(ItemID.SilverHammer);
                    SilverHammer.AddRecipe();
                }
                if (GetInstance<Config>().allowWeaponRecipe)
                {
                    _ = new RecipeFinder();
                    RecipeFinder SilverBroadswordR = new RecipeFinder();
                    SilverBroadswordR.AddIngredient(ItemID.SilverBar, 8);
                    SilverBroadswordR.AddTile(TileID.Anvils);
                    SilverBroadswordR.SetResult(ItemID.SilverBroadsword);
                    Recipe SilverBroadswordRR = SilverBroadswordR.FindExactRecipe();
                    if (SilverBroadswordRR != null)
                    {
                        RecipeEditor SilverBroadswordE = new RecipeEditor(SilverBroadswordRR);
                        SilverBroadswordE.DeleteRecipe();
                    }
                    ModRecipe SilverBroadsword = new ModRecipe(this);
                    SilverBroadsword.AddIngredient(ItemID.SilverBar, 8);
                    SilverBroadsword.AddTile(TileID.Anvils);
                    SilverBroadsword.SetResult(ItemID.SilverBroadsword);
                    SilverBroadsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder SilverShortswordR = new RecipeFinder();
                    SilverShortswordR.AddIngredient(ItemID.SilverBar, 6);
                    SilverShortswordR.AddTile(TileID.Anvils);
                    SilverShortswordR.SetResult(ItemID.SilverShortsword);
                    Recipe SilverShortswordRR = SilverShortswordR.FindExactRecipe();
                    if (SilverShortswordRR != null)
                    {
                        RecipeEditor SilverShortswordE = new RecipeEditor(SilverShortswordRR);
                        SilverShortswordE.DeleteRecipe();
                    }
                    ModRecipe SilverShortsword = new ModRecipe(this);
                    SilverShortsword.AddIngredient(ItemID.SilverBar, 6);
                    SilverShortsword.AddTile(TileID.Anvils);
                    SilverShortsword.SetResult(ItemID.SilverShortsword);
                    SilverShortsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder SilverBowR = new RecipeFinder();
                    SilverBowR.AddIngredient(ItemID.SilverBar, 7);
                    SilverBowR.AddTile(TileID.Anvils);
                    SilverBowR.SetResult(ItemID.SilverBow);
                    Recipe SilverBowRR = SilverBowR.FindExactRecipe();
                    if (SilverBowRR != null)
                    {
                        RecipeEditor SilverBowE = new RecipeEditor(SilverBowRR);
                        SilverBowE.DeleteRecipe();
                    }
                    ModRecipe SilverBow = new ModRecipe(this);
                    SilverBow.AddIngredient(ItemID.SilverBar, 7);
                    SilverBow.AddTile(TileID.Anvils);
                    SilverBow.SetResult(ItemID.SilverBow);
                    SilverBow.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder SapphireStaffR = new RecipeFinder();
                    SapphireStaffR.AddIngredient(ItemID.SilverBar, 10);
                    SapphireStaffR.AddIngredient(ItemID.Sapphire, 8);
                    SapphireStaffR.AddTile(TileID.Anvils);
                    SapphireStaffR.SetResult(ItemID.SapphireStaff);
                    Recipe SapphireStaffRR = SapphireStaffR.FindExactRecipe();
                    if (SapphireStaffRR != null)
                    {
                        RecipeEditor SapphireStaffE = new RecipeEditor(SapphireStaffRR);
                        SapphireStaffE.DeleteRecipe();
                    }
                    ModRecipe SapphireStaff = new ModRecipe(this);
                    SapphireStaff.AddIngredient(ItemID.SilverBar, 10);
                    SapphireStaff.AddIngredient(ItemID.Sapphire, 8);
                    SapphireStaff.AddTile(TileID.Anvils);
                    SapphireStaff.SetResult(ItemID.SapphireStaff);
                    SapphireStaff.AddRecipe();
                }
                if (GetInstance<Config>().allowArmorRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder SilverHelmetR = new RecipeFinder();
                    SilverHelmetR.AddIngredient(ItemID.SilverBar, 20);
                    SilverHelmetR.AddTile(TileID.Anvils);
                    SilverHelmetR.SetResult(ItemID.SilverHelmet);
                    Recipe SilverHelmetRR = SilverHelmetR.FindExactRecipe();
                    if (SilverHelmetRR != null)
                    {
                        RecipeEditor SilverHelmetE = new RecipeEditor(SilverHelmetRR);
                        SilverHelmetE.DeleteRecipe();
                    }
                    ModRecipe SilverHelmet = new ModRecipe(this);
                    SilverHelmet.AddIngredient(ItemID.SilverBar, 15);
                    SilverHelmet.AddTile(TileID.Anvils);
                    SilverHelmet.SetResult(ItemID.SilverHelmet);
                    SilverHelmet.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder SilverChainmailR = new RecipeFinder();
                    SilverChainmailR.AddIngredient(ItemID.SilverBar, 30);
                    SilverChainmailR.AddTile(TileID.Anvils);
                    SilverChainmailR.SetResult(ItemID.SilverChainmail);
                    Recipe SilverChainmailRR = SilverChainmailR.FindExactRecipe();
                    if (SilverChainmailRR != null)
                    {
                        RecipeEditor SilverChainmailE = new RecipeEditor(SilverChainmailRR);
                        SilverChainmailE.DeleteRecipe();
                    }
                    ModRecipe SilverChainmail = new ModRecipe(this);
                    SilverChainmail.AddIngredient(ItemID.SilverBar, 25);
                    SilverChainmail.AddTile(TileID.Anvils);
                    SilverChainmail.SetResult(ItemID.SilverChainmail);
                    SilverChainmail.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder SilverGreavesR = new RecipeFinder();
                    SilverGreavesR.AddIngredient(ItemID.SilverBar, 25);
                    SilverGreavesR.AddTile(TileID.Anvils);
                    SilverGreavesR.SetResult(ItemID.SilverGreaves);
                    Recipe SilverGreavesRR = SilverGreavesR.FindExactRecipe();
                    if (SilverGreavesRR != null)
                    {
                        RecipeEditor SilverGreavesE = new RecipeEditor(SilverGreavesRR);
                        SilverGreavesE.DeleteRecipe();
                    }
                    ModRecipe SilverGreaves = new ModRecipe(this);
                    SilverGreaves.AddIngredient(ItemID.SilverBar, 20);
                    SilverGreaves.AddTile(TileID.Anvils);
                    SilverGreaves.SetResult(ItemID.SilverGreaves);
                    SilverGreaves.AddRecipe();
                }
                #endregion
                #region Tungsten
                if (GetInstance<Config>().allowToolRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder TungstenPickaxeR = new RecipeFinder();
                    TungstenPickaxeR.AddIngredient(ItemID.TungstenBar, 12);
                    TungstenPickaxeR.AddRecipeGroup("Wood", 4);
                    TungstenPickaxeR.AddTile(TileID.Anvils);
                    TungstenPickaxeR.SetResult(ItemID.TungstenPickaxe);
                    Recipe TungstenPickaxeRR = TungstenPickaxeR.FindExactRecipe();
                    if (TungstenPickaxeRR != null)
                    {
                        RecipeEditor TungstenPickaxeE = new RecipeEditor(TungstenPickaxeRR);
                        TungstenPickaxeE.DeleteRecipe();
                    }
                    ModRecipe TungstenPickaxe = new ModRecipe(this);
                    TungstenPickaxe.AddIngredient(ItemID.TungstenBar, 10);
                    TungstenPickaxe.AddRecipeGroup("Wood", 4);
                    TungstenPickaxe.AddTile(TileID.Anvils);
                    TungstenPickaxe.SetResult(ItemID.TungstenPickaxe);
                    TungstenPickaxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TungstenAxeR = new RecipeFinder();
                    TungstenAxeR.AddIngredient(ItemID.TungstenBar, 9);
                    TungstenAxeR.AddRecipeGroup("Wood", 3);
                    TungstenAxeR.AddTile(TileID.Anvils);
                    TungstenAxeR.SetResult(ItemID.TungstenAxe);
                    Recipe TungstenAxeRR = TungstenAxeR.FindExactRecipe();
                    if (TungstenAxeRR != null)
                    {
                        RecipeEditor TungstenAxeE = new RecipeEditor(TungstenAxeRR);
                        TungstenAxeE.DeleteRecipe();
                    }
                    ModRecipe TungstenAxe = new ModRecipe(this);
                    TungstenAxe.AddIngredient(ItemID.TungstenBar, 8);
                    TungstenAxe.AddRecipeGroup("Wood", 3);
                    TungstenAxe.AddTile(TileID.Anvils);
                    TungstenAxe.SetResult(ItemID.TungstenAxe);
                    TungstenAxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TungstenHammerR = new RecipeFinder();
                    TungstenHammerR.AddIngredient(ItemID.TungstenBar, 10);
                    TungstenHammerR.AddRecipeGroup("Wood", 3);
                    TungstenHammerR.AddTile(TileID.Anvils);
                    TungstenHammerR.SetResult(ItemID.TungstenHammer);
                    Recipe TungstenHammerRR = TungstenHammerR.FindExactRecipe();
                    if (TungstenHammerRR != null)
                    {
                        RecipeEditor TungstenHammerE = new RecipeEditor(TungstenHammerRR);
                        TungstenHammerE.DeleteRecipe();
                    }
                    ModRecipe TungstenHammer = new ModRecipe(this);
                    TungstenHammer.AddIngredient(ItemID.TungstenBar, 8);
                    TungstenHammer.AddRecipeGroup("Wood", 3);
                    TungstenHammer.AddTile(TileID.Anvils);
                    TungstenHammer.SetResult(ItemID.TungstenHammer);
                    TungstenHammer.AddRecipe();
                }
                if (GetInstance<Config>().allowWeaponRecipe)
                {
                    _ = new RecipeFinder();
                    RecipeFinder TungstenBroadswordR = new RecipeFinder();
                    TungstenBroadswordR.AddIngredient(ItemID.TungstenBar, 8);
                    TungstenBroadswordR.AddTile(TileID.Anvils);
                    TungstenBroadswordR.SetResult(ItemID.TungstenBroadsword);
                    Recipe TungstenBroadswordRR = TungstenBroadswordR.FindExactRecipe();
                    if (TungstenBroadswordRR != null)
                    {
                        RecipeEditor TungstenBroadswordE = new RecipeEditor(TungstenBroadswordRR);
                        TungstenBroadswordE.DeleteRecipe();
                    }
                    ModRecipe TungstenBroadsword = new ModRecipe(this);
                    TungstenBroadsword.AddIngredient(ItemID.TungstenBar, 8);
                    TungstenBroadsword.AddTile(TileID.Anvils);
                    TungstenBroadsword.SetResult(ItemID.TungstenBroadsword);
                    TungstenBroadsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TungstenShortswordR = new RecipeFinder();
                    TungstenShortswordR.AddIngredient(ItemID.TungstenBar, 6);
                    TungstenShortswordR.AddTile(TileID.Anvils);
                    TungstenShortswordR.SetResult(ItemID.TungstenShortsword);
                    Recipe TungstenShortswordRR = TungstenShortswordR.FindExactRecipe();
                    if (TungstenShortswordRR != null)
                    {
                        RecipeEditor TungstenShortswordE = new RecipeEditor(TungstenShortswordRR);
                        TungstenShortswordE.DeleteRecipe();
                    }
                    ModRecipe TungstenShortsword = new ModRecipe(this);
                    TungstenShortsword.AddIngredient(ItemID.TungstenBar, 6);
                    TungstenShortsword.AddTile(TileID.Anvils);
                    TungstenShortsword.SetResult(ItemID.TungstenShortsword);
                    TungstenShortsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TungstenBowR = new RecipeFinder();
                    TungstenBowR.AddIngredient(ItemID.TungstenBar, 7);
                    TungstenBowR.AddTile(TileID.Anvils);
                    TungstenBowR.SetResult(ItemID.TungstenBow);
                    Recipe TungstenBowRR = TungstenBowR.FindExactRecipe();
                    if (TungstenBowRR != null)
                    {
                        RecipeEditor TungstenBowE = new RecipeEditor(TungstenBowRR);
                        TungstenBowE.DeleteRecipe();
                    }
                    ModRecipe TungstenBow = new ModRecipe(this);
                    TungstenBow.AddIngredient(ItemID.TungstenBar, 7);
                    TungstenBow.AddTile(TileID.Anvils);
                    TungstenBow.SetResult(ItemID.TungstenBow);
                    TungstenBow.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder EmeraldStaffR = new RecipeFinder();
                    EmeraldStaffR.AddIngredient(ItemID.TungstenBar, 10);
                    EmeraldStaffR.AddIngredient(ItemID.Emerald, 8);
                    EmeraldStaffR.AddTile(TileID.Anvils);
                    EmeraldStaffR.SetResult(ItemID.EmeraldStaff);
                    Recipe EmeraldStaffRR = EmeraldStaffR.FindExactRecipe();
                    if (EmeraldStaffRR != null)
                    {
                        RecipeEditor EmeraldStaffE = new RecipeEditor(EmeraldStaffRR);
                        EmeraldStaffE.DeleteRecipe();
                    }
                    ModRecipe EmeraldStaff = new ModRecipe(this);
                    EmeraldStaff.AddIngredient(ItemID.TungstenBar, 10);
                    EmeraldStaff.AddIngredient(ItemID.Emerald, 8);
                    EmeraldStaff.AddTile(TileID.Anvils);
                    EmeraldStaff.SetResult(ItemID.EmeraldStaff);
                    EmeraldStaff.AddRecipe();
                }
                if (GetInstance<Config>().allowArmorRecipes)
                {


                    _ = new RecipeFinder();
                    RecipeFinder TungstenHelmetR = new RecipeFinder();
                    TungstenHelmetR.AddIngredient(ItemID.TungstenBar, 20);
                    TungstenHelmetR.AddTile(TileID.Anvils);
                    TungstenHelmetR.SetResult(ItemID.TungstenHelmet);
                    Recipe TungstenHelmetRR = TungstenHelmetR.FindExactRecipe();
                    if (TungstenHelmetRR != null)
                    {
                        RecipeEditor TungstenHelmetE = new RecipeEditor(TungstenHelmetRR);
                        TungstenHelmetE.DeleteRecipe();
                    }
                    ModRecipe TungstenHelmet = new ModRecipe(this);
                    TungstenHelmet.AddIngredient(ItemID.TungstenBar, 15);
                    TungstenHelmet.AddTile(TileID.Anvils);
                    TungstenHelmet.SetResult(ItemID.TungstenHelmet);
                    TungstenHelmet.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TungstenChainmailR = new RecipeFinder();
                    TungstenChainmailR.AddIngredient(ItemID.TungstenBar, 30);
                    TungstenChainmailR.AddTile(TileID.Anvils);
                    TungstenChainmailR.SetResult(ItemID.TungstenChainmail);
                    Recipe TungstenChainmailRR = TungstenChainmailR.FindExactRecipe();
                    if (TungstenChainmailRR != null)
                    {
                        RecipeEditor TungstenChainmailE = new RecipeEditor(TungstenChainmailRR);
                        TungstenChainmailE.DeleteRecipe();
                    }
                    ModRecipe TungstenChainmail = new ModRecipe(this);
                    TungstenChainmail.AddIngredient(ItemID.TungstenBar, 30);
                    TungstenChainmail.AddTile(TileID.Anvils);
                    TungstenChainmail.SetResult(ItemID.TungstenChainmail);
                    TungstenChainmail.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TungstenGreavesR = new RecipeFinder();
                    TungstenGreavesR.AddIngredient(ItemID.TungstenBar, 25);
                    TungstenGreavesR.AddTile(TileID.Anvils);
                    TungstenGreavesR.SetResult(ItemID.TungstenGreaves);
                    Recipe TungstenGreavesRR = TungstenGreavesR.FindExactRecipe();
                    if (TungstenGreavesRR != null)
                    {
                        RecipeEditor TungstenGreavesE = new RecipeEditor(TungstenGreavesRR);
                        TungstenGreavesE.DeleteRecipe();
                    }
                    ModRecipe TungstenGreaves = new ModRecipe(this);
                    TungstenGreaves.AddIngredient(ItemID.TungstenBar, 20);
                    TungstenGreaves.AddTile(TileID.Anvils);
                    TungstenGreaves.SetResult(ItemID.TungstenGreaves);
                    TungstenGreaves.AddRecipe();
                }
                #endregion
                #region Gold
                if (GetInstance<Config>().allowToolRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder GoldPickaxeR = new RecipeFinder();
                    GoldPickaxeR.AddIngredient(ItemID.GoldBar, 12);
                    GoldPickaxeR.AddRecipeGroup("Wood", 4);
                    GoldPickaxeR.AddTile(TileID.Anvils);
                    GoldPickaxeR.SetResult(ItemID.GoldPickaxe);
                    Recipe GoldPickaxeRR = GoldPickaxeR.FindExactRecipe();
                    if (GoldPickaxeRR != null)
                    {
                        RecipeEditor GoldPickaxeE = new RecipeEditor(GoldPickaxeRR);
                        GoldPickaxeE.DeleteRecipe();
                    }
                    ModRecipe GoldPickaxe = new ModRecipe(this);
                    GoldPickaxe.AddIngredient(ItemID.GoldBar, 10);
                    GoldPickaxe.AddRecipeGroup("Wood", 4);
                    GoldPickaxe.AddTile(TileID.Anvils);
                    GoldPickaxe.SetResult(ItemID.GoldPickaxe);
                    GoldPickaxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder GoldAxeR = new RecipeFinder();
                    GoldAxeR.AddIngredient(ItemID.GoldBar, 9);
                    GoldAxeR.AddRecipeGroup("Wood", 3);
                    GoldAxeR.AddTile(TileID.Anvils);
                    GoldAxeR.SetResult(ItemID.GoldAxe);
                    Recipe GoldAxeRR = GoldAxeR.FindExactRecipe();
                    if (GoldAxeRR != null)
                    {
                        RecipeEditor GoldAxeE = new RecipeEditor(GoldAxeRR);
                        GoldAxeE.DeleteRecipe();
                    }
                    ModRecipe GoldAxe = new ModRecipe(this);
                    GoldAxe.AddIngredient(ItemID.GoldBar, 8);
                    GoldAxe.AddRecipeGroup("Wood", 3);
                    GoldAxe.AddTile(TileID.Anvils);
                    GoldAxe.SetResult(ItemID.GoldAxe);
                    GoldAxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder GoldHammerR = new RecipeFinder();
                    GoldHammerR.AddIngredient(ItemID.GoldBar, 10);
                    GoldHammerR.AddRecipeGroup("Wood", 3);
                    GoldHammerR.AddTile(TileID.Anvils);
                    GoldHammerR.SetResult(ItemID.GoldHammer);
                    Recipe GoldHammerRR = GoldHammerR.FindExactRecipe();
                    if (GoldHammerRR != null)
                    {
                        RecipeEditor GoldHammerE = new RecipeEditor(GoldHammerRR);
                        GoldHammerE.DeleteRecipe();
                    }
                    ModRecipe GoldHammer = new ModRecipe(this);
                    GoldHammer.AddIngredient(ItemID.GoldBar, 8);
                    GoldHammer.AddRecipeGroup("Wood", 3);
                    GoldHammer.AddTile(TileID.Anvils);
                    GoldHammer.SetResult(ItemID.GoldHammer);
                    GoldHammer.AddRecipe();
                }
                if (GetInstance<Config>().allowWeaponRecipe)
                {
                    _ = new RecipeFinder();
                    RecipeFinder GoldBroadswordR = new RecipeFinder();
                    GoldBroadswordR.AddIngredient(ItemID.GoldBar, 8);
                    GoldBroadswordR.AddTile(TileID.Anvils);
                    GoldBroadswordR.SetResult(ItemID.GoldBroadsword);
                    Recipe GoldBroadswordRR = GoldBroadswordR.FindExactRecipe();
                    if (GoldBroadswordRR != null)
                    {
                        RecipeEditor GoldBroadswordE = new RecipeEditor(GoldBroadswordRR);
                        GoldBroadswordE.DeleteRecipe();
                    }
                    ModRecipe GoldBroadsword = new ModRecipe(this);
                    GoldBroadsword.AddIngredient(ItemID.GoldBar, 8);
                    GoldBroadsword.AddTile(TileID.Anvils);
                    GoldBroadsword.SetResult(ItemID.GoldBroadsword);
                    GoldBroadsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder GoldShortswordR = new RecipeFinder();
                    GoldShortswordR.AddIngredient(ItemID.GoldBar, 7);
                    GoldShortswordR.AddTile(TileID.Anvils);
                    GoldShortswordR.SetResult(ItemID.GoldShortsword);
                    Recipe GoldShortswordRR = GoldShortswordR.FindExactRecipe();
                    if (GoldShortswordRR != null)
                    {
                        RecipeEditor GoldShortswordE = new RecipeEditor(GoldShortswordRR);
                        GoldShortswordE.DeleteRecipe();
                    }
                    ModRecipe GoldShortsword = new ModRecipe(this);
                    GoldShortsword.AddIngredient(ItemID.GoldBar, 6);
                    GoldShortsword.AddTile(TileID.Anvils);
                    GoldShortsword.SetResult(ItemID.GoldShortsword);
                    GoldShortsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder GoldBowR = new RecipeFinder();
                    GoldBowR.AddIngredient(ItemID.GoldBar, 7);
                    GoldBowR.AddTile(TileID.Anvils);
                    GoldBowR.SetResult(ItemID.GoldBow);
                    Recipe GoldBowRR = GoldBowR.FindExactRecipe();
                    if (GoldBowRR != null)
                    {
                        RecipeEditor GoldBowE = new RecipeEditor(GoldBowRR);
                        GoldBowE.DeleteRecipe();
                    }
                    ModRecipe GoldBow = new ModRecipe(this);
                    GoldBow.AddIngredient(ItemID.GoldBar, 7);
                    GoldBow.AddTile(TileID.Anvils);
                    GoldBow.SetResult(ItemID.GoldBow);
                    GoldBow.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder RubyStaffR = new RecipeFinder();
                    RubyStaffR.AddIngredient(ItemID.GoldBar, 10);
                    RubyStaffR.AddIngredient(ItemID.Ruby, 8);
                    RubyStaffR.AddTile(TileID.Anvils);
                    RubyStaffR.SetResult(ItemID.RubyStaff);
                    Recipe RubyStaffRR = RubyStaffR.FindExactRecipe();
                    if (RubyStaffRR != null)
                    {
                        RecipeEditor RubyStaffE = new RecipeEditor(RubyStaffRR);
                        RubyStaffE.DeleteRecipe();
                    }
                    ModRecipe RubyStaff = new ModRecipe(this);
                    RubyStaff.AddIngredient(ItemID.GoldBar, 10);
                    RubyStaff.AddIngredient(ItemID.Ruby, 8);
                    RubyStaff.AddTile(TileID.Anvils);
                    RubyStaff.SetResult(ItemID.RubyStaff);
                    RubyStaff.AddRecipe();
                }
                if (GetInstance<Config>().allowArmorRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder GoldHelmetR = new RecipeFinder();
                    GoldHelmetR.AddIngredient(ItemID.GoldBar, 25);
                    GoldHelmetR.AddTile(TileID.Anvils);
                    GoldHelmetR.SetResult(ItemID.GoldHelmet);
                    Recipe GoldHelmetRR = GoldHelmetR.FindExactRecipe();
                    if (GoldHelmetRR != null)
                    {
                        RecipeEditor GoldHelmetE = new RecipeEditor(GoldHelmetRR);
                        GoldHelmetE.DeleteRecipe();
                    }
                    ModRecipe GoldHelmet = new ModRecipe(this);
                    GoldHelmet.AddIngredient(ItemID.GoldBar, 20);
                    GoldHelmet.AddTile(TileID.Anvils);
                    GoldHelmet.SetResult(ItemID.GoldHelmet);
                    GoldHelmet.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder GoldChainmailR = new RecipeFinder();
                    GoldChainmailR.AddIngredient(ItemID.GoldBar, 35);
                    GoldChainmailR.AddTile(TileID.Anvils);
                    GoldChainmailR.SetResult(ItemID.GoldChainmail);
                    Recipe GoldChainmailRR = GoldChainmailR.FindExactRecipe();
                    if (GoldChainmailRR != null)
                    {
                        RecipeEditor GoldChainmailE = new RecipeEditor(GoldChainmailRR);
                        GoldChainmailE.DeleteRecipe();
                    }
                    ModRecipe GoldChainmail = new ModRecipe(this);
                    GoldChainmail.AddIngredient(ItemID.GoldBar, 30);
                    GoldChainmail.AddTile(TileID.Anvils);
                    GoldChainmail.SetResult(ItemID.GoldChainmail);
                    GoldChainmail.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder GoldGreavesR = new RecipeFinder();
                    GoldGreavesR.AddIngredient(ItemID.GoldBar, 30);
                    GoldGreavesR.AddTile(TileID.Anvils);
                    GoldGreavesR.SetResult(ItemID.GoldGreaves);
                    Recipe GoldGreavesRR = GoldGreavesR.FindExactRecipe();
                    if (GoldGreavesRR != null)
                    {
                        RecipeEditor GoldGreavesE = new RecipeEditor(GoldGreavesRR);
                        GoldGreavesE.DeleteRecipe();
                    }
                    ModRecipe GoldGreaves = new ModRecipe(this);
                    GoldGreaves.AddIngredient(ItemID.GoldBar, 25);
                    GoldGreaves.AddTile(TileID.Anvils);
                    GoldGreaves.SetResult(ItemID.GoldGreaves);
                    GoldGreaves.AddRecipe();
                }
                #endregion
                #region Platinum
                if (GetInstance<Config>().allowToolRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder PlatinumPickaxeR = new RecipeFinder();
                    PlatinumPickaxeR.AddIngredient(ItemID.PlatinumBar, 12);
                    PlatinumPickaxeR.AddRecipeGroup("Wood", 4);
                    PlatinumPickaxeR.AddTile(TileID.Anvils);
                    PlatinumPickaxeR.SetResult(ItemID.PlatinumPickaxe);
                    Recipe PlatinumPickaxeRR = PlatinumPickaxeR.FindExactRecipe();
                    if (PlatinumPickaxeRR != null)
                    {
                        RecipeEditor PlatinumPickaxeE = new RecipeEditor(PlatinumPickaxeRR);
                        PlatinumPickaxeE.DeleteRecipe();
                    }
                    ModRecipe PlatinumPickaxe = new ModRecipe(this);
                    PlatinumPickaxe.AddIngredient(ItemID.PlatinumBar, 10);
                    PlatinumPickaxe.AddRecipeGroup("Wood", 4);
                    PlatinumPickaxe.AddTile(TileID.Anvils);
                    PlatinumPickaxe.SetResult(ItemID.PlatinumPickaxe);
                    PlatinumPickaxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder PlatinumAxeR = new RecipeFinder();
                    PlatinumAxeR.AddIngredient(ItemID.PlatinumBar, 9);
                    PlatinumAxeR.AddRecipeGroup("Wood", 3);
                    PlatinumAxeR.AddTile(TileID.Anvils);
                    PlatinumAxeR.SetResult(ItemID.PlatinumAxe);
                    Recipe PlatinumAxeRR = PlatinumAxeR.FindExactRecipe();
                    if (PlatinumAxeRR != null)
                    {
                        RecipeEditor PlatinumAxeE = new RecipeEditor(PlatinumAxeRR);
                        PlatinumAxeE.DeleteRecipe();
                    }
                    ModRecipe PlatinumAxe = new ModRecipe(this);
                    PlatinumAxe.AddIngredient(ItemID.PlatinumBar, 8);
                    PlatinumAxe.AddRecipeGroup("Wood", 3);
                    PlatinumAxe.AddTile(TileID.Anvils);
                    PlatinumAxe.SetResult(ItemID.PlatinumAxe);
                    PlatinumAxe.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder PlatinumHammerR = new RecipeFinder();
                    PlatinumHammerR.AddIngredient(ItemID.PlatinumBar, 10);
                    PlatinumHammerR.AddRecipeGroup("Wood", 3);
                    PlatinumHammerR.AddTile(TileID.Anvils);
                    PlatinumHammerR.SetResult(ItemID.PlatinumHammer);
                    Recipe PlatinumHammerRR = PlatinumHammerR.FindExactRecipe();
                    if (PlatinumHammerRR != null)
                    {
                        RecipeEditor PlatinumHammerE = new RecipeEditor(PlatinumHammerRR);
                        PlatinumHammerE.DeleteRecipe();
                    }
                    ModRecipe PlatinumHammer = new ModRecipe(this);
                    PlatinumHammer.AddIngredient(ItemID.PlatinumBar, 8);
                    PlatinumHammer.AddRecipeGroup("Wood", 3);
                    PlatinumHammer.AddTile(TileID.Anvils);
                    PlatinumHammer.SetResult(ItemID.PlatinumHammer);
                    PlatinumHammer.AddRecipe();
                }
                if (GetInstance<Config>().allowWeaponRecipe)
                {
                    _ = new RecipeFinder();
                    RecipeFinder PlatinumBroadswordR = new RecipeFinder();
                    PlatinumBroadswordR.AddIngredient(ItemID.PlatinumBar, 8);
                    PlatinumBroadswordR.AddTile(TileID.Anvils);
                    PlatinumBroadswordR.SetResult(ItemID.PlatinumBroadsword);
                    Recipe PlatinumBroadswordRR = PlatinumBroadswordR.FindExactRecipe();
                    if (PlatinumBroadswordRR != null)
                    {
                        RecipeEditor PlatinumBroadswordE = new RecipeEditor(PlatinumBroadswordRR);
                        PlatinumBroadswordE.DeleteRecipe();
                    }
                    ModRecipe PlatinumBroadsword = new ModRecipe(this);
                    PlatinumBroadsword.AddIngredient(ItemID.PlatinumBar, 8);
                    PlatinumBroadsword.AddTile(TileID.Anvils);
                    PlatinumBroadsword.SetResult(ItemID.PlatinumBroadsword);
                    PlatinumBroadsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder PlatinumShortswordR = new RecipeFinder();
                    PlatinumShortswordR.AddIngredient(ItemID.PlatinumBar, 7);
                    PlatinumShortswordR.AddTile(TileID.Anvils);
                    PlatinumShortswordR.SetResult(ItemID.PlatinumShortsword);
                    Recipe PlatinumShortswordRR = PlatinumShortswordR.FindExactRecipe();
                    if (PlatinumShortswordRR != null)
                    {
                        RecipeEditor PlatinumShortswordE = new RecipeEditor(PlatinumShortswordRR);
                        PlatinumShortswordE.DeleteRecipe();
                    }
                    ModRecipe PlatinumShortsword = new ModRecipe(this);
                    PlatinumShortsword.AddIngredient(ItemID.PlatinumBar, 6);
                    PlatinumShortsword.AddTile(TileID.Anvils);
                    PlatinumShortsword.SetResult(ItemID.PlatinumShortsword);
                    PlatinumShortsword.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder PlatinumBowR = new RecipeFinder();
                    PlatinumBowR.AddIngredient(ItemID.PlatinumBar, 7);
                    PlatinumBowR.AddTile(TileID.Anvils);
                    PlatinumBowR.SetResult(ItemID.PlatinumBow);
                    Recipe PlatinumBowRR = PlatinumBowR.FindExactRecipe();
                    if (PlatinumBowRR != null)
                    {
                        RecipeEditor PlatinumBowE = new RecipeEditor(PlatinumBowRR);
                        PlatinumBowE.DeleteRecipe();
                    }
                    ModRecipe PlatinumBow = new ModRecipe(this);
                    PlatinumBow.AddIngredient(ItemID.PlatinumBar, 7);
                    PlatinumBow.AddTile(TileID.Anvils);
                    PlatinumBow.SetResult(ItemID.PlatinumBow);
                    PlatinumBow.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder DiamondStaffR = new RecipeFinder();
                    DiamondStaffR.AddIngredient(ItemID.PlatinumBar, 10);
                    DiamondStaffR.AddIngredient(ItemID.Diamond, 8);
                    DiamondStaffR.AddTile(TileID.Anvils);
                    DiamondStaffR.SetResult(ItemID.DiamondStaff);
                    Recipe DiamondStaffRR = DiamondStaffR.FindExactRecipe();
                    if (DiamondStaffRR != null)
                    {
                        RecipeEditor DiamondStaffE = new RecipeEditor(DiamondStaffRR);
                        DiamondStaffE.DeleteRecipe();
                    }
                    ModRecipe DiamondStaff = new ModRecipe(this);
                    DiamondStaff.AddIngredient(ItemID.PlatinumBar, 10);
                    DiamondStaff.AddIngredient(ItemID.Diamond, 8);
                    DiamondStaff.AddTile(TileID.Anvils);
                    DiamondStaff.SetResult(ItemID.DiamondStaff);
                    DiamondStaff.AddRecipe();
                }
                if (GetInstance<Config>().allowArmorRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder PlatinumHelmetR = new RecipeFinder();
                    PlatinumHelmetR.AddIngredient(ItemID.PlatinumBar, 25);
                    PlatinumHelmetR.AddTile(TileID.Anvils);
                    PlatinumHelmetR.SetResult(ItemID.PlatinumHelmet);
                    Recipe PlatinumHelmetRR = PlatinumHelmetR.FindExactRecipe();
                    if (PlatinumHelmetRR != null)
                    {
                        RecipeEditor PlatinumHelmetE = new RecipeEditor(PlatinumHelmetRR);
                        PlatinumHelmetE.DeleteRecipe();
                    }
                    ModRecipe PlatinumHelmet = new ModRecipe(this);
                    PlatinumHelmet.AddIngredient(ItemID.PlatinumBar, 20);
                    PlatinumHelmet.AddTile(TileID.Anvils);
                    PlatinumHelmet.SetResult(ItemID.PlatinumHelmet);
                    PlatinumHelmet.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder PlatinumChainmailR = new RecipeFinder();
                    PlatinumChainmailR.AddIngredient(ItemID.PlatinumBar, 35);
                    PlatinumChainmailR.AddTile(TileID.Anvils);
                    PlatinumChainmailR.SetResult(ItemID.PlatinumChainmail);
                    Recipe PlatinumChainmailRR = PlatinumChainmailR.FindExactRecipe();
                    if (PlatinumChainmailRR != null)
                    {
                        RecipeEditor PlatinumChainmailE = new RecipeEditor(PlatinumChainmailRR);
                        PlatinumChainmailE.DeleteRecipe();
                    }
                    ModRecipe PlatinumChainmail = new ModRecipe(this);
                    PlatinumChainmail.AddIngredient(ItemID.PlatinumBar, 30);
                    PlatinumChainmail.AddTile(TileID.Anvils);
                    PlatinumChainmail.SetResult(ItemID.PlatinumChainmail);
                    PlatinumChainmail.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder PlatinumGreavesR = new RecipeFinder();
                    PlatinumGreavesR.AddIngredient(ItemID.PlatinumBar, 30);
                    PlatinumGreavesR.AddTile(TileID.Anvils);
                    PlatinumGreavesR.SetResult(ItemID.PlatinumGreaves);
                    Recipe PlatinumGreavesRR = PlatinumGreavesR.FindExactRecipe();
                    if (PlatinumGreavesRR != null)
                    {
                        RecipeEditor PlatinumGreavesE = new RecipeEditor(PlatinumGreavesRR);
                        PlatinumGreavesE.DeleteRecipe();
                    }
                    ModRecipe PlatinumGreaves = new ModRecipe(this);
                    PlatinumGreaves.AddIngredient(ItemID.PlatinumBar, 25);
                    PlatinumGreaves.AddTile(TileID.Anvils);
                    PlatinumGreaves.SetResult(ItemID.PlatinumGreaves);
                    PlatinumGreaves.AddRecipe();
                }
                #endregion
                #endregion
                #region Weapon Recipe
                if (GetInstance<Config>().allowWeaponRecipe)
                {
                    #region too long kinda wanted to hide this
                    ModRecipe TungstenBulletbutactuallyitssilverbulletbecauseisaidiwontaddnewitemsinthismodsoiwontaddnewitemsinthismodsosilverbulletswilldoinstead = new ModRecipe(this);
                    TungstenBulletbutactuallyitssilverbulletbecauseisaidiwontaddnewitemsinthismodsoiwontaddnewitemsinthismodsosilverbulletswilldoinstead.AddIngredient(ItemID.MusketBall, 70);
                    TungstenBulletbutactuallyitssilverbulletbecauseisaidiwontaddnewitemsinthismodsoiwontaddnewitemsinthismodsosilverbulletswilldoinstead.AddIngredient(ItemID.TungstenBar);
                    TungstenBulletbutactuallyitssilverbulletbecauseisaidiwontaddnewitemsinthismodsoiwontaddnewitemsinthismodsosilverbulletswilldoinstead.AddTile(TileID.Anvils);
                    TungstenBulletbutactuallyitssilverbulletbecauseisaidiwontaddnewitemsinthismodsoiwontaddnewitemsinthismodsosilverbulletswilldoinstead.SetResult(ItemID.SilverBullet, 70);
                    TungstenBulletbutactuallyitssilverbulletbecauseisaidiwontaddnewitemsinthismodsoiwontaddnewitemsinthismodsosilverbulletswilldoinstead.AddRecipe();
                    #endregion
                    ModRecipe EnchantedBoomerang = new ModRecipe(this);
                    EnchantedBoomerang.AddIngredient(ItemID.FallenStar);
                    EnchantedBoomerang.AddIngredient(ItemID.WoodenBoomerang);
                    EnchantedBoomerang.SetResult(ItemID.EnchantedBoomerang);
                    EnchantedBoomerang.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder JungleYoyoR = new RecipeFinder();
                    JungleYoyoR.AddIngredient(ItemID.RichMahogany, 8);
                    JungleYoyoR.AddIngredient(ItemID.Stinger, 2);
                    JungleYoyoR.AddIngredient(ItemID.Vine);
                    JungleYoyoR.AddIngredient(ItemID.JungleSpores, 3);
                    JungleYoyoR.AddTile(TileID.Anvils);
                    JungleYoyoR.SetResult(ItemID.JungleYoyo);
                    Recipe JungleYoyoRR = JungleYoyoR.FindExactRecipe();
                    if (JungleYoyoRR != null)
                    {
                        RecipeEditor JungleYoyoE = new RecipeEditor(JungleYoyoRR);
                        JungleYoyoE.DeleteRecipe();
                    }
                    ModRecipe JungleYoyo = new ModRecipe(this);
                    JungleYoyo.AddIngredient(ItemID.RichMahogany, 8);
                    JungleYoyo.AddIngredient(ItemID.Stinger, 12);
                    JungleYoyo.AddIngredient(ItemID.Vine);
                    JungleYoyo.AddIngredient(ItemID.JungleSpores, 9);
                    JungleYoyo.AddTile(TileID.Anvils);
                    JungleYoyo.SetResult(ItemID.JungleYoyo);
                    JungleYoyo.AddRecipe();
                }
                #endregion
                #region Accessory Recipe
                if (GetInstance<Config>().allowAccessoryRecipe)
                {
                    ModRecipe BandOfStarpower = new ModRecipe(this);
                    BandOfStarpower.AddIngredient(ItemID.PanicNecklace);
                    BandOfStarpower.AddIngredient(ItemID.ManaCrystal);
                    BandOfStarpower.AddTile(TileID.TinkerersWorkbench);
                    BandOfStarpower.SetResult(ItemID.BandofStarpower);
                    BandOfStarpower.AddRecipe();

                    ModRecipe PanicNecklace = new ModRecipe(this);
                    PanicNecklace.AddIngredient(ItemID.BandofStarpower);
                    PanicNecklace.AddIngredient(ItemID.LifeCrystal);
                    PanicNecklace.AddTile(TileID.TinkerersWorkbench);
                    PanicNecklace.SetResult(ItemID.PanicNecklace);
                    PanicNecklace.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder LavaWadersR = new RecipeFinder();
                    LavaWadersR.AddIngredient(ItemID.LavaCharm);
                    LavaWadersR.AddIngredient(ItemID.ObsidianWaterWalkingBoots);
                    LavaWadersR.AddTile(TileID.TinkerersWorkbench);
                    LavaWadersR.SetResult(ItemID.LavaWaders);
                    Recipe LavaWadersRR = LavaWadersR.FindExactRecipe();
                    if (LavaWadersRR != null)
                    {
                        RecipeEditor LavaWadersE = new RecipeEditor(LavaWadersRR);
                        LavaWadersE.DeleteRecipe();
                    }
                    ModRecipe LavaWaders = new ModRecipe(this);
                    LavaWaders.AddIngredient(ItemID.LavaCharm);
                    LavaWaders.AddIngredient(ItemID.ObsidianWaterWalkingBoots);
                    LavaWaders.AddIngredient(ItemID.ObsidianRose);
                    LavaWaders.AddTile(TileID.TinkerersWorkbench);
                    LavaWaders.SetResult(ItemID.LavaWaders);
                    LavaWaders.AddRecipe();
                }
                #endregion
                #region Bar Recipe
                if (GetInstance<Config>().allowBarRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder AdamantiteBarR = new RecipeFinder();
                    AdamantiteBarR.AddIngredient(ItemID.AdamantiteOre, 5);
                    AdamantiteBarR.AddTile(TileID.AdamantiteForge);
                    AdamantiteBarR.SetResult(ItemID.AdamantiteBar);
                    Recipe AdamantiteBarRR = AdamantiteBarR.FindExactRecipe();
                    if (AdamantiteBarRR != null)
                    {
                        RecipeEditor AdamantiteBarE = new RecipeEditor(AdamantiteBarRR);
                        AdamantiteBarE.DeleteRecipe();
                    }
                    ModRecipe AdamaniteBar = new ModRecipe(this);
                    AdamaniteBar.AddIngredient(ItemID.AdamantiteOre, 4);
                    AdamaniteBar.AddTile(TileID.AdamantiteForge);
                    AdamaniteBar.SetResult(ItemID.AdamantiteBar);
                    AdamaniteBar.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TitaniumBarR = new RecipeFinder();
                    TitaniumBarR.AddIngredient(ItemID.TitaniumOre, 5);
                    TitaniumBarR.AddTile(TileID.AdamantiteForge);
                    TitaniumBarR.SetResult(ItemID.TitaniumBar);
                    Recipe TitaniumBarRR = TitaniumBarR.FindExactRecipe();
                    if (TitaniumBarRR != null)
                    {
                        RecipeEditor TitaniumBarE = new RecipeEditor(TitaniumBarRR);
                        TitaniumBarE.DeleteRecipe();
                    }
                    ModRecipe TitaniumBar = new ModRecipe(this);
                    TitaniumBar.AddIngredient(ItemID.TitaniumOre, 4);
                    TitaniumBar.AddTile(TileID.AdamantiteForge);
                    TitaniumBar.SetResult(ItemID.TitaniumBar);
                    TitaniumBar.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder ChlorophyteBarR = new RecipeFinder();
                    ChlorophyteBarR.AddIngredient(ItemID.ChlorophyteOre, 6);
                    ChlorophyteBarR.AddTile(TileID.AdamantiteForge);
                    ChlorophyteBarR.SetResult(ItemID.ChlorophyteBar);
                    Recipe ChlorophyteBarRR = ChlorophyteBarR.FindExactRecipe();
                    if (ChlorophyteBarRR != null)
                    {
                        RecipeEditor ChlorophyteBarE = new RecipeEditor(ChlorophyteBarRR);
                        ChlorophyteBarE.DeleteRecipe();
                    }
                    ModRecipe ChlorophyteBar = new ModRecipe(this);
                    ChlorophyteBar.AddIngredient(ItemID.ChlorophyteOre, 5);
                    ChlorophyteBar.AddTile(TileID.AdamantiteForge);
                    ChlorophyteBar.SetResult(ItemID.ChlorophyteBar);
                    ChlorophyteBar.AddRecipe();
                }
                #endregion
                #region Dye Recipe
                if (GetInstance<Config>().allowDyeRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder RedDyeR = new RecipeFinder();
                    RedDyeR.AddIngredient(ItemID.RedHusk);
                    RedDyeR.AddTile(TileID.DyeVat);
                    RedDyeR.SetResult(ItemID.RedDye);
                    Recipe RedDyeRR = RedDyeR.FindExactRecipe();
                    if (RedDyeR != null)
                    {
                        RecipeEditor RedDyeE = new RecipeEditor(RedDyeRR);
                        RedDyeE.DeleteRecipe();
                    }
                    ModRecipe RedDye = new ModRecipe(this);
                    RedDye.AddIngredient(ItemID.RedHusk);
                    RedDye.AddTile(TileID.DyeVat);
                    RedDye.SetResult(ItemID.RedDye, 2);
                    RedDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder OrangeDyeR = new RecipeFinder();
                    OrangeDyeR.AddIngredient(ItemID.OrangeBloodroot);
                    OrangeDyeR.AddTile(TileID.DyeVat);
                    OrangeDyeR.SetResult(ItemID.OrangeDye);
                    Recipe OrangeDyeRR = OrangeDyeR.FindExactRecipe();
                    if (OrangeDyeRR != null)
                    {
                        RecipeEditor OrangeDyeE = new RecipeEditor(OrangeDyeRR);
                        OrangeDyeE.DeleteRecipe();
                    }
                    ModRecipe OrangeDye = new ModRecipe(this);
                    OrangeDye.AddIngredient(ItemID.OrangeBloodroot);
                    OrangeDye.AddTile(TileID.DyeVat);
                    OrangeDye.SetResult(ItemID.OrangeDye, 2);
                    OrangeDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder YellowDyeR = new RecipeFinder();
                    YellowDyeR.AddIngredient(ItemID.YellowMarigold);
                    YellowDyeR.AddTile(TileID.DyeVat);
                    YellowDyeR.SetResult(ItemID.YellowDye);
                    Recipe YellowDyeRR = YellowDyeR.FindExactRecipe();
                    if (YellowDyeRR != null)
                    {
                        RecipeEditor YellowDyeE = new RecipeEditor(YellowDyeRR);
                        YellowDyeE.DeleteRecipe();
                    }
                    ModRecipe YellowDye = new ModRecipe(this);
                    YellowDye.AddIngredient(ItemID.YellowMarigold);
                    YellowDye.AddTile(TileID.DyeVat);
                    YellowDye.SetResult(ItemID.YellowDye, 2);
                    YellowDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder LimeDyeR = new RecipeFinder();
                    LimeDyeR.AddIngredient(ItemID.LimeKelp);
                    LimeDyeR.AddTile(TileID.DyeVat);
                    LimeDyeR.SetResult(ItemID.LimeDye);
                    Recipe LimeDyeRR = LimeDyeR.FindExactRecipe();
                    if (LimeDyeRR != null)
                    {
                        RecipeEditor LimeDyeE = new RecipeEditor(LimeDyeRR);
                        LimeDyeE.DeleteRecipe();
                    }
                    ModRecipe LimeDye = new ModRecipe(this);
                    LimeDye.AddIngredient(ItemID.LimeKelp);
                    LimeDye.AddTile(TileID.DyeVat);
                    LimeDye.SetResult(ItemID.LimeDye, 2);
                    LimeDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder GreenDyeR = new RecipeFinder();
                    GreenDyeR.AddIngredient(ItemID.GreenMushroom);
                    GreenDyeR.AddTile(TileID.DyeVat);
                    GreenDyeR.SetResult(ItemID.GreenDye);
                    Recipe GreenDyeRR = GreenDyeR.FindExactRecipe();
                    if (GreenDyeRR != null)
                    {
                        RecipeEditor GreenDyeE = new RecipeEditor(GreenDyeRR);
                        GreenDyeE.DeleteRecipe();
                    }
                    ModRecipe GreenDye = new ModRecipe(this);
                    GreenDye.AddIngredient(ItemID.GreenMushroom);
                    GreenDye.AddTile(TileID.DyeVat);
                    GreenDye.SetResult(ItemID.GreenDye, 2);
                    GreenDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TealDyeR = new RecipeFinder();
                    TealDyeR.AddIngredient(ItemID.TealMushroom);
                    TealDyeR.AddTile(TileID.DyeVat);
                    TealDyeR.SetResult(ItemID.TealDye);
                    Recipe TealDyeRR = TealDyeR.FindExactRecipe();
                    if (TealDyeRR != null)
                    {
                        RecipeEditor TealDyeE = new RecipeEditor(TealDyeRR);
                        TealDyeE.DeleteRecipe();
                    }
                    ModRecipe TealDye = new ModRecipe(this);
                    TealDye.AddIngredient(ItemID.TealMushroom);
                    TealDye.AddTile(TileID.DyeVat);
                    TealDye.SetResult(ItemID.TealDye, 2);
                    TealDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder CyanDyeR = new RecipeFinder();
                    CyanDyeR.AddIngredient(ItemID.CyanHusk);
                    CyanDyeR.AddTile(TileID.DyeVat);
                    CyanDyeR.SetResult(ItemID.CyanDye);
                    Recipe CyanDyeRR = CyanDyeR.FindExactRecipe();
                    if (CyanDyeRR != null)
                    {
                        RecipeEditor CyanDyeE = new RecipeEditor(CyanDyeRR);
                        CyanDyeE.DeleteRecipe();
                    }
                    ModRecipe CyanDye = new ModRecipe(this);
                    CyanDye.AddIngredient(ItemID.CyanHusk);
                    CyanDye.AddTile(TileID.DyeVat);
                    CyanDye.SetResult(ItemID.CyanDye, 2);
                    CyanDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder SkyBlueDyeR = new RecipeFinder();
                    SkyBlueDyeR.AddIngredient(ItemID.SkyBlueFlower);
                    SkyBlueDyeR.AddTile(TileID.DyeVat);
                    SkyBlueDyeR.SetResult(ItemID.SkyBlueDye);
                    Recipe SkyBlueDyeRR = SkyBlueDyeR.FindExactRecipe();
                    if (SkyBlueDyeRR != null)
                    {
                        RecipeEditor SkyBlueDyeE = new RecipeEditor(SkyBlueDyeRR);
                        SkyBlueDyeE.DeleteRecipe();
                    }
                    ModRecipe SkyBlueDye = new ModRecipe(this);
                    SkyBlueDye.AddIngredient(ItemID.SkyBlueFlower);
                    SkyBlueDye.AddTile(TileID.DyeVat);
                    SkyBlueDye.SetResult(ItemID.SkyBlueDye, 2);
                    SkyBlueDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder BlueDyeR = new RecipeFinder();
                    BlueDyeR.AddIngredient(ItemID.BlueBerries);
                    BlueDyeR.AddTile(TileID.DyeVat);
                    BlueDyeR.SetResult(ItemID.BlueDye);
                    Recipe BlueDyeRR = BlueDyeR.FindExactRecipe();
                    if (BlueDyeRR != null)
                    {
                        RecipeEditor BlueDyeE = new RecipeEditor(BlueDyeRR);
                        BlueDyeE.DeleteRecipe();
                    }
                    ModRecipe BlueDye = new ModRecipe(this);
                    BlueDye.AddIngredient(ItemID.BlueBerries);
                    BlueDye.AddTile(TileID.DyeVat);
                    BlueDye.SetResult(ItemID.BlueDye, 2);
                    BlueDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder PurpleDyeR = new RecipeFinder();
                    PurpleDyeR.AddIngredient(ItemID.PurpleMucos);
                    PurpleDyeR.AddTile(TileID.DyeVat);
                    PurpleDyeR.SetResult(ItemID.PurpleDye);
                    Recipe PurpleDyeRR = PurpleDyeR.FindExactRecipe();
                    if (PurpleDyeRR != null)
                    {
                        RecipeEditor PurpleDyeE = new RecipeEditor(PurpleDyeRR);
                        PurpleDyeE.DeleteRecipe();
                    }
                    ModRecipe PurpleDye = new ModRecipe(this);
                    PurpleDye.AddIngredient(ItemID.PurpleMucos);
                    PurpleDye.AddTile(TileID.DyeVat);
                    PurpleDye.SetResult(ItemID.PurpleDye, 2);
                    PurpleDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder VioletDyeR = new RecipeFinder();
                    VioletDyeR.AddIngredient(ItemID.VioletHusk);
                    VioletDyeR.AddTile(TileID.DyeVat);
                    VioletDyeR.SetResult(ItemID.VioletDye);
                    Recipe VioletDyeRR = VioletDyeR.FindExactRecipe();
                    if (VioletDyeRR != null)
                    {
                        RecipeEditor VioletDyeE = new RecipeEditor(VioletDyeRR);
                        VioletDyeE.DeleteRecipe();
                    }
                    ModRecipe VioletDye = new ModRecipe(this);
                    VioletDye.AddIngredient(ItemID.VioletHusk);
                    VioletDye.AddTile(TileID.DyeVat);
                    VioletDye.SetResult(ItemID.VioletDye, 2);
                    VioletDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder PinkDyeR = new RecipeFinder();
                    PinkDyeR.AddIngredient(ItemID.PinkPricklyPear);
                    PinkDyeR.AddTile(TileID.DyeVat);
                    PinkDyeR.SetResult(ItemID.PinkDye);
                    Recipe PinkDyeRR = PinkDyeR.FindExactRecipe();
                    if (PinkDyeRR != null)
                    {
                        RecipeEditor PinkDyeE = new RecipeEditor(PinkDyeRR);
                        PinkDyeE.DeleteRecipe();
                    }
                    ModRecipe PinkDye = new ModRecipe(this);
                    PinkDye.AddIngredient(ItemID.PinkPricklyPear);
                    PinkDye.AddTile(TileID.DyeVat);
                    PinkDye.SetResult(ItemID.PinkDye, 2);
                    PinkDye.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder BlackDyeR = new RecipeFinder();
                    BlackDyeR.AddIngredient(ItemID.BlackInk);
                    BlackDyeR.AddTile(TileID.DyeVat);
                    BlackDyeR.SetResult(ItemID.BlackDye);
                    Recipe BlackDyeRR = BlackDyeR.FindExactRecipe();
                    if (BlackDyeRR != null)
                    {
                        RecipeEditor BlackDyeE = new RecipeEditor(BlackDyeRR);
                        BlackDyeE.DeleteRecipe();
                    }
                    ModRecipe BlackDye = new ModRecipe(this);
                    BlackDye.AddIngredient(ItemID.BlackInk);
                    BlackDye.AddTile(TileID.DyeVat);
                    BlackDye.SetResult(ItemID.BlackDye, 2);
                    BlackDye.AddRecipe();
                }
                #endregion Recipe s
                #region Platform Recipe
                if (GetInstance<Config>().allowPlatformRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder BonePFR = new RecipeFinder();
                    BonePFR.AddIngredient(ItemID.Bone);
                    BonePFR.AddTile(TileID.BoneWelder);
                    BonePFR.SetResult(ItemID.BonePlatform, 2);
                    Recipe BonePFRR = BonePFR.FindExactRecipe();
                    if (BonePFRR != null)
                    {
                        RecipeEditor BonePFE = new RecipeEditor(BonePFRR);
                        BonePFE.DeleteRecipe();
                    }
                    ModRecipe BonePF = new ModRecipe(this);
                    BonePF.AddIngredient(ItemID.Bone);
                    BonePF.SetResult(ItemID.BonePlatform, 2);
                    BonePF.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder BoneR = new RecipeFinder();
                    BoneR.AddIngredient(ItemID.BonePlatform, 2);
                    BoneR.AddTile(TileID.BoneWelder);
                    BoneR.SetResult(ItemID.Bone);
                    Recipe BoneRR = BoneR.FindExactRecipe();
                    if (BoneRR != null)
                    {
                        RecipeEditor BoneE = new RecipeEditor(BoneRR);
                        BoneE.DeleteRecipe();
                    }
                    ModRecipe Bone = new ModRecipe(this);
                    Bone.AddIngredient(ItemID.BonePlatform, 2);
                    Bone.SetResult(ItemID.Bone);
                    Bone.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder HoneyPFR = new RecipeFinder();
                    HoneyPFR.AddIngredient(ItemID.HoneyBlock);
                    HoneyPFR.AddTile(TileID.HoneyDispenser);
                    HoneyPFR.SetResult(ItemID.HoneyPlatform, 2);
                    Recipe HoneyPFRR = HoneyPFR.FindExactRecipe();
                    if (HoneyPFRR != null)
                    {
                        RecipeEditor HoneyPFE = new RecipeEditor(HoneyPFRR);
                        HoneyPFE.DeleteRecipe();
                    }
                    ModRecipe HoneyPF = new ModRecipe(this);
                    HoneyPF.AddIngredient(ItemID.HoneyBlock);
                    HoneyPF.SetResult(ItemID.HoneyPlatform, 2);
                    HoneyPF.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder HoneyR = new RecipeFinder();
                    HoneyR.AddIngredient(ItemID.HoneyPlatform, 2);
                    HoneyR.AddTile(TileID.HoneyDispenser);
                    HoneyR.SetResult(ItemID.HoneyBlock);
                    Recipe HoneyRR = HoneyR.FindExactRecipe();
                    if (HoneyRR != null)
                    {
                        RecipeEditor HoneyE = new RecipeEditor(HoneyRR);
                        HoneyE.DeleteRecipe();
                    }
                    ModRecipe Honey = new ModRecipe(this);
                    Honey.AddIngredient(ItemID.HoneyPlatform, 2);
                    Honey.SetResult(ItemID.HoneyBlock);
                    Honey.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder SkyPFR = new RecipeFinder();
                    SkyPFR.AddIngredient(ItemID.SunplateBlock);
                    SkyPFR.AddTile(TileID.SkyMill);
                    SkyPFR.SetResult(ItemID.SkywarePlatform, 2);
                    Recipe SkyPFRR = SkyPFR.FindExactRecipe();
                    if (SkyPFRR != null)
                    {
                        RecipeEditor SkyPFE = new RecipeEditor(SkyPFRR);
                        SkyPFE.DeleteRecipe();
                    }
                    ModRecipe SkyPF = new ModRecipe(this);
                    SkyPF.AddIngredient(ItemID.SunplateBlock);
                    SkyPF.SetResult(ItemID.SkywarePlatform, 2);
                    SkyPF.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder SkyR = new RecipeFinder();
                    SkyR.AddIngredient(ItemID.SkywarePlatform, 2);
                    SkyR.AddTile(TileID.SkyMill);
                    SkyR.SetResult(ItemID.SunplateBlock);
                    Recipe SkyRR = SkyR.FindExactRecipe();
                    if (SkyRR != null)
                    {
                        RecipeEditor SkyE = new RecipeEditor(SkyRR);
                        SkyE.DeleteRecipe();
                    }
                    ModRecipe Sky = new ModRecipe(this);
                    Sky.AddIngredient(ItemID.SkywarePlatform, 2);
                    Sky.SetResult(ItemID.SunplateBlock);
                    Sky.AddRecipe();


                    _ = new RecipeFinder();
                    RecipeFinder SteamPFR = new RecipeFinder();
                    SteamPFR.AddIngredient(ItemID.Cog);
                    SteamPFR.AddTile(TileID.SteampunkBoiler);
                    SteamPFR.SetResult(ItemID.SteampunkPlatform, 2);
                    Recipe SteamPFRR = SteamPFR.FindExactRecipe();
                    if (SteamPFRR != null)
                    {
                        RecipeEditor SteamPFE = new RecipeEditor(SteamPFRR);
                        SteamPFE.DeleteRecipe();
                    }
                    ModRecipe SteamPF = new ModRecipe(this);
                    SteamPF.AddIngredient(ItemID.Cog);
                    SteamPF.SetResult(ItemID.SteampunkPlatform, 2);
                    SteamPF.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder SteamR = new RecipeFinder();
                    SteamR.AddIngredient(ItemID.SteampunkPlatform, 2);
                    SteamR.AddTile(TileID.SteampunkBoiler);
                    SteamR.SetResult(ItemID.Cog);
                    Recipe SteamRR = SteamR.FindExactRecipe();
                    if (SteamRR != null)
                    {
                        RecipeEditor SteamE = new RecipeEditor(SteamRR);
                        SteamE.DeleteRecipe();
                    }
                    ModRecipe Steam = new ModRecipe(this);
                    Steam.AddIngredient(ItemID.SteampunkPlatform, 2);
                    Steam.SetResult(ItemID.Cog);
                    Steam.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder CactusPFR = new RecipeFinder();
                    CactusPFR.AddIngredient(ItemID.Cactus);
                    CactusPFR.AddTile(TileID.WorkBenches);
                    CactusPFR.SetResult(ItemID.CactusPlatform, 2);
                    Recipe CactusPFRR = CactusPFR.FindExactRecipe();
                    if (CactusPFRR != null)
                    {
                        RecipeEditor CactusPFE = new RecipeEditor(CactusPFRR);
                        CactusPFE.DeleteRecipe();
                    }
                    ModRecipe CactusPF = new ModRecipe(this);
                    CactusPF.AddIngredient(ItemID.Cactus);
                    CactusPF.SetResult(ItemID.CactusPlatform, 2);
                    CactusPF.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder CactusR = new RecipeFinder();
                    CactusR.AddIngredient(ItemID.CactusPlatform, 2);
                    CactusR.AddTile(TileID.WorkBenches);
                    CactusR.SetResult(ItemID.Cactus);
                    Recipe CactusRR = CactusR.FindExactRecipe();
                    if (CactusRR != null)
                    {
                        RecipeEditor CactusE = new RecipeEditor(CactusRR);
                        CactusE.DeleteRecipe();
                    }
                    ModRecipe Cactus = new ModRecipe(this);
                    Cactus.AddIngredient(ItemID.CactusPlatform, 2);
                    Cactus.SetResult(ItemID.Cactus);
                    Cactus.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder GlassPFR = new RecipeFinder();
                    GlassPFR.AddIngredient(ItemID.Glass);
                    GlassPFR.AddTile(TileID.WorkBenches);
                    GlassPFR.SetResult(ItemID.GlassPlatform, 2);
                    Recipe GlassPFRR = GlassPFR.FindExactRecipe();
                    if (GlassPFRR != null)
                    {
                        RecipeEditor GlassPFE = new RecipeEditor(GlassPFRR);
                        GlassPFE.DeleteRecipe();
                    }

                    ModRecipe GlassPF = new ModRecipe(this);
                    GlassPF.AddIngredient(ItemID.Glass);
                    GlassPF.SetResult(ItemID.GlassPlatform, 2);
                    GlassPF.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder GlassR = new RecipeFinder();
                    GlassR.AddIngredient(ItemID.GlassPlatform, 2);
                    GlassR.AddTile(TileID.WorkBenches);
                    GlassR.SetResult(ItemID.Glass);
                    Recipe GlassRR = GlassR.FindExactRecipe();
                    if (GlassRR != null)
                    {
                        RecipeEditor GlassE = new RecipeEditor(GlassRR);
                        GlassE.DeleteRecipe();
                    }
                    ModRecipe Glass = new ModRecipe(this);
                    Glass.AddIngredient(ItemID.GlassPlatform, 2);
                    Glass.SetResult(ItemID.Glass);
                    Glass.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder MushPFR = new RecipeFinder();
                    MushPFR.AddIngredient(ItemID.GlowingMushroom);
                    MushPFR.AddTile(TileID.WorkBenches);
                    MushPFR.SetResult(ItemID.MushroomPlatform, 2);
                    Recipe MushPFRR = MushPFR.FindExactRecipe();
                    if (MushPFRR != null)
                    {
                        RecipeEditor MushPFE = new RecipeEditor(MushPFRR);
                        MushPFE.DeleteRecipe();
                    }
                    ModRecipe MushPF = new ModRecipe(this);
                    MushPF.AddIngredient(ItemID.GlowingMushroom);
                    MushPF.SetResult(ItemID.MushroomPlatform, 2);
                    MushPF.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder MushR = new RecipeFinder();
                    MushR.AddIngredient(ItemID.MushroomPlatform, 2);
                    MushR.AddTile(TileID.WorkBenches);
                    MushR.SetResult(ItemID.GlowingMushroom);
                    Recipe MushRR = MushR.FindExactRecipe();
                    if (MushRR != null)
                    {
                        RecipeEditor MushE = new RecipeEditor(MushRR);
                        MushE.DeleteRecipe();
                    }
                    ModRecipe Mush = new ModRecipe(this);
                    Mush.AddIngredient(ItemID.MushroomPlatform, 2);
                    Mush.SetResult(ItemID.GlowingMushroom);
                    Mush.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder PumpkinPFR = new RecipeFinder();
                    PumpkinPFR.AddIngredient(ItemID.Pumpkin);
                    PumpkinPFR.AddTile(TileID.WorkBenches);
                    PumpkinPFR.SetResult(ItemID.PumpkinPlatform, 2);
                    Recipe PumpkinPFRR = PumpkinPFR.FindExactRecipe();
                    if (PumpkinPFRR != null)
                    {
                        RecipeEditor PumpkinPFE = new RecipeEditor(PumpkinPFRR);
                        PumpkinPFE.DeleteRecipe();
                    }
                    ModRecipe PumpkinPF = new ModRecipe(this);
                    PumpkinPF.AddIngredient(ItemID.Pumpkin);
                    PumpkinPF.SetResult(ItemID.PumpkinPlatform, 2);
                    PumpkinPF.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder PumpkinR = new RecipeFinder();
                    PumpkinR.AddIngredient(ItemID.PumpkinPlatform, 2);
                    PumpkinR.AddTile(TileID.WorkBenches);
                    PumpkinR.SetResult(ItemID.Pumpkin);
                    Recipe PumpkinRR = PumpkinR.FindExactRecipe();
                    if (PumpkinRR != null)
                    {
                        RecipeEditor PumpkinE = new RecipeEditor(PumpkinRR);
                        PumpkinE.DeleteRecipe();
                    }
                    ModRecipe Pumpkin = new ModRecipe(this);
                    Pumpkin.AddIngredient(ItemID.PumpkinPlatform, 2);
                    Pumpkin.SetResult(ItemID.Pumpkin);
                    Pumpkin.AddRecipe();
                }
                #endregion
                #region Tile Recipe
                if (GetInstance<Config>().allowTileRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder BoulderR = new RecipeFinder();
                    BoulderR.AddIngredient(ItemID.StoneBlock, 6);
                    BoulderR.AddTile(TileID.TinkerersWorkbench);
                    BoulderR.SetResult(ItemID.Boulder);
                    Recipe BoulderRR = BoulderR.FindExactRecipe();
                    if (BoulderRR != null)
                    {
                        RecipeEditor BoulderE = new RecipeEditor(BoulderRR);
                        BoulderE.DeleteRecipe();
                    }
                    ModRecipe Boulder = new ModRecipe(this);
                    Boulder.AddIngredient(ItemID.StoneBlock, 6);
                    Boulder.AddTile(TileID.HeavyWorkBench);
                    Boulder.SetResult(ItemID.Boulder);
                    Boulder.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder ClayPotR = new RecipeFinder();
                    ClayPotR.AddIngredient(ItemID.ClayBlock, 6);
                    ClayPotR.AddTile(TileID.Furnaces);
                    ClayPotR.SetResult(ItemID.ClayPot);
                    Recipe ClayPotRR = ClayPotR.FindExactRecipe();
                    if (ClayPotRR != null)
                    {
                        RecipeEditor ClayPotE = new RecipeEditor(ClayPotRR);
                        ClayPotE.DeleteRecipe();
                    }
                    ModRecipe ClayPot = new ModRecipe(this);
                    ClayPot.AddIngredient(ItemID.ClayBlock, 5);
                    ClayPot.AddTile(TileID.Furnaces);
                    ClayPot.SetResult(ItemID.ClayPot);
                    ClayPot.AddRecipe();
                }
                #endregion
                #region Torch Recipe
                if (GetInstance<Config>().allowTorchRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder BlueTorchR = new RecipeFinder();
                    BlueTorchR.AddIngredient(ItemID.Torch, 3);
                    BlueTorchR.AddIngredient(ItemID.Sapphire);
                    BlueTorchR.SetResult(ItemID.BlueTorch, 3);
                    Recipe BlueTorchRR = BlueTorchR.FindExactRecipe();
                    if (BlueTorchRR != null)
                    {
                        RecipeEditor BlueTorchE = new RecipeEditor(BlueTorchRR);
                        BlueTorchE.DeleteRecipe();
                    }
                    _ = new RecipeFinder();
                    RecipeFinder GreenTorchR = new RecipeFinder();
                    GreenTorchR.AddIngredient(ItemID.Torch, 3);
                    GreenTorchR.AddIngredient(ItemID.Emerald);
                    GreenTorchR.SetResult(ItemID.GreenTorch, 3);
                    Recipe GreenTorchRR = GreenTorchR.FindExactRecipe();
                    if (GreenTorchRR != null)
                    {
                        RecipeEditor GreenTorchE = new RecipeEditor(GreenTorchRR);
                        GreenTorchE.DeleteRecipe();
                    }
                    _ = new RecipeFinder();
                    RecipeFinder OrangeTorchR = new RecipeFinder();
                    OrangeTorchR.AddIngredient(ItemID.Torch, 3);
                    OrangeTorchR.AddIngredient(ItemID.Amber);
                    OrangeTorchR.SetResult(ItemID.OrangeTorch, 3);
                    Recipe OrangeTorchRR = OrangeTorchR.FindExactRecipe();
                    if (OrangeTorchRR != null)
                    {
                        RecipeEditor OrangeTorchE = new RecipeEditor(OrangeTorchRR);
                        OrangeTorchE.DeleteRecipe();
                    }
                    _ = new RecipeFinder();
                    RecipeFinder PurpleTorchR = new RecipeFinder();
                    PurpleTorchR.AddIngredient(ItemID.Torch, 3);
                    PurpleTorchR.AddIngredient(ItemID.Amethyst);
                    PurpleTorchR.SetResult(ItemID.PurpleTorch, 3);
                    Recipe PurpleTorchRR = PurpleTorchR.FindExactRecipe();
                    if (PurpleTorchRR != null)
                    {
                        RecipeEditor PurpleTorchE = new RecipeEditor(PurpleTorchRR);
                        PurpleTorchE.DeleteRecipe();
                    }
                    _ = new RecipeFinder();
                    RecipeFinder RedTorchR = new RecipeFinder();
                    RedTorchR.AddIngredient(ItemID.Torch, 3);
                    RedTorchR.AddIngredient(ItemID.Ruby);
                    RedTorchR.SetResult(ItemID.RedTorch, 3);
                    Recipe RedTorchRR = RedTorchR.FindExactRecipe();
                    if (RedTorchRR != null)
                    {
                        RecipeEditor RedTorchE = new RecipeEditor(RedTorchRR);
                        RedTorchE.DeleteRecipe();
                    }
                    _ = new RecipeFinder();
                    RecipeFinder WhiteTorchR = new RecipeFinder();
                    WhiteTorchR.AddIngredient(ItemID.Torch, 3);
                    WhiteTorchR.AddIngredient(ItemID.Diamond);
                    WhiteTorchR.SetResult(ItemID.WhiteTorch, 3);
                    Recipe WhiteTorchRR = WhiteTorchR.FindExactRecipe();
                    if (WhiteTorchRR != null)
                    {
                        RecipeEditor WhiteTorchE = new RecipeEditor(WhiteTorchRR);
                        WhiteTorchE.DeleteRecipe();
                    }
                    _ = new RecipeFinder();
                    RecipeFinder YellowTorchR = new RecipeFinder();
                    YellowTorchR.AddIngredient(ItemID.Torch, 3);
                    YellowTorchR.AddIngredient(ItemID.Topaz);
                    YellowTorchR.SetResult(ItemID.YellowTorch, 3);
                    Recipe YellowTorchRR = YellowTorchR.FindExactRecipe();
                    if (YellowTorchRR != null)
                    {
                        RecipeEditor YellowTorchE = new RecipeEditor(YellowTorchRR);
                        YellowTorchE.DeleteRecipe();
                    }
                    _ = new RecipeFinder();
                    RecipeFinder IceTorchR = new RecipeFinder();
                    IceTorchR.AddIngredient(ItemID.Torch, 3);
                    IceTorchR.AddIngredient(ItemID.IceBlock);
                    IceTorchR.SetResult(ItemID.IceTorch, 3);
                    Recipe IceTorchRR = IceTorchR.FindExactRecipe();
                    if (IceTorchRR != null)
                    {
                        RecipeEditor IceTorchE = new RecipeEditor(IceTorchRR);
                        IceTorchE.DeleteRecipe();
                    }
                    ModRecipe IceTorch = new ModRecipe(this);
                    IceTorch.AddIngredient(ItemID.Torch, 3);
                    IceTorch.AddIngredient(ItemID.IceBlock);
                    IceTorch.SetResult(ItemID.IceTorch, 3);
                    IceTorch.AddRecipe();
                    ModRecipe IceTorchAlt1 = new ModRecipe(this);
                    IceTorchAlt1.AddIngredient(ItemID.Torch, 3);
                    IceTorchAlt1.AddIngredient(ItemID.PinkIceBlock);
                    IceTorchAlt1.SetResult(ItemID.IceTorch, 3);
                    IceTorchAlt1.AddRecipe();
                    ModRecipe IceTorchAlt2 = new ModRecipe(this);
                    IceTorchAlt2.AddIngredient(ItemID.Torch, 3);
                    IceTorchAlt2.AddIngredient(ItemID.PurpleIceBlock);
                    IceTorchAlt2.SetResult(ItemID.IceTorch, 3);
                    IceTorchAlt2.AddRecipe();
                    ModRecipe IceTorchAlt3 = new ModRecipe(this);
                    IceTorchAlt3.AddIngredient(ItemID.Torch, 3);
                    IceTorchAlt3.AddIngredient(ItemID.RedIceBlock);
                    IceTorchAlt3.SetResult(ItemID.IceTorch, 3);
                    IceTorchAlt3.AddRecipe();
                    ModRecipe DiamondTorch = new ModRecipe(this);
                    DiamondTorch.AddIngredient(ItemID.Torch, 10);
                    DiamondTorch.AddIngredient(ItemID.Diamond);
                    DiamondTorch.SetResult(ItemID.WhiteTorch, 10);
                    DiamondTorch.AddRecipe();
                    ModRecipe AmberTorch = new ModRecipe(this);
                    AmberTorch.AddIngredient(ItemID.Torch, 10);
                    AmberTorch.AddIngredient(ItemID.Amber);
                    AmberTorch.SetResult(ItemID.OrangeTorch, 10);
                    AmberTorch.AddRecipe();
                    ModRecipe RubyTorch = new ModRecipe(this);
                    RubyTorch.AddIngredient(ItemID.Torch, 10);
                    RubyTorch.AddIngredient(ItemID.Ruby);
                    RubyTorch.SetResult(ItemID.RedTorch, 10);
                    RubyTorch.AddRecipe();
                    ModRecipe EmeraldTorch = new ModRecipe(this);
                    EmeraldTorch.AddIngredient(ItemID.Torch, 10);
                    EmeraldTorch.AddIngredient(ItemID.Emerald);
                    EmeraldTorch.SetResult(ItemID.GreenTorch, 10);
                    EmeraldTorch.AddRecipe();
                    ModRecipe SapphireTorch = new ModRecipe(this);
                    SapphireTorch.AddIngredient(ItemID.Torch, 10);
                    SapphireTorch.AddIngredient(ItemID.Sapphire);
                    SapphireTorch.SetResult(ItemID.BlueTorch, 10);
                    SapphireTorch.AddRecipe();
                    ModRecipe TopazTorch = new ModRecipe(this);
                    TopazTorch.AddIngredient(ItemID.Torch, 10);
                    TopazTorch.AddIngredient(ItemID.Topaz);
                    TopazTorch.SetResult(ItemID.YellowTorch, 10);
                    TopazTorch.AddRecipe();
                    ModRecipe AmethystTorch = new ModRecipe(this);
                    AmethystTorch.AddIngredient(ItemID.Torch, 10);
                    AmethystTorch.AddIngredient(ItemID.Amethyst);
                    AmethystTorch.SetResult(ItemID.PurpleTorch, 10);
                    AmethystTorch.AddRecipe();
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
                    _ = new RecipeFinder();
                    RecipeFinder TerraBladeR = new RecipeFinder();
                    TerraBladeR.AddIngredient(ItemID.TrueExcalibur);
                    TerraBladeR.AddIngredient(ItemID.TrueNightsEdge);
                    TerraBladeR.AddTile(TileID.MythrilAnvil);
                    TerraBladeR.SetResult(ItemID.TerraBlade);
                    Recipe TerraBladeRR = TerraBladeR.FindExactRecipe();
                    if (TerraBladeRR != null)
                    {
                        RecipeEditor TerraBladeE = new RecipeEditor(TerraBladeRR);
                        TerraBladeE.DeleteRecipe();
                    }
                    ModRecipe TerraBlade = new ModRecipe(this);
                    TerraBlade.AddIngredient(ItemID.TrueNightsEdge);
                    TerraBlade.AddIngredient(ItemID.TrueExcalibur);
                    TerraBlade.AddIngredient(ItemID.BrokenHeroSword);
                    TerraBlade.AddTile(TileID.MythrilAnvil);
                    TerraBlade.SetResult(ItemID.TerraBlade);
                    TerraBlade.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TrueNightsEdgeR = new RecipeFinder();
                    TrueNightsEdgeR.AddIngredient(ItemID.NightsEdge);
                    TrueNightsEdgeR.AddIngredient(ItemID.BrokenHeroSword);
                    TrueNightsEdgeR.AddTile(TileID.MythrilAnvil);
                    TrueNightsEdgeR.SetResult(ItemID.TrueNightsEdge);
                    Recipe TrueNightsEdgeRR = TrueNightsEdgeR.FindExactRecipe();
                    if (TrueNightsEdgeRR != null)
                    {
                        RecipeEditor TrueNightsEdgeE = new RecipeEditor(TrueNightsEdgeRR);
                        TrueNightsEdgeE.DeleteRecipe();
                    }
                    ModRecipe TrueNightsEdge = new ModRecipe(this);
                    TrueNightsEdge.AddIngredient(ItemID.NightsEdge);
                    TrueNightsEdge.AddIngredient(ItemID.SoulofSight, 20);
                    TrueNightsEdge.AddIngredient(ItemID.SoulofMight, 20);
                    TrueNightsEdge.AddIngredient(ItemID.SoulofFright, 20);
                    TrueNightsEdge.AddTile(TileID.MythrilAnvil);
                    TrueNightsEdge.SetResult(ItemID.TrueNightsEdge);
                    TrueNightsEdge.AddRecipe();

                    _ = new RecipeFinder();
                    RecipeFinder TrueExcaliburR = new RecipeFinder();
                    TrueExcaliburR.AddIngredient(ItemID.Excalibur);
                    TrueExcaliburR.AddIngredient(ItemID.BrokenHeroSword);
                    TrueExcaliburR.AddTile(TileID.MythrilAnvil);
                    TrueExcaliburR.SetResult(ItemID.TrueExcalibur);
                    Recipe TrueExcaliburRR = TrueExcaliburR.FindExactRecipe();
                    if (TrueExcaliburRR != null)
                    {
                        RecipeEditor TrueExcaliburE = new RecipeEditor(TrueExcaliburRR);
                        TrueExcaliburE.DeleteRecipe();
                    }
                    ModRecipe TrueExcalibur = new ModRecipe(this);
                    TrueExcalibur.AddIngredient(ItemID.Excalibur);
                    TrueExcalibur.AddIngredient(ItemID.ChlorophyteBar, 24);
                    TrueExcalibur.AddTile(TileID.MythrilAnvil);
                    TrueExcalibur.SetResult(ItemID.TrueExcalibur);
                    TrueExcalibur.AddRecipe();
                }
                #endregion
                #region Throwing Stuff
                if (GetInstance<Config>().AllowThrowingToRangedRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder FossilHeadR = new RecipeFinder();
                    FossilHeadR.AddIngredient(ItemID.FossilOre, 20);
                    FossilHeadR.AddTile(TileID.Anvils);
                    FossilHeadR.SetResult(ItemID.FossilHelm);
                    Recipe FossilHeadRR = FossilHeadR.FindExactRecipe();
                    if (FossilHeadRR != null)
                    {
                        RecipeEditor FossilHeadE = new RecipeEditor(FossilHeadRR);
                        FossilHeadE.DeleteRecipe();
                    }

                    _ = new RecipeFinder();
                    RecipeFinder FossilChestR = new RecipeFinder();
                    FossilChestR.AddIngredient(ItemID.FossilOre, 30);
                    FossilChestR.AddTile(TileID.Anvils);
                    FossilChestR.SetResult(ItemID.FossilShirt);
                    Recipe FossilChestRR = FossilChestR.FindExactRecipe();
                    if (FossilChestRR != null)
                    {
                        RecipeEditor FossilChestE = new RecipeEditor(FossilChestRR);
                        FossilChestE.DeleteRecipe();
                    }

                    _ = new RecipeFinder();
                    RecipeFinder FossilLegsR = new RecipeFinder();
                    FossilLegsR.AddIngredient(ItemID.FossilOre, 25);
                    FossilLegsR.AddTile(TileID.Anvils);
                    FossilLegsR.SetResult(ItemID.FossilPants);
                    Recipe FossilLegsRR = FossilLegsR.FindExactRecipe();
                    if (FossilLegsRR != null)
                    {
                        RecipeEditor FossilLegsE = new RecipeEditor(FossilLegsRR);
                        FossilLegsE.DeleteRecipe();
                    }

                    _ = new RecipeFinder();
                    RecipeFinder BoneJavelinR = new RecipeFinder();
                    BoneJavelinR.AddIngredient(ItemID.FossilOre);
                    BoneJavelinR.AddTile(TileID.Anvils);
                    BoneJavelinR.SetResult(ItemID.BoneJavelin, 15);
                    Recipe BoneJavelinRR = BoneJavelinR.FindExactRecipe();
                    if (BoneJavelinRR != null)
                    {
                        RecipeEditor BoneJavelinE = new RecipeEditor(BoneJavelinRR);
                        BoneJavelinE.DeleteRecipe();
                    }

                    _ = new RecipeFinder();
                    RecipeFinder BoneKnifeR = new RecipeFinder();
                    BoneKnifeR.AddIngredient(ItemID.FossilOre);
                    BoneKnifeR.AddTile(TileID.Anvils);
                    BoneKnifeR.SetResult(ItemID.BoneDagger, 25);
                    Recipe BoneKnifeRR = BoneKnifeR.FindExactRecipe();
                    if (BoneKnifeRR != null)
                    {
                        RecipeEditor BoneKnifeE = new RecipeEditor(BoneKnifeRR);
                        BoneKnifeE.DeleteRecipe();
                    }

                    _ = new RecipeFinder();
                    RecipeFinder AmberStaffR = new RecipeFinder();
                    AmberStaffR.AddIngredient(ItemID.FossilOre, 15);
                    AmberStaffR.AddIngredient(ItemID.Amber, 8);
                    AmberStaffR.AddTile(TileID.Anvils);
                    AmberStaffR.SetResult(ItemID.AmberStaff);
                    Recipe AmberStaffRR = AmberStaffR.FindExactRecipe();
                    if (AmberStaffRR != null)
                    {
                        RecipeEditor AmberStaffE = new RecipeEditor(AmberStaffRR);
                        AmberStaffE.DeleteRecipe();
                    }
                    ModRecipe AmberStaff = new ModRecipe(this);
                    AmberStaff.AddIngredient(ItemID.FossilOre, 15);
                    AmberStaff.AddIngredient(ItemID.Amber, 8);
                    AmberStaff.AddTile(TileID.Anvils);
                    AmberStaff.SetResult(ItemID.AmberStaff);
                    AmberStaff.AddRecipe();
                    ModRecipe BoneJavelin = new ModRecipe(this);
                    BoneJavelin.AddIngredient(ItemID.FossilOre);
                    BoneJavelin.AddTile(TileID.Anvils);
                    BoneJavelin.SetResult(ItemID.BoneJavelin, 20);
                    BoneJavelin.AddRecipe();
                    ModRecipe BoneThrowingKnife = new ModRecipe(this);
                    BoneThrowingKnife.AddIngredient(ItemID.FossilOre);
                    BoneThrowingKnife.AddTile(TileID.Anvils);
                    BoneThrowingKnife.SetResult(ItemID.BoneDagger, 30);
                    BoneThrowingKnife.AddRecipe();
                    ModRecipe FossilGreaves = new ModRecipe(this);
                    FossilGreaves.AddIngredient(ItemID.FossilOre, 20);
                    FossilGreaves.AddTile(TileID.Anvils);
                    FossilGreaves.SetResult(ItemID.FossilPants);
                    FossilGreaves.AddRecipe();
                    ModRecipe FossilHelmet = new ModRecipe(this);
                    FossilHelmet.AddIngredient(ItemID.FossilOre, 15);
                    FossilHelmet.AddTile(TileID.Anvils);
                    FossilHelmet.SetResult(ItemID.FossilHelm);
                    FossilHelmet.AddRecipe();
                    ModRecipe FossilPlate = new ModRecipe(this);
                    FossilPlate.AddIngredient(ItemID.FossilOre, 25);
                    FossilPlate.AddTile(TileID.Anvils);
                    FossilPlate.SetResult(ItemID.FossilShirt);
                    FossilPlate.AddRecipe();
                }
                #endregion
                #region Potion Recipe
                if (GetInstance<Config>().allowBuffRecipes)
                {
                    _ = new RecipeFinder();
                    RecipeFinder CratePotionR = new RecipeFinder();
                    CratePotionR.AddIngredient(ItemID.BottledWater);
                    CratePotionR.AddIngredient(ItemID.Amber);
                    CratePotionR.AddIngredient(ItemID.Moonglow);
                    CratePotionR.AddIngredient(ItemID.Deathweed);
                    CratePotionR.AddTile(TileID.Bottles);
                    CratePotionR.SetResult(ItemID.CratePotion);
                    Recipe CratePotionRR = CratePotionR.FindExactRecipe();
                    if (CratePotionRR != null)
                    {
                        RecipeEditor CratePotionE = new RecipeEditor(CratePotionRR);
                        CratePotionE.DeleteRecipe();
                    }
                    ModRecipe CratePotion = new ModRecipe(this);
                    CratePotion.AddIngredient(ItemID.BottledWater);
                    CratePotion.AddIngredient(ItemID.Amber);
                    CratePotion.AddIngredient(ItemID.Moonglow);
                    CratePotion.AddIngredient(ItemID.Shiverthorn);
                    CratePotion.AddIngredient(ItemID.Waterleaf);
                    CratePotion.AddTile(TileID.Bottles);
                    CratePotion.SetResult(ItemID.CratePotion);
                    CratePotion.AddRecipe();

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
            bool flag3 = GetInstance<JourneyRecipesServerConfig>().AllowBuffDuration;
            if (flag3)
            {
                Main.buffNoTimeDisplay[BuffID.Sharpened] = false;
                Main.buffNoTimeDisplay[BuffID.Clairvoyance] = false;
                Main.buffNoTimeDisplay[BuffID.Bewitched] = false;
                Main.buffNoTimeDisplay[BuffID.AmmoBox] = false;
                Main.buffNoSave[BuffID.Sharpened] = false;
                Main.buffNoSave[BuffID.Clairvoyance] = false;
                Main.buffNoSave[BuffID.Bewitched] = false;
                Main.buffNoSave[BuffID.AmmoBox] = false;
            }
        }
    }
}