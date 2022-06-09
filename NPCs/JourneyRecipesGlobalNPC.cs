using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class JourneyRecipesGlobalNPC : GlobalNPC
    {
        /*public override bool Autoload(ref string name)
        {
            return ModContent.GetInstance<Config>().AllowNPCStat || ModContent.GetInstance<Config>().TerraBladeStuff || ModContent.GetInstance<Config>().AllowBuffStat;
        }*/
        public override bool InstancePerEntity => true;
        public override void SetDefaults(NPC npc)
        {
            bool ns = ModContent.GetInstance<Config>().AllowNPCStat;
            bool flag1 = ModContent.GetInstance<Config>().TerraBladeStuff && !NPC.downedPlantBoss;//checks for config and if plantera has been defeated
            if (ns)
            {
                NPCValues(npc);
            }
            if (flag1)
            {
                if (npc.type == 477)
                    npc.lifeMax = 0;
            }
        }
        public override void OnHitPlayer(NPC npc, Player target, int damage, bool crit)
        {
            bool ns = ModContent.GetInstance<Config>().AllowNPCStat;
            if (ns)
            {
                ActiveNPC(npc, target);
            }
        }
        public override bool PreNPCLoot(NPC npc)
        {
            bool ns = ModContent.GetInstance<Config>().AllowNPCStat;
            if (ns)
            {
                switch (npc.type)
                {
                    case 392:
                    case 393:
                    case 394:
                    case 395:
                        NPCLoader.blockLoot.Add(ItemID.AntiGravityHook);
                        NPCLoader.blockLoot.Add(ItemID.LaserDrill);
                        NPCLoader.blockLoot.Add(ItemID.ChargedBlasterCannon);
                        break;
                }
            }
            return base.PreNPCLoot(npc);
        }
        public override void NPCLoot(NPC npc)
        {
            if (ModContent.GetInstance<Config>().AllowNPCStat)
            {
                if (npc.type == 289)
                {
                    if (!Main.expertMode)
                    {
                        if (Main.rand.NextBool(100))
                        {
                            Item.NewItem(npc.Hitbox, ItemID.Nazar);
                        }
                    }
                    else
                    {
                        if (Main.rand.NextBool(50))
                        {
                            Item.NewItem(npc.Hitbox, ItemID.Nazar);
                        }
                    }
                }
                else if (npc.type == 381 || npc.type == 382 || npc.type == 383 || npc.type == 385 || npc.type == 389)
                {
                    if (Main.rand.NextBool(800))
                    {
                        Item.NewItem(npc.Hitbox, ItemID.AntiGravityHook);
                    }
                    if (Main.rand.NextBool(800))
                    {
                        Item.NewItem(npc.Hitbox, ItemID.ChargedBlasterCannon);
                    }
                    if (Main.rand.NextBool(800))
                    {
                        if (Main.rand.NextBool(800)) Item.NewItem(npc.Hitbox, ItemID.LaserDrill);
                    }
                }
                else if (npc.type == 509)
                {
                    if (Main.rand.NextBool(50))
                    {
                        Item.NewItem(npc.Hitbox, ItemID.AntlionClaw);
                    }
                }
                else if (npc.type == 513)
                {
                    if (Main.rand.NextBool(2))
                    {
                        if (Main.rand.NextBool(2)) Item.NewItem(npc.Hitbox, ItemID.FossilOre, Main.rand.Next(1, 2));
                    }
                }
            }
        }
        public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale)
        {
            bool ns = ModContent.GetInstance<Config>().AllowNPCStat;
            if (ns)
            {
                if (npc.type == NPCID.MeteorHead && Main.expertMode)
                {
                    if (!Main.hardMode) npc.lifeMax = 52;
                    else npc.lifeMax = 56;
                }
            }
        }
        private void NPCValues(NPC npc)
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
        private void ActiveNPC(NPC npc, Player target)
        {
            switch (npc.type)
            {
                case 289:
                    if (Main.rand.NextBool(3)) target.AddBuff(BuffID.Cursed, 120);
                    break;
                case 236:
                case 237:
                    if (Main.rand.NextBool(10)) target.AddBuff(BuffID.Venom, 240);
                    break;
            }
        }
        public override void EditSpawnRate(Player player, ref int spawnRate, ref int maxSpawns)
        {
            if (ModContent.GetInstance<Config>().AllowBuffStat && player.GetModPlayer<JourneyRecipesPlayer>().PlayerInvis)
                spawnRate = (int)(spawnRate * 1.2f);
        }
    }
}