using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using JourneyRecipes;

namespace JourneyRecipes
{
    public class JourneyRecipesGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public override void SetDefaults(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.Mothron || npc.type == NPCID.GoblinSummoner || npc.type == NPCID.Squid || npc.type == NPCID.SeaSnail || npc.type == NPCID.PirateCaptain || npc.type == NPCID.Clown || npc.type == NPCID.UndeadMiner)
            {
                npc.rarity = 1;
            }
            if (Config.Instance.allowNPCStat && npc.type == NPCID.Eyezor || npc.type == NPCID.IceGolem || npc.type == NPCID.LacBeetle || npc.type == NPCID.CyanBeetle || npc.type == NPCID.CochinealBeetle)
            {
                npc.rarity = 2;
            }
            if (Config.Instance.allowNPCStat && npc.type == NPCID.Mimic)
            {
                npc.rarity = 4;
            }
            if (Config.Instance.allowNPCStat && npc.type == NPCID.BigMimicCorruption || npc.type == NPCID.BigMimicCrimson || npc.type == NPCID.BigMimicHallow || npc.type == NPCID.BigMimicJungle)
            {
                npc.rarity = 5;
            }
        }
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if (Config.Instance.allowBuffStat && player.GetModPlayer<JourneyRecipesPlayer>().PlayerInvis)
            {
                spawnRate = (int)(spawnRate *( 1.2f));
            }
        }
    }
}