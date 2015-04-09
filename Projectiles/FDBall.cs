using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TAPI;
using jLib;
using Terraria;

namespace jLib.Projectiles
{
    public class FDBall : ModProjectile
    {
        public override void DealtNPC(NPC n, int hitDir, int dmgDealt, float knockback, bool crit)
        {
            int rp = ProjDef.byName["jLib:RedProj"].type;

            Projectile.NewProjectile(projectile.position.X, Main.screenPosition.Y - 400.0f, 0.0f, 0f, rp, 86, 0, projectile.whoAmI);
            Projectile.NewProjectile(projectile.position.X + 100.0f, Main.screenPosition.Y - 400.0f, 0.0f, 0f, rp, 86, 0, projectile.whoAmI);
            Projectile.NewProjectile(projectile.position.X - 100.0f, Main.screenPosition.Y - 400.0f, 0.0f, 0f, rp, 86, 0, projectile.whoAmI);
            Projectile.NewProjectile(projectile.position.X + 200.0f, Main.screenPosition.Y - 400.0f, 0.0f, 0f, rp, 86, 0, projectile.whoAmI);
            Projectile.NewProjectile(projectile.position.X - 200.0f, Main.screenPosition.Y - 400.0f, 0.0f, 0f, rp, 86, 0, projectile.whoAmI);
        }
        public override void PostAI()        
        {            
            int d = Dust.NewDust(projectile.position, projectile.width, projectile.height, 1, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 50, default(Color), 0.8f);
            Main.dust[d].noGravity = true;
            Main.dust[d].OverrideTexture = MBase.BaseInstance.textures["Gores/RedDust"]; 
        }
    }
}