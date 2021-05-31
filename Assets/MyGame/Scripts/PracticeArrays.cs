﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeArrays : MonoBehaviour
{
    public int[] array1 = new int[4];
    public int[] array2 = { 31, 32, 33, 34, 35, 36, 37 };
    public int[] array3 = new int[4] { 21, 22, 23, 24 };
    public string[] array4 = new string[10];
    public GameObject[] arrayColloredIamgesRed;



    // Start is called before the first frame update
    void Start()
    {
        


        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }


        arrayColloredIamgesRed = GameObject.FindGameObjectsWithTag("RedImage");

        foreach(GameObject elem in arrayColloredIamgesRed)
        {
            Debug.Log(elem.name);
        }
        //for (int i = 0; i < arrayColloredIamgesRed.Length; i++)
        //{
            
        //}

        Debug.Log("Element 0 von array1 hat den Wert " + array1[0]);
        Debug.Log("Element 0 von array2 hat den Wert " + array2[0]);
        Debug.Log("Element 0 von array3 hat den Wert " + array3[0]);
        Debug.Log("Element 0 von array4 hat den Wert " + array4[0]);
        Debug.Log("Name erstes GO: " + arrayColloredIamgesRed[0].name);

        Debug.Log("Das letzte Element von array1 hatt den Wert: " + array1[array1.Length-1]);
        Debug.Log("Das letzte Element von array2 hatt den Wert: " + array2[array2.Length - 1]);
        Debug.Log("Das letzte Element von array3 hatt den Wert: " + array3[array3.Length - 1]);
        Debug.Log("Das letzte Element von array4 hatt den Wert: " + array4[array4.Length - 1]);
        Debug.Log("Name letztes GO: " + arrayColloredIamgesRed[arrayColloredIamgesRed.Length - 1].name);

        PrintElemnts(array4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PrintElemnts(string[] stringArray)
    {
        for (int i = 0; i < stringArray.Length; i++)
        {
            Debug.Log("Eement Nummer: " + i + "hatt den Wert:" + stringArray[i]);
        }



        //Debug.Log("Eement Nummer: " + string.[]);



    }



}
