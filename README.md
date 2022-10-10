# 385hero


self-assessment

World Camera Setting
Height of 100 (total world height is 200)
Hero
Size: 5x5
Control model: Key-M toggles between mouse or keyboard control
Mouse control: Hero’s position follow that of the mouse at all time. This is the default control (easy for me to test)
Keyboard control: Up/Down (WS) keys gradually increases/decreases the Hero’s speed moving towards its Transform.up direction.
Initial speed: 20 units/second
Left/Right (AD) keys: turn the hero towards left/right at a rate of 45-degrees per second.
Space-bar: spawns an egg-projectile (refer to next section) at a rate of one egg every 0.2 seconds
Spawned Egg
Size: 1x1
Aligned with the Transform.up direction of the hero at the spawn time
Spawned eggs travers towards its Transform.up direction at a speed of 40 unit/sec

Enemy and Spawning
Each enemy size is 5x5
There are always 10 enemies in the world
Enemies are within 90% of the world boundaries
