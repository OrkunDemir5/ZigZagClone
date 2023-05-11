using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallInputContorller : MonoBehaviour
{
    public Vector3 ballDirection;

    public TMP_Text skor_txt;
    public static int skor;
    void Start()
    {
        skor = 0;
        ballDirection = Vector3.left;
        skor_txt.text = skor.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        skor_txt.text = skor.ToString();
        HandBallInput();

    }
    private void HandBallInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeBallDirection();
            scoreArttirma();
        }
    }
    private void ChangeBallDirection()
    {   //sola gidiyor
        if (ballDirection.x == -1)
        {
            ballDirection = Vector3.forward;
        }
        else
        {
            ballDirection = Vector3.left;
        }
    }
    public void scoreArttirma()
    {
        skor += 1;
        skor_txt.text = skor.ToString();
    }
}
