using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace JourneyRecipes.Items.Weapons.Melee
{
    public class Umbrella : GlobalItem
    {
        /*readonly float AimLeft = -1f;
        readonly float AimRight = 1f;*/
        public override void SetDefaults(Item item)
        {
            /*if (item.type == ItemID.Umbrella)
            {
                item.useStyle = ItemUseStyleID.Stabbing;
                item.damage = 10;
                item.melee = true;
                item.useTime = 22;
                item.useAnimation = 22;
                item.knockBack = 5f;
            }*/
        }//rotate so that umbrella is actually 'stabbing', rather than pushing or smt idk coding is hard lmao
    }
}