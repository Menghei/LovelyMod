using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Microsoft.Xna.Framework;

namespace LovelyMod
{
	public class LovelyModPlayer : ModPlayer
	{
		public bool scopeEquipped;
		public float gunMultiplier;

		public LovelyModPlayer()
		{
			this.scopeEquipped = false;
			this.gunMultiplier = 1f;
		}

		public override void ResetEffects()
		{
			this.scopeEquipped = false;
		}

		public override void PostUpdate()
		{
			if(this.scopeEquipped)
			{
				this.gunMultiplier = 5f; //Increases gun damage if scope is equipped
			}
			else
			{
				this.gunMultiplier = 1f; //Makes sure the gun multiplier is normal if scope is not equipped
			}
		}

		public override bool Shoot(Item item, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			//If the weapon being shot is a gun
			if(item.useAmmo == AmmoID.Bullet)
			{
				damage = (int)(damage * this.gunMultiplier);
			}
			return true;
		}
	}
}
