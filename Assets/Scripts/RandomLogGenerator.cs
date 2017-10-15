using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomLogGenerator : MonoBehaviour {
    private static readonly string[] RANDOM_MESSAGES =
    {
        "むかしむかし",
        "ある所に",
        "おじいさんと",
        "おばあさんが",
        "住んでおったそうな",
        "おじいさんは",
        "山へ芝刈りに",
        "おばあさんは",
        "川へ洗濯に",
        "いったそうな"
    };
    private float elapsedTime;

    void Start () {
        elapsedTime = 0.0f;
	}
	
	void Update () {
        elapsedTime += Time.deltaTime;
        if(elapsedTime > 1.0f)
        {
            elapsedTime = 0.0f;
            Debug.Log(RANDOM_MESSAGES[Random.Range(0, RANDOM_MESSAGES.Length-1)]);
        }
	}
}
