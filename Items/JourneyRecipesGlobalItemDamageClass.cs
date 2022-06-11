using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;
using static Terraria.ModLoader.ModContent;

namespace JourneyRecipes.Items
{
    public class JourneyRecipesGlobalItemDamageClass : GlobalItem
    {
        const string Fossil = "fossilSet";
        const string Ninja = "ninjaSet";
        public override bool Autoload(ref string name)
        {
            return GetInstance<Config>().allowThrowingToRanged;
        }
        public override void SetDefaults(Item item)
        {
            if (item.thrown)
            {
                item.melee = false;
                item.thrown = false;
                item.ranged = true;
            }
            if (item.type == 3374 || item.type == 3376)
            {
                item.defense = 4;
            }
            else if (item.type == 3375)
            {
                item.defense = 5;
            }
        }
        public override void UpdateEquip(Item item, Player p)
        {
            if (item.type == 256)
            {
                p.thrownVelocity -= .15f;
                p.magicCrit += 3;
                p.meleeCrit += 3;
                p.rangedCrit += 3;
            }
            else if (item.type == 257)
            {
                p.thrownDamage -= .15f;
                p.magicCrit += 3;
                p.meleeCrit += 3;
                p.rangedCrit += 3;
            }
            else if (item.type == 258)
            {
                p.thrownCrit -= 10;
                p.magicCrit += 3;
                p.meleeCrit += 3;
                p.rangedCrit += 3;
            }
            else if (item.type == 3374)
            {
                p.thrownVelocity -= .2f;
                p.rangedCrit += 4;
            }
            else if (item.type == 3375)
            {
                p.thrownCrit -= 15;
                p.rangedDamage += .05f;
            }
            else if (item.type == 3376)
            {
                p.thrownDamage -= .2f;
                p.rangedCrit += 4;
            }
        }
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == 3374 && body.type == 3375 && legs.type == 3376)
            {
                return Fossil;
            }
            if (head.type == 256 && body.type == 257 && legs.type == 258)
            {
                return Ninja;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (set == Fossil)
            {
                player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetbonus.Fossil");
                player.thrownCost33 = false;
                player.thrownCost50 = false;
                player.ammoCost80 = true;
            }
            else if (set == Ninja)
            {
                player.setBonus = Language.GetTextValue("Mods.JourneyRecipes.ArmorSetbonus.Ninja");
                player.thrownCost33 = false;
                player.thrownCost50 = false;
                player.moveSpeed += .2f;
            }
        }
    }
}