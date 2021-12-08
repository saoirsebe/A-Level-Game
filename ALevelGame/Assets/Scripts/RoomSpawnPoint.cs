using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoomSpawnPoint : MonoBehaviour
{

    public GameObject[] objects;
    private Vector3 transPos;
    private int xCoord;
    private int yCoord;
    private string searchTagDoor;
    private string searchTagWallTile;



    public GameObject s1;
    private RMapGenorator s11;

    void Start()
    {
        
        int locationx = (int)transform.position.x;
        int locationy = (int)transform.position.y;

        int rand = Random.Range(0, objects.Length);
        GameObject obj = Instantiate(objects[rand],transform.position, Quaternion.identity);//Spawns random room from list

        if (s1 != null) 
        {
            searchTagDoor = "Door";
            List<ObjectLocation> doors = new List<ObjectLocation>();
            FindObjectswithTag(searchTagDoor, obj,doors);//Adds Door location of each door to the list doors

            s11=s1.GetComponent<RMapGenorator>();
            Room room = new Room(locationx, locationy, doors);
            s11.AddToRoomsList(room);//Adds room location and list of its doors to roomsList


            searchTagWallTile = "Wall Tile";
            List<ObjectLocation> walls = new List<ObjectLocation>();
            FindObjectswithTag(searchTagWallTile, obj, walls);//Adds Wall location of each Wall to the list walls

        }
    }

    private List<ObjectLocation> FindObjectswithTag(string _tag,GameObject obj, List<ObjectLocation> listToAdd)
    {
        listToAdd.Clear();
        Transform parent = obj.transform;

        GetChildObject(parent, _tag, listToAdd);
        
        return listToAdd;
  
    }

    private List<ObjectLocation> GetChildObject(Transform parent, string _tag, List<ObjectLocation> listToAdd)
    {
        for(int i = 0; i < parent.childCount; i++) //for each child of current room, if game tag == "Door" then add x and y coordinates to the list doors
        {
            Transform child = parent.GetChild(i);
            string tagg = child.tag;
            if (tagg ==_tag)
            {
                transPos = child.position;

                xCoord = (int)transPos.x;
                yCoord = (int)transPos.y;

                listToAdd.Append(new ObjectLocation(xCoord, yCoord, 0));
            }
        }
        return listToAdd;
    }

}
