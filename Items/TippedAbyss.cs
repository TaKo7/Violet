using System.Collections.Generic;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Violet.Items
{
	class TippedAbyss : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tipped Abyss");
			Tooltip.SetDefault("Its blade is tipped with the finest drops of water");
			Tooltip.SetDefault("Right click to shoot a concentrated drop of water");
		}
		public override void SetDefaults()
		{
			item.damage = 74;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = 150000;
			item.rare = 3;
		}



		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.useStyle = 3;
				item.useTime = 10;
				item.useAnimation = 10;
				item.UseSound = SoundID.Item46;
				item.damage = 74;
				item.shoot = mod.ProjectileType("TippedAbyssProj");
				item.shootSpeed = 5f;
			}
			else
			{
				item.useStyle = 1;
				item.useTime = 16;
				item.useAnimation = 16;
				item.damage = 74;
				item.shoot = 0;
			}
			return base.CanUseItem(player);
		}
	}
}
