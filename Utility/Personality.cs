using System;
using System.Runtime.CompilerServices;

public class Personality
{
    // Statics



    

    


    // Feilds
    int prejudice;
    int agreeableness;
    int conscientiousness;
    // neuroticism will make it so the person struggles to regain happiness at a faster rate
    int neuroticism;
    // a positive intext value means they are more extroverted and a negitive more introverted
    int introExtro;
    int hotHeadedness;



    // The randomness feild will aid in the making of a totally random personality, assigning different values for each of the regular feilds (Non-temp)
    int randomness;



    //Temp
    // all of the temp feilds will start at 0, and they will go up depending on the persons actions and how other people interact with them
    // the temp feilds will slowly turn into 
    int TempPrejudice = 0;
    int TempAgreeableness = 0;
    int TempConscientiousness = 0;
    int TempNeuroticism = 0;
    int TempIntroExtro = 0;
    int TempHotHeadedness = 0;



    public Personality(int randomness)
	{
        this.randomness = randomness;
                 
        
        


    }


   



}
