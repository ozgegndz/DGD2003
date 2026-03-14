Game Design Document
Freshman First Day
1. Game Overview
Game Title: Freshman First Day
Genre: 3D Exploration / Puzzle
Platform: PC (Unity)
Game Engine: Unity
Game Summary:
Freshman First Day is a 3D exploration puzzle game that takes place inside a school environment.
The player takes the role of a new student attending their first orientation day. In order to receive
their official student ID card, the player must complete a sequence of orientation tasks given by
various characters inside the school.
The player explores corridors, interacts with NPCs, and follows clues that lead to different locations
such as the library, cafeteria, and administration office. Each completed task brings the player
closer to receiving their student ID.
The game focuses on exploration, interaction, and puzzle-like progression through a chain of
orientation objectives.

3. Game Concept
The game simulates the experience of a new student navigating an unfamiliar school environment.
Instead of directly receiving a student ID, the player must first prove that they understand the layout
of the school by completing several orientation steps.
NPC characters guide the player by providing hints and directions. Each step unlocks the next
objective, creating a progression system that encourages exploration and interaction.
The final reward for completing the orientation process is obtaining the student ID card.
4. Gameplay
The player navigates the school environment using basic movement controls and interacts with
NPC characters to receive information and instructions.
The game progression is based on completing a series of orientation tasks. Each task requires the
player to find a specific location or character inside the school.
Core Gameplay Loop:
Explore the school ® Talk to NPC characters ® Receive a clue or objective ® Find a location or
item ® Complete the task ® Unlock the next objective.
This loop continues until the player finishes all orientation steps and receives the student ID.
5. Orientation Progression (Quest System)
The game contains a structured sequence of ten steps that simulate an orientation process.
1. School Entrance – The player meets an NPC who explains that orientation tasks must be
completed before receiving a student ID.
2. Orientation Guide – The player is directed to find the orientation guide.
3. Blue-Haired Student – The guide suggests speaking with a blue-haired student who knows the
layout of the school.
4. Library Discovery – The blue-haired student reveals the location of the library.
5. Cafeteria Location – Inside the library, an NPC tells the player to locate the cafeteria.
6. Computer Lab Discovery – The cafeteria NPC directs the player to the computer lab.
7. Administration Office – The player is informed that student IDs are issued at the administration
office.
8. Registration Form – The administration office requires a registration form located in a classroom.
9. Form Submission – The player returns the registration form to the administration office.
10. Student ID Received – The administration staff gives the player their official student ID.

5. Environment Design
The game environment consists of a school building designed using Unity ProBuilder.
Main areas include:
Entrance Hall, Corridors, Library, Cafeteria, Computer Lab, Classroom, Administration Office.
The building layout encourages exploration while remaining simple enough for players to navigate.
  
7.  Characters
NPC characters guide the player through the orientation process.

9. User Interface
The game includes a simple objective system displayed on the screen.
Example objectives:
Find the Blue-Haired Student
Go to the Library
Find the Cafeteria
Return to the Administration Office
UI messages also appear when the player obtains important items or completes tasks.

10. Technical Implementation
The project will be developed using the Unity game engine.
Main technical systems include:
NPC Dialogue System
Quest / Objective System
Item Collection System (Registration Form)
Door or area triggers
Character movement controller
The game environment will be created using ProBuilder tools, and NPC interactions will be
implemented using simple C# scripts.
Character Roles
Character Role
Entrance Student Introduces orientation
Orientation Guide Gives initial instructions
Blue-Haired Student Provides the library location
Library NPC Gives the cafeteria task
Cafeteria NPC Gives computer lab clue
Administration Staff Provides the student ID
