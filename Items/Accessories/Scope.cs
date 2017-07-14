using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace LovelyMod.Items.Accessories
{
	public class Scope : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Allows greater gun accuracy.");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.value = 100000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetModPlayer<LovelyModPlayer>(mod).scopeEquipped = true;
		}

		public override void AddRecipes()
    {
      ModRecipe recipe = new ModRecipe(mod);
      recipe.AddIngredient(ItemID.DirtBlock);
      recipe.SetResult(this);
      recipe.AddRecipe();
    }
	}
}
