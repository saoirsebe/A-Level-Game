using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoomSpawnPoint : MonoBehaviour
{
    RMapGenorator s1;

    public GameObject[] objects;
    void Start()
    {
        int rand = Random.Range(0, objects.Length);

        Instantiate(objects[rand],transform.position, Quaternion.identity);

    }

    IEnumerator start()
    {
        s1 = GetComponent<RMapGenorator>();
        s1.roomsList.Append(new Room());

        yield return new WaitForEndOfFrame();
    }
    

}
