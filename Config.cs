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
        [Label("[i:3281]   Change weapon recipes?")]
        [Tooltip("If this setting is turned off, this mod will not change weapon recipes, e.g. the 1.3 Amazon recipe remains unchanged" +
            "\nBy enabling this setting, some weapons will use 1.4 recipes" +
            "\nThis setting also affects ammunition")]
        [ReloadRequired]
        public bool allowWeaponRecipe;

        [DefaultValue(true)]
        [Label("[i:696]   Change armor recipes?")]
        [Tooltip("If this setting is turned off, this mod will not change any armor recipes, e.g. the 1.3 Platinum armor cost will remain 90 bars" +
            "\nBy enabling this setting, some armor sets, like Platinum armor cost less bars to craft")]
        [ReloadRequired]
        public bool allowArmorRecipes;

        [DefaultValue(true)]
        [Label("[i:3509]   Change tool recipes?")]
        [Tooltip("If this setting is turned off, this mod will not change any tool recipes, e.g. the 1.3 Gold Axe cost will remain 9 bars" +
            "\nBy enabling this setting, some tools sets, like Gold Axe cost less bars to craft")]
        [ReloadRequired]
        public bool allowToolRecipes;

        [DefaultValue(true)]
        [Label("[i:908]   Change accessory recipes?")]
        [Tooltip("If this setting is turned off, this mod will not change accessory recipes, e.g. the 1.3 Lava Waders recipe will be used" +
            "\nBy enabling this config, some accessories will use 1.4 recipes" +
            "\nCurrently only affects Lava Waders")]
        [ReloadRequired]
        public bool allowAccessoryRecipe;

        [DefaultValue(true)]
        [Label("[i:1017]   Change dye recipes?")]
        [Tooltip("If this setting is turned off, this mod will not change any dye recipes, e.g. the 1.3 dye materials only give 1 dye" +
            "\nBy enabling this setting, dye materials will craft 2 dyes")]
        [ReloadRequired]
        public bool allowDyeRecipes;

        [DefaultValue(true)]
        [Label("[i:431]   Change torch recipes?")]
        [Tooltip("If this setting is turned off, this mod will not change any torch recipes, e.g. colored torches give 3 torches" +
            "\nBy enabling this setting, torches with gems will craft into 10 colored torches," +
            "\nIce torches can by crafted by all Ice Blocks")]
        [ReloadRequired]
        public bool allowTorchRecipes;

        [DefaultValue(true)]
        [Label("[i:634]   Change platform recipes?")]
        [Tooltip("If this setting is turned off, this mod will not change any platform recipes, e.g. the 1.3 platforms require a special crafting station" +
            "\nBy enabling this setting, all platforms can be crafted without a crafting station")]
        [ReloadRequired]
        public bool allowPlatformRecipes;

        [DefaultValue(true)]
        [Label("[i:681]   Change chest recipes?")]
        [Tooltip("If this setting is turned off, this mod will not change any chest recipes, e.g. some chests are uncraftable" +
            "\nBy enabling this setting, more chests will be craftable")]
        [ReloadRequired]
        public bool allowChestRecipes;

        [DefaultValue(true)]
        [Label("[i:222]   Change tile recipes?")]
        [Tooltip("If this setting is turned off, this mod will not change any tile recipes, e.g. 1.3 Clay Pots require 6 clay" +
            "\nBy enabling this setting, some tiles will use 1.4 recipes" +
            "\nCurrently only affects Clay Pots and Boulders")]
        [ReloadRequired]
        public bool allowTileRecipes;

        [DefaultValue(true)]
        [Label("[i:1006]   Change hardmode bar recipes?")]
        [Tooltip("If this setting is turned off, this mod will not change any hardmode bar recipes, e.g. 1.3 Titanium bar costs 5 ore" +
            "\nBy enabling this setting, Titanium, Adamantite and Chlorophyte will use 1.4 recipes")]
        [ReloadRequired]
        public bool allowBarRecipes;

        [DefaultValue(true)]
        [Label("[i:2356]   Change potion recipes?")]
        [Tooltip("If this setting is turned off, this mod will not change any potion recipes, e.g. the 1.3 Crate Potion requires Deathweed" +
            "\nBy enabling this setting, certain potions will have 1.4 recipes" +
            "\nCurrently only affects Crate potion")]
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
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [Header("Stat Settings [c/ff3333:(Read red configs!)]")]

        [DefaultValue(true)]
        [Label("[i:73]   Change sell values?")]
        [Tooltip("If this setting is turned on, this mod will change sell values of certain items." +
            "\nE.g. all drops from Shadow orbs sell for 1,50 Gold" +
            "\nThis also gives Luminite armor a sell value (31,50 Gold for set)")]
        [ReloadRequired]
        public bool allowSellChange;

        [DefaultValue(true)]
        [Label("[i:1147]   Change tiles?")]
        [Tooltip("If this setting is turned on, this mod will change some tile properties." +
            "\nE.g. Meteorite can't be blown up before hardmode")]
        [ReloadRequired]
        public bool allowTileChange;

        [DefaultValue(true)]
        [Label("[i:2341]    Change tool stats?")]
        [Tooltip("If this setting is turned off, this mod will not change tool stats, e.g. the 1.3 Reaver Shark stats will be used" +
            "\nBy enabling this setting, certain tools will use 1.4 stats" +
            "\nCurrently only affects Reaver Shark and Laser Drill")]
        [ReloadRequired]
        public bool allowToolStat;

        [BackgroundColor(255, 20, 0, 1)]
        [DefaultValue(true)]
        [Label("[i/s999:1198]   Change max stack for items?")]
        [Tooltip("If this setting is turned on, this mod will change the maximum amount of items a stack can hold.\nE.g. the max stack for Titanium bars goes from 99 to 999" +
        "\nRecommended to turn off if any other mod that changes max stacks for items (Calamity, Fargo's Mutant, Max Stack Plus)")]
        [ReloadRequired]
        public bool allowMaxStack;

        [DefaultValue(true)]
        [BackgroundColor(255, 20, 0, 1)]
        [Label("[i:1295]   Change weapon stats?")]
        [Tooltip("If this setting is turned off, this mod will not change weapon stats, e.g. the 1.3 Heat Ray stats will be used" +
            "\nBy enabling this setting, certain weapons will use 1.4 stats" +
            "\nThis setting also affects ammunition" +
            "\nHighly recommended to disable while using Calamity or Fargo's Eternity Mode")]
        [ReloadRequired]
        public bool allowWeaponStat;

        [BackgroundColor(255, 20, 0, 1)]
        [DefaultValue(true)]
        [Label("[i:1832]   Change armor stats?")]
        [Tooltip("If this setting is turned off, this mod will not change armor stats, e.g. the 1.3 Spooky armor giving +3 minion slots" +
            "\nBy enabling this setting, certain armor sets will use 1.4 stats" +
            "\nHighly recommended to disable while using Calamity or Fargo's Eternity Mode")]
        [ReloadRequired]
        public bool allowArmorStat;

        [BackgroundColor(255, 20, 0, 1)]
        [DefaultValue(true)]
        [Label("[i:2221]   Change accessory stats?")]
        [Tooltip("If this setting is turned off, this mod will not change accessory stats, e.g. the 1.3 Celestial Cuffs won't grant +20 mana" +
            "\nBy enabling this setting, certain accessories will use 1.4 stats" +
            "\nCurrently only affects Lava Waders, Celesial Cuffs, Charm of Myths, Fire Gauntlet and Flesh Knuckles" +
            "\nHighly recommended to disable while using Calamity or Fargo's Eternity Mode")]
        [ReloadRequired]
        public bool allowAccessoryStat;

        [BackgroundColor(255, 20, 0, 1)]
        [DefaultValue(true)]
        [Label("[i:757 ]    Change Terra Blade crafting process?")]
        [Tooltip("If this setting is turned on, this mod will change the recipes for the Terra Blade and components to match 1.4" +
            "\nBy enabling this config:" +
            "\nThe Terra Blade, True Excalibur & True Night's Edge will have 1.4 stats," +
            "\nMothron only spawns after Plantera" +
            "\nThis setting is unaffected by all other unrelated configs" +
            "\nHighly recommended to enable alongside the Recipe config" +
            "\nHighly recommended to disable while using Calamity or Thorium")]
        [ReloadRequired]
        public bool TerraBladeStuff { get; set; }
        [BackgroundColor(255, 20, 0, 1)]
        [DefaultValue(true)]
        [Label("[i:493]   Change wing stats?")]
        [Tooltip("If this setting is turned off, this mod will not change wings stats, e.g. the 1.3 Fin Wings being bad" +
            "\nBy enabling this setting, certain wings will use 1.4 stats" +
            "\nStill in testing phase, I haven't encountered any issues so far, but if you do, please report them in the Homepage!" +
            "\nHighly recommended to disable while using Calamity")]
        [ReloadRequired]
        public bool AllowWingStat { get; set; }

        [DefaultValue(true)]
        [Label("[i:293]   Change buff duration?")]
        [Tooltip("If this setting is turned off, this mod will not change buff durations, e.g. the 1.3 Builder Potion won't last for 45 minutes" +
            "\nBy enabling this setting, certain buffs will have 1.4 durations" +
            "\nCurrently affects all potions" +
            "\nAlso makes buff stations give their buff for an unlimited time")]
        [ReloadRequired]
        public bool AllowBuffDuration { get; set; }

        [DefaultValue(true)]
        [Label("[i:297]   Change buff stats?")]
        [Tooltip("If this setting is turned off, this mod wiull not change buff stats, e.g. the 1.3 Invisibility Potion won't grant reduced enemy spawn rates" +
            "\nBy enabling this setting, certain buffs will have 1.4 stats" +
            "\nCurrently only affects Invisibility Potion and Sharpening Station")]
        [ReloadRequired]
        public bool AllowBuffStat { get; set; }

        [DefaultValue(true)]
        [Label("[i:267]   Change NPC stats?")]
        [Tooltip("If this setting is turned off, this mod will not change NPCs, e.g. Giant Cursed Skull having no chance to drop Nazar" +
            "\nBy enabling this config, certain NPCs will have 1.4 stats")]
        [ReloadRequired]
        public bool AllowNPCStat { get; set; }

        [DefaultValue(true)]
        [Label("[i:1307]    Change NPC shops?")]
        [Tooltip("If this setting is turned off, this mod will not change NPC shops, e.g. Merchant selling Sharpening Station" +
            "\nBy enabling this config, certain NPCs will have 1.4 shops with 1.3 items")]
        [ReloadRequired]
        public bool AllowNPCShop { get; set; }

        [BackgroundColor(255, 50, 0, 1)]
        [DefaultValue(false)]
        [Label("[i:3378]   Change throwing weapons to ranged?")]
        [Tooltip("If this setting is turned off, this mod will not change throwing weapons to the ranged damage type." +
            "\nBy enabling this config:" +
            "\nAll Throwing weapons do Ranged damage," +
            "\nNinja and Fossil armor have 1.4 stats" +
            "\nSturdy Fossil recipes use 1.4 recipes" +
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