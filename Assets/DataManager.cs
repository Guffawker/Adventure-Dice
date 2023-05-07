using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;

public class DataManager
{
    public static string filePath = Application.persistentDataPath + "/save.data";
    public static void Save(SaveData saveData)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/save.data", FileMode.OpenOrCreate);
        bf.Serialize(file, saveData);
        file.Close();
        Debug.Log("Saved");

    }

    public static SaveData Load()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/save.data", FileMode.OpenOrCreate);
        if (File.Exists(filePath))
        {
            SaveData saveData = bf.Deserialize(file) as SaveData;
            file.Close();
            return saveData;
        }
        else
        {
            Debug.Log("No File");
            return null;
        }
    }
}
[Serializable]
public class SaveData
{
    //Player One Stats
    public int P1HealthSave;
    public int P1ArmorClassSave;
    public int P1IntelligenceSave;
    public int P1ArcanaSave;
    public int P1HistorySave;
    public int P1InvestigationSave;
    public int P1NatureSave;
    public int P1ReligionSave;
    public int P1WisdomSave;
    public int P1AnimalHandlingSave;
    public int P1InsightSave;
    public int P1MedicineSave;
    public int P1PerceptionSave;
    public int P1SurvivalSave;
    public int P1CharismaSave;
    public int P1DeceptionSave;
    public int P1IntimidationSave;
    public int P1PerformanceSave;
    public int P1PersuasionSave;
    public int P1DexteritySave;
    public int P1AcrobatocsSave;
    public int P1SlightOfHandSave;
    public int P1StealthSave;
    public int P1StrengthSave;
    public int P1AthleticsSave;
    public int P1ConstitutionSave;
    //Player Two Stats
    public int P2HealthSave;
    public int P2ArmorClassSave;
    public int P2IntelligenceSave;
    public int P2ArcanaSave;
    public int P2HistorySave;
    public int P2InvestigationSave;
    public int P2NatureSave;
    public int P2ReligionSave;
    public int P2WisdomSave;
    public int P2AnimalHandlingSave;
    public int P2InsightSave;
    public int P2MedicineSave;
    public int P2PerceptionSave;
    public int P2SurvivalSave;
    public int P2CharismaSave;
    public int P2DeceptionSave;
    public int P2IntimidationSave;
    public int P2PerformanceSave;
    public int P2PersuasionSave;
    public int P2DexteritySave;
    public int P2AcrobatocsSave;
    public int P2SlightOfHandSave;
    public int P2StealthSave;
    public int P2StrengthSave;
    public int P2AthleticsSave;
    public int P2ConstitutionSave;
    //Player Three Stats
    public int P3HealthSave;
    public int P3ArmorClassSave;
    public int P3IntelligenceSave;
    public int P3ArcanaSave;
    public int P3HistorySave;
    public int P3InvestigationSave;
    public int P3NatureSave;
    public int P3ReligionSave;
    public int P3WisdomSave;
    public int P3AnimalHandlingSave;
    public int P3InsightSave;
    public int P3MedicineSave;
    public int P3PerceptionSave;
    public int P3SurvivalSave;
    public int P3CharismaSave;
    public int P3DeceptionSave;
    public int P3IntimidationSave;
    public int P3PerformanceSave;
    public int P3PersuasionSave;
    public int P3DexteritySave;
    public int P3AcrobatocsSave;
    public int P3SlightOfHandSave;
    public int P3StealthSave;
    public int P3StrengthSave;
    public int P3AthleticsSave;
    public int P3ConstitutionSave;
}
