using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace JourneyRecipes.NPCs
{
    public class UndeadMiner : GlobalNPC
    {
        /*public override bool PreNPCLoot(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.UndeadMiner)
            {

            }
            return base.PreNPCLoot(npc);
        }*/
        public override void NPCLoot(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.UndeadMiner)
            {
                if (Main.rand.Next(20) == 0)
                    Item.NewItem(npc.Hitbox, ItemID.BonePickaxe);
                int i = Main.rand.Next(25);
                switch (i)
                {
                    case 0:
                        Item.NewItem(npc.Hitbox, ItemID.MiningShirt);
                        break;
                    case 1:
                        Item.NewItem(npc.Hitbox, ItemID.MiningShirt);
                        break;
                    case 2:
                        Item.NewItem(npc.Hitbox, ItemID.MiningShirt);
                        break;
                    case 3:
                        Item.NewItem(npc.Hitbox, ItemID.MiningPants);
                        break;
                    case 4:
                        Item.NewItem(npc.Hitbox, ItemID.MiningPants);
                        break;
                    case 5:
                        Item.NewItem(npc.Hitbox, ItemID.MiningPants);
                        break;
                    case 6:
                        Item.NewItem(npc.Hitbox, ItemID.Hook);
                        break;
                    case 7:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 8:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 9:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 10:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 11:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 12:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 13:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 14:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 15:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 16:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 17:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 18:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 19:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 20:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 21:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 22:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 23:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 24:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                    case 25:
                        Item.NewItem(npc.Hitbox, ItemID.Bomb, Main.rand.Next(1, 3));
                        break;
                }
            }
        }
    }
}