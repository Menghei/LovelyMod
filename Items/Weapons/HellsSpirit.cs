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
	public class HellsSpirit : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Pretty cool, right?");
			//TODO - Change name to Hell's Spirit with proper apostrophe
			//TODO - Make gun closer to player when shooting
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useStyle = 5;
			item.useTime = 30;
			item.useAnimation = 30;
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
			recipe.AddIngredient(null, "RaethentiteOre");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
