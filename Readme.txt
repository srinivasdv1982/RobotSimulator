

How to Run the RobotSimulator?
Place the file in Commands.txt file in C:\Commands.txt or pass the file path in arguments.

Test Cases :
-----------------------------------------------
Test Case 1 : 
-----------------------------------------------
Input : 
	PLACE 0,0,NORTH
	MOVE
	MOVE
	LEFT
	REPORT
	MOVE
	MOVE
	LEFT
	REPORT

Output :
	0,2,WEST
	0,2,SOUTH

-----------------------------------------------
Test Case 2 : 
-----------------------------------------------
Input : 
	PLACE 0,0,NORTH
	LEFT
	LEFT
	REPORT
Output :
	0,0,SOUTH
-----------------------------------------------
Test Case 3 : 
-----------------------------------------------
Input : 
	PLACE 0,0,NORTH
	MOVE
	MOVE
	LEFT
	REPORT
Output :
	0,2,WEST

