using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LovelyMod.NPCs
{
	public class Cow : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cow");
			Main.npcFrameCount[npc.type] = 16; //Because this NPC has 4 frames
		}

		public override void SetDefaults()
		{
			npc.width = 22;
			npc.height = 42;
			npc.defense = 0;
			npc.lifeMax = 100;
			npc.aiStyle = 7; //Friendly AI
		}

		public override void FindFrame(int frameHeight)
		{
			//TODO - Make animation stop when cow isn't moving
			//TODO - Make cow eat grass periodically
			//TODO - Add gore
			//TODO - Make cow drop raw beef
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
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("BottleOfMilk"));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CookedBeef"));
		}
	}
}
