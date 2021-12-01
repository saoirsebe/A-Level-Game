using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoomSpawnPoint : MonoBehaviour
{
    RMapGenorator s1;

    private List<Door> doors = new List<Door>();

    public GameObject[] objects;
    private List <GameObject> doorsAdd =  new List<GameObject>();
    private Vector3 transPos;
    private int xCoord;
    private int yCoord;
    private string searchTag;

    void Start()
    {
        int rand = Random.Range(0, objects.Length);
        GameObject obj = Instantiate(objects[rand],transform.position, Quaternion.identity);//Spawns random room from list


        if (searchTag != null)
        {
            searchTag = "Door";
            FindObjectswithTag(searchTag,obj);
        }



        foreach (GameObject door in doorsAdd)
        {
            transPos = door.transform.position;

            xCoord = (int)transPos.x;
            yCoord = (int)transPos.y;

            doors.Append(new Door(xCoord, yCoord,0));
        }

        int locationx = (int)transform.position.x;
        int locationy = (int)transform.position.y;

        s1 = GetComponent<RMapGenorator>();
        s1.roomsList.Append(new Room(locationx, locationy, doors));

        Debug.Log("p");

    }

    private void FindObjectswithTag(string _tag,GameObject obj)
    {
        doorsAdd.Clear();
        Transform parent = obj.transform;
        GetChildObject(parent, _tag);
    }

    private void GetChildObject(Transform parent, string _tag)
    {
        for(int i = 0; i < parent.childCount; i++)
        {
            Transform child = parent.GetChild(i);
            if (child.CompareTag(_tag))
            {
                transPos = child.position;

                xCoord = (int)transPos.x;
                yCoord = (int)transPos.y;

                doors.Append(new Door(xCoord, yCoord, 0));
            }
        }
    }

    /*IEnumerator Start()
    {
        int locationx = (int)transform.position.x;
        int locationy = (int)transform.position.y;

        s1 = GetComponent<RMapGenorator>();
        s1.roomsList.Append(new Room (locationx, locationy,doors));

        Debug.Log("p");
       

        yield return new WaitForEndOfFrame();

    }*/
    
    
}
