using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using JourneyRecipes.Items;

namespace JourneyRecipes.Prefixes
{
    public class JourneyRecipesLegendaryPrefix : ModPrefix
    {
        private readonly byte _power;
        public override bool CanRoll(Item item)
        {
            if (item.type == ItemID.Terrarian && ModContent.GetInstance<JourneyRecipesServerConfig>().allowWeaponStat) return true;//check for config please yes thank you
            else return false;
        }
        public override PrefixCategory Category => PrefixCategory.Melee;//only this yoyo, but yoyo is melee so eh
        public JourneyRecipesLegendaryPrefix() { }
        public JourneyRecipesLegendaryPrefix(byte power)
        {
            _power = power;
        }
        public override bool Autoload(ref string name)
        {
            if (!base.Autoload(ref name)) return false;
            mod.AddPrefix("Legendary", new JourneyRecipesLegendaryPrefix(1));
            return false;
        }
        public override void Apply(Item item) => item.GetGlobalItem<JourneyRecipesTerrarian>().legendary = _power;
        public override void ModifyValue(ref float valueMult)
        {
            float mp = 1 + 0.05f * _power;
            valueMult *= mp;//how much value changes with this tooltip
        }
        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult *= 1.17f;//the actual stats of the prefix
            critBonus += 8;
            knockbackMult *= 1.17f;
        }
    }
}