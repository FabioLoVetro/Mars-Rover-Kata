### Mars-Rover-Kata
Mars Rover kata is a program to move rovers around the surface of Mars!
The surface of Mars is represented by a Plateau.
Rovers navigate the Plateau so they can use their special cameras and robot arms to collect samples back to Planet Earth
Representation of a Rover’s Position on the Plateau
A Rover’s position is represented by x and y co-ordinates and the letters N, S, W, E to represent North, South, West, East (the four cardinal compass points) respectively.

##Example
0 0 N
This means the Rover is at the bottom-left corner facing in the North direction.

##Instructing a Rover to Move Around the Plateau
To move a Rover around the Plateau, a string of letters (instruction) is sent to a Rover.
Here are the letters and their resultant action:

##Instruction
[RoverName Command LetterAction]

The first part of the instruction is the name of the rover to move.
The second part of the instruction is the command to apply.
The third part of the instruction is the object/tool/LetterAction

##Command
Move: move rover around the plateau.
PickUp: allows rovers to pick up tools or objects.
DropOff: allows rovers to drop off tools or objects

##Letter Action
L Spins the Rover 90 degrees Left without moving from the current coordinate point/

R Spins the Rover 90 degrees Right without moving from the current coordinate point/

M Moves the Rover forward by one grid point, maintaining the same heading (i.e. from where the Rover is facing (its orientation)).

**N.B. Assume that the square directly North from (x, y) is (x, y+1).

##Special instruction "end"
if typed, "end" allows the program stop.

##Inputs into the Program

#First Line of Input to the Program
The first line inputted into the program represents the upper-right coordinates of the Plateau.
10 10
This Plateau has maximum (x, y) co-ordinates of (10, 10).
**N.B. Assume that the lower-left coordinates is (0, 0).

Subsequent Lines of Input into the Program - Input to Rovers
This represents the instructions to move the rovers.
Each rover receives one line of input.

#Input to a Rover
The Rover’s position is represented by two integers representing the X and Y coordinates and a letter representing where the Rover is facing (its orientation).
Each rover starts from position [0,0] origin.
R01 Move LMRMMLM

input to a Rover:
A string of letters representing the instructions to move the Rover around the Plateau.

#Movement Rules
Rovers move sequentially, this means that the first Rover needs to finish moving first before the next one can move.

#Output
For each Rover, the output represents its final position (final coordinates and where it is facing), a list of tools and objects that the rover have collected.
A list of tools and objects on the plateau and their position.

#Example Test Case
Type the size of the Plateau [Example 10 10]

**10 10

Welcome on Mars

Have a look at the situation

Rover:[Name:R01, Max Weight:10 Tool:[Name:RobotArm, Weight:2]  Object:[Name:Quarzo, Weight:5] ], Position:[Coordinates:[0,0], Orientation:[N]]
Rover:[Name:R02, Max Weight:8 Tool:[Name:Camera, Weight:1]  Object:[Name:GreenRock, Weight:2] ], Position:[Coordinates:[0,0], Orientation:[E]]

Plateau:


Type an instruction:
**R01 Move MMRM

Rover:[Name:R01, Max Weight:10 Tool:[Name:RobotArm, Weight:2]  Object:[Name:Quarzo, Weight:5] ], Position:[Coordinates:[1,2], Orientation:[E]]
Rover:[Name:R02, Max Weight:8 Tool:[Name:Camera, Weight:1]  Object:[Name:GreenRock, Weight:2] ], Position:[Coordinates:[0,0], Orientation:[E]]

Plateau:


Type an instruction:
**R01 DropOff RobotArm

Rover:[Name:R01, Max Weight:10  Object:[Name:Quarzo, Weight:5] ], Position:[Coordinates:[1,2], Orientation:[E]]
Rover:[Name:R02, Max Weight:8 Tool:[Name:Camera, Weight:1]  Object:[Name:GreenRock, Weight:2] ], Position:[Coordinates:[0,0], Orientation:[E]]

Plateau:
Tool:[Name:RobotArm, Weight:2], Coordinates:[1,2]


Type an instruction:
**R02 Move MLMM

Rover:[Name:R01, Max Weight:10  Object:[Name:Quarzo, Weight:5] ], Position:[Coordinates:[1,2], Orientation:[E]]
Rover:[Name:R02, Max Weight:8 Tool:[Name:Camera, Weight:1]  Object:[Name:GreenRock, Weight:2] ], Position:[Coordinates:[1,2], Orientation:[N]]

Plateau:
Tool:[Name:RobotArm, Weight:2], Coordinates:[1,2]


Type an instruction:
**R02 PickUp RobotArm

Rover:[Name:R01, Max Weight:10  Object:[Name:Quarzo, Weight:5] ], Position:[Coordinates:[1,2], Orientation:[E]]
Rover:[Name:R02, Max Weight:8 Tool:[Name:Camera, Weight:1] Tool:[Name:RobotArm, Weight:2]  Object:[Name:GreenRock, Weight:2] ], Position:[Coordinates:[1,2], Orientation:[N]]

Plateau:


Type an instruction:
**R02 DropOff GreenRock

Rover:[Name:R01, Max Weight:10  Object:[Name:Quarzo, Weight:5] ], Position:[Coordinates:[1,2], Orientation:[E]]
Rover:[Name:R02, Max Weight:8 Tool:[Name:Camera, Weight:1] Tool:[Name:RobotArm, Weight:2]  ], Position:[Coordinates:[1,2], Orientation:[N]]

Plateau:

Object:[Name:GreenRock, Weight:2], Coordinates:[1,2]