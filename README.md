# cs-backend-castle-grimtol

## Overview

As our first project of the course, the student is now equipped with the knowledge of multiple layer applications and sound reasoning to apply to the abstraction of data. Having begun to learn the benefits of implementing multiple layers, this project remains open to the student as to what he/she would like to implement, as well as how and why. With that in mind, here are the guiding principles and requirements or expectations that must be applied.

## Principal Idea

This application allows for the use of a Console Application for the Presentation layer. This outside layer remains our entry point to interacting with this app. It also remains strictly our Presentation layer and only functionality necessary to the view of our application will exist here (No Data!). This means the Class Library(Business Layer) should only expose a StartGame method and ProcessCommand method. 

The user can make choices and then pass those directives on to the Data layer to apply our Business Logic. Knowing that, all of our Data manipulation and accessing of real data objects will occur within that Abstracted Business layer. Any information that needs returned, will be sent back to the presentation layer, and the presentation layer will be responsible for handling and displaying correctly. 

The most important aspect is making sure to retain complete compliance of this pattern across all functionality to ensure the correct implementation of a Multiple Layer Application with a distinct Presentation Layer and an Abstracted Business Layer. It is important to keep these decoupled so different Presentation layers or Business Layers could easily be swapped out without refactoring.

## Game Layout

The user will be able to set up a new game(create a game object) that is stored in our Business Layer. The application will not directly allow access to a game state. The class library contains the game state which serves as a snapshot of the current game object, and whatever its values may be as they exist at the moment of the request. This should be able to send back a string to display the results from the command.

The user will be able to select an action to take. This will cause the Presentation Layer to handle this input, correctly identify the chosen action, and pass this to our Data Layer, with a reference to the game. The Data Layer is going to accept this action, apply its functionality with the changes to our game Data, and then respond with the updated game state as a result of that action. Upon getting that game state back, our Presentation Layer is going to update the user with the new game state to allow them to see the result of the action they took.

### Actions

 - Move from room to room
 - Get a description of their current room(include items in the room)
 - Help - show a list of the commands and respective actions that will occur
 - Get an Item
 - Use an Item
 - Display Player Inventory(items)
 - Quit
 - Restart
 
 ### Command Examples
 
 - Go <Direction>
 - Look  
 - Help
 - Take <ItemName>  
 - Use <ItemName>
 - Inventory
 - Quit
 - Restart
  
  ## Requirements
  
You can get as creative as you would like with this, but it is always suggested that you complete a functional prototype first, and add flair and more fun upon completing the initial requirements. Your game has to have at least the following features:

 - 4 rooms
 - 1 Useable Item
 - 1 Item that can be picked up(can be the same item)
 - 1 room that changes based on that item(Maybe a key to unlock a door, get creative!)
 - When the player enters a room, the description should display for the user to see
 - Players can see their items in their inventory
 - Players can lose the game from some sort of decision or action
 - The game must have a reachable Win condition
 
 ## Visualization: 
 - `help` Provides the user a list of commands for your game
 - `look` Re-prints the room description
 - `inventory` prints a list of the items in the players inventory
 -  When the player enters a room they get the room description
  
### BONUS IDEAS - Some enhancing features
- Try changing the console color or adding some beeps for dramatic effect(if using the console)
- Clear the console when appropriate
- The user should know when its their turn try formatting the users input with something like this everytime its the users turn to type
  - What do you do: __________________ // <- Their Answer on the same line
- Add some riddles or puzzles for users to solve to get from room to room

### Finished?
When You are finished please submit the url for your github repo to the gradebook.
