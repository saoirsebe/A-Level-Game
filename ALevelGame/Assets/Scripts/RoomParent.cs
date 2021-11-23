using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomParent : MonoBehaviour
{
    public GameObject RoomLocation { get; private set; }
    public GameObject RoomNew { get; private set; }

    public GameObject StartRoom;
   
    void Start()
    {
        StartCoroutine(NewRoom());
    }

    IEnumerator NewRoom()
    {
        RoomLocation = GameObject.Find("RoomParent");

        RoomNew = Instantiate(original: StartRoom, transform.position + new Vector3(0, 0, 0), Quaternion.identity);
        RoomNew.transform.parent = transform;

        yield return new WaitForSeconds(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
