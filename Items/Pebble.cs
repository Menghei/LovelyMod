using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items
{
	public class Pebble : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Ammo for popper.");
		}

		public override void SetDefaults()
		{
			item.damage = 12;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.consumable = true;
			item.knockBack = 1.5f;
			item.shoot = mod.ProjectileType("Pebble");
			item.shootSpeed = 16f;   
			item.maxStack = 999;
			item.value = 50;
			item.rare = 1;
			item.ammo = 270; //Arbitrary number for pebble ammo
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "RaethentiteOre");
			recipe.SetResult(this, 999);
			recipe.AddRecipe();
		}
	}
}