using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace JourneyRecipes.Items.Ammo
{
    [AutoloadEquip(EquipType.Head)]
    public class ChlorophyteArmorHeadMelee : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowArmorStat && item.type == ItemID.ChlorophyteMask)
                item.defense = 20;
        }
    }
    public class ChlorophyteArmorSet : GlobalItem
    {
        const string ChlorophyteArmorMeleeSet = "Chlorophyte_armor_set_with_Mask";
        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            if (head.type == ItemID.ChlorophyteMask && body.type == ItemID.ChlorophytePlateMail && legs.type == ItemID.ChlorophyteGreaves)
            {
                return ChlorophyteArmorMeleeSet;
            }
            return base.IsArmorSet(head, body, legs);
        }
        public override void UpdateArmorSet(Player player, string set)
        {
            if (Config.Instance.allowArmorStat && set == ChlorophyteArmorMeleeSet)
            {
                player.endurance += .05f;
                if (GameCulture.German.IsActive)
                {
                    player.setBonus = "Beschwört einen mächtigen Blattkristall mit dem du auf Gegner in der Nähe schießen kannst\nReduziert erlittenen Schaden um 5%";
                }
                if (GameCulture.English.IsActive)
                {
                    player.setBonus = "Summons a powerful leaf crystal to shoot at nearby enemies\nReduces damage taken by 5%";
                }
                if (GameCulture.Spanish.IsActive)
                {
                    player.setBonus = "Invoca una poderosa hoja de cristal que se lanza a los enemigos cercanos\nReduce en un 5% el daño sufrido";
                }
                if (GameCulture.French.IsActive)
                {
                    player.setBonus = "Invoque une feuille de cristal puissante pour tirer sur les ennemis à proximité\nRéduit les dégâts subis de 5 %";
                }
                if (GameCulture.Italian.IsActive)
                {
                    player.setBonus = "Evoca una potente cristallo a foglia da sparare ai nemici vicini \nRiduce il danno subito del 5%";
                }
                if (GameCulture.Polish.IsActive)
                {
                    player.setBonus = "Przywołuje potężnego liścia kryształowego, który rani pobliskich wrogów\nZmniejsza otrzymywane obrażenia o 5%";
                }
                if (GameCulture.Portuguese.IsActive)
                {
                    player.setBonus = "Invoca um poderoso cristal de folha para atirar em inimigos próximos\nReduz os danos sofridos em 5%";
                }
                if (GameCulture.Russian.IsActive)
                {
                    player.setBonus = "Призывает мощный лиственный кристалл, который стреляет в ближайших врагов\nПолучаемый урон снижен на 5 %";
                }
                if (GameCulture.Chinese.IsActive)
                {
                    player.setBonus = "召唤强大的叶状水晶来射击附近的敌人\n所受伤害减少5%";
                }
            }
        }
    }
    public class CrystalLeaf : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowArmorStat && projectile.type == ProjectileID.CrystalLeaf)
            {
                //Make shit shoot every .67 sec instead of .83
            }
        }
    }
}