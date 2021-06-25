using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interrogation : MonoBehaviour
{
    public int ChoiceMade;
    public int NumberofChoicesMade;
    public GameObject AllChoose;
    
    public GameObject Sam;
    public GameObject SamTextBox;
    public GameObject SamQuestion1;
    public GameObject SamQuestion2;
    public GameObject SamQuestion3;
    public GameObject SamNext;
    
    public GameObject Stuart;
    public GameObject StuartTextBox;
    public GameObject StuartQuestion1;
    public GameObject StuartQuestion2;
    public GameObject StuartQuestion3;
    public GameObject StuartNext;
   
    public GameObject Patrick;
    public GameObject PatrickTextBox;
    public GameObject PatrickQuestion1;
    public GameObject PatrickQuestion2;
    public GameObject PatrickQuestion3;
    public GameObject PatrickNext;

    public GameObject Edward;
    public GameObject EdwardTextBox;
    public GameObject EdwardQuestion1;
    public GameObject EdwardQuestion2;
    public GameObject EdwardQuestion3;
    public GameObject EdwardNext;

    /*public string[] Responses;
    private int index;
    public float TypingSpeed;

    /*private void Start()
    {
        StartCoroutine(Typeytype());
    }*/

    private void Start()
    {
        AllChoose.SetActive(false);
        
        SamQuestion1.SetActive(false);
        SamQuestion2.SetActive(false);
        SamQuestion3.SetActive(false);
        SamTextBox.SetActive(false);
        SamNext.SetActive(false);


        StuartQuestion1.SetActive(false);
        StuartQuestion2.SetActive(false);
        StuartQuestion3.SetActive(false);
        StuartTextBox.SetActive(false);
        StuartNext.SetActive(false);

        PatrickQuestion1.SetActive(false);
        PatrickQuestion2.SetActive(false);
        PatrickQuestion3.SetActive(false);
        PatrickTextBox.SetActive(false);
        PatrickNext.SetActive(false);

        EdwardQuestion1.SetActive(false);
        EdwardQuestion2.SetActive(false);
        EdwardQuestion3.SetActive(false);
        EdwardTextBox.SetActive(false);
        EdwardNext.SetActive(false);
    }

    void Update()
    {
        if (ChoiceMade >= 1)
        {
            SamQuestion1.SetActive(false);
            SamQuestion2.SetActive(false);
            SamQuestion3.SetActive(false);

            StuartQuestion1.SetActive(false);
            StuartQuestion2.SetActive(false);
            StuartQuestion3.SetActive(false);

            PatrickQuestion1.SetActive(false);
            PatrickQuestion2.SetActive(false);
            PatrickQuestion3.SetActive(false);

            EdwardQuestion1.SetActive(false);
            EdwardQuestion2.SetActive(false);
            EdwardQuestion3.SetActive(false);
        }

        if (NumberofChoicesMade >= 5)
        {
            //goto next scene
            Debug.Log("Interrogation Complete!!!");
            SceneManager.LoadScene("EndScene");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quitting bitch!");
        }
    }

    /*public IEnumerator Typeytype()
    {
        foreach (char alphabet in Responses[index].ToCharArray())
        {
            TextBox.GetComponent<Text>().text += alphabet;
            yield return new WaitForSeconds(TypingSpeed);
        }
    }*/

    public void ChoiceOption1 ()
    {
        SamTextBox.GetComponent<Text>().text = "Looks like you made the first choice.";
        ChoiceMade = 1;
        SamQuestion1.GetComponent<Button>().interactable = false;
        SamNext.SetActive(true);
        AllChoose.SetActive(false);
    }

    public void ChoiceOption2()
    {
        SamTextBox.GetComponent<Text>().text = "Looks like you made the second choice.";
        ChoiceMade = 2;
        SamQuestion2.GetComponent<Button>().interactable = false;
        SamNext.SetActive(true);
        AllChoose.SetActive(false);
    }

    public void ChoiceOption3()
    {
        SamTextBox.GetComponent<Text>().text = "Looks like you made the third choice.";
        ChoiceMade = 3;
        SamQuestion3.GetComponent<Button>().interactable = false;
        SamNext.SetActive(true);
        AllChoose.SetActive(false);
    }

    public void ChoiceOption6()
    {
        StuartTextBox.GetComponent<Text>().text = "Looks like you made the sixth choice.";
        ChoiceMade = 6;
        StuartQuestion1.GetComponent<Button>().interactable = false;
        StuartNext.SetActive(true);
        AllChoose.SetActive(false);
    }

    public void ChoiceOption7()
    {
        StuartTextBox.GetComponent<Text>().text = "Looks like you made the seventh choice.";
        ChoiceMade = 7;
        StuartQuestion2.GetComponent<Button>().interactable = false;
        StuartNext.SetActive(true);
        AllChoose.SetActive(false);
    }

    public void ChoiceOption8()
    {
        StuartTextBox.GetComponent<Text>().text = "Looks like you made the eigth choice.";
        ChoiceMade = 8;
        StuartQuestion3.GetComponent<Button>().interactable = false;
        StuartNext.SetActive(true);
        AllChoose.SetActive(false);
    }

    public void ChoiceOption11()
    {
        PatrickTextBox.GetComponent<Text>().text = "Looks like you made the eleventh choice.";
        ChoiceMade = 11;
        PatrickQuestion1.GetComponent<Button>().interactable = false;
        PatrickNext.SetActive(true);
        AllChoose.SetActive(false);
    }

    public void ChoiceOption12()
    {
        PatrickTextBox.GetComponent<Text>().text = "Looks like you made the twelfth choice.";
        ChoiceMade = 12;
        PatrickQuestion2.GetComponent<Button>().interactable = false;
        PatrickNext.SetActive(true);
        AllChoose.SetActive(false);
    }

    public void ChoiceOption13()
    {
        PatrickTextBox.GetComponent<Text>().text = "Looks like you made the thirteenth choice.";
        ChoiceMade = 13;
        PatrickQuestion3.GetComponent<Button>().interactable = false;
        PatrickNext.SetActive(true);
        AllChoose.SetActive(false);
    }

    public void ChoiceOption16()
    {
        EdwardTextBox.GetComponent<Text>().text = "Looks like you made the sixteenth choice.";
        ChoiceMade = 16;
        EdwardQuestion1.GetComponent<Button>().interactable = false;
        EdwardNext.SetActive(true);
        AllChoose.SetActive(false);
    }

    public void ChoiceOption17()
    {
        EdwardTextBox.GetComponent<Text>().text = "Looks like you made the seventeenth choice.";
        ChoiceMade = 17;
        EdwardQuestion2.GetComponent<Button>().interactable = false;
        EdwardNext.SetActive(true);
        AllChoose.SetActive(false);
    }

    public void ChoiceOption18()
    {
        EdwardTextBox.GetComponent<Text>().text = "Looks like you made the eighteenth choice.";
        ChoiceMade = 18;
        EdwardQuestion3.GetComponent<Button>().interactable = false;
        EdwardNext.SetActive(true);
        AllChoose.SetActive(false);
        
    }

    public void SamNextResponse()
    {
        SamQuestion1.SetActive(true);
        SamQuestion2.SetActive(true);
        SamQuestion3.SetActive(true);
        ChoiceMade = 0;
        SamNext.SetActive(false);

        Sam.SetActive(true);
        Stuart.SetActive(true);
        Patrick.SetActive(true);
        Edward.SetActive(true);

        SamQuestion1.SetActive(false);
        SamQuestion2.SetActive(false);
        SamQuestion3.SetActive(false);
        SamTextBox.SetActive(false);

        NumberofChoicesMade += 1;
        /*if (index < Responses.Length - 1)
        {
            index++;
            TextBox.GetComponent<Text>().text = "";
            StartCoroutine(Typeytype());
        }
        else
        {
            TextBox.GetComponent<Text>().text = "";
        }*/
    }

    public void StuartNextResponse()
    {
        StuartQuestion1.SetActive(true);
        StuartQuestion2.SetActive(true);
        StuartQuestion3.SetActive(true);
        ChoiceMade = 0;
        StuartNext.SetActive(false);

        Sam.SetActive(true);
        Stuart.SetActive(true);
        Patrick.SetActive(true);
        Edward.SetActive(true);

        StuartQuestion1.SetActive(false);
        StuartQuestion2.SetActive(false);
        StuartQuestion3.SetActive(false);
        StuartTextBox.SetActive(false);

        NumberofChoicesMade += 1;
    }

    public void PatrickNextResponse()
    {
        PatrickQuestion1.SetActive(true);
        PatrickQuestion2.SetActive(true);
        PatrickQuestion3.SetActive(true);
        ChoiceMade = 0;
        PatrickNext.SetActive(false);

        Sam.SetActive(true);
        Stuart.SetActive(true);
        Patrick.SetActive(true);
        Edward.SetActive(true);

        PatrickQuestion1.SetActive(false);
        PatrickQuestion2.SetActive(false);
        PatrickQuestion3.SetActive(false);
        PatrickTextBox.SetActive(false);

        NumberofChoicesMade += 1;
    }

    public void EdwardNextResponse()
    {
        EdwardQuestion1.SetActive(true);
        EdwardQuestion2.SetActive(true);
        EdwardQuestion3.SetActive(true);
        ChoiceMade = 0;
        EdwardNext.SetActive(false);

        Sam.SetActive(true);
        Stuart.SetActive(true);
        Patrick.SetActive(true);
        Edward.SetActive(true);

        EdwardQuestion1.SetActive(false);
        EdwardQuestion2.SetActive(false);
        EdwardQuestion3.SetActive(false);
        EdwardTextBox.SetActive(false);

        NumberofChoicesMade += 1;
    }

    public void SamQuestions()
    {
        SamQuestion1.SetActive(true);
        SamQuestion2.SetActive(true);
        SamQuestion3.SetActive(true);
        SamTextBox.SetActive(false);

        Sam.SetActive(false);
        Stuart.SetActive(false);
        Patrick.SetActive(false);
        Edward.SetActive(false);

        AllChoose.SetActive(true);
    }

    public void StuartQuestions()
    {
        StuartQuestion1.SetActive(true);
        StuartQuestion2.SetActive(true);
        StuartQuestion3.SetActive(true);
        StuartTextBox.SetActive(false);

        Sam.SetActive(false);
        Stuart.SetActive(false);
        Patrick.SetActive(false);
        Edward.SetActive(false);

        AllChoose.SetActive(true);
    }

    public void PatrickQuestions()
    {
        PatrickQuestion1.SetActive(true);
        PatrickQuestion2.SetActive(true);
        PatrickQuestion3.SetActive(true);
        PatrickTextBox.SetActive(false);

        Sam.SetActive(false);
        Stuart.SetActive(false);
        Patrick.SetActive(false);
        Edward.SetActive(false);

        AllChoose.SetActive(true);
    }

    public void EdwardQuestions()
    {
        EdwardQuestion1.SetActive(true);
        EdwardQuestion2.SetActive(true);
        EdwardQuestion3.SetActive(true);
        EdwardTextBox.SetActive(false);


        Sam.SetActive(false);
        Stuart.SetActive(false);
        Patrick.SetActive(false);
        Edward.SetActive(false);

        AllChoose.SetActive(true);
    }

    public void AllChooseAgain()
    {
        SamQuestion1.SetActive(false);
        SamQuestion2.SetActive(false);
        SamQuestion3.SetActive(false);
        SamTextBox.SetActive(false);
        SamNext.SetActive(false);


        StuartQuestion1.SetActive(false);
        StuartQuestion2.SetActive(false);
        StuartQuestion3.SetActive(false);
        StuartTextBox.SetActive(false);
        StuartNext.SetActive(false);

        PatrickQuestion1.SetActive(false);
        PatrickQuestion2.SetActive(false);
        PatrickQuestion3.SetActive(false);
        PatrickTextBox.SetActive(false);
        PatrickNext.SetActive(false);

        EdwardQuestion1.SetActive(false);
        EdwardQuestion2.SetActive(false);
        EdwardQuestion3.SetActive(false);
        EdwardTextBox.SetActive(false);
        EdwardNext.SetActive(false);

        Sam.SetActive(true);
        Stuart.SetActive(true);
        Patrick.SetActive(true);
        Edward.SetActive(true);

    }
}
