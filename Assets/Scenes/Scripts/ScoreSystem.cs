using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;
public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private Paddle playerPaddle;
    [SerializeField] private Paddle computerPaddle;
    public TMP_Text playerScoreText;
    public TMP_Text comScoreText;
    public Ball ball;
    private int computerScore;
    private int playerScore;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
            NewGame();
        }
        if(playerScore >= 11)SceneManager.LoadScene("VictoryScene");
        else if(computerScore >= 11)SceneManager.LoadScene("GameOverScene");
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        NewRound();
    }
     
     public void ComputerAdd(){

        computerScore++;

        comScoreText.text = computerScore.ToString();

        NewRound();

    }
    public void PlayerAdd(){
        
        playerScore++;
        
        playerScoreText.text = playerScore.ToString();

        NewRound();

    }
     private void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        computerScore = score;
        comScoreText.text = score.ToString();
    }
     public void NewRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.Start();
        
    }
    /*public void GameOver(){
        if(playerScore >= 1)SceneManager.LoadScene("VictoryScene");
        else if(computerScore >= 1)SceneManager.LoadScene("GameOverScene");
    }*/
}
