using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace JourneyRecipes.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class CactusArmorBody : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.CactusBreastplate)
                item.defense = 1;
        }
    }
    public class CactusArmorSet : GlobalItem
    {
        const string CactusSet = "Cactus_armor_set";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.CactusHelmet && body.type == ItemID.CactusBreastplate && legs.type == ItemID.CactusLeggings)
            {
                return CactusSet;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == CactusSet)
            {
                player.statDefense -= 1;
                player.GetModPlayer<JourneyRecipesPlayer>().CactusThorns = true;
                //^^ Make Thorns damage deal 15 flat damage, 30 in Expert
                player.thorns = 1f;
                if (GameCulture.German.IsActive)
                {
                    player.setBonus = "Angreifer erleiden Schaden durch Kaktusstacheln";
                }
                if (GameCulture.English.IsActive)
                {
                    player.setBonus = "Attackers take damage from the cactus spines";
                }
                if (GameCulture.Spanish.IsActive)
                {
                    player.setBonus = "Los atacantes sufren daños por las espinas del cactus";
                }
                if (GameCulture.French.IsActive)
                {
                    player.setBonus = "Les agresseurs subissent des dégâts causés par les épines de cactus";
                }
                if (GameCulture.Italian.IsActive)
                {
                    player.setBonus = "Gli aggressori ricevono danni dalle spine di cactus";
                }
                if (GameCulture.Polish.IsActive)
                {
                    player.setBonus = "Atakujący otrzymują obrażenia od kolców kaktusa";
                }
                if (GameCulture.Portuguese.IsActive)
                {
                    player.setBonus = "Atacantes sofrem dano por espinhos de cactos";
                }
                if (GameCulture.Russian.IsActive)
                {
                    player.setBonus = "Атакующие получают урон от колючек кактуса";
                }
                if (GameCulture.Chinese.IsActive)
                {
                    player.setBonus = "攻击者因为仙人掌尖刺受到伤害";
                }
            }
        }
    }
}
