using System;
using System.Collections.Generic;




public class Person
{
	// Static arrtibute actions will contain all available actions that every member of the base class 'Person' will be able to perform




	protected static Dictionary<string, float> actions = new Dictionary<string, float>()
	{

		{"take", 1.0f},
		{"want",1.0f},
		{"have", 1.0f},
		{"go", 1.0f},
		{"strole", 1.0f},
		{"work", 1.0f},
		{"eat", 1.0f},
		{"express", 1.0f},
		{"make", 1.0f},
		{"feel", 1.0f},
		{"fell", 1.0f},
		{"listen", 1.0f},
		{"hit", 1.0f},
		{"defend", 1.0f},
		{"yell", 1.0f},
		{"hurt", 1.0f}

	};


	static protected float totalHappieness;





	// Feilds

	protected float happieness;
	protected int amoutOfDirectFamily;
	protected Personality personality;
	


	
	public Person(float happieness, int amountOfDirectFamily, Personality personality,)
	{    	
			
		this.amoutOfDirectFamily = amountOfDirectFamily;

		this.happieness = happieness;

		this.personality = personality;


	
	
	}




}
