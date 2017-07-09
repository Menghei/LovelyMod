using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LovelyMod.Projectiles
{
	public class Pebble : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pebble");
		}

		public override void SetDefaults()
		{
			projectile.width = 8; //The width of projectile hitbox
			projectile.height = 8; //The height of projectile hitbox
			projectile.friendly = true; //Can the projectile deal damage to enemies?
			projectile.hostile = false; //Can the projectile deal damage to the player?
			projectile.ranged = true; //Is the projectile shoot by a ranged weapon?
			projectile.timeLeft = 600; //The live time for the projectile (60 = 1 second, so 600 is 10 seconds)
			projectile.tileCollide = true; //Can the projectile collide with tiles?
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for(int i = 0; i < 20; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 1, -projectile.velocity.X / 10, -projectile.velocity.X / 10, 100, default(Color), 0.75f);
				Main.dust[dustIndex].velocity *= 1f;
			}
			return true;
		}

		public override void AI()
		{
			projectile.velocity.Y += 0.3f; //Makes pebble experience gravity
		}

		public override void Kill(int timeLeft)
		{
			for(int i = 0; i < 20; i++) {
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 1, -projectile.velocity.X / 10, -projectile.velocity.X / 10, 100, default(Color), 0.75f);
				Main.dust[dustIndex].velocity *= 1f;
			}
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			//Redraw the projectile with the color not influenced by light
			Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}
	}
}
