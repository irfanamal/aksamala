using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject tree;

    private void Awake()
    {
        for (int i=5; i<=95; i+=5)
        {
            Vector3 spawnPosition = new Vector3((float)i, tree.transform.position.y, 5.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (int i = 10; i <= 95; i += 5)
        {
            Vector3 spawnPosition = new Vector3(5.0f, tree.transform.position.y, (float)i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (int i = 10; i <= 95; i += 5)
        {
            Vector3 spawnPosition = new Vector3((float)i, tree.transform.position.y, 95.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (int i = 10; i <= 90; i += 5)
        {
            Vector3 spawnPosition = new Vector3(95.0f, tree.transform.position.y, (float)i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
    }
}
