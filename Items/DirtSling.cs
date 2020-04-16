using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Violet.Items
{
	public class DirtSling : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dirt Sling");
			Tooltip.SetDefault("Could use some dirt balls to fling");
			Tooltip.SetDefault("With the scraps that you have, this is where it all begins...");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.ranged = true;
			item.width = 16;
			item.height = 16;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.noMelee = true;
			item.useAmmo = mod.ItemType("DirtBall");
			item.shoot = mod.ProjectileType("DirtBallProjectile");
			item.shootSpeed = 5f;
			item.value = 50;
			item.rare = 1;
	
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

		{ 
			Projectile.NewProjectile(position, new Vector2(speedX,speedY), type, damage, knockBack, player.whoAmI);
			return false;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	
}	
