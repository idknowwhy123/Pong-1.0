
using UnityEngine;

public class PlayerPaddle : Paddle
{
    private Vector2 _direction;

    private Vector3 _rotation;

 
    public void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
            _direction = Vector2.up;
            //_rigidbody.AddForce(_direction * this.speed);
        }else if(Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.DownArrow)){
            _direction = Vector2.down;
            //_rigidbody.AddForce(_direction * this.speed);
        }else if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow)){
           
            transform.Rotate(Vector3.forward,0.5f);
           
        
        }else if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow)){
        
            transform.Rotate(Vector3.back,0.5f);
           
        
        }else{
            _direction = Vector2.zero;
        }
    }
    private void FixedUpdate()
    {
        if(_direction.sqrMagnitude != 0){
            _rigidbody.AddForce(_direction * this.speed);
        }
    }
    public void GoUp(){

        _direction = Vector2.up;
        FixedUpdate();
        _rigidbody.AddForce(_direction * 9.0f);
    }
    public void GoDown(){
        _direction = Vector2.down;
        _rigidbody.AddForce(_direction * 9.0f);
        FixedUpdate();
        
    }
}
