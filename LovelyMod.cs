using Terraria.ID;
using Terraria.ModLoader;

namespace LovelyMod
{
	class LovelyMod : Mod
	{
		public LovelyMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(ItemID.Grenade, 20);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.DirtBlock);
			recipe.SetResult(ItemID.MusketBall, 100);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(null, "RaethentiteOre");
			recipe.SetResult(ItemID.MusketBall, 100);
			recipe.AddRecipe();
		}
	}
}
