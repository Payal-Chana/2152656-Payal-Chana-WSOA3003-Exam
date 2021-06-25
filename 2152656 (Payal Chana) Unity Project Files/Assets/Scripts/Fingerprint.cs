using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fingerprint : MonoBehaviour
{
    public bool correctfingerprint;
    public bool wrongfingerprint;

    private float startPosX;
    private float startPosY;
    public bool isBeingHeld = false;

    public GameObject scanner;
    public GameObject Crimescene;

    Scene currentScene;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        currentScene = SceneManager.GetActiveScene();

    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quitting bitch!");
        }*/

        if (isBeingHeld == true)
        {   
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            scanner.transform.localPosition = new Vector3(mousePos.x -startPosX , mousePos.y - startPosY, 0);
        }

        PlayerPrefs.SetInt("correctfingerprint", (correctfingerprint ? 1 : 0));
        PlayerPrefs.SetInt("wrongfingerprint", (wrongfingerprint ? 1 : 0));

        int value1;
        int value2;

        value1 = correctfingerprint ? 1 : 0;
        value2 = wrongfingerprint ? 1 : 0;

        if (correctfingerprint == true)
        {
            value1 = 1;
        }
        else
        {
            value1 = 0;
        }

        if (wrongfingerprint == true)
        {
            value2 = 1;
        }
        else
        {
            value2 = 0;
        }

        if (currentScene.name == "Fingerprint")
        {
            scanner.SetActive(true);
        }
        else if (currentScene.name != "Fingerprint" )
        {
            scanner.SetActive(false);
        }

    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - scanner.transform.localPosition.x;
            startPosY = mousePos.y - scanner.transform.localPosition.y;

            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;
    }

    public void CorrectFingerprint()
    {
        correctfingerprint = true;
        wrongfingerprint = false;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Correct Finger chosen");
        Crimescene.SetActive(true);

    }

    public void WrongFingerPrint()
    {
        correctfingerprint = false;
        wrongfingerprint = true;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Wrong Finger chosen");
        Crimescene.SetActive(true);
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
