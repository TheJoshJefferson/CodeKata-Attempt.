Note: There is an error in this code. I had difficulty finding a C#/.Net equivalent to the java function hasNext().
I wanted it to scan the first word of each string and do one of two functions correlating with each. I couldn't,
but I went ahead and put what each correlating function would have done.



I'll take this time to run you through my thought process behind this exercise:
- In visual studio i selected a console app so that I would have access to console commands.
- From there I declared the few variables I know I would need 
	Command (driver or trip)
        Name
        StartTimme
        EndTime
        Miles
- I decided to impliment a try/catch. So that the program can scan for the input file. If detected I had it write the contents to the console only for confirmation.
- The catch throws out an error message should the file be missing/not existant

Here is what the code should do in theory:

-Read the first bit of each string which is the command
-Seperate functions based on command.
-For Driver command just Collect the Name
-For Trip collect the name, Start time, end time, and Miles traveled. 
- then DateTime.Parse both start and end times and subtract start from end.Store as a new variable TotalTime


My home version of visual studio didn't have report wizard or a report option available but I'll tell you how i would do it
-Set up 3 data tables (Name, Miles, MPH) have the name correspond with the name collected. Miles collected from report. and MPH i'd use Miles/totaltime
-I'd have that set up in a SQL similar data table. Use an Inner Join for similar names
-And finally set up a condition that excludes MPH<5 && MPH>100

