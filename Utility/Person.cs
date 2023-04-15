using System;

public class Person
{

	static public Random rnm = new Random();


	enum actionType
	{
		// Yeaaaa these are the 7 deadly sins and the 7 virtues, it was just easier this way because they did a good job encapsulating what I wanted
        LUST,
		GLUTTONY,
		GREED,
		SLOTH,
		WRATH,
		ENVY,
		PRIDE,
		CHASTITY,
		TEMPRANCE,
		CHARITY,
		DILIGENCE,
		PATIENCE,
		KINDNESS,
		HUMILITY,
		NONE

    }



	// Statics

	
	
	// Static arrtibute actions will contain all available actions that every member of the base class 'Person' will be able to perform
	public static Dictionary<string, List<object>> actions = new Dictionary<string, List<object>>()
	{
		// This Dict has an action as a string, and its associated effect and area of effect (The actionType type)
		{"take", new List<object> {3, actionType.GREED} },
		{"want",new List<object> {1, actionType.GREED } },
		{"have", new List<object> { 0, actionType.NONE} },
		{"go", new List<object> { 0, actionType.NONE} },
		{"strole",new List<object> { 0,actionType.NONE } },
		{"work", new List<object> { 3, actionType.DILIGENCE} },
		{"eat", new List<object> { 0, actionType.NONE} },
		{"express", new List<object> { 0, actionType.NONE } },
		{"make", new List<object> { 3, actionType.DILIGENCE} },
		{"feel", new List<object> { 0, actionType.NONE} },
		{"fell", new List<object> { 0, actionType.NONE} },
		{"listen", new List<object> { 2, actionType.HUMILITY} },
		{"hit", new List<object> { 5, actionType.WRATH} },
		{"defend", new List<object> { 5, actionType.KINDNESS } },
		{"yell", new List<object> { 3, actionType.WRATH} },
		{"hurt", new List<object> { 6, actionType.WRATH} }

	};


	static public float totalHappieness;



	// Feilds

	public int happieness;
	public int amountOfDirectFamily;
	public Personality personality;
	public string race;
	

	
	public Person()
	{
		string[] raceArray = new string[] { "White", "Black", "Hispanic", "Asian", "Pacific Islander", "Indigeonous", "MultiRacial" };


		race = raceArray[rnm.Next(0,8)];

		happieness = rnm.Next(0, 101);
			
		amountOfDirectFamily = rnm.Next(0, 1001);

		if (amountOfDirectFamily < 50)
		{
			amountOfDirectFamily = rnm.Next(0, 3);
		}
		else if (amountOfDirectFamily < 400)
		{
            amountOfDirectFamily = rnm.Next(3, 5);

        }
		else if (amountOfDirectFamily < 700)
		{
            amountOfDirectFamily = rnm.Next(5, 8);
        }
		else if (amountOfDirectFamily < 950)
		{
            amountOfDirectFamily = rnm.Next(8, 10);
        }
		else
		{
            amountOfDirectFamily = rnm.Next(10, 13);
        }
        //Tracking the total happieness of the class
        totalHappieness += happieness;


		personality = new Personality();

	
	}

	public void preformAction()
	{
		





	}



}
