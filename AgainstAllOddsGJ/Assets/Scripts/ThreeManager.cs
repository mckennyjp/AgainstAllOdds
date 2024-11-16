using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeManager : MonoBehaviour
{
    public static ThreeManager instance;
    int totalDestoyedOdds = 0;
    public GameObject even;

    void Awake()
    {
        instance = this;
    }

    public void OnOddDestroyed(Vector3 lastPosition)
    {
        totalDestoyedOdds++;

        if (totalDestoyedOdds % 2 == 0)
        {
            Instantiate(even, lastPosition, Quaternion.identity);
        }
    }
}