using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace firstGame
{
    namespace Particles
    {
        class ExplosionSmokeParticleSystem: ParticleSystem
        {
            public ExplosionSmokeParticleSystem(Game1 game, int howManyEffects, string textureFileName):
                base(game,howManyEffects,textureFileName)
            {

            }

            protected override void InitializeConstants()
            {
                minInitialSpeed = 20;
                maxInitialSpeed = 200;

                minAcceleration = -10;
                maxAcceleration = -50;

                minLifetime = 0.4f;
                maxLifetime = 1.0f;

                minScale = 0.7f;
                maxScale = 1.0f;

                minNumParticles = 10;
                maxNumParticles = 20;

                minRotationSpeed = -MathHelper.PiOver4;
                maxRotationSpeed = MathHelper.PiOver4;

                spriteBlendMode = SpriteBlendMode.AlphaBlend;

                DrawOrder = AlphaBlendDrawOrder;
            }
        }
    }
}
