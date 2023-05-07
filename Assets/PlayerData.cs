using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public InputField Intelligence_input;
    public InputField Arcana_input;
    public InputField History_input;
    public InputField Investigation_input;
    public InputField Nature_input;
    public InputField Religion_input;
    public InputField Wisdom_input;
    public InputField AnimalHandling_input;
    public InputField Insight_input;
    public InputField Medicine_input;
    public InputField Perception_input;
    public InputField Survival_input;
    public InputField Charisma_input;
    public InputField Deception_input;
    public InputField Intimidation_input;
    public InputField Performance_input;
    public InputField Persuasion_input;
    public InputField Dexterity_input;
    public InputField Acrobatics_input;
    public InputField SlightOfHand_input;
    public InputField Stealth_input;
    public InputField Strength_input;
    public InputField Athletics_input;
    public InputField Constitution_input;
    // Start is called before the first frame update

    public SaveData saveData;

    void Start()
    {
        InputField IntelligenceInput = Intelligence_input.GetComponent<InputField>();
        InputField ArcanaInput = Arcana_input.GetComponent<InputField>();
        InputField HistoryInput = History_input.GetComponent<InputField>();
        InputField InvestigationInput = Investigation_input.GetComponent<InputField>();
        InputField NatureInput = Nature_input.GetComponent<InputField>();
        InputField ReligionInput = Religion_input.GetComponent<InputField>();
        InputField WisdomInput = Wisdom_input.GetComponent<InputField>();
        InputField AnimalHandlingInput = AnimalHandling_input.GetComponent<InputField>();
        InputField InsightInput = Insight_input.GetComponent<InputField>();
        InputField MedicineInput = Medicine_input.GetComponent<InputField>();
        InputField PerceptionInput = Perception_input.GetComponent<InputField>();
        InputField SurvivalInput = Survival_input.GetComponent<InputField>();
        InputField CharismaInput = Charisma_input.GetComponent<InputField>();
        InputField DeceptionInput = Deception_input.GetComponent<InputField>();
        InputField IntimidationInput = Intimidation_input.GetComponent<InputField>();
        InputField PerformanceInput = Performance_input.GetComponent<InputField>();
        InputField PersuasionInput = Persuasion_input.GetComponent<InputField>();
        InputField DexterityInput = Dexterity_input.GetComponent<InputField>();
        InputField AcrobaticsInput = Acrobatics_input.GetComponent<InputField>();
        InputField SlightOfHandInput = SlightOfHand_input.GetComponent<InputField>();
        InputField StealthInput = Stealth_input.GetComponent<InputField>();
        InputField StrengthInput = Strength_input.GetComponent<InputField>();
        InputField AthleticsInput = Athletics_input.GetComponent<InputField>();
        InputField ConstitutionInput = Constitution_input.GetComponent<InputField>();


        IntelligenceInput.onEndEdit.AddListener(UpdateIntelligence);
        ArcanaInput.onEndEdit.AddListener(UpdateArcana);
        HistoryInput.onEndEdit.AddListener(UpdateHistory);
        InvestigationInput.onEndEdit.AddListener(UpdateInvestigation);
        NatureInput.onEndEdit.AddListener(UpdateNature);
        ReligionInput.onEndEdit.AddListener(UpdateReligion);
        WisdomInput.onEndEdit.AddListener(UpdateWisdom);
        AnimalHandlingInput.onEndEdit.AddListener(UpdateAnimalHandling);
        InsightInput.onEndEdit.AddListener(UpdateInsight);
        MedicineInput.onEndEdit.AddListener(UpdateMedicine);
        PerceptionInput.onEndEdit.AddListener(UpdatePerception);
        SurvivalInput.onEndEdit.AddListener(UpdateSurvival);
        CharismaInput.onEndEdit.AddListener(UpdateCharisma);
        DeceptionInput.onEndEdit.AddListener(UpdateDeception);
        IntimidationInput.onEndEdit.AddListener(UpdateIntimidation);
        PerformanceInput.onEndEdit.AddListener(UpdatePerformance);
        PersuasionInput.onEndEdit.AddListener(UpdatePersuasion);
        DexterityInput.onEndEdit.AddListener(UpdateDexterity);
        AcrobaticsInput.onEndEdit.AddListener(UpdateAcrobatics);
        SlightOfHandInput.onEndEdit.AddListener(UpdateSlightOfHand);
        StealthInput.onEndEdit.AddListener(UpdateStealth);
        StrengthInput.onEndEdit.AddListener(UpdateStrength);
        AthleticsInput.onEndEdit.AddListener(UpdateAthletics);
        ConstitutionInput.onEndEdit.AddListener(UpdateConstitution);
    }

    void UpdateIntelligence(string stat)
    {
        if (LogicScript.PCNumber == 1){
            StatVariables.P1Intelligence = int.Parse(stat);
            saveData.P1IntelligenceSave = int.Parse(stat);
            DataManager.Save(saveData);
        }
    }
    void UpdateArcana(string stat)
    {


    }
    void UpdateHistory(string stat)
    {


    }
    void UpdateInvestigation(string stat)
    {


    }
    void UpdateNature(string stat)
    {


    }
    void UpdateReligion(string stat)
    {


    }
    void UpdateWisdom(string stat)
    {


    }
    void UpdateAnimalHandling(string stat)
    {


    }
    void UpdateInsight(string stat)
    {


    }
    void UpdateMedicine(string stat)
    {

    }
    void UpdatePerception(string stat)
    {


    }
    void UpdateSurvival(string stat)
    {


    }
    void UpdateCharisma(string stat)
    {


    }
    void UpdateDeception(string stat)
    {


    }
    void UpdateIntimidation(string stat)
    {


    }
    void UpdatePerformance(string stat)
    {


    }
    void UpdatePersuasion(string stat)
    {


    }
    void UpdateDexterity(string stat)
    {


    }
    void UpdateSlightOfHand(string stat)
    {


    }
    void UpdateAcrobatics(string stat)
    {


    }
    void UpdateStealth(string stat)
    {


    }
    void UpdateStrength(string stat)
    {


    }
    void UpdateAthletics(string stat)
    {


    }
    void UpdateConstitution(string stat)
    {


    }
}
