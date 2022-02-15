using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace JourneyRecipes.NPCs
{
    public class GiantCursedSkull : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.GiantCursedSkull && Config.Instance.allowNPCStat)
            {
                if (!Main.expertMode)
                {
                    if (Main.rand.Next(100) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Nazar);
                    }
                }
                if (Main.expertMode)
                {
                    if (Main.rand.Next(50) == 0)
                    {
                        Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Nazar);
                    }
                }
            }
        }
        public override void OnHitPlayer(NPC npc, Player target, int damage, bool crit)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.GiantCursedSkull)
            {
                if (Main.rand.Next(3) == 0 && !Main.expertMode)
                {
                    target.AddBuff(BuffID.Cursed, 240);
                }
                if (Main.rand.Next(3) == 0 && Main.expertMode)
                {
                    target.AddBuff(BuffID.Cursed, 120);
                }
            }
        }
    }
    public class GiantCursedSkullProjectile : GlobalProjectile
    {
        public override void OnHitPlayer(Projectile projectile, Player target, int damage, bool crit)
        {
            if (Config.Instance.allowNPCStat && projectile.type == 299)
            {
                if (Main.rand.Next(3) == 0 && !Main.expertMode)
                {
                    target.AddBuff(BuffID.Cursed, 240);
                }
                if (Main.rand.Next(3) == 0 && Main.expertMode)
                {
                    target.AddBuff(BuffID.Cursed, 121);
                }
            }
        }
    }
}