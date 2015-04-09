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
    public class CireusChest : ModItem
	{
		public override void ArmorSetBonus(Player p)
		{
			p.setBonus = "Grants many different effects!";
            p.lifeRegen = 10;
            p.knockbackResist = 0f;
			p.breath = p.breathMax;
			p.maxMinions = 99;
			p.longInvince = true;
			p.accFlipper = true;
			p.iceSkate = true;
			p.manaFlower = true;
			p.slowFall = true;
			p.jumpBoost = true;
			p.doubleJump = true;
			p.doubleJump2 = true;
			p.doubleJump3 = true;
            p.noFallDmg = true;
            p.thorns = 5.0f;
			p.AddBuff(63, 300, true); //panic necklace effect
			p.statLifeMax2 += 100;
		}
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