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
        class ExplosionParticleSystem: ParticleSystem
        {
            public ExplosionParticleSystem(Game1 game, int howManyEffects, string textureFileName):
                base(game, howManyEffects, textureFileName)
            {
                
            }

            protected override void InitializeConstants()
            {
                minInitialSpeed = 40;
                maxInitialSpeed = 500;

                minAcceleration = 0;
                maxAcceleration = 0;

                minLifetime = 0.1f;
                maxLifetime = 0.3f;

                minScale = 0.3f;
                maxScale = 1.0f;

                minNumParticles = 20;
                maxNumParticles = 25;

                minRotationSpeed = -MathHelper.PiOver4;
                maxRotationSpeed = MathHelper.PiOver4;

                spriteBlendMode = SpriteBlendMode.Additive;

                DrawOrder = AdditiveDrawOrder;
            }

            protected override void InitializeParticle(Particle p, Vector2 where)
            {
                base.InitializeParticle(p, where);

                p.acceleration = -p.velocity / p.lifetime;
            }
        }
    }
}
