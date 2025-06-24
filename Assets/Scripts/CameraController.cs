using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    Camera cam;

    public float minY = 0f;              // ���� ī�޶� y ��ġ
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

        // �÷��̾ ȭ�� �ֻ�ܺ��� ���� ������ ��� �� ���� �ö�
        if (playerPos.y > topVisibleY)
        {
            targetY = playerPos.y - cameraHalfHeight + margin;
        }
        // ���� ��ġ���� ���� �ö� ��� �� ���� ��ġ�� ������
        else if (camPos.y > minY)
        {
            targetY = minY;
        }
        else
        {
            targetY = camPos.y;  // �״�� ����
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
