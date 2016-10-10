using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {

        int[] array = {3124,23424,5451234,134,4125,51,5451};

        for (int i = array.Length - 1; i >= 0;i--) {


            Debug.Log(array[i]);

        }

    }

    // Update is called once per frame
    void Update () {
	
	}
}
