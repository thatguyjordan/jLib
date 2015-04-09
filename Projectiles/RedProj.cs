using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

using TAPI;
using Terraria;

namespace jLib.Projectiles
{
    public class RedProj : ModProjectile
    {

        public override void PostKill()
        {
            int d = Dust.NewDust(projectile.position, projectile.width, projectile.height, 1, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 50, default(Color), 0.8f);
            Main.dust[d].noGravity = true;
            Main.dust[d].OverrideTexture = MBase.BaseInstance.textures["Gores/RedDust"]; 
	    }
    }
}