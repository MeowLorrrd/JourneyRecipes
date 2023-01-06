using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace JourneyRecipes
{
    public class Config : ModConfig
    {
        public static Config Instance;
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("Recipe Settings")]
        [DefaultValue(true)]
        [Label("[i:3281]   Weapon recipes")]
        [Tooltip("Changes weapon recipes" +
            "\nCopper, Iron, Silver, Gold, Cobalt and Mythril (and their equivelants) weapons are cheaper to craft" +
            "\nSilver Bullets are craftable with Tungsten Bars" +
            "\nEnchanted Boomerang is craftable with Wooden Boomerang + Fallen Star" +
            "\nPhasesabers cost 25 Crystal Shard to craft" +
            "\nAmazon is more expensive to craft" +
            "\nMolotov Cocktail uses regular Gel")]
        [ReloadRequired]
        public bool allowWeaponRecipe;

        [DefaultValue(true)]
        [Label("[i:696]   Armor recipes")]
        [Tooltip("Changes Pre-Hardmode armor recipes" +
            "\nCopper, Iron, Silver and Gold (and their equivelants) armor is cheaper to craft")]
        [ReloadRequired]
        public bool allowArmorRecipes;

        [DefaultValue(true)]
        [Label("[i:3509]   Tool recipes")]
        [Tooltip("Changes Pre-Hardmode tool recipes" +
            "\nCopper, Iron, Silver and Gold (and their equivelants) tools are cheaper to craft")]
        [ReloadRequired]
        public bool allowToolRecipes;

        [DefaultValue(true)]
        [Label("[i:908]   Accessory recipes")]
        [Tooltip("Changes certain Accessory recipes, as well as adding new ones" +
            "\nLava Waders use Obisidian Rose" +
            "\nSandstorm and Blizzard in a Bottle are craftable" +
            "\nBand of Starpower and Panic Necklace are craftable" +
            "\nFairy, Demon and Angel Wings are cheaper to craft")]
        [ReloadRequired]
        public bool allowAccessoryRecipe;

        [DefaultValue(true)]
        [Label("[i:1017]   Dye recipes")]
        [Tooltip("Basic Dye materials give 2 dye" +
            "\nYellow Marigold, Orange Bloodroot, Red Husk, etc. produce 2 dye")]
        [ReloadRequired]
        public bool allowDyeRecipes;

        [DefaultValue(true)]
        [Label("[i:431]   Torch recipes")]
        [Tooltip("Give Ice Torches new recipes and Gem Torches produce 10" +
            "\nGem Torches are crafted with 10 torches, rather than 3" +
            "\nIce torches can by crafted by all Ice Blocks")]
        [ReloadRequired]
        public bool allowTorchRecipes;

        [DefaultValue(true)]
        [Label("[i:634]   Platform recipes")]
        [Tooltip("Makes all platforms craftable without a crafting station" +
            "\nBone, Honey, Skyware, Steampunk, Cactus, Glass, Mushroom and Pumpkin platforms are craftable by hand")]
        [ReloadRequired]
        public bool allowPlatformRecipes;

        [DefaultValue(true)]
        [Label("[i:681]   Chest recipes")]
        [Tooltip("Makes certain chests craftable" +
            "\nFrozen, Skyware, Lihzahrd and Living Wood chests are craftable")]
        [ReloadRequired]
        public bool allowChestRecipes;

        [DefaultValue(true)]
        [Label("[i:222]   Tile recipes")]
        [Tooltip("Give certain tiles updated or added recipes" +
            "\nHardened Sand and Sandstone are craftable with Sand and Dirt/Stone @ Solidifier" +
            "\nClay Pot uses 5 Clay, rather than 6" +
            "\nBoulder are crafted at Heavy Workbench" +
            "\nMetal Bricks (such as Copper Brick) use a 1:5 ratio" +
            "\nSpooky, Cactus and Pumpkin furniture are crafted at Anvil or Sawmill")]
        [ReloadRequired]
        public bool allowTileRecipes;

        [DefaultValue(true)]
        [Label("[i:1006]   Hardmode bar recipes")]
        [Tooltip("Give Adamantite, Titanium and Chlorophyte bars their 1.4.4 recipe" +
            "\nAdamantite and Titanium use 4 Ore" +
            "\nChlorophyte uses 5 Ore")]
        [ReloadRequired]
        public bool allowBarRecipes;

        [DefaultValue(true)]
        [Label("[i:2356]   Potion recipes")]
        [Tooltip("Give potions their 1.4.4 recipe" +
            "\nCrate Potion won't use Deathweed, will require Shiverthorn and Waterleaf instead" +
            "\nThorns Potion won't use Stinger and Worm Tooth")]
        [ReloadRequired]
        public bool allowBuffRecipes;

        [DefaultValue(true)]
        [Label("[i:757 ]    Change Terra Blade crafting process?")]
        [Tooltip("If this setting is turned on, this mod will change the recipes for the Terra Blade and components to match 1.4" +
            "\nBy enabling this config:" +
            "\nThe True Night's Edge requires 20 of the Mech bosses' souls," +
            "\nThe True Excalibur requires 24 Chlorophyte bars," +
            "\nThe Terra Blade requires a Broken Hero Sword," +
            "\nHighly recommended to enable alongside the Stats config" +
            "\nThis setting is unaffected by all other unrelated configs" +
            "\nHighly recommended to disable while using Calamity or Thorium")]
        [ReloadRequired]
        public bool TerraBladeStuffRecipes { get; set; }

        [DefaultValue(false)]
        [Label("[i:3378]   Change throwing weapons to ranged?")]
        [Tooltip("If this setting is turned off, this mod will not change throwing weapons to the ranged damage type." +
            "\nBy enabling this config:" +
            "\nSturdy Fossil recipes use 1.4 recipes" +
            "\nHighly recommended to turn on alongside the Stats config" +
            "\nThis setting is unaffected by all other unrelated configs" +
            "\nHighly recommended to turn this off when using Calamity or Thorium, as these mods use the Throwing class!")]
        [ReloadRequired]
        public bool AllowThrowingToRangedRecipes { get; set; }

    }
    public class JourneyRecipesServerConfig : ModConfig
    {
        public static JourneyRecipesServerConfig instance;
        public override ConfigScope Mode => ConfigScope.ClientSide;
        [Header("Stat Settings [c/ff3333:(Read red configs!)]")]

        [DefaultValue(true)]
        [Label("[i:73]   Sell values")]
        [Tooltip("Changes sell value of item" +
            "\nAll drops from Shadow Orbs/Crimson Hearts sell for 1,50 Gold" +
            "\nThis also gives Luminite armor a sell value (31,50 Gold for set)" +
            "\nOverall balances sell values of vanilla items")]
        [ReloadRequired]
        public bool allowSellChange;

        [DefaultValue(true)]
        [Label("[i:1147]   Tile properties")]
        [Tooltip("Changes properties of certain tiles" +
            "\nJungle Traps can't be mined or blown up before Golem has been defeated" +
            "\nMeteorite can't be blown up before Hardmode")]
        [ReloadRequired]
        public bool allowTileChange;

        [DefaultValue(true)]
        [Label("[i:2341]    Tool stats")]
        [Tooltip("Changes stats of certain tools" +
            "\nReaver Shark is faster, but has reduced pickaxe power" +
            "\nLaser Drill is faster, has longer reach and can't mine trees" +
            "\nFiberglass Fishing Pole and Mechanic's Rod have 30% and 35% fishing power (respectively)")]
        [ReloadRequired]
        public bool allowToolStat;

        [DefaultValue(true)]
        [Label("[i:293]   Buff duration")]
        [Tooltip("Buffs will receive a longer or unlimited duration" +
            "\nAffects all potions" +
            "\nBuff stations give their buff for an unlimited time")]
        [ReloadRequired]
        public bool AllowBuffDuration;

        [DefaultValue(true)]
        [Label("[i:297]   Buff stats")]
        [Tooltip("Changes some buffs" +
            "\nBy enabling this setting, certain buffs will have 1.4 stats" +
            "\nSharpening Station will increase armor penetration by 12 in total" +
            "\nThorns Potion reflects 100% damage" +
            "\nInvisibility Potion decreases spawn rates and max spawns" +
            "\nPlayer can now have 44 buffs active")]
        [ReloadRequired]
        public bool AllowBuffStat;

        [DefaultValue(true)]
        [Label("[i:267]   NPC stats")]
        [Tooltip("Change stats and drops of certain NPCs" +
            "\nCommon Martian Madness enemies drop items that the Saucer would drop" +
            "\nMoss Hornets can drop Stinger" +
            "\nSeveral NPCs have a rarity (for the Lifeform Analyzer)" +
            "\nSeveral NPCs have their defense, max health, damage, value modified" +
            "\nTruffle Worm can't get hit by enemies" +
            "\nCelestial Towers shields no longer scale with Expert Mode, and have 50 Power after Moon Lord has been defeated")]
        [ReloadRequired]
        public bool AllowNPCStat;

        [DefaultValue(true)]
        [Label("[i:1307]   NPC shops")]
        [Tooltip("Add or changes NPC shops" +
            "\nMerchant sells Sharpening Station, Furnace, Mana and Healing Potion under certain conditions" +
            "\nArms Deal sells Ammo Box in Hardmode" +
            "\nMechanic sells Timers, Teleporters and Pixel Boxes" +
            "\nWizard sells Books" +
            "\nSkeleton Merchant sells different early-game items, depending on moon phase" +
            "\nWitch Doctor sells Summoner items without having Pygmy Staff as a requirement")]
        [ReloadRequired]
        public bool AllowNPCShop;

        [DefaultValue(true)]
        [Label("[i/s9999:1198]   Max item stack")]
        [Tooltip("Changes the max stack a stackable item can have" +
            "\nEvery stackable item has a max stack of 9999")]
        [ReloadRequired]
        public bool allowMaxStack;

        [DefaultValue(true)]
        [BackgroundColor(255, 20, 0, 1)]
        [Label("[i:1295]   Weapon stats")]
        [Tooltip("If this setting is turned off, this mod will not change weapon stats, e.g. the 1.3 Heat Ray stats will be used" +
            "\nBy enabling this setting, certain weapons will use 1.4 stats" +
            "\nThis setting also affects ammunition" +
            "\nHighly recommended to disable while using Calamity or Fargo's Eternity Mode")]
        [ReloadRequired]
        public bool allowWeaponStat;

        [BackgroundColor(255, 20, 0, 1)]
        [DefaultValue(true)]
        [Label("[i:1832]   Armor stats")]
        [Tooltip("If this setting is turned off, this mod will not change armor stats, e.g. the 1.3 Spooky armor giving +3 minion slots" +
            "\nBy enabling this setting, certain armor sets will use 1.4 stats" +
            "\nHighly recommended to disable while using Calamity or Fargo's Eternity Mode")]
        [ReloadRequired]
        public bool allowArmorStat;

        [BackgroundColor(255, 20, 0, 1)]
        [DefaultValue(true)]
        [Label(" [i:2221]  Accessory stats")]
        [Tooltip("If this setting is turned off, this mod will not change accessory stats, e.g. the 1.3 Celestial Cuffs won't grant +20 mana" +
            "\nBy enabling this setting, certain accessories will use 1.4 stats" +
            "\nHighly recommended to disable while using Calamity or Fargo's Eternity Mode")]
        [ReloadRequired]
        public bool allowAccessoryStat;

        [BackgroundColor(255, 20, 0, 1)]
        [DefaultValue(true)]
        [Label(" [i:757 ]   Terra Blade crafting process")]
        [Tooltip("If this setting is turned on, this mod will change the recipes for the Terra Blade and components to match 1.4" +
            "\nThe Terra Blade, True Excalibur & True Night's Edge will have 1.4 stats" +
            "\nMothron only spawns after Plantera" +
            "\nThis setting is unaffected by all other configs" +
            "\nHighly recommended to enable alongside the Recipe config" +
            "\nHighly recommended to disable while using Calamity or Thorium")]
        [ReloadRequired]
        public bool TerraBladeStuff;
        [BackgroundColor(255, 20, 0, 1)]
        [DefaultValue(true)]
        [Label("[i:493]   Wing stats")]
        [Tooltip("If this setting is turned off, this mod will not change wings stats, e.g. the 1.3 Fin Wings being bad" +
            "\nBy enabling this setting, certain wings will use 1.4 stats" +
            "\nStill in testing phase, I haven't encountered any issues so far, but if you do, please report them in the Homepage!" +
            "\nHighly recommended to disable while using Calamity")]
        [ReloadRequired]
        public bool AllowWingStat;

        [BackgroundColor(255, 50, 0, 1)]
        [DefaultValue(false)]
        [Label("[i:3378]   Throwing weapons to Ranged")]
        [Tooltip("If this setting is turned off, this mod will not change throwing weapons to the ranged damage type." +
            "\nBy enabling this config:" +
            "\nAll Throwing weapons do Ranged damage," +
            "\nNinja and Fossil armor have 1.4 stats" +
            "\nHighly recommended to turn on alongside the Recipe config" +
            "\nThis setting is unaffected by all other unrelated configs" +
            "\nHighly recommended to turn this off when using Calamity or Thorium, as these mods use the Throwing class!")]
        [ReloadRequired]
        public bool allowThrowingToRanged;

        /*[DefaultValue(false)]
        [Label("Change item textures?")]
        [Tooltip("If this setting is turned on, this mod will update 1.3 item textures, e.g. 1.4 Husks, weapons, accessories, etc\nCurrently unstable (will crash game if unloaded, otherwise works as intended)\n \n ")]
        [ReloadRequired]
        public bool ItemResprite;*/
    }
}