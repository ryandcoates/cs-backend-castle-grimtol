# cs-backend-castle-grimtol

## Overview

As our second project of the course, the student is now equipped with the knowledge of multiple layer applications and sound reasoning to apply to abstraction of our data. Having learned multiple ways to implement different layers and why they may choose one over the other, this project remains open to the student as to what he/she would like to implement, as well as how and why. With that in mind, here are the guiding principles and requirements or expectations that must be applied.

## Principal Idea

This application allows for the use of a Console Application, or a Web API for the Presentation layer. Regardless of which one you choose, this outside layer remains our entry point to interacting with this app. It also remains strictly our Presentation layer and only funcitonality necessary to the view of our application will exist here (No Data!). 

It will provide specific options to the user, apply their choice to the appropriate action, and then pass those directives on to the Data layer to apply our Business Logic. Knowing that, all of our Data manipulation and accessing of real data objects will occur within that Abstracted Data layer. Any information that needs returned, will be applied to Helper Objects to return instead of the real objects. The most important aspect is making sure to retain complete compliance of this pattern across all functionality to ensure the correct implementation of a Multiple Layer Application with a distinct Presentation Layer and an Abstracted Data Layer. 

The different layers should be created in such a way that we can apply the Dependency Inversion Principle to decouple our layers. In the image below, the Presentation Layer is going to define what abstractions are necessary for interaction with the Application Layer. The Application Layer defines abstractions it depends upon from the Business Layer, and so on down the chain. This can be applied to any number of Layers necessary for the Project you are building. 

More traditional applications have the high level modules depend upon the following lower level modules in a concrete crossover pattern that makes the decoupling any piece of the entire application difficult if not impossible. The Dependency Inversion is named as such because we are inverting the dependencies and making it a lot easier to swap any one module or Layer as desired. 

![](http://www.intertech.com/Blog/wp-content/uploads/2015/11/Dip-1.png)

Depending on how strictly this principle is followed each Layer may contain the abstractions for the next layer.

![](http://www.intertech.com/Blog/wp-content/uploads/2015/11/Dip-2.png)

In this image, the Presentation Layer contains its own logic, as well as the abstractions for the Application Layer. These would be the abstracted classes and interfaces that the Application Layer would depend upon. That Lower level module dependency from the Higher level module. Keep this in mind as you develop this Project. Though we may not have the four layers from this example, we still want to apply this principle to the layers we do have.

## Game Layout

The user will be able to set up a new game(create a game object) that is stored in our Data. The application will allow access to a game state, which serves as a snapshot of the current game object, and whatever its values may be as they exist at the moment of the request. This should be a representation of the game, not the actual original game object, though it will need a way to reference that original game object. 

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
