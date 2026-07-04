using UnityEngine;

public class messageFollow : MonoBehaviour
{
    public Transform target; // drag player/rover here
    private float offsetX;
    private float offsetZ;
    private float offsetY;

    void Start()
    {
        if (target == null) return;
        offsetX = transform.position.x - target.position.x;
        offsetZ = transform.position.z - target.position.z;
        offsetY = transform.position.y - target.position.y;

    }

    void Update()
    {
        if (target == null) return;
        transform.position = new Vector3(target.position.x + offsetX, transform.position.y+offsetY, target.position.z + offsetZ);
    }
}