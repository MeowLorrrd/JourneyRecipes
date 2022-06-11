using Terraria;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class JourneyRecipesGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public override bool Autoload(ref string name)
        {
            return ModContent.GetInstance<Config>().AllowNPCStat;
        }
        public override void SetDefaults(NPC npc)
        {
            if (npc.type == 44)
            {
                npc.rarity = 1;
            }
            else if (npc.type == 85)
            {
                npc.rarity = 4;
            }
            else if (npc.type == 109)
            {
                npc.rarity = 1;
            }
            else if (npc.type == 113 || npc.type == 114)
            {
                npc.buffImmune[20] = false;
            }
            else if (npc.type == 127)
            {
                npc.buffImmune[39] = false;
            }
            else if (npc.type == 216)
            {
                npc.rarity = 1;
            }
            else if (npc.type == 217 || npc.type == 218 || npc.type == 219)
            {
                npc.rarity = 2;
            }
            else if (npc.type == 220 || npc.type == 221)
            {
                npc.rarity = 1;
            }
            else if (npc.type == 236 || npc.type == 237)
            {
                npc.lifeMax = 400;
                npc.damage = 100;
                npc.defense = 40;
            }
            else if (npc.type == 241)
            {
                npc.lifeMax = 150;
                npc.damage = 50;
                npc.defense = 20;
                npc.value = 500f;
            }
            else if (npc.type == 243 || npc.type == 251)
            {
                npc.rarity = 2;
            }
            else if (npc.type == 370)
            {
                npc.value = 250000f;
            }
            else if (npc.type == 374 || npc.type == 375)
            {
                npc.dontTakeDamageFromHostiles = true;
            }
            else if (npc.type == 398)
            {
                npc.value = 1000000f;
            }
            else if (npc.type == 471)
            {
                npc.rarity = 1;
            }
            else if (npc.type == 473 || npc.type == 474 || npc.type == 475 || npc.type == 476)
            {
                npc.rarity = 5;
            }
            else if (npc.type == 477)
            {
                npc.rarity = 1;
            }
            else if (npc.type == 509)
            {
                npc.value = 195f;
            }
        }
        public override void OnHitPlayer(NPC npc, Player target, int damage, bool crit)
        {
            if (npc.type == 236 || npc.type == 237)
            {
                if (Main.rand.NextBool(10))
                {
                    target.AddBuff(70, 240);
                }
            }
            else if (npc.type == 289)
            {
                if (Main.rand.NextBool(3))
                {
                    target.AddBuff(23, 240);
                }
            }
        }
        public override bool PreNPCLoot(NPC npc)
        {
            if (npc.type == 392 || npc.type == 393 || npc.type == 394 || npc.type == 395)
            {
                NPCLoader.blockLoot.Add(2800);
                NPCLoader.blockLoot.Add(2882);
                NPCLoader.blockLoot.Add(2798);
            }
            return base.PreNPCLoot(npc);
        }
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == 289)
            {
                if (!Main.expertMode)
                {
                    if (Main.rand.NextBool(100))
                    {
                        Item.NewItem(npc.Hitbox, 891);
                    }
                }
                else
                {
                    if (Main.rand.NextBool(50))
                    {
                        Item.NewItem(npc.Hitbox, 891);
                    }
                }
            }
            else if (npc.type == 381 || npc.type == 382 || npc.type == 383 || npc.type == 385 || npc.type == 389)
            {
                if (Main.rand.NextBool(800))
                {
                    Item.NewItem(npc.Hitbox, 2800);
                }
                if (Main.rand.NextBool(800))
                {
                    Item.NewItem(npc.Hitbox, 2882);
                }
                if (Main.rand.NextBool(800))
                {
                    Item.NewItem(npc.Hitbox, 2798);
                }
            }
            else if (npc.type == 509)
            {
                if (Main.rand.NextBool(50))
                {
                    Item.NewItem(npc.Hitbox, 3772);
                }
            }
            else if (npc.type == 513)
            {
                if (Main.rand.NextBool(2))
                {
                    Item.NewItem(npc.Hitbox, 3380, Main.rand.Next(1, 2));
                }
            }
        }
        public override void ScaleExpertStats(NPC npc, int numPlayers, float bossLifeScale)
        {
            if (npc.type == 23)
            {
                if (Main.expertMode)
                {
                    if (!Main.hardMode)
                    {
                        npc.lifeMax = 52;
                    }
                    else
                    {
                        npc.lifeMax = 56;
                    }
                }
            }
        }
    }
}