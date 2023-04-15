using System;

// The world class will be a singleton that will make a world where events can take place, the world class will handel all of the interactions between people
// and will have the ability to produce random chance events


// The biggest question right now is how am I going to handel and force interactions between players?


// 1. I could use this world class to make a world and only people who are in the same area of the 2D array can interact with eachother, this will hopefully also
// give me a way to show what is happening through a UI, maybe even use windows forms ;)




public class World
{


	int startingPopulation;


	public World(int startingPopulation)
	{
		this.startingPopulation = startingPopulation;	
	
	}


	public void chanceEvent()
	{
		 
	}

	public void drawWorld()
	{

	}

	



}
