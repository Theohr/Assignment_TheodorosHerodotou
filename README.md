# Snake 2D in Unity C#

  In order to complete the project i used the SOLID principles.
  
## SOLID

### Single Responsibility Principle
  A class should have one, and only one reason to change
  
### Open/Close Principle
  You should be able to extend a class's behavior, without modifying it
  
### Liskov Substitution Principle
  Derived classes must be substitutable for their base classes
  
### Interface Segregation Principle (ISP)
  Many client specific interfaces are better than one general purpose interface.
  
### Dependency Inversion Principle (DIP)
  Depend on abstractions, not on concretions.
  
## Game Implementation
  - 2 Scenes (Home, Game)
  - 7 Scripts (For the game to work)
  - Sprites (Fruit, Background, Snake as a square)
  - Prefabs (Snake's tale)
  
## Scripts

  ### EatPositionCharger.cs
    Generates the food in random positions in map.
  ### TailColisionDestroyer.cs
    Game ends when the snake hits its tail.
  ### SnakeKeyboardHandler.cs
    Snake movement on arrow keys.
  ### RecursivePositionRepeater.cs
    Gets snake's position on map.
  ### NavigateToGame.cs
    Start Game button in Home.
  ### EatTaleIncrementer.cs
    Everytime snake eats the apple its tail is incrementing.
  ### IncrementObjectMover.cs
    Snakes tail moving with the snake.

## Youtube Video Link
  https://youtu.be/KkSzbnxIMZs
