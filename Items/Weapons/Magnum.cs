using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace LovelyMod.Items.Weapons
{
	public class Magnum : ModItem
	{
		public int maxShotCount;
		public int useTime;
		public int reloadTime;

		private int shotCount;

		public Magnum()
		{
			maxShotCount = 6;
			useTime = 20;
			reloadTime = 60;
			setShotCount(maxShotCount);
		}
		public int getShotCount()
		{
			return this.shotCount;
		}
		public void setShotCount(int newShotCount) {
			if(newShotCount <= maxShotCount && newShotCount >= 0)
			{
				this.shotCount = newShotCount;
			}
		}
		public void updateUseTime()
		{
			if(getShotCount() > 1)
			{
				item.useTime = useTime;
				item.useAnimation = useTime;
			} else {
				item.useTime = useTime + reloadTime;
				item.useAnimation = useTime + reloadTime;
			}
		}

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Warm to the touch.");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			updateUseTime();
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			setShotCount(getShotCount() - 1);
			if(getShotCount() <= 0)
			{
				setShotCount(maxShotCount);
			}
			updateUseTime();
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RaethentiteOre", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
