using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LogicScript : MonoBehaviour
{
    //Button Variables
        //PC Buttons
    public Button PCOne_btn;
    public Button PCTwo_btn;
    public Button PCThree_btn;
        //End PC Buttons

        //Ability Buttons
    public Button Intelligence_btn;
    public Button Arcana_btn;
    public Button History_btn;
    public Button Investigation_btn;
    public Button Nature_btn;
    public Button Religion_btn;
    public Button Wisdom_btn;
    public Button AnimalHandling_btn;
    public Button Insight_btn;
    public Button Medicine_btn;
    public Button Perception_btn;
    public Button Survival_btn;
    public Button Charisma_btn;
    public Button Deception_btn;
    public Button Intimidation_btn;
    public Button Performance_btn;
    public Button Persuasion_btn;
    public Button Dexterity_btn;
    public Button Acrobatics_btn;
    public Button SlightOfHand_btn;
    public Button Stealth_btn;
    public Button Strength_btn;
    public Button Athletics_btn;
    public Button Constitution_btn;
        //End Ability Buttons
        //DC Buttons
    public Button DC0_btn;
    public Button DC5_btn;
    public Button DC10_btn;
    public Button DC15_btn;
    public Button DC20_btn;
    public Button EditPlayer_btn;
    public Button PCButtons_btn;
        //End DC Buttons
    //End Button Variables

    public GameObject StatUI;
    public GameObject CharacterSheet;

    public DataManager dataManager;
        public SaveData saveData;


    public static int PCNumber;
    public int DCLevel;
    // Start is called before the first frame update

    void Start()
    {
        //Create Buttons
        //PC Button Creation
        Button PCOne = PCOne_btn.GetComponent<Button>();
        Button PCTwo = PCTwo_btn.GetComponent<Button>();
        Button PCThree = PCThree_btn.GetComponent<Button>();
            //End PC Button Creation
            //Abilities Button Creation
        Button IntelligenceBtn = Intelligence_btn.GetComponent<Button>();
        Button ArcanaBtn = Arcana_btn.GetComponent<Button>();
        Button HistoryBtn = History_btn.GetComponent<Button>();
        Button InvestigationBtn = Investigation_btn.GetComponent<Button>();
        Button NatureBtn = Nature_btn.GetComponent<Button>();
        Button ReligionBtn = Religion_btn.GetComponent<Button>();
        Button WisdomBtn = Wisdom_btn.GetComponent<Button>();
        Button AnimalHandlingBtn = AnimalHandling_btn.GetComponent<Button>();
        Button InsightBtn = Insight_btn.GetComponent<Button>();
        Button MedicineBtn = Medicine_btn.GetComponent<Button>();
        Button PerceptionBtn = Perception_btn.GetComponent<Button>();
        Button SurvivalBtn = Survival_btn.GetComponent<Button>();
        Button CharismaBtn = Charisma_btn.GetComponent<Button>();
        Button DeceptionBtn = Deception_btn.GetComponent<Button>();
        Button IntimidationBtn = Intimidation_btn.GetComponent<Button>();
        Button PerformanceBtn = Performance_btn.GetComponent<Button>();
        Button PersuasionBtn = Persuasion_btn.GetComponent<Button>();
        Button DexterityBtn = Dexterity_btn.GetComponent<Button>();
        Button AcrobaticsBtn = Acrobatics_btn.GetComponent<Button>();
        Button SlightOfHandBtn = SlightOfHand_btn.GetComponent<Button>();
        Button StealthBtn = Stealth_btn.GetComponent<Button>();
        Button StrengthBtn = Strength_btn.GetComponent<Button>();
        Button AthleticsBtn = Athletics_btn.GetComponent<Button>();
        Button ConstitutionBtn = Constitution_btn.GetComponent<Button>();
            //End Ability Button Creation
            //DC Button Creation
        Button DC0Btn = DC0_btn.GetComponent<Button>();
        Button DC5Btn = DC5_btn.GetComponent<Button>();
        Button DC10Btn = DC10_btn.GetComponent<Button>();
        Button DC15Btn = DC15_btn.GetComponent<Button>();
        Button DC20Btn = DC20_btn.GetComponent<Button>();
        Button EditPlayerBtn = EditPlayer_btn.GetComponent<Button>();
        Button PCButtonsBtn = PCButtons_btn.GetComponent<Button>();

        //End DC Button Creation
        //End Button Creation

        //Create Button Listeners
        //Abilities Listeners
        IntelligenceBtn.onClick.AddListener(delegate { Roll(StatVariables.Intelligence); });
        ArcanaBtn.onClick.AddListener(delegate { Roll(StatVariables.Arcana); });
        HistoryBtn.onClick.AddListener(delegate { Roll(StatVariables.History); });
        InvestigationBtn.onClick.AddListener(delegate { Roll(StatVariables.Investigation); });
        NatureBtn.onClick.AddListener(delegate { Roll(StatVariables.Nature); });
        ReligionBtn.onClick.AddListener(delegate { Roll(StatVariables.Religion); });
        WisdomBtn.onClick.AddListener(delegate { Roll(StatVariables.Wisdom); });
        AnimalHandlingBtn.onClick.AddListener(delegate { Roll(StatVariables.AnimalHandling); });
        InsightBtn.onClick.AddListener(delegate { Roll(StatVariables.Insight); });
        MedicineBtn.onClick.AddListener(delegate { Roll(StatVariables.Medicine); });
        PerceptionBtn.onClick.AddListener(delegate { Roll(StatVariables.Perception); });
        SurvivalBtn.onClick.AddListener(delegate { Roll(StatVariables.Survival); });
        CharismaBtn.onClick.AddListener(delegate { Roll(StatVariables.Charisma); });
        DeceptionBtn.onClick.AddListener(delegate { Roll(StatVariables.Deception); });
        IntimidationBtn.onClick.AddListener(delegate { Roll(StatVariables.Intimidation); });
        PerformanceBtn.onClick.AddListener(delegate { Roll(StatVariables.Performance); });
        PersuasionBtn.onClick.AddListener(delegate { Roll(StatVariables.Persuasion); });
        DexterityBtn.onClick.AddListener(delegate { Roll(StatVariables.Dexterity); });
        AcrobaticsBtn.onClick.AddListener(delegate { Roll(StatVariables.Acrobatics); });
        SlightOfHandBtn.onClick.AddListener(delegate { Roll(StatVariables.SlightOfHand); });
        StealthBtn.onClick.AddListener(delegate { Roll(StatVariables.Stealth); });
        StrengthBtn.onClick.AddListener(delegate { Roll(StatVariables.Strength); });
        AthleticsBtn.onClick.AddListener(delegate { Roll(StatVariables.Athletics); });
        ConstitutionBtn.onClick.AddListener(delegate { Roll(StatVariables.Constitution); });
            //Abilities Listeners
            //PC Listeners
        PCOne.onClick.AddListener(delegate { SetPC(1); });
        PCTwo.onClick.AddListener(delegate { SetPC(2); });
        PCThree.onClick.AddListener(delegate { SetPC(3); });
        EditPlayerBtn.onClick.AddListener(LoadCharacterSheet);
        PCButtonsBtn.onClick.AddListener(LoadPCButtons);
        //End PC Listeners
        //DC Button Listeners
        DC0Btn.onClick.AddListener(delegate { DCSet(0); });
        DC5Btn.onClick.AddListener(delegate { DCSet(5); });
        DC10Btn.onClick.AddListener(delegate { DCSet(10); });
        DC15Btn.onClick.AddListener(delegate { DCSet(15); });
        DC20Btn.onClick.AddListener(delegate { DCSet(20); });
            //End DC Button Listeners

        //End Button Listeners
    }

    // Update is called once per frame
    void Update()
    {

    }


    //Assign the PC variable based on button input
    void SetPC(int i)
    {
        PCNumber = i;
        StatVariables.UpdateStats();
        UpdateValues();
    }
    //Rolls and Passes Results to QLab over OSC
    void Roll(int stat)
    {
        int CurrentRoll = Random.Range(1, 20);
        Debug.Log(stat);
    }
    //Sets the DC to see if Die rolls are success or failure
    void DCSet(int i)
    {
        DCLevel = i;
    }


    void LoadCharacterSheet()
    {
        StatUI.SetActive(false);
        CharacterSheet.SetActive(true);
    }
    void LoadPCButtons()
    {
        StatUI.SetActive(true);
        CharacterSheet.SetActive(false);
    }

    void UpdateValues()
    {
        Intelligence_btn.GetComponentInChildren<Text>().text = StatVariables.Intelligence.ToString();
        Arcana_btn.GetComponentInChildren<Text>().text = StatVariables.Arcana.ToString();
        History_btn.GetComponentInChildren<Text>().text = StatVariables.History.ToString();
        Investigation_btn.GetComponentInChildren<Text>().text = StatVariables.Investigation.ToString();
        Religion_btn.GetComponentInChildren<Text>().text = StatVariables.Religion.ToString();
        Nature_btn.GetComponentInChildren<Text>().text = StatVariables.Nature.ToString();
        Wisdom_btn.GetComponentInChildren<Text>().text = StatVariables.Wisdom.ToString();
        AnimalHandling_btn.GetComponentInChildren<Text>().text = StatVariables.AnimalHandling.ToString();
        Insight_btn.GetComponentInChildren<Text>().text = StatVariables.Insight.ToString();
        Medicine_btn.GetComponentInChildren<Text>().text = StatVariables.Medicine.ToString();
        Perception_btn.GetComponentInChildren<Text>().text = StatVariables.Perception.ToString();
        Charisma_btn.GetComponentInChildren<Text>().text = StatVariables.Charisma.ToString();
        Survival_btn.GetComponentInChildren<Text>().text = StatVariables.Survival.ToString();
        Deception_btn.GetComponentInChildren<Text>().text = StatVariables.Deception.ToString();
        Intimidation_btn.GetComponentInChildren<Text>().text = StatVariables.Intimidation.ToString();
        Performance_btn.GetComponentInChildren<Text>().text = StatVariables.Performance.ToString();
        Persuasion_btn.GetComponentInChildren<Text>().text = StatVariables.Persuasion.ToString();
        Dexterity_btn.GetComponentInChildren<Text>().text = StatVariables.Dexterity.ToString();
        Acrobatics_btn.GetComponentInChildren<Text>().text = StatVariables.Acrobatics.ToString();
        SlightOfHand_btn.GetComponentInChildren<Text>().text = StatVariables.SlightOfHand.ToString();
        Stealth_btn.GetComponentInChildren<Text>().text = StatVariables.Stealth.ToString();
        Strength_btn.GetComponentInChildren<Text>().text = StatVariables.Strength.ToString();
        Athletics_btn.GetComponentInChildren<Text>().text = StatVariables.Athletics.ToString();
        Constitution_btn.GetComponentInChildren<Text>().text = StatVariables.Constitution.ToString();
    }
}

