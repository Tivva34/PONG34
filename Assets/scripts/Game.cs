using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
   

    public int Player1Score;
    public int Player2Score;
   
    public TMP_Text Player1ScoreUI;
    public TMP_Text Player2ScoreUI;

    

    private void Start(int Player1Score, int Player2Score)
    {
       Player1ScoreUI.text = Player1Score.ToString();
        Player2ScoreUI.text = Player2Score.ToString();
    }
    public void Player1Scored()
    {
        Player1Score++;
        Player1ScoreUI.text = Player1Score.ToString();
        print("Player 1 scored!");
    }
    public void Player2Scored()
    {
        Player2Score++;
        Player2ScoreUI.text = Player2Score.ToString();
        print("Player 2 scored!");
        
    }



}
   
