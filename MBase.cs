using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using TAPI;
using Terraria;
using jLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace jLib
{
    public sealed class MBase : ModBase
    {
        internal static MBase BaseInstance;
        public override void OnLoad() 
        {
            BaseInstance = this;
            Main.chain3Texture = MBase.BaseInstance.textures["Gores/Chain3"];
            //Main.chain3Texture = MBase.BaseInstance.textures["Gores/Flaildigit Chain"];
            DateTime now = DateTime.Now;
            int day = now.Day;
            int month = now.Month;
            int dg = NPCDef.byName["Vanilla:Dungeon Guardian"].type;
            if (day == 12 && month == 11)
            {
                    Main.NPCLoaded[68] = true;
                    Main.npcTexture[68] = Main.goreTexture[GoreDef.gores["jLib:Red"]];
            }
        }
        public override void OnUnload() {
            Main.NPCLoaded[68] = false;
            Main.chain3Texture = MBase.BaseInstance.textures["Gores/Chain3"];
        }
    }
}