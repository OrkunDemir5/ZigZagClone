using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallData : MonoBehaviour
{
    [SerializeField] private BallInputContorller ballInputContorller;



    public Vector3 GetBallDirection()
    {
        return ballInputContorller.ballDirection;
    }
}
