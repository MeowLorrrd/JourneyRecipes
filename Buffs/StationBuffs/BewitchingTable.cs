using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.Buffs.StationBuffs
{
    public class BewitchingTable : GlobalBuff
    {
        public override void Update(int type, Player player, ref int buffIndex)
        {
            if (Config.Instance.allowBuffDuration && type == BuffID.Bewitched)
            {
                player.buffTime[buffIndex] = 216000;
                Main.buffNoTimeDisplay[type] = true;
                Main.buffNoSave[type] = true;
            }
        }
    }
}