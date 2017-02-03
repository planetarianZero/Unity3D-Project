using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour 
{
    int numEnemies = 3;
    int cupsInTheSink = 4;
    bool shouldContinue = false;

	// Use this for initialization
	void Start () 
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }

        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }

        do
        {
            print("Hello World");

        } while (shouldContinue == true);

        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (string item in strings)
        {
            print(item);
        }
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}
}
