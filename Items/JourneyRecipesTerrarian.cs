using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesTerrarian : GlobalItem
    {
        public byte legendary;
        public override bool InstancePerEntity => true;
        public override bool CloneNewInstances => true;
        public override int ChoosePrefix(Item item, UnifiedRandom rand)
        {
            int[] prefix = new int[] { PrefixID.Keen, PrefixID.Superior, PrefixID.Forceful, PrefixID.Broken, PrefixID.Damaged, PrefixID.Shoddy, PrefixID.Hurtful, PrefixID.Strong, PrefixID.Unpleasant, PrefixID.Weak, PrefixID.Ruthless, PrefixID.Godly, PrefixID.Demonic, PrefixID.Zealous };
            //listed prefix ids
            if (item.type == ItemID.Terrarian && Config.Instance.allowWeaponStat)
            {
                if (Main.rand.NextBool(15))//chance 1/15
                {
                    return mod.PrefixType(rand.NextBool(1) ? "Legendary" : "");//select this prefix
                }
                else//chance 1/14
                {
                    return prefix[Main.rand.Next(0, 14)];//select one of the prefixes from above
                }
            }
            return -1;
        }
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            if (item.type == ItemID.Terrarian && Config.Instance.allowWeaponStat)
            {
                foreach (TooltipLine line in tooltips)
                {
                    if (item.prefix != 0)
                    {
                        if (line.mod == "Terraria" && line.text == "Terrarian")
                        {
                            line.text = "Legendary Terrarian";//if mod prefix is active, chance tooltip to include prefix name
                        }
                    }
                }
            }
        }
    }
}