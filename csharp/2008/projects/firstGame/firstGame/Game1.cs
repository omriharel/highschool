using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using firstGame.Particles;

namespace firstGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;

        Texture2D backgroundTexture;
        Rectangle viewportRect;
        SpriteBatch spriteBatch;
        public SpriteBatch SpriteBatch
        {
            get
            {
                return spriteBatch;
            }
        }
        GameObject cannon;
        const int maxCannonBalls = 10;
        GameObject[] cannonBalls;
        GamePadState previousGamePadState = GamePad.GetState(PlayerIndex.One);
        KeyboardState previousKeyboardState = Keyboard.GetState();
        const int maxEnemies = 5;
        const float maxEnemyHeight = 0.1f;
        const float minEnemyHeight = 0.5f;
        const float maxEnemyVelocity = 5.0f;
        const float minEnemyVelocity = 1.0f;
        Random random = new Random();
        GameObject[] enemies;
        int score;
        SpriteFont font;
        Vector2 scoreDrawPoint = new Vector2(0.01f, 0.01f);
        ParticleSystem explosion;
        ParticleSystem smoke;
        ParticleSystem tomer;

        public Game1()
        {
            Window.Title = "Blast Tomer!";
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            tomer = new TomerParticleSystem(this, maxEnemies, "Sprites\\tomer");
            explosion = new ExplosionParticleSystem(this, maxEnemies, "Sprites\\explosion");
            smoke = new ExplosionSmokeParticleSystem(this, maxEnemies, "Sprites\\smoke");

            Components.Add(tomer);
            Components.Add(explosion);
            Components.Add(smoke);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            backgroundTexture = Content.Load<Texture2D>("Sprites\\background");
            cannon = new GameObject(Content.Load<Texture2D>("Sprites\\cannon"));
            cannon.position = new Vector2(120, graphics.GraphicsDevice.Viewport.Height - 80);
            cannonBalls = new GameObject[maxCannonBalls];
            for (int i = 0; i < maxCannonBalls; i++)
            {
                cannonBalls[i] = new GameObject(Content.Load<Texture2D>("Sprites\\cannonball"));
            }
            enemies = new GameObject[maxEnemies];
            for (int i = 0; i < maxEnemies; i++)
            {
                enemies[i] = new GameObject(Content.Load<Texture2D>("Sprites\\enemy"));
            }
            font = Content.Load<SpriteFont>("Fonts\\GameFont");
            viewportRect = new Rectangle(0, 0, graphics.GraphicsDevice.Viewport.Width, 
                graphics.GraphicsDevice.Viewport.Height);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            GamePadState gamePadState = GamePad.GetState(PlayerIndex.One);
            cannon.rotation += gamePadState.ThumbSticks.Left.X * 0.1f;

#if !XBOX
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                cannon.rotation -= 0.1f;
            }
            if (keyboardState.IsKeyDown(Keys.Right))
            {
                cannon.rotation += 0.1f;
            }
#endif

            if (gamePadState.Buttons.A == ButtonState.Pressed && previousGamePadState.Buttons.A == ButtonState.Released)
            {
                FireCannonBall();
            }

            if (keyboardState.IsKeyDown(Keys.Space) && previousKeyboardState.IsKeyUp(Keys.Space))
            {
                FireCannonBall();
            }

            cannon.rotation = MathHelper.Clamp(cannon.rotation, -MathHelper.PiOver2, 0);

            UpdateCannonBalls();
            UpdateEnemies();

            base.Update(gameTime);

            previousGamePadState = gamePadState;

#if !XBOX
            previousKeyboardState = keyboardState;
#endif

        }

        public void FireCannonBall()
        {
            foreach (GameObject ball in cannonBalls)
            {
                if (!ball.alive)
                {
                    ball.alive = true;
                    ball.position = cannon.position - ball.center;
                    ball.velocity = new Vector2((float)Math.Cos(cannon.rotation), (float)Math.Sin(cannon.rotation)) * 8.0f;
                    return;
                }
            }
        }

        public void UpdateCannonBalls()
        {
            foreach (GameObject ball in cannonBalls)
            {
                if (ball.alive)
                {
                    ball.position += ball.velocity;
                    if (!viewportRect.Contains(new Point((int)ball.position.X, (int)ball.position.Y)))
                    {
                        ball.alive = false;
                        continue;
                    }
                    Rectangle cannonBallRect = new Rectangle(
                        (int)ball.position.X, 
                        (int)ball.position.Y, 
                        ball.sprite.Width, 
                        ball.sprite.Height);
                    foreach (GameObject enemy in enemies)
                    {
                        Rectangle enemyRect = new Rectangle(
                            (int)enemy.position.X,
                            (int)enemy.position.Y,
                            enemy.sprite.Width,
                            enemy.sprite.Height);
                        if (cannonBallRect.Intersects(enemyRect))
                        {
                            ball.alive = false;
                            enemy.alive = false;
                            score += 10;
                            smoke.AddParticles(enemy.position);
                            explosion.AddParticles(enemy.position);
                            tomer.AddParticles(enemy.position);
                            break;
                        }
                    }
                }
            }
        }

        public void UpdateEnemies()
        {
            foreach (GameObject enemy in enemies)
            {
                if (enemy.alive)
                {
                    enemy.position += enemy.velocity;
                    if (!viewportRect.Contains(new Point((int)enemy.position.X, (int)enemy.position.Y)))
                    {
                        enemy.alive = false;
                        score -= 5;
                    }
                }
                else
                {
                    enemy.alive = true;
                    enemy.position = new Vector2(viewportRect.Right,
                        MathHelper.Lerp(
                        (float)viewportRect.Height * minEnemyHeight,
                        (float)viewportRect.Height * maxEnemyHeight,
                        (float) random.NextDouble()));
                    enemy.velocity = new Vector2(MathHelper.Lerp(
                        -minEnemyVelocity,
                        -maxEnemyVelocity,
                        (float)random.NextDouble()), 0);
                }
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteBlendMode.AlphaBlend);
            spriteBatch.Draw(backgroundTexture, viewportRect, Color.White);
            spriteBatch.Draw(cannon.sprite, cannon.position, null, Color.White, cannon.rotation, cannon.center, 1.0f, SpriteEffects.None, 0);
            foreach (GameObject ball in cannonBalls)
            {
                if (ball.alive)
                {
                    spriteBatch.Draw(ball.sprite, ball.position, Color.White);
                }
            }
            foreach (GameObject enemy in enemies)
            {
                if (enemy.alive)
                {
                    spriteBatch.Draw(enemy.sprite, enemy.position, Color.White);
                }
            }
            spriteBatch.DrawString(font, "Score: " + score.ToString(),
                new Vector2(scoreDrawPoint.X * viewportRect.Width,
                scoreDrawPoint.Y * viewportRect.Height), new Color(64,224,228,130));
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
