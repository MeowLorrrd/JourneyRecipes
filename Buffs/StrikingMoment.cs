using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Localization;


namespace JourneyRecipes.Buffs
{
    public class StrikingMoment : GlobalBuff
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            base.ModifyBuffTip(type, ref tip, ref rare);
            if (type == BuffID.ParryDamageBuff)
            {
                if (GameCulture.German.IsActive)
                    tip = "Um 400% erhöhter Schaden für den nächsten Nahkampfangriff";
                if (GameCulture.English.IsActive)
                    tip = "400% increased damage for next melee strike";
                if (GameCulture.Spanish.IsActive)
                    tip = "Un 400% más de daño en el próximo ataque cuerpo a cuerpo";
                if (GameCulture.French.IsActive)
                    tip = "+400 % de dégâts pour la prochaine attaque au corps à corps";
                if (GameCulture.Italian.IsActive)
                    tip = "Danni per il prossimo attacco in mischia aumentati del 400%";
                if (GameCulture.Polish.IsActive)
                    tip = "400% zwiększone obrażenia następnego ataku w walce w zwarciu";
                if (GameCulture.Portuguese.IsActive)
                    tip = "Aumento de 400% nos danos para o próximo ataque físico";
                if (GameCulture.Russian.IsActive)
                    tip = "+400 % к урону от следующего удара ближнего боя";
                if (GameCulture.Chinese.IsActive)
                    tip = "下次近战暴击伤害增加400%";
            }
        }
    }
}