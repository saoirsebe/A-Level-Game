using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RMapGenorator : MonoBehaviour
{

    public GameObject[] nodes;

    /*
    public List<Transform> findShortestPath(Transform start,Transform end)
    {
        nodes = GameObject.FindGameObjectsWithTag("Door");

        List<Transform> result = new List<Transform>();
        Transform node = dijkstrasAlgo(start, end);

        while (node != null)
        {
            result.Add(node);
            Node currentNode = node.GetComponent<Node>();
            node = currentNode.getParentNode();
        }
        //result.Reverse();
        return result;
    }

    private Transform dijkstrasAlgo(Transform start, Transform end)
    {
        double startTime = Time.realtimeSinceStartup;

        List<Transform> unexplored = new List<Transform>(); //unexplored nodes
        foreach (GameObject obj in nodes)
        {
            Node n = obj.GetComponent<Node>();
            if (n.isWalkable())
            {
                n.resetNode();
                unexplored.Add(obj.transform);
            }
        }
        Node startNode = start.GetComponent<Node>();
        startNode.setWeight(0);

        while (unexplored.Count > 0)
        {
            // Sort the explored by their weight in ascending order.
            unexplored.Sort((x, y) => x.GetComponent<Node>().getWeight().CompareTo(y.GetComponent<Node>().getWeight()));

            // Get the lowest weight in unexplored.
            Transform current = unexplored[0];
            unexplored.Remove(current);

            Node currentNode = current.GetComponent<Node>();
            List<Transform> neighbours = currentNode.getNeighbourNode();
            foreach (Transform neighNode in neighbours)
            {

            }

        }*/



    public List<Vector2Int> shortestPathCoridors(Vector2Int startPosition, Vector2Int endPosition)
    {
        List<Vector2Int> corridors = new List<Vector2Int>();//List of corridors

   
        

 


        return corridors;

    }
}

public class Room
{
    int x;
    int y;

    List<Door>doors;
}

public class Door
{
    int x;
    int y;
    int direction;
}
