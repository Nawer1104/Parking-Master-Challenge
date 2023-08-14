using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Transform[] parkingPoints;

    private int index;

    public GameObject vfx;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        index = 0;
    }

    private void Start()
    {
        parkingPoints[index].gameObject.SetActive(true);
    }

    public void NextPoint()
    {
        parkingPoints[index].gameObject.SetActive(false);

        GameObject explosion = Instantiate(vfx, parkingPoints[index].position, parkingPoints[index].rotation);
        Destroy(explosion, .5f);

        index++;

        if (index == parkingPoints.Length)
        {
            index = 0;
        } 

        parkingPoints[index].gameObject.SetActive(true);
    }
}
