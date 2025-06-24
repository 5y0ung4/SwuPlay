using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    Camera cam;

    public float minY = 0f;              // 원래 카메라 y 위치
    public float smoothSpeed = 5f;
    public float margin = 0.2f;
    private float velocityY = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.player = GameObject.Find("player");
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        Vector3 camPos = transform.position;

        float cameraHalfHeight = cam.orthographicSize;
        float topVisibleY = camPos.y + cameraHalfHeight - margin;

        float targetY;

        // 플레이어가 화면 최상단보다 위로 나갔을 경우 → 따라 올라감
        if (playerPos.y > topVisibleY)
        {
            targetY = playerPos.y - cameraHalfHeight + margin;
        }
        // 원래 위치보다 높이 올라간 경우 → 원래 위치로 내려옴
        else if (camPos.y > minY)
        {
            targetY = minY;
        }
        else
        {
            targetY = camPos.y;  // 그대로 유지
        }

        float smoothedY = Mathf.SmoothDamp(camPos.y, targetY, ref velocityY, 0.3f);
        transform.position = new Vector3(playerPos.x, smoothedY, camPos.z);
        //if (this.player.transform.position.y > transform.position.y)
        //{
        //    transform.position = new Vector3(playerPos.x, playerPos.y, transform.position.z);
        //}
        //else
        //{
        //    transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z);
        //}

    }
}
