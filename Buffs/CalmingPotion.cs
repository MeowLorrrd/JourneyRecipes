using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;

namespace JourneyRecipes.Buffs
{
    public class CalmingPotionBuff : GlobalBuff
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            if (type == BuffID.Calm)//No config needed because no buff duration change, just tooltip
            {
                if (GameCulture.German.IsActive)
                    tip = "Verringert die Feind-Spawnquote";
                if (GameCulture.English.IsActive)
                    tip = "Decreases enemy spawn rate";
                if (GameCulture.Spanish.IsActive)
                    tip = "Reduce la velocidad de regeneración del enemigo";
                if (GameCulture.French.IsActive)
                    tip = "Réduit le taux d'apparition d'ennemis";
                if (GameCulture.Italian.IsActive)
                    tip = "Riduce il ritmo di generazione dei nemici";
                if (GameCulture.Polish.IsActive)
                    tip = "Zmniejsza tempo rodzenia się przeciwników";
                if (GameCulture.Portuguese.IsActive)
                    tip = "Diminui a taxa de criação de inimigos";
                if (GameCulture.Russian.IsActive)
                    tip = "Замедляет воскрешение врагов";
                if (GameCulture.Chinese.IsActive)
                    tip = "降低敌人生成速度";
            }
        }
    }
    public class CalmingPotion : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if (Config.Instance.allowBuffDuration && item.type == ItemID.CalmingPotion)
            {
                item.buffType = BuffID.Calm;
                item.buffTime = 28800;
            }
        }
    }
}