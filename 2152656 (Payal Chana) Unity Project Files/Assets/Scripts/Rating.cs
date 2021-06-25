using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Rating : MonoBehaviour
{
    Scene currentScene;
    public Text Win;
    public Text Lose;

    public bool RightAccuse;
    public bool WrongAccuse;

    GameManager GameMan;
    Fingerprint FinPrin;

    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();

        GameMan = GameObject.Find("GameManager").GetComponent<GameManager>();
        FinPrin = GameObject.Find("Canvas").GetComponent<Fingerprint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quitting bitch!");
        }

        if (RightAccuse == true)
        {
            if (GameMan.GoodRating = (PlayerPrefs.GetInt("GoodRating") != 0))
            {
                if (FinPrin.correctfingerprint = (PlayerPrefs.GetInt("correctfingerprint") != 0))
                {
                    Win.GetComponent<Text>().text = "You're still a fantastic detective! Rating: 10/10";
                }
                else if (FinPrin.wrongfingerprint = (PlayerPrefs.GetInt("wrongfingerprint") != 0))
                {
                    Win.GetComponent<Text>().text = "You're still quite a decent detective! Rating: 7/10";
                }
            }
            else if (GameMan.BadRating = (PlayerPrefs.GetInt("BadRating") != 0))
            {
                if (FinPrin.correctfingerprint = (PlayerPrefs.GetInt("correctfingerprint") != 0))
                {
                    Win.GetComponent<Text>().text = "You're still quite a decent detective!  Rating: 7/10";
                }
                else if (FinPrin.wrongfingerprint = (PlayerPrefs.GetInt("wrongfingerprint") != 0))
                {
                    Win.GetComponent<Text>().text = "Your detective skill need some work! Rating: 4/10";
                }
            }
        }
        else if (WrongAccuse == true)
        {
            if (GameMan.GoodRating = (PlayerPrefs.GetInt("GoodRating") != 0))
            {
                if (FinPrin.correctfingerprint = (PlayerPrefs.GetInt("correctfingerprint") != 0))
                {
                    Lose.GetComponent<Text>().text = "You're still quite a decent detective! Rating: 7/10";
                }
                else if (FinPrin.wrongfingerprint = (PlayerPrefs.GetInt("wrongfingerprint") != 0))
                {
                    Lose.GetComponent<Text>().text = "Your detective skill need some work! Rating: 4/10";
                }
            }
            else if (GameMan.BadRating = (PlayerPrefs.GetInt("BadRating") != 0))
            {
                if (FinPrin.correctfingerprint = (PlayerPrefs.GetInt("correctfingerprint") != 0))
                {
                    Lose.GetComponent<Text>().text = "Your detective skill need some work! Rating: 4/10";
                }
                else if (FinPrin.wrongfingerprint = (PlayerPrefs.GetInt("wrongfingerprint") != 0))
                {
                    Lose.GetComponent<Text>().text = "Your detective skills... it's the old age, it's okay! Rating: 0/10";
                }
            }
        }
    }

    public void Correct()
    {
        RightAccuse = true;
    }

    public void Incorrect()
    {
        WrongAccuse = true;
    }
}
