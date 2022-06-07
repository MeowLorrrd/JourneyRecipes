using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;

namespace JourneyRecipes.NPCs
{
    public class JourneyRecipesGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public override void SetDefaults(NPC npc)
        {
            bool ns = Config.Instance.allowNPCStat;
            if (ns)
            {
                NPCValues(npc);
            }
        }
        public static void NPCValues(NPC npc)
        {
            switch (npc.type)
            {
                case 44:
                    npc.rarity = 1;
                    break;
                case 85:
                    npc.rarity = 4;
                    break;
                case 109:
                    npc.rarity = 1;
                    break;
                case 113:
                case 114:
                    npc.buffImmune[BuffID.Poisoned] = false;
                    break;
                case 127:
                    npc.buffImmune[BuffID.CursedInferno] = false;
                    break;
                case 216:
                    npc.rarity = 1;
                    break;
                case 217:
                case 218:
                case 219:
                    npc.rarity = 2;
                    break;
                case 220:
                case 221:
                    npc.rarity = 1;
                    break;
                case 236:
                case 237:
                    npc.lifeMax = 400;
                    npc.damage = 100;
                    npc.defense = 40;
                    break;
                case 241:
                    npc.lifeMax = 150;
                    npc.damage = 50;
                    npc.defense = 20;
                    npc.value = 500f;
                    break;
                case 243:
                case 251:
                    npc.rarity = 2;
                    break;
                case 370:
                    npc.value = 250000;
                    break;
                case 374:
                case 375:
                    npc.dontTakeDamageFromHostiles = true;
                    break;
                case 398:
                    npc.value = 1000000;
                    break;
                case 471:
                    npc.rarity = 1;
                    break;
                case 473:
                case 474:
                case 475:
                case 476:
                    npc.rarity = 5;
                    break;
                case 477:
                    npc.rarity = 1;
                    break;
                case 509:
                    npc.value = 195f;
                    break;
            }
        }
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if (Config.Instance.allowBuffStat && player.GetModPlayer<JourneyRecipesPlayer>().PlayerInvis)
            {
                spawnRate = (int)(spawnRate * 1.2f);
            }
        }
    }
}