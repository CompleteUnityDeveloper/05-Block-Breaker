# Complete Unity Developer 2D - Block Breaker

This is the [Complete Unity Developer](http://gdev.tv/cudgithub) - one of the most successful e-learning courses on the internet! Completely re-worked from scratch with brand-new projects and our latest teaching techniques. You will benefit from the fact we have already taught nearly half a million students game development, many shipping commercial games as a result.

You're welcome to download, fork or do whatever else legal with all the files! The real value is in our huge, high-quality online tutorials that accompany this repo. You can check out the course here: [Complete Unity Developer](http://gdev.tv/cudgithub)

## In This Section
In this section we use Unity's physics engine to create a wall-breaking game. (Ref: BR_CUD)

## How To Build / Compile

## Lecture List
Here are the lectures of the course for this section. 


### 1 Welcome To Block Breaker ###

**In this video (objectives)…**

1. Overview of this section.
2. Focus on Unity's physics engine and collisions.
3. Lots of creative opportunity to make your own levels, background, blocks, rules, tuning and so on.

**After watching (learning outcomes)…**
Ready and raring to start this section.


### 2 Block Breaker Game Design ###

**In this video (objectives)…**

1. Fundamental aspects of our design.
2. Ideas for your game.
3. Challenge for your game theme, background image and name.

**After watching (learning outcomes)…**
Clear on the game design we will use for Block Breaker.


### 3 Export & Import Package ###

**In this video (objectives)…**

1. Export scenes and SceneLoader.cs from previous project.
2. Import package into our new project.
3. Set up build settings, change aspect ratio, update text.

**After watching (learning outcomes)…**
Export scenes and logic from one project and import as a package into another.


### 4 World Units & Play Space ###

**In this video (objectives)…**

1. Discuss what Unity World Units are.
2. Set up our camera size.
3. Import and set up background image, paddle, ball and block.

**After watching (learning outcomes)…**
Understand world units and set up play space.


### 5 Rigidbody & Colliders ###

**In this video (objectives)…**

1. Add a Rigidbody2D to the ball so that it has gravity influencing it.
2. Add colliders to ball and block so that they collider.

**After watching (learning outcomes)…**
Able to add the core physics components to 2D objects.


### 6 Add Unity Physics Material ###

**In this video (objectives)…**

1. Add Polygon Collider 2D to our paddle.
2. Add Physics Material 2D to our ball.
3. Bounce!

**After watching (learning outcomes)…**
Make a game object bounce off another game object.


### 7 Colliders, Collision & Triggers ###

**In this video (objectives)…**

1. Stop our ball rotating by freezing Z axis rotation on our Rigidbody.
2. Create a lose collider.
3. Discuss difference between trigger and collider and examine the event matrix for collision events.
5. Load Game Over screen when ball passes through lose collider.

**After watching (learning outcomes)…**
Make the game load a new scene when an object passes through a trigger volume.


### 8 Move Object With Mouse ###

**In this video (objectives)…**

1. Find the position of the mouse on the screen.
2. Convert the mouse position into a relative proportion of our screen represented as game units.
3. Link movement of our mouse to movement of our paddle.

**After watching (learning outcomes)…**
Move a game object so that it matches the position of the player's mouse.


### 9 Limit With Mathf.Clamp() ###

**In this video (objectives)…**

1. Figure out the range we want to allow the paddle to move on x axis.
2. use Mathf.Clamp() to limit the paddle's movement.

**After watching (learning outcomes)…**
Use Mathf.Clamp() to limit the movement of a game object.


### 10 Distance As A Vector2 ###

**In this video (objectives)…**

1. Understand how to calculate the distance from ball to paddle.
2. Update location of the ball to match the location of the paddle plus our offset.

**After watching (learning outcomes)…**
Stick the ball to the paddle.


### 11 Launch The Ball ###

**In this video (objectives)…**

1. Create a method to give the ball an upwards velocity.
2. Create a bool which allows us to determine if the game has started yet and therefore stop locking the ball to the paddle.

**After watching (learning outcomes)…**
Launch the ball with upward velocity from the paddle.


### 12 Block Breaker Instructor Hangout #1 ###

**In this video (objectives)…**

1. Ben and Rick discuss the use of public variables versus [SerializeField].

**After watching (learning outcomes)…**
Understand why we avoid using public variables in our classes.


### 13 Play Space & Gravity ###

**In this video (objectives)…**

1. Add walls for our ball to bounce off.
2. Alter the gravity so that the ball doesn't slow down due to gravity.

**After watching (learning outcomes)…**
Set up our play space and change our gravity.


### 14 Destroy GameObject ###

**In this video (objectives)…**

1. Add Block.cs script to our block.
2. Use the Destroy() method to destroy the block once its hit.
3. Discuss the option to set arguments for the method.

**After watching (learning outcomes)…**
Destroy our block when the ball hits it.


### 15 Using Prefabs In Unity ###

**In this video (objectives)…**

1. Create our first prefab.
2. Experiment with how prefabs work.
3. Set our snap settings.
4. Build a level.

**After watching (learning outcomes)…**
Use prefabs and build a level out of prefabbed blocks.


### 16 Make A Second Level ###

**In this video (objectives)…**

1. Prefab all of the game objects that are required for our game levels.
2. Create Level 2 using our prefabbed objects.

**After watching (learning outcomes)…**
Create a second level using prefabbed assets.


### 17 Fraction Too Much Friction ###

**In this video (objectives)…**

1. Identify the issue - the ball slows down after hitting the side of the paddle.
2. Alter the physics material friction value to remove all friction on the ball.

**After watching (learning outcomes)…**
Stop the ball slowing down when it collides with the paddle.


### 18 GetComponent To Play Audio ###

**In this video (objectives)…**

1. Understand Audio Listener, Audio Source and Audio Clip.
2. Use GetComponent to access the Audio Source and play our clip.
3. Ensure that the sound does not start until the ball is launched.

**After watching (learning outcomes)…**
Trigger sound effect each time the ball collides with something.


### 19 Play Random Sound From Array ###

**In this video (objectives)…**

1. Use PlayOneShot instead of Play.
2. Create an array and then use that array to randomly select one of many audio clips.
3. Cache our component reference.

**After watching (learning outcomes)…**
Randomly play one of many sound effects when an event takes place.


### 20 PlayClipAtPoint() ###

**In this video (objectives)…**

1. Examine our problem with destroying our GameObject and therefore destroying the ability to play our destroyed SFX.
2. Use PlayClipAtPoint() to solve the issue of our AudioSource being destroyed.

**After watching (learning outcomes)…**
Play sounds from objects which are being destroyed.


### 21 Count Breakable Blocks ###

**In this video (objectives)…**

1. Map out our workflow for determining how many blocks are in a scene so that we can know when we reach zero.
2. Create level GameObject and script.
3. Increment our number of blocks for each block in our scene.
4. Introduction to FindObjectOfType.

**After watching (learning outcomes)…**
Tally up the total number of blocks in our scene.


### 22 Win The Level & Load ###

**In this video (objectives)…**

1. Create a public method for decreasing total number of blocks when a block is destroyed.
2. Use FindObjectOfType to access our level loading methods.

**After watching (learning outcomes)…**
Load the next level when all blocks in a level have been destroyed.


### 23 Using Time.timeScale ###

**In this video (objectives)…**

1. Use [Range] to create a constrained slider in our inspector.
2. Add Time.timeScale to adjust the speed of our entire game instead of needing to play around with gravity and velocity.
3. Hunt down an error by updating our other level with our prefabs.

**After watching (learning outcomes)…**
Able to change the speed of our game using Time.timeScale.


### 24 Add Player Score ###

**In this video (objectives)…**

1. Create currentScore and pointsPerBlockDestroyed variables.
2. Create a public method that adds to our score when called.
3. Call the method which increases our score when a block is destroyed.

**After watching (learning outcomes)…**
Able to increase the player's score when a block is destroyed.


### 25 Display Player Score ###

**In this video (objectives)…**

1. Create TextMeshPro text, import font, tweak till we're happy.
2. Use ToString() to update our text field with our current score.

**After watching (learning outcomes)…**
Able to display and update the player's score in the UI.


### 26 Implement Singleton Pattern ###

**In this video (objectives)…**

1. Introduce the Singleton Pattern.
2. Use DontDestroyOnLoad().
3. Examine the Unity script execution order to see that we can use Awake() for our singleton.

**After watching (learning outcomes)…**
Able to implement a Singleton Pattern to ensure that our score persists across level load.


### 27 Reset Game Session ###

**In this video (objectives)…**

1. Reinforce the public method paradigm we've been using.
2. Fix the issue with our score persisting from game session to game session.
3. How to rename a class.

**After watching (learning outcomes)…**
How to elegantly reset our game session so that our score resets.


### 28 Instantiate GameObject ###

**In this video (objectives)…**

1. Review how Instantiate() works, discussing method overloads and signatures.
2. Create code for instantiating a particle effect when we destroy a block.

**After watching (learning outcomes)…**
Able to instantiate a GameObject through our code.


### 29 Using Tags In Unity ###

**In this video (objectives)…**

1. Getting schwifty with tags - understanding the what and why of using them.
2. Creating an unbreakable block type which... doesn't... break!

**After watching (learning outcomes)…**
Able to use tags to create an unbreakable block type.


### 30 Block Damage Levels ###

**In this video (objectives)…**

1. Create 2 variables we can compare - maxHits and timesHit.
2. Implement a conditional statement to destroy block if maxHits is more than timesHit.

**After watching (learning outcomes)…**
Create a simple system of multiple damage levels for our blocks.


### 31 Damage Affordance ###

**In this video (objectives)…**

1. Create an array to hold our damage sprites.
2. Change our sprite renderer depending upon how many hits a block has taken.

**After watching (learning outcomes)…**
Change the sprite displayed for a block based upon how many hits it has taken.