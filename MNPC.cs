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
    [GlobalMod]
    public sealed class MNPC : ModNPC
    {
        public override void Initialize()
        {
            DateTime now = DateTime.Now;
            int day = now.Day;
            int month = now.Month;
            /* why arent you doing if (now.Day == 12 && now.Month; == 11 && npc.type == 68)
             * so you dont even have to declare day/month
             */
            if (day == 12 && month == 11 && npc.type == 68)
            {
                npc.displayName = "Digit Guardian";
                Main.PlaySound("jLib:Andrew", npc.position.X, npc.position.Y, true, null, 1f, 10f, - 0.1f);
            }
        }
        public override void PostNPCLoot()
        {
            DateTime now = DateTime.Now;
            int d = now.Day;
            int m = now.Month;
            int fd = ItemDef.byName["jLib:Flaildigit"].type;
            int X = (int)npc.position.X;
            int Y = (int)npc.position.Y;
            if (npc.type == 68 && d == 31 && m == 10)
            {
                Item.NewItem(X, Y, npc.width, npc.height, fd, 1, false, 0, false);
            }
        }
    }
}