using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class BreathingReed : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.BreathingReed)
            {
                item.damage = 10;
                item.knockBack = 4f;
                item.useTime = 27;
                item.useAnimation = 27;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.melee = true;
            }
        }
        public override int ChoosePrefix(Item item, UnifiedRandom rand)
        {
            if (Config.Instance.allowWeaponStat && item.type == ItemID.BreathingReed)
            {
                return rand.Next(new int[] { PrefixID.Legendary, PrefixID.Godly, PrefixID.Savage, PrefixID.Superior, PrefixID.Demonic, PrefixID.Deadly, PrefixID.Unpleasant, PrefixID.Murderous, PrefixID.Massive, PrefixID.Agile, PrefixID.Forceful, PrefixID.Sharp, PrefixID.Strong, PrefixID.Dangerous, PrefixID.Large, PrefixID.Zealous, PrefixID.Hurtful, PrefixID.Pointy, PrefixID.Quick, PrefixID.Nasty, PrefixID.Bulky, PrefixID.Ruthless, PrefixID.Keen, PrefixID.Nimble, PrefixID.Light, PrefixID.Heavy, PrefixID.Lazy, PrefixID.Small, PrefixID.Slow, PrefixID.Damaged, PrefixID.Dull, PrefixID.Tiny, PrefixID.Weak, PrefixID.Sluggish, PrefixID.Shameful, PrefixID.Shoddy, PrefixID.Unhappy, PrefixID.Annoying, PrefixID.Terrible, PrefixID.Broken });
            }
            return base.ChoosePrefix(item, rand);
        }
    }
}