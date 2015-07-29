# FloodControl
Chapers 2 and 3 from "XNA 4.0 Game Development by Example" by Kurt Jaegers

This is a chapter introducing some basics about using sprites and images and creating a basic game.

Extra Objectives

-Add a "paused" game state that displays an indication that the game is paused and how to resume play. to prevent cheating, the game board should either not be visible or be obscured in some way while the game is paused.

-the Game Over screen is not very exciting. Createa  new bitmap image indicating the aftermath of the flooded facility and display that image instead of the simple game over text. You will need to load the image via the LoadContent() method and isplay it when appropriate.

-Create an additional "suffix" for pieces that are locked down and cannot be turned. You'll need to expand the Tile_sheet.png file by adding an additional fourth column and then copying the first two columsn to columns three and four. Draw bolts in the four corners of each of the twelve new piece images and modify the draw code to add an additional 40 pixels to the x value of the source Rectangle if the piece contains the locked suffix. Grant extra points for using locked pieces in a scoring chain.
