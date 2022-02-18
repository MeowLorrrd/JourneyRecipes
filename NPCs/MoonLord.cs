using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace JourneyRecipes.NPCs
{
    public class MoonLord : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.MoonLordCore)
            {
                Item.NewItem(npc.Hitbox, ItemID.SuperHealingPotion, Main.rand.Next(5, 15));
                //
            }
        }
        public override void SetDefaults(NPC npc)
        {
            if (Config.Instance.allowNPCStat && npc.type == NPCID.MoonLordCore)
                npc.value = 1000000;
        }
        public override bool PreNPCLoot(NPC npc)
        {
            if (npc.type == NPCID.MoonLordCore)
            {

            }
            return base.PreNPCLoot(npc);
        }
    }
}
//Moon Lord doesn't drop Greater Healing Potions, but drops Super Healing Potions