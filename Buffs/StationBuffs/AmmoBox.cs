using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs.StationBuffs
{
    public class AmmoBoxBuff : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            if (Config.Instance.allowBuffDuration && type == BuffID.AmmoBox)
            {
                player.buffTime[buffIndex] = 216000;
                Main.buffNoTimeDisplay[type] = true;
                Main.buffNoSave[type] = true;
            }
        }
    }
}