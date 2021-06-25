using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CrimeScene : MonoBehaviour
{
    public static int ItemCounter = 0;
    public GameObject Interrogation;


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quitting bitch!");
        }

        if (ItemCounter >= 5)
        {
            Debug.Log("All items collected");
            Interrogation.SetActive(true);
        }
    }

    public void RotatePuzzle()
    {
        SceneManager.LoadScene("RotatePuzzle");
        ItemCounter += 1;
    }

    public void FingerPrint()
    {
        SceneManager.LoadScene("Fingerprint");
        ItemCounter += 1;
    }

    public void Clues()
    {
        ItemCounter += 1;
    }

    public void crimescene() 
    {
        SceneManager.LoadScene("CrimeScene");
    }

    public void InterrogationScene()
    {
        SceneManager.LoadScene("Interrogation");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting bitch!");
    }

    public void MainMenuThingy()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
