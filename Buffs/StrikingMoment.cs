using Terraria.ModLoader;
using Terraria.ID;


namespace JourneyRecipes.Buffs
{
    public class StrikingMoment : GlobalBuff
    {
        public override void ModifyBuffTip(int type, ref string tip, ref int rare)
        {
            base.ModifyBuffTip(type, ref tip, ref rare);
            if (type == BuffID.ParryDamageBuff)
            {
                tip = ("400% increased damage for next melee strike");
            }
        }
    }
}