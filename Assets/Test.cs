using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    private void Start()
    {
        int[] array = new int[5];


        array[4] = 715;
        array[3] = 677;
        array[2] = 147;
        array[1] = 362;
        array[0] = 521;
       

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }





}

    void Update()
    {

    }
}