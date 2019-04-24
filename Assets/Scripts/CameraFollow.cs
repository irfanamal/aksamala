using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera mainCamera;
    private Transform playerTransform;
    private float timer;

    // Start is called before the first frame update
    void Awake()
    {
        playerTransform = GetComponent<Transform>();
    }

    void Start()
    {
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 5.0f)
        {
            mainCamera.transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y + 5.0f, playerTransform.position.z - 5.0f);
            mainCamera.transform.rotation = Quaternion.Euler(30.0f, 0.0f, 0.0f);
        }
    }
}
