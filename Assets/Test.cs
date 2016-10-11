using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int[] array = {11,22,33,44,55};

        for (int i = 0; i < array.Length; i++){

            Debug.Log(array[i]);

        }

        for (int i = array.Length - 1; i >= 0;i--) {

            Debug.Log(array[i]);

        }

    }

    // Update is called once per frame
    void Update () {
	
	}
}
