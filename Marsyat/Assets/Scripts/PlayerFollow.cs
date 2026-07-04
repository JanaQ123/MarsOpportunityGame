using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public Transform target; // drag player/rover here
    private float offsetX;
    private float offsetZ;

    void Start()
    {
        if (target == null) return;
        offsetX = transform.position.x - target.position.x;
        offsetZ = transform.position.z - target.position.z;
    }

    void Update()
    {
        if (target == null) return;
        transform.position = new Vector3(target.position.x + offsetX, transform.position.y, target.position.z + offsetZ);
    }
}