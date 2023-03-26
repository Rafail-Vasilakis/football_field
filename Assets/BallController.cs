using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 10f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
    }
}
