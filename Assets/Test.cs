using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
  
 

    void Start () {
        int[] array = { 8, 94, 49, 30, 20 };

        int i, j;

        for (i = 0; i <= 4; i++)
            Debug.Log(array[i]);

        for(j = 4; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }

       

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

