using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public int x, y;
    public GameObject playerPrefab;
    void Start()
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                GameObject player = Instantiate(playerPrefab, new Vector3(i, j, 0), Quaternion.identity);
                player.transform.SetParent(transform);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
