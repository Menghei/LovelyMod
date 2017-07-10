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
			Main.npcFrameCount[npc.type] = 6; //Because this NPC has 4 frames
		}

		public override void SetDefaults()
		{
			npc.width = 22;
			npc.height = 42;
			npc.defense = 0;
			npc.lifeMax = 100;
			npc.aiStyle = 3;
		}

		public override void FindFrame(int frameHeight)
		{
			npc.frameCounter += 0.2F; //Animation speed
			npc.frameCounter %= Main.npcFrameCount[npc.type];
			int frame = (int)npc.frameCounter;
			npc.frame.Y = frame * frameHeight;
			npc.spriteDirection = npc.direction; //Makes npc always face towards the player
		}

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
