using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.GameContent.Events;
using Terraria.GameInput;
using Terraria.ModLoader.IO;

namespace JourneyRecipes
{
    public class JourneyRecipesPlayer : ModPlayer
    {
        public bool PlayerInvis;
        public bool PlayerFeral;
        public bool PlayerAutouse;
        public bool PlayerTitanGlove;
        public static float PlayerMeleeOriginalScale;
        public float PlayerMeleeBigger;
        public bool CactusThorns;
        public override void ResetEffects()
        {
            PlayerInvis = false;
            PlayerFeral = false;
            PlayerTitanGlove = false;
            PlayerAutouse = false;
            PlayerMeleeOriginalScale = -1;
            CactusThorns = false;
        }
        public override bool PreItemCheck()
        {
            if (Config.Instance.allowAccessoryStat && PlayerFeral && player.HeldItem.melee)
            {
                PlayerAutouse = player.HeldItem.autoReuse;
                player.HeldItem.autoReuse = true;
            }
            return true;
        }
        public override void PostItemCheck()
        {
            if (PlayerFeral && player.HeldItem.melee)
            {
                player.HeldItem.autoReuse = PlayerAutouse;
            }
        }
    }
}