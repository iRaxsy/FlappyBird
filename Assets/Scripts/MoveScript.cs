using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 10);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
