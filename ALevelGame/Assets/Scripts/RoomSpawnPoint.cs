using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawnPoint : MonoBehaviour
{
   // public GameObject RoomLocation { get; private set; }
    //public GameObject RoomNew { get; private set; }

    //public GameObject StartRoom;

    public GameObject[] objects;

    void Start()
    {
        int rand = Random.Range(0, objects.Length);

        Instantiate(objects[rand],transform.position, Quaternion.identity);

       // StartCoroutine(NewRoom());
    }

    /* IEnumerator NewRoom()
    {
        RoomLocation = GameObject.Find("RoomParent");

        RoomNew = Instantiate(original: StartRoom, transform.position + new Vector3(0, 0, 0), Quaternion.identity);
        RoomNew.transform.parent = transform;

        yield return new WaitForSeconds(1);
    }*/

    
}
