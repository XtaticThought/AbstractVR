using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;





public class TeleportToLocation : MonoBehaviour { 

 public Transform teleportCandidate;
 public Transform selector;

    // Start is called before the first frame update
    void Start()
    {
        selector = GameObject.FindGameObjectWithTag("selector").transform;
    }


    public void CreateCandidate(Transform candidate)
    {
        teleportCandidate = candidate;
        selector.position = candidate.position;
    }

    public void NotCandidate()
    {
        teleportCandidate = null;
        selector.position = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
        if(teleportCandidate != null && (Input.GetButton("Fire1")))
        {
            this.gameObject.transform.position = teleportCandidate.position;
            Debug.Log("I moved to " + teleportCandidate.name);
        }
    }
}
