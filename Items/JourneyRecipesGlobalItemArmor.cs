using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemArmor : GlobalItem
    {
        const string Cactus = "cactusSet";
        const string ChlorophyteMelee = "chlorophyteMaskSet";
        const string Gladiator = "gladiatorSet";
        const string Molten = "moltenSet";
        const string Necro = "necroSet";
        const string Solar = "solarFlareSet";
        const string Turtle = "turtleSet";
        const string Angler = "anglerSet";
        const string Snow = "snowSet";
        public override void SetDefaults(Item item)
        {
            if (!GetInstance<JourneyRecipesServerConfig>().allowArmorStat)
            {
                return;
            }

            if (item.type == 151)
            {
                item.defense = 6;
            }
            else if (item.type == 152)
            {
                item.defense = 7;
            }
            else if (item.type == 153)
            {
                item.defense = 6;
            }
            else if (item.type == 238)
            {
                item.defense = 4;
            }
            else if (item.type == 895)
            {
                item.defense = 1;
            }
            else if (item.type == 959)
            {
                item.defense = 6;
            }
            else if (item.type == 1001)
            {
                item.defense = 20;
            }
            else if (item.type == 1832)
            {
                item.defense = 9;
            }
            else if (item.type == 1833)
            {
                item.defense = 11;
            }
            else if (item.type == 1834)
            {
                item.defense = 10;
            }
            else if (item.type == 2763 || item.type == 2764 || item.type == 2765)
            {
                item.lifeRegen = 2;
            }
            else if (item.type == 3187)
            {
                item.defense = 5;
            }
            else if (item.type == 3188)
            {
                item.defense = 6;
            }
            else if (item.type == 3189)
            {
                item.defense = 5;
            }
            else if (item.type == 3800)
            {
                item.defense = 13;
                item.lifeRegen = 4;
            }
            else if (item.type == 3802)
            {
                item.defense = 18;
            }
            else if (item.type == 3871)
            {
                item.defense = 20;
            }
            else if (item.type == 3872)
            {
                item.defense = 24;
                item.lifeRegen = 8;
            }
            else if (item.type == 3873)
            {
                item.defense = 24;
            }
        }
        public override void UpdateEquip(Item item, Player p)
        {
            if (!GetInstance<JourneyRecipesServerConfig>().allowArmorStat)
            {
                return;
            }

            if (p.accDivingHelm)
            {
            }
            if (item.type == 123 || item.type == 124 || item.type == 125)
            {
                p.magicDamage += .02f;
            }
            else if (item.type == 228)
            {
                p.magicCrit += 2;
            }
            else if (item.type == 229)
            {
                p.magicCrit -= 4;
                p.magicDamage += .06f;
            }
            else if (item.type == 230)
            {
                p.magicCrit += 2;
            }
            else if (item.type == 231)
            {
                p.meleeCrit += 7;
            }
            else if (item.type == 232)
            {
                p.meleeDamage += .07f;
            }
            else if (item.type == 233)
            {
                p.meleeSpeed += .07f;
            }
            else if (item.type == 238)
            {
                p.magicDamage -= .1f;
            }
            else if (item.type == 960)
            {
                p.magicCrit += 2;
            }
            else if (item.type == 961)
            {
                p.magicCrit -= 4;
                p.magicDamage += .06f;
            }
            else if (item.type == 962)
            {
                p.magicCrit += 2;
            }
            else if (item.type == 1833)
            {
                p.maxMinions += 1;
            }
            else if (item.type == 1834)
            {
                p.moveSpeed += .2f;
            }
            else if (item.type == 2763)
            {
                p.meleeCrit += 9;
            }
            else if (item.type == 2764)
            {
                p.meleeDamage += .07f;
            }
            else if (item.type == 3777)
            {
                p.maxMinions += 1;
                p.statManaMax2 -= 40;
                p.minionDamage += .1f;
            }
            else if (item.type == 3778)
            {
                p.maxMinions -= 1;
                p.statManaMax2 += 40;
                p.magicDamage += .1f;
            }
            else if (item.type == 3797)
            {
                p.magicDamage += .1f;
            }
            else if (item.type == 3802)
            {
                p.meleeCrit -= 5;
            }
            else if (item.type == 3804)
            {
                p.GetModPlayer<JourneyRecipesPlayer>().Ammo10 = true;
            }
            else if (item.type == 3808)
            {
                p.meleeCrit += 5;
            }
            else if (item.type == 3871)
            {
                p.meleeDamage += .1f;
            }
            else if (item.type == 3873)
            {
                p.moveSpeed -= .1f;
            }
            else if (item.type == 3874)
            {
                p.magicDamage += .05f;
                p.minionDamage += .05f;
            }
            else if (item.type == 3875)
            {
                p.magicDamage -= .05f;
                p.minionDamage -= .05f;
                p.manaCost -= .15f;
            }
            else if (item.type == 3876)
            {
                p.moveSpeed += .2f;
            }
            else if (item.type == 3878)
            {
                p.ammoCost80 = true;
            }
            else if (item.type == 3879)
            {
                p.rangedCrit += 10;
            }
            else if (item.type == 3881)
            {
                p.meleeCrit += 5;
            }
            else if (item.type == 3882)
            {
                p.moveSpeed += .1f;
            }
        }
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (!GetInstance<JourneyRecipesServerConfig>().allowArmorStat)
            {
                return base.IsArmorSet(head, body, legs);
            }

            if (head.type == 894 && body.type == 895 && legs.type == 896)
            {
                return Cactus;
            }
            if (head.type == 1001 && body.type == 1004 && legs.type == 1005)
            {
                return ChlorophyteMelee;
            }
            if (head.type == 3187 && body.type == 3188 && legs.type == 3189)
            {
                return Gladiator;
            }
            if (head.type == 231 && body.type == 232 && legs.type == 233)
            {
                return Molten;
            }
            if ((head.type == 151 || head.type == 959) && body.type == 152 && legs.type == 153)
            {
                return Necro;
            }
            if (head.type == 2763 && body.type == 2764 && legs.type == 2765)
            {
                return Solar;
            }
            if (head.type == 1316 && body.type == 1317 && legs.type == 1318)
            {
                return Turtle;
            }
            if (head.type == 2367 || body.type == 2368 || legs.type == 2369)
            {
                return Angler;
            }
            if ((head.type == 803 || head.type == 978) && (body.type == 804 || body.type == 979) && (legs.type == 805 || legs.type == 980))
            {
                return Snow;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == Cactus)
            {
                player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetBonus.Cactus");
                player.statDefense -= 1;
                player.GetModPlayer<JourneyRecipesPlayer>().CactusThorns = true;
            }
            else if (set == ChlorophyteMelee)
            {
                player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetBonus.ChlorophyteMelee");
                player.endurance += .05f;
            }
            else if (set == Gladiator)
            {
                player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetBonus.Gladiator");
                player.noKnockback = true;
            }
            else if (set == Necro)
            {
                player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetBonus.Necro");
                player.rangedCrit += 10;
            }
            else if (set == Molten)
            {
                player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetBonus.Molten");
                player.buffImmune[24] = true;
            }
            else if (set == Solar)
            {
                player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetBonus.Solar");
                player.endurance += .12f;
                player.solarCounter++;
            }
            else if (set == Turtle)
            {
                player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetBonus.Turtle");
                player.endurance += 0.15f;
                player.turtleThorns = true;
                player.thorns = 2f;
            }
            else if (set == Angler)
            {
                player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetBonus.Angler");
                player.GetModPlayer<JourneyRecipesPlayer>().anglerSetSpawnReduction = true;
            }
            else if (set == Snow)
            {
                player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetBonus.Snow");
                player.buffImmune[46] = true;
                player.buffImmune[47] = true;
            }
        }
    }
}
