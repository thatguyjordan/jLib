using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;
using TAPI;
using Terraria;


namespace jLib
{
    public class Flaildigit : ModItem
    {
        public override void HoldStyle(Player p)
        {
            Main.chain3Texture = Main.goreTexture[GoreDef.gores["jLib:Flaildigit Chain"]];
        }
    }
}