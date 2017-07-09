using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LovelyMod.Items.Vanity
{
	[AutoloadEquip(EquipType.Body)]
	public class MonsterSuit : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			//DisplayName.SetDefault("Example Breastplate"); //Can probably delete this
			Tooltip.SetDefault("Dang!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
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