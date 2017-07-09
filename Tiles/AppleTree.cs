using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace LovelyMod.Tiles
{
	public class AppleTree : ModTree
	{
		private Mod mod
		{
			get
			{
				return ModLoader.GetMod("LovelyMod");
			}
		}

		public override int CreateDust()
		{
			return mod.DustType("Sparkle");
		}

		//public override int GrowthFXGore()
		//{
		//	return mod.GetGoreSlot("Gores/ExampleTreeFX");
		//}

		public override int DropWood()
		{
			return mod.ItemType("Apple");
		}

		public override Texture2D GetTexture()
		{
			return mod.GetTexture("Tiles/AppleTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
		{
			return mod.GetTexture("Tiles/AppleTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
		{
			return mod.GetTexture("Tiles/AppleTree_Branches");
		}
	}
}