using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class Hoplite : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.GreekSkeleton)
            {
                if (Main.rand.Next(7) == 0)
                {
                    int i = Main.rand.Next(3);
                    switch (i)
                    {
                        case 0:
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GladiatorHelmet);
                            break;
                        case 1:
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GladiatorBreastplate);
                            break;
                        case 2:
                            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GladiatorLeggings);
                            break;
                    }
                }
            }
        }
    }
    public class GladiatorProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            if (Config.Instance.allowNPCStat && projectile.type == ProjectileID.JavelinHostile)
            {
                projectile.damage = 36;
            }
        }
    }
}