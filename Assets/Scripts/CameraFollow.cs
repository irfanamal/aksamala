using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera mainCamera;
    private Transform playerTransform;
    // Start is called before the first frame update
    void Awake()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.transform.position = new Vector3(playerTransform.position.x + 2.0f, playerTransform.position.y, playerTransform.position.z - 4.0f);
    }
}
