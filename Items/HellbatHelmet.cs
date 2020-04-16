using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Violet.Items
{
	[AutoloadEquip(EquipType.Head)]
	class HellbatHelmet:ModItem
	{
		public override void SetDefaults()
		{
			item.width = 21;
			item.height = 14;
			item.value = 60000;
			item.rare = 2;
			item.defense = 20;
		}

		public static void Effects(Player player)
		{
			player.moveSpeed += 15;
		}
	}
}
