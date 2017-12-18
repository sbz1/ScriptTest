using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
       
        int[]  array = new[] { 1, 2, 3, 4, 5 };
        for (int i = array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
         
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

