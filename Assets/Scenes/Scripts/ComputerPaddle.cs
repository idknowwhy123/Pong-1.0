
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if(this.ball.velocity.x > 0.0f){
            if(this.ball.velocity.y > this.transform.position.y){
                _rigidbody.AddForce(Vector2.up * this.speed);
            }else if(this.ball.velocity.y < this.transform.position.y){
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }else{
            if(_rigidbody.position.y > 0.0f){
                _rigidbody.AddForce(Vector2.down * this.speed);
            }else if(_rigidbody.position.y < 0.0f){
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
