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

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return 1000f;
		}

		public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("RaethentiteOre"));
		}
	}
}
