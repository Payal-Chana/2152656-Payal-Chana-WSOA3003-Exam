using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatePuzzle : MonoBehaviour
{
    public float correctRotation = 0;
    public bool isPlaced = false;
    GameManager GameMan;

    private void Awake()
    {
        GameMan = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Start()
    {
        if (transform.eulerAngles.z == correctRotation)
        {
            isPlaced = true;
            GameMan.correctMove();
        }

        isPlaced = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quitting bitch!");
        }
    }

    public void OnMouseDown()
    {
        /*if (transform.eulerAngles.z != 0)
        {*/
            transform.Rotate(new Vector3(0f, 0f, 90f));
        //}
        /*else if (transform.eulerAngles.z == 0)
        {
            transform.Rotate(new Vector3(0f, 0f, 0f));
        }*/

        if (transform.eulerAngles.z == correctRotation && isPlaced == false /*&& transform.eulerAngles.z == 0*/)
        {
            isPlaced = true;
            GameMan.correctMove();

        }
        else if (isPlaced == true /*&& transform.eulerAngles.z != 0*/)
        {
            isPlaced = false;
            GameMan.wrongMove();
        }
    }


}
