using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject tree;
    public GameObject crystal;
    public GameObject orb;

    private void Awake()
    {
        //Innest boundary
        for (float i = 7.5f; i <= 92.5f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 7.5f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 12.5f; i <= 92.5f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(7.5f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 12.5f; i <= 92.5f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 92.5f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 12.5f; i <= 92.5f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(92.5f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }

        //Inner boundary
        for (float i = 5.0f; i <= 95.0f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 5.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 10.0f; i <= 95.0f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(5.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 10.0f; i <= 95.0f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 95.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 10.0f; i <= 90.0f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(95.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }

        //OuterBoundary
        for (float i = 2.5f; i<= 97.5f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 2.5f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 7.5f; i <= 97.5f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(97.5f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 7.5f; i <= 97.5f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 97.5f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 7.5f; i <= 97.5f; i += 5.0f)
        {
            Vector3 spawnPosition = new Vector3(2.5f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }

        //Northwest crystal
        for (float i = 40.0f; i <= 46.0f; i += 2.0f)
        {
            Vector3 spawnPosition = new Vector3(i, crystal.transform.position.y, 60.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(crystal, spawnPosition, spawnRotation);
        }
        for (float i = 54.0f; i <= 58.0f; i += 2.0f)
        {
            Vector3 spawnPosition = new Vector3(40.0f, crystal.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(crystal, spawnPosition, spawnRotation);
        }

        //Northeast crystal
        for (float i = 54.0f; i <= 60.0f; i += 2.0f)
        {
            Vector3 spawnPosition = new Vector3(i, crystal.transform.position.y, 60.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(crystal, spawnPosition, spawnRotation);
        }
        for (float i = 54.0f; i <= 58.0f; i += 2.0f)
        {
            Vector3 spawnPosition = new Vector3(60.0f, crystal.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(crystal, spawnPosition, spawnRotation);
        }

        //Southwest crystal
        for (float i = 40.0f; i <= 46.0f; i += 2.0f)
        {
            Vector3 spawnPosition = new Vector3(i, crystal.transform.position.y, 40.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(crystal, spawnPosition, spawnRotation);
        }
        for (float i = 42.0f; i <= 46.0f; i += 2.0f)
        {
            Vector3 spawnPosition = new Vector3(40.0f, crystal.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(crystal, spawnPosition, spawnRotation);
        }

        //Southeast crystal
        for (float i = 54.0f; i <= 60.0f; i += 2.0f)
        {
            Vector3 spawnPosition = new Vector3(i, crystal.transform.position.y, 40.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(crystal, spawnPosition, spawnRotation);
        }
        for (float i = 42.0f; i <= 46.0f; i += 2.0f)
        {
            Vector3 spawnPosition = new Vector3(60.0f, crystal.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(crystal, spawnPosition, spawnRotation);
        }

        //Center crystal
        Vector3 spawnPosition0 = new Vector3(50.0f, crystal.transform.position.y, 50.0f);
        Quaternion spawnRotation0 = Quaternion.identity;
        Instantiate(crystal, spawnPosition0, spawnRotation0);
        for (float i = 46.0f; i <= 54.0f; i += 2.0f)
        {
            if (i != 50.0f)
            {
                Vector3 spawnPosition1 = new Vector3(50.0f, crystal.transform.position.y, i);
                Vector3 spawnPosition2 = new Vector3(i, crystal.transform.position.y, 50.0f);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(crystal, spawnPosition1, spawnRotation);
                Instantiate(crystal, spawnPosition2, spawnRotation);
            }
        }

        /********************Map********************/
        //Part 1
        for (float i = 10.0f; i <= 20.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 70.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 50.0f; i <= 70.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(20.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        //Part 2
        for (float i = 30.0f; i <= 40.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(20.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 22.5f; i <= 30.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 40.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 20.0f; i <= 37.5f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(30.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 20.0f; i <= 27.5f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 20.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        //Part 3
        for (float i = 20.0f; i <= 30.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 80.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 50.0f; i <= 77.5f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(30.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        //Part 4
        for (float i = 62.5f; i <= 90.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(40.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        //Part 5
        for (float i = 20.0f; i <= 30.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(40.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 42.5f; i <= 47.5f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 20.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 10.0f; i <= 30.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(50.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        //Part 6
        for (float i = 50.0f; i <= 60.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 70.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 72.5f; i <= 80.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(50.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 52.5f; i <= 70.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 80.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 82.5f; i <= 90.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(70.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        //Part 7
        for (float i = 60.0f; i <= 70.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(70.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        //Part 8
        for (float i = 60.0f; i <= 70.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 20.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 22.5f; i <= 30.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(60.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 62.5f; i <= 70.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 30.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 32.5f; i <= 50.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(70.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        //Part 9
        for (float i = 60.0f; i <= 80.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(80.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        //Part 10
        for (float i = 80.0f; i <= 90.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(i, tree.transform.position.y, 50.0f);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        for (float i = 40.0f; i <= 47.5f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(80.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }
        //Part 11
        Instantiate(tree, new Vector3(80.0f, tree.transform.position.y, 30.0f), Quaternion.identity);
        //Part 12
        for (float i = 10.0f; i <= 20.0f; i += 2.5f)
        {
            Vector3 spawnPosition = new Vector3(80.0f, tree.transform.position.y, i);
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(tree, spawnPosition, spawnRotation);
        }

        //Orb
        List<Vector2> spawnPos = new List<Vector2>();
        float[] availPos = { 15.0f, 25.0f, 35.0f, 45.0f, 55.0f, 65.0f, 75.0f, 85.0f };
        while (spawnPos.Count < 10)
        {
            float xPos = availPos[Random.Range(0, 8)];
            float yPos = availPos[Random.Range(0, 8)];
            Vector2 orbPos = new Vector2(xPos, yPos);
            if (!spawnPos.Contains(orbPos) && orbPos != new Vector2(15.0f, 15.0f))
            {
                spawnPos.Add(orbPos);
            }
        }
        foreach (Vector2 pos in spawnPos)
        {
            Vector3 spawnPosition = new Vector3(pos.x, 2.0f, pos.y);
            Instantiate(orb, spawnPosition, Quaternion.identity);
        }
    }
}
