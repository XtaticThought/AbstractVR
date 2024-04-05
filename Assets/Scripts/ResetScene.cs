using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class ResetScene : MonoBehaviour
{
    public bool pointerEnter;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SceneReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void PointerEnter()
    {
        pointerEnter = true;
        Debug.Log("Pointer Enter for Reset Button");
    }

    public void PointerExist()
    {
        pointerEnter = false;
        Debug.Log("Pointer Exit for Reset Button");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneReset();
        }
    }
}
