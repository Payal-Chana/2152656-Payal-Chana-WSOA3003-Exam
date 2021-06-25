using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject crimescene;
    public GameObject PuzzleHolder;
    public GameObject[] Pieces;
    public GameObject FullPuzzlePiece;

    public int totalPieces = 0;
    public int correctPieces = 0;
    public static int TotalClicks = 0;

    public bool GoodRating;
    public bool BadRating;


    //public RotatePuzzle rotatePuzzlescript;
    // Start is called before the first frame update
    void Start()
    {
        totalPieces = PuzzleHolder.transform.childCount;
        Pieces = new GameObject[totalPieces];

        for (int i = 0; i < Pieces.Length; i++)
        {
            Pieces[i] = PuzzleHolder.transform.GetChild(i).gameObject;
        }

        DontDestroyOnLoad(transform.gameObject);

        GoodRating = false;
        BadRating = false;
        correctPieces = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("GoodRating", (GoodRating ? 1 : 0));
        PlayerPrefs.SetInt("BadRating", (BadRating ? 1 : 0));

        int value1;
        int value2;

        value1 = GoodRating ? 1 : 0;
        value2 = BadRating ? 1 : 0;

        if (GoodRating == true)
        {
            value1 = 1;
        }
        else
        {
            value1 = 0;
        }

        if (BadRating == true)
        {
            value2 = 1;
        }
        else
        {
            value2 = 0;
        }

        /*if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quitting bitch!");
        }*/
    }

    public void correctMove()
    {
        correctPieces += 1;
        Debug.Log("Correct Move");
        TotalClicks += 1;

        if (correctPieces == totalPieces)
        {
            Debug.Log("You Win!!");
            StartCoroutine(Puzzlepiece());
        }
    }

    public void wrongMove()
    {
        correctPieces -= 1;
        TotalClicks += 1;

    }

    public IEnumerator Puzzlepiece()
    {
        if (TotalClicks <= 15)
        {
            GoodRating = true;
        }
        else if (TotalClicks > 15)
        {
            BadRating = true;
        }

        yield return new WaitForSeconds(1f);
        FullPuzzlePiece.SetActive(true);
        PuzzleHolder.SetActive(false);
        crimescene.SetActive(true);
    }
}
