using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class Hoplite : GlobalNPC
    {
        public override bool PreNPCLoot(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.GreekSkeleton)
            {
                NPCLoader.blockLoot.Add(ItemID.GladiatorHelmet);
                //NPCLoader.blockLoot.Add(ItemID.GladiatorBreastplate);
                //NPCLoader.blockLoot.Add(ItemID.GladiatorLeggings);
                //NPCLoader.blockLoot.Remove(ItemID.GladiatorHelmet);
            }
            return base.PreNPCLoot(npc);
        }
        public override void NPCLoot(NPC npc)
        {
            /*if (Config.Instance.allowNPCStat && npc.type == NPCID.GreekSkeleton)
            {
                if (Main.rand.Next(7) == 0)
                {
                    int i = Main.rand.Next(3);
                    switch (i)
                    {
                        case 0:
                            Item.NewItem(npc.Hitbox, ItemID.GladiatorHelmet);
                            break;
                        case 1:
                            Item.NewItem(npc.Hitbox, ItemID.GladiatorBreastplate);
                            break;
                        case 2:
                            Item.NewItem(npc.Hitbox, ItemID.GladiatorLeggings);
                            break;
                    }
                }
            }*/
            if (Config.Instance.allowNPCStat && npc.type == NPCID.GreekSkeleton)
            {
                /*if (Main.rand.Next(7) == 0)
                {
                    Item.NewItem(npc.Hitbox, 3187 + Main.rand.Next(3));
                }*/
                //Item.NewItem(npc.Hitbox, 5);
                NewDropRules();
                Item.NewItem(npc.Hitbox, 3187);// + Main.rand.Next(3));

                //2 Helmets can drop at same time, fix
            }
        }
        public void NewDropRules()
        {
            NPCLoader.blockLoot.Remove(ItemID.GladiatorHelmet);
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