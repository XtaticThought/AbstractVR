using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InstantiatePrefab : MonoBehaviour
{
    public GameObject grabCube;
    public Transform spawnPoint;
    public bool pointerEnter;
    public void PointerEnter()
    {
        pointerEnter = true;
        Debug.Log("Pointer Enter for Create Button");
    }

    public void PointerExist()
    {
        pointerEnter = false;
        Debug.Log("Pointer Exit for Create Button");
    }

    public void CreateObject()
    {
        Instantiate(grabCube, spawnPoint.position, spawnPoint.rotation);
        Debug.Log("We created something!");
    }


    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.C))
        {
            CreateObject();
        }  
    }
}
