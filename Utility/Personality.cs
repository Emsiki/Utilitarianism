using System;
using System.Runtime.CompilerServices;

public class Personality
{
    // Statics

    public static int totalPrejudice;
    public static int totalAgreeableness;
    public static int totalConscientiousness;
    public static int totalNeuroticism;
    public static int totalIntroExtro;
    public static int totalHotHeadedness;

    public static int totalTempPrejudice;
    public static int totalTempAgreeableness;
    public static int totalTempConscientiousness;
    public static int totalTempNeuroticism;
    public static int totalTempIntroExtro;
    public static int totalTempHotHeadedness;      


    // Feilds
    public int prejudice;
    public int agreeableness;
    public int conscientiousness;
    // neuroticism will make it so the person struggles to regain happiness at a faster rate
    public int neuroticism;
    // a positive intext value means they are more extroverted and a negitive more introverted
    public int introExtro;
    public int hotHeadedness;



    // The randomness feild will aid in the making of a totally random personality, assigning different values for each of the regular feilds (Non-temp)
    public int variance;


    //Temp
    // all of the temp feilds will start at 0, and they will go up depending on the persons actions and how other people interact with them
    // the temp feilds will slowly turn into 
    public int tempPrejudice;
    public int tempAgreeableness;
    public int tempConscientiousness;
    public int tempNeuroticism;
    public int tempIntroExtro;
    public int tempHotHeadedness;


    public Personality()
    {

        variance = Person.rnm.Next(1, 11);
        prejudice = Person.rnm.Next(-10, 11) * variance;
        agreeableness = Person.rnm.Next(-10, 11) * variance;
        conscientiousness = Person.rnm.Next(-10, 11) * variance;
        neuroticism = Person.rnm.Next(-10, 11) * variance;
        introExtro = Person.rnm.Next(-10, 11) * variance;
        hotHeadedness = Person.rnm.Next(-10, 11) * variance;


        totalPrejudice += prejudice;
        totalAgreeableness += agreeableness;
        totalConscientiousness += conscientiousness;
        totalNeuroticism += neuroticism;
        totalIntroExtro += introExtro;
        totalHotHeadedness += hotHeadedness;


    }

    // Constructor to make a Personality custom instead of randomly
    public Personality(int prejudice, int agreeableness, int conscientiousness, int neuroticism, int introExtro, int hotHeadedness)
    {


        this.prejudice = prejudice;
        this.agreeableness = agreeableness;
        this.conscientiousness = conscientiousness;
        this.neuroticism = neuroticism;
        this.introExtro = introExtro;
        this.hotHeadedness = hotHeadedness;


        totalPrejudice += this.prejudice;
        totalAgreeableness += this.agreeableness;
        totalConscientiousness += this.conscientiousness;
        totalNeuroticism += this.neuroticism;
        totalIntroExtro += this.introExtro;
        totalHotHeadedness += this.hotHeadedness;


    }   
   


   



}
