using UnityEngine;
using UnityEngine.Events;

public class ScoringZone : MonoBehaviour
{
    //public UnityEvent scoreTrigger;

    ScoreSystem gameScript;

    protected Rigidbody2D _rigidbody;

    void Start()
    {
        gameScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ScoreSystem>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball bal = collision.gameObject.GetComponent<Ball>();
        
        _rigidbody = GetComponent<Rigidbody2D>();
        
        if(bal != null){

            if(_rigidbody.position.x > 0)gameScript.PlayerAdd();
            else gameScript.ComputerAdd();

        }
    }

}
