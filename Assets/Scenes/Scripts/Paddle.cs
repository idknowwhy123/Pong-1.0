
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10;
    protected Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void ResetPosition()
    {
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0f);
    }
}
