using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Violet.Items
{
	public class HellbatWingPiece : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellbat Wing Piece");
		}
		public override void SetDefaults()
		{
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.value = 300;
			item.rare = 1;
		}
		public class ModGlobalNPC : GlobalNPC
		{
			public override void NPCLoot(NPC npc)
			{
				if (Main.rand.Next(100) == 33)
					Item.NewItem(npc.getRect(), mod.ItemType("HellbatWingPiece"), 1);
				{
					if (npc.type == NPCID.Hellbat)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellbatWingPiece"));
					}
				}
			}
		}
	}
}

