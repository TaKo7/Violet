using System.Collections.Generic;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Violet.Items
{
	class DirtBall:ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dirt Ball");
			Tooltip.SetDefault("Could be slinged somehow...");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.ranged = true;
			item.consumable = true;
			item.maxStack = 999;
			item.height = 8;
			item.width = 8;
			item.knockBack = 1.5f;
			item.shoot = ProjectileType<Projectiles.DirtBallProjectile>();
			item.ammo = item.type;
			item.value = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}
	}
}
