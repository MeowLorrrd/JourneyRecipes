using Terraria;
using Terraria.ID;
using Terraria.Localization;
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
                player.endurance += .15f;
                player.thorns = 2;
                player.turtleThorns = false;
                if (GameCulture.German.IsActive)
                {
                    player.setBonus = "Angreifer erleiden doppelten Schaden\nReduziert erlittenen Schaden um 15%";
                }
                if (GameCulture.English.IsActive)
                {
                    player.setBonus = "Attackers also take double damage\nReduces damage taken by 15%";
                }
                if (GameCulture.Spanish.IsActive)
                {
                    player.setBonus = "Los atacantes también reciben el doble de daño\nSe reduce en un 15% el daño sufrido";
                }
                if (GameCulture.French.IsActive)
                {
                    player.setBonus = "Les agresseurs subissent également des dégâts\nRéduit les dégâts subis de 15 %";
                }
                if (GameCulture.Italian.IsActive)
                {
                    player.setBonus = "Gli aggressori ricevono anche danni doppi\nRiduce i danni ricevuti del 15%";
                }
                if (GameCulture.Polish.IsActive)
                {
                    player.setBonus = "Atakujący także otrzymują podwójne obrażenia\nZmniejsza otrzymywane obrażenia o 15%";
                }
                if (GameCulture.Portuguese.IsActive)
                {
                    player.setBonus = "Quem ataca também sofre dano em dobro\nReduz o dano sofrido em 15%";
                }
                if (GameCulture.Russian.IsActive)
                {
                    player.setBonus = "Нападающие также получают двойной урон\nПолучаемый урон снижен на 15 %";
                }
                if (GameCulture.Chinese.IsActive)
                {
                    player.setBonus = "攻击者也会承受双倍伤害\n所受伤害减少15%";
                }
            }
        }
    }
}
