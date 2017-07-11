using System;
using Microsoft.Xna.Framework;
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
			npc.aiStyle = -1; //For unique AI
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return 10000f; //Very high spawn rate, for testing purposes
		}

		const int AI_State_Slot = 0;
		const int AI_Timer_Slot = 1;

		const int State_Peaceful = 0;
		const int State_Pursuing = 1;

		public float AI_State
		{
			get{return npc.ai[AI_State_Slot];}
			set{npc.ai[AI_State_Slot] = value;}
		}
		public float AI_Timer
		{
			get{return npc.ai[AI_Timer_Slot];}
			set{npc.ai[AI_Timer_Slot] = value;}
		}

		public override void AI()
		{
			if(AI_State == State_Peaceful)
			{
				npc.TargetClosest(true); //Should face towards nearest player
				if(npc.HasValidTarget && Main.player[npc.target].Distance(npc.Center) < 100f)
				{
					AI_State = State_Pursuing;
					AI_Timer = 0;
				}
			}
			else if(AI_State == State_Pursuing)
			{
				npc.velocity = new Vector2(npc.direction * 2, 0f);
				if(!npc.HasValidTarget || Main.player[npc.target].Distance(npc.Center) >= 100f)
				{
					AI_State = State_Peaceful;
					AI_Timer = 0;
				}
			}
		}

		public override void FindFrame(int frameHeight)
		{
			npc.frameCounter += 0.2F; //Animation speed
			npc.frameCounter %= Main.npcFrameCount[npc.type];
			int frame = (int)npc.frameCounter;
			npc.frame.Y = frame * frameHeight;
			npc.spriteDirection = npc.direction; //Makes npc always face towards the player
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
