using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LovelyMod.NPCs
{
	public class DaddyUnk : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Daddy Unk");
			Main.npcFrameCount[npc.type] = 4; //Because this NPC has 4 frames
		}

		public override void SetDefaults()
		{
			npc.width = 22;
			npc.height = 42;
			npc.defense = 0;
			npc.lifeMax = 100;
			npc.aiStyle = 3;
			animationType = NPCID.Zombie;
		}

		// public override void FindFrame(int frameHeight)
		// {
		// 	if(npc.frameCounter <= 4)
		// 	{
		// 		npc.frameCounter++;
		// 	}
		// 	else
		// 	{
		// 		npc.frameCounter = 1;
		// 	}
		// 	npc.spriteDirection = npc.direction;
		// }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return 100000f;
		}

		public override void NPCLoot()
		{
			int numBeans = Main.rand.Next(5) + 5;
			for(int i = 0; i < numBeans; i++)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Bean"));
			}
		}
	}
}
