using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Violet.Items
{
	public class HellbatSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellbat Sword");
			Tooltip.SetDefault("Forged together with the flaming wings of Hellbats");
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.value = 20000;
			item.rare = 3;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("HellbatWingPiece"), 25);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}