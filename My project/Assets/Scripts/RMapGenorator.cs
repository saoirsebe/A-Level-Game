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
    private int[,] WeightToMoveArray = new int [50,50];
    public const int maxint = 2147483647;
    public int roomsMade;

    Queue<ObjectLocation> LocationsToVisit = new Queue<ObjectLocation>();
    private Vector3 transPos;
    private int xCoord;
    private int yCoord;
    private int xstart;
    private int ystart;
    private int xend;
    private int yend;
    private bool roomsLeft = true;


    public void AddToRoomsList(Room room)
    {
        roomsList.Add(room);
    }

    public void AddToWallsList(List<ObjectLocation> walls)
    {
        foreach (var wallTile in walls)
        {
            wallsList.Add(wallTile);  
        }
    }

    void Start()
    {
        for (int x = 0; x < 50; x++)
        {
            for (int y = 0; y < 50; y++)
            {
                WeightToMoveArray[x, y] = 1;
            }
        }

        ObjectLocation startRoomObj = new ObjectLocation();
        List<ObjectLocation> doorsn = startRoomObj.doors;
        DoorsInStart(doorsn);

        while (roomsMade==9 & roomsLeft)
        {
            PickStart();
        }
    }

    private PickStart()
    {
        int rand = Random.Range(0, roomsList.Count);
        Room roomSt = roomsList[rand];
        List<ObjectLocation> doorsn = roomSt.doors;

        DoorsInStart(doorsn);
    }

    private DoorsInStart(List<ObjectLocation> doorsn)
    {
        foreach (var door in doorsn)
        {
            PickEnd(< ObjectLocation > door, rand);
            //del door
        }
    }

    private void PickEnd(<ObjectLocation> startDoor , int rand)
    {
        int rand2;
        do
        {
            rand2 = Random.Range(0, roomsList.Count);
        } while (rand2 == rand);

        Room roomEn = roomsList[rand2];
        List<ObjectLocation> doorsn = roomEn.doors;

        int rand3;
        rand3 = Random.Range(0, doorsn.Count);
        ObjectLocation endDoor = doorsn[rand3];

        MakeDistanceFromEndArray(startDoor, endDoor);
    }

    public void MakeWeightToMoveArray()
    {
        foreach (var wall in wallsList)
        {
            int wallx = wall._x;
            int wally = wall._y;
            WeightToMoveArray[wallx, wally] = maxint;
        }
    }


    private void MakeDistanceFromEndArray(<ObjectLocation> startDoor,<ObjectLocation> endDoor)
    {
        
    }

    private (int xstart, int ystart) GetChildObject(Transform parent, string _tag)
    {
        for (int i = 0; i < parent.childCount; i++) //for each child of start room, if game tag == "Door" then return x and y coordinates
        {
            Transform childx = parent.GetChild(i);
            string tagg = childx.tag;
            if (tagg == _tag)
            {
                transPos = childx.position;
                xCoord = (int)transPos.x;
                yCoord = (int)transPos.y;
            }
        }
        return (xCoord, yCoord);
    }
}

public class Room
{
    internal List<ObjectLocation> doors;
    int _x;
    int _y;
    List<ObjectLocation> _doors;

    public Room(int x, int y, List<ObjectLocation> doors)
    {
        _x = x;
        _y = y;
        _doors = doors;
    }
}

public class ObjectLocation
{
    public int _x;
    public int _y;
    int _direction;

    public ObjectLocation(int x, int y, int direction)
    {
        _x = x;
        _y = y;
        _direction = direction;
    }
}



