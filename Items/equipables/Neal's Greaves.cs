using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using TAPI;
using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace jLib
{
	public class NealGreaves : ModItem
	{
        public override void Effects(Player p)
        {
            p.AddBuff("jLib:Death", 60, true);
        }
        public override void VanityEffects(Player p)
        {
            p.AddBuff("jLib:Death", 60, true);
        }
	}
}