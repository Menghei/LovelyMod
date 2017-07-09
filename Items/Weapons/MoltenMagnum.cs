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
	public class MoltenMagnum : Magnum
	{

		public MoltenMagnum()
		{
			maxShotCount = 6;
			useTime = 10;
			reloadTime = 30;
			setShotCount(maxShotCount);
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
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RaethentiteOre", 10);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
