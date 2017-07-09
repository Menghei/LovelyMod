using Terraria.ModLoader;

namespace LovelyMod.Items.Vanity
{
	[AutoloadEquip(EquipType.Head)]
	public class MonsterHead : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.rare = 1;
			item.vanity = true;
		}

		public override bool DrawHead()
		{
			return false;
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