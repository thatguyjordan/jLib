using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jLib
{
    public class Death : TAPI.ModBuff
    {
        public override void Effects(Player player, int index)
        {
            player.statLife -= 1;
        }
    }
}