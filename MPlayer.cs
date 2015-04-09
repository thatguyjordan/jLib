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
    public sealed class MPlayer : ModPlayer
    {
        public override void Initialize()
        {
            base.Initialize();
        }
        public override void MidUpdate()
        {
            if (player.inventory[player.selectedItem].type == ItemDef.byName["jLib:Flaildigit"].type)
            {
                Main.chain3Texture = MBase.BaseInstance.textures["Gores/Flaildigit Chain"];
            }
        }
    }
}