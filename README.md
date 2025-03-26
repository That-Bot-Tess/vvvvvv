# VVVVVV Godot Sandbox

A recreation of the 2010 puzzle platformer by Terry Cavanagh, VVVVVV! 
Retro-styled and designed around the ability to flip gravity instead of jumping.

Goal: Create all the game's signature objects.

# Directories

- `assets` - Contains all code and visual assets for the project.
- `scenes` - Contains the main scene as well as all the objects.

# Objects
- **spikes**: Stationary hazards that cause the player to die and respawn from the initial spawn point or their last passed checkpoint upon contact.
- **gravity lines**: Flip the player upon contact.
- **enemies**: Moving hazards with variable size. Kill the player upon contact.
- **warping rooms**: Cause the player to seamlessly appear on the opposite extreme of the room instead of traveling to a new room.
- **moving platforms**: Platforms that travel within a specified range, flipping direction when reaching their extreme.
- **disappearing platforms**: Platforms that disappear shortly upon contact.
- **conveyor belts**: Platforms that move the player automatically and impact their movement speed, whether to the lefft or right.
- **terminals**: Interact with these to start a dialogue.
- **warp tokens**: Teleport a player to a specified position.

# Progress
- **spikes**: Done!
- **gravity lines**: Done!
- **enemies**: Done!
- **warping rooms**: Functionality complete for vertical extremes. Room background still required.
- **moving platforms**: Work, but are moved by the player, which should not occur.
- **disappearing platforms**: Not yet implemented.
- **conveyor belts**: Attempted, but failed. Might return to last.
- **terminals**: Not yet implemented.
- **warp tokens**: Not yet implemented.
