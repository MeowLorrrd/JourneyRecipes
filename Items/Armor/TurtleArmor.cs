using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Items.Armor
{
    public class TurtleArmorSet : GlobalItem
    {
        const string TurtleArmor = "Turtle_armor";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.TurtleHelmet && body.type == ItemID.TurtleScaleMail && legs.type == ItemID.TurtleLeggings)
            {
                return TurtleArmor;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == TurtleArmor)
            {
                player.setBonus = "Attackers also take double damage\nReduces damage taken by 15%";
                player.endurance += .15f;
                player.thorns = 2;
                player.turtleThorns = false;
            }
        }
    }
}
