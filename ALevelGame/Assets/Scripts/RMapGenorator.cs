using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class RMapGenorator : MonoBehaviour
{

    public GameObject[] nodes;
    public List<Room> roomsList = new List<Room>();
    public Room Room;
    public List<ObjectLocation> wallsList = new List<ObjectLocation>();


    public void AddToRoomsList(Room room)
    {
        roomsList.Add(room);

        Debug.Log("p");
   
    }

    public List<Vector2Int> shortestPathCoridors(Vector2Int startPosition, Vector2Int endPosition)
    {
        List<Vector2Int> corridors = new List<Vector2Int>();//List of corridors


        return corridors;

    }


   

    internal void AddToWallsList(List<ObjectLocation> walls)
    {
        foreach (var wallTile in walls)
        {
            wallsList.Add(wallTile);
            Debug.Log(wallTile.x);
        }
        
    }
}

public class Room
{
    float x;
    float y;
    public List<ObjectLocation> doors;

    public Room(float x, float y, List<ObjectLocation> doors)
    {
    }
}

public class ObjectLocation
{
    public float x;
    float y;
    float direction;

    public ObjectLocation(float x, float y, float direction)
    {
    }
}
