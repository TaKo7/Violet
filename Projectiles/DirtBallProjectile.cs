using System.Collections.Generic;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Violet.Projectiles
{
	class DirtBallProjectile:ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("DirtBallProjectile");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}
		public override void SetDefaults()
		{
			projectile.width = 8;              
			projectile.height = 8;             
			projectile.aiStyle = 1;            
			projectile.friendly = true;        
			projectile.hostile = false;        
			projectile.ranged = true;          
			projectile.penetrate = 1;          
			projectile.timeLeft = 600;         
			projectile.alpha = 0;           
			projectile.light = 0.5f;           
			projectile.ignoreWater = true;     
			projectile.tileCollide = true;         
			projectile.extraUpdates = 1;           
			aiType = ProjectileID.SnowBallFriendly;
		}
	}
}
