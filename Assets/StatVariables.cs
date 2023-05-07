using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatVariables : MonoBehaviour
{
    public SaveData currentData;
    //Player One Stats
    public static int P1Health;
    public static int P1ArmorClass;
    public static int P1Intelligence;
    public static int P1Arcana;
    public static int P1History;
    public static int P1Investigation;
    public static int P1Nature;
    public static int P1Religion;
    public static int P1Wisdom;
    public static int P1AnimalHandling;
    public static int P1Insight;
    public static int P1Medicine;
    public static int P1Perception;
    public static int P1Survival;
    public static int P1Charisma;
    public static int P1Deception;
    public static int P1Intimidation;
    public static int P1Performance;
    public static int P1Persuasion;
    public static int P1Dexterity;
    public static int P1Acrobatocs;
    public static int P1SlightOfHand;
    public static int P1Stealth;
    public static int P1Strength;
    public static int P1Athletics;
    public static int P1Constitution;
    //Player Two Stats
    public static int P2Health;
    public static int P2ArmorClass;
    public static int P2Intelligence;
    public static int P2Arcana;
    public static int P2History;
    public static int P2Investigation;
    public static int P2Nature;
    public static int P2Religion;
    public static int P2Wisdom;
    public static int P2AnimalHandling;
    public static int P2Insight;
    public static int P2Medicine;
    public static int P2Perception;
    public static int P2Survival;
    public static int P2Charisma;
    public static int P2Deception;
    public static int P2Intimidation;
    public static int P2Performance;
    public static int P2Persuasion;
    public static int P2Dexterity;
    public static int P2Acrobatocs;
    public static int P2SlightOfHand;
    public static int P2Stealth;
    public static int P2Strength;
    public static int P2Athletics;
    public static int P2Constitution;
    //Player Three Stats
    public static int P3Health;
    public static int P3ArmorClass;
    public static int P3Intelligence;
    public static int P3Arcana;
    public static int P3History;
    public static int P3Investigation;
    public static int P3Nature;
    public static int P3Religion;
    public static int P3Wisdom;
    public static int P3AnimalHandling;
    public static int P3Insight;
    public static int P3Medicine;
    public static int P3Perception;
    public static int P3Survival;
    public static int P3Charisma;
    public static int P3Deception;
    public static int P3Intimidation;
    public static int P3Performance;
    public static int P3Persuasion;
    public static int P3Dexterity;
    public static int P3Acrobatocs;
    public static int P3SlightOfHand;
    public static int P3Stealth;
    public static int P3Strength;
    public static int P3Athletics;
    public static int P3Constitution;

    public static int Intelligence;
    public static int Arcana;
    public static int History;
    public static int Investigation;
    public static int Nature;
    public static int Religion;
    public static int Wisdom;
    public static int AnimalHandling;
    public static int Insight;
    public static int Medicine;
    public static int Perception;
    public static int Survival;
    public static int Charisma;
    public static int Deception;
    public static int Intimidation;
    public static int Performance;
    public static int Persuasion;
    public static int Dexterity;
    public static int Acrobatics;
    public static int SlightOfHand;
    public static int Stealth;
    public static int Strength;
    public static int Athletics;
    public static int Constitution;
    // Start is called before the first frame update
    void Start()
    {
        currentData = DataManager.Load();
        P1Intelligence = currentData.P1IntelligenceSave;
        Debug.Log(P1Intelligence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void UpdateStats()
    {
        if(LogicScript.PCNumber == 1)
        {
            Intelligence = P1Intelligence;
            Arcana = P1Arcana;
            History = P1History;
            Investigation = P1Investigation;
            Nature = P1Nature;
            Religion = P1Religion;
            Wisdom = P1Wisdom;
            AnimalHandling = P1AnimalHandling;
            Insight = P1Insight;
            Medicine = P1Medicine;
            Perception = P1Perception;
            Survival = P1Survival;
            Charisma = P1Charisma;
            Deception = P1Deception;
            Intimidation = P1Intimidation;
            Performance = P1Performance;
            Persuasion = P1Persuasion;
            Dexterity = P1Dexterity;
            Acrobatics = P1Acrobatocs;
            SlightOfHand = P1SlightOfHand;
            Stealth = P1Stealth;
            Strength = P1Strength;
            Athletics = P1Athletics;
            Constitution = P1Constitution;
}
        if (LogicScript.PCNumber == 2)
        {

        }
        if (LogicScript.PCNumber == 3)
        {

        }
    }
}
