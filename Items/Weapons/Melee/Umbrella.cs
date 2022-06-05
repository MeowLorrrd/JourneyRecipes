using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Utilities;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class Umbrella : GlobalItem
    {
        public bool c = Config.Instance.allowWeaponStat;//instead of retyping ugly overused mega cringe Config line, just use 'c' :D
        public override bool InstancePerEntity => true;
        public override bool CloneNewInstances => true;
        public override void SetDefaults(Item item)
        {
            if (item.type == ItemID.Umbrella && c)
            {
                item.useStyle = ItemUseStyleID.Stabbing;
                item.damage = 10;
                item.melee = true;
                item.useTime = 22;
                item.useAnimation = 22;
                item.knockBack = 5f;
                item.width = 44;
                item.height = 44;
                item.rare = ItemRarityID.Blue;
            }
        }
        public override bool UseItem(Item item, Player player)
        {
            if (item.type == ItemID.Umbrella && c)
            {
                if (player.direction == 1)
                {
                    player.itemRotation = 1.575f;
                    player.itemLocation -= new Vector2(5, 25);
                }
                if (player.direction != 1)
                {
                    player.itemRotation = -1.575f;
                    player.itemLocation -= new Vector2(-5, 25);
                }
            }
            return base.UseItem(item, player);
        }
        public override int ChoosePrefix(Item item, UnifiedRandom rand)
        {
            if (c && item.type == ItemID.Umbrella)
            {
                return rand.Next(new int[] { PrefixID.Legendary, PrefixID.Godly, PrefixID.Savage, PrefixID.Superior, PrefixID.Demonic, PrefixID.Deadly, PrefixID.Unpleasant, PrefixID.Murderous, PrefixID.Massive, PrefixID.Agile, PrefixID.Forceful, PrefixID.Sharp, PrefixID.Strong, PrefixID.Dangerous, PrefixID.Large, PrefixID.Zealous, PrefixID.Hurtful, PrefixID.Pointy, PrefixID.Quick, PrefixID.Nasty, PrefixID.Bulky, PrefixID.Ruthless, PrefixID.Keen, PrefixID.Nimble, PrefixID.Light, PrefixID.Heavy, PrefixID.Lazy, PrefixID.Small, PrefixID.Slow, PrefixID.Damaged, PrefixID.Dull, PrefixID.Tiny, PrefixID.Weak, PrefixID.Sluggish, PrefixID.Shameful, PrefixID.Shoddy, PrefixID.Unhappy, PrefixID.Annoying, PrefixID.Terrible, PrefixID.Broken });
            }
            return base.ChoosePrefix(item, rand);
        }
    }
}