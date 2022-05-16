# Project 6 - Quest System
CS 596 

Project 6, Questing Systems,  100 pts

 

For the Sixth individual project you will be making a quest system.  

For this assignment name the project as follows: CS_596_S22_LASTNAME_FIRSTNAME_Proj_06.

Here are a list of requirements for the project:

The Quest System (QS) should be Object (OOP) based.
The QS shall implement a quest list of multiple quests with a maximum of 10 sub quests. This can be done as a list of lists . 
There shall be 3 types of quests for Undergraduate students and 6 types for Graduate students. The quest types are as follows:
Kill - Probably the most basic quest type, the task is to kill something in the game, for example; kill 10 goblins.
Gather - Again very simple, the task is to gather x things in the game world, collecting berries or the like.
Escort - The player must escort or follow a person or object from point A to B while keeping it safe.
Deliver - The player is the delivery boy, they must deliver an item to a person or point.
Defend - The player has to defend a location from oncoming enemies, often for a set number of waves or time.
Profit - The player must have a certain amount of resources to complete the quest, contrary to gather quests these resources are resources the player would otherwise be able to use himself.
Activate - The player's task is to activate / interact with one or more objects in the game world or talk to a number of NPC’s. In some cases, this must be done in a certain order for a puzzle effect.
Search - Search an area, discover an area creature of the game world. This is useful for introducing areas of the map to the player and giving them a sense of accomplishment right of the bat, showing them a new quest hub or the like.
The QS shall have clear start and completion criteria and implement the following quest states:
Pending  -  the quest did not met the unlocking requirement yet.
Unlocked — the unlocking requirements are met, but it is not in progress yet, there may be a prior uncompleted quest before this one
In progress  -  the quest was started / unlocked and shown to the player. The player must intentionally start
Completed  - quest  was in progress and player did everything necessary to complete it. Now it is time to collect the reward. If there is no reward the task might directly switch to the done state. 
Done —quest was completed and user collected the reward
Canceled — this state is important if you want a quest to disappear. It’s particularly useful, if you introduce a new quests which player, who advanced beyond a certain threshold, shall not see
You shall create a scene with an empty game object in it that has your questController.CS script in it. 
In your questController.CS in the awake function you should initialize the QS with at least 3 quests.
The QS scene shall have a button that prints all the information about the current state of the quest systems to the console (minimum) or ideally to an in-scene text box. For instance your QS would produce the following output when queried : 
There are a total of 20 quests in the system. 
Quest #1 is named “MYAwesomeQUEST” and it is in the state of In Progress. 
Q#1 contains 3 sub quests. 
Q#1.SubQuest #1 is named “Gather Berries” is of type Gather and it is in the state of COMPLETED.
Q#1.SubQuest #2  is named “Search for Field Mice” is of type Search and it is in the state of InProgress
Q#1.SubQuest #3  is named “Bop them on the Head”  is of type Kill and it is in the state of InPr
Quest #2 is named “Song of the Field Mice” and it is in the state of In Progress.
Q#2 contains 2 sub quests. 
Q#2.SubQuest #1 is named “Hansel and Gretel ” is of type Escort and it is in the state of COMPLETED.
Q#21.SubQuest #2  is named “Find the old Lady in the Ginger Bread House” is of type Profit and it is in the state of InProgress
 

….
Q#N contains Xsub quests…






Extra credit:

Both Undergraduate and Graduate students will earn 2 extra points for quest types up to max of 8 . 




Due date:April 23, 2022 at 23:55 (. Turn in your project via rijeka.sdsu.edu version control server.. 

 

Due date:April 23, 2022 at 23:55. Turn in your project via rijeka.sdsu.edu version control server. 


