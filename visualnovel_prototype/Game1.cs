using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace visualnovel_prototype
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {

        //variables
        int countDown = 0;
        int whichchar = 0;
        Texture2D dialog;
        Vector2 position = new Vector2(0,0);
        Vector2 text = new Vector2(30, 750);

        SpriteFont font;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        string textString = "";
        string textReal = "hello this is just a test to see if the text will slowly draw out on the screen";
        string text = "ser om det sparar i github";

        public Game1()
        {
               
            graphics = new GraphicsDeviceManager(this);
            //set window size

            graphics.PreferredBackBufferHeight = 980;
            graphics.PreferredBackBufferWidth = 1240;
            Content.RootDirectory = "Content";
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
            dialog = Content.Load<Texture2D>("dialogB");
            font = Content.Load<SpriteFont>("text");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
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
            countDown++;
            while(countDown >= 3)
            {
                if (whichchar != textReal.Length)
                {
                    textString += textReal[whichchar];
               
                    whichchar++;
                }
                countDown = 0;

            }
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();

            spriteBatch.Draw(dialog, position, Color.White);
            spriteBatch.DrawString(font, textString, text, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
