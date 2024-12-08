using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] private TextMeshProUGUI scoreText;

    private int score;

    void Start()
    {
        //de score waar die mee start
        score = 0;

        //update de score telkens als er iets bij komt
        scoreText.text = "Score: " + score;
    }

   
    public void AddScore(int amount)
    {
        score = score + amount;

        scoreText.text = "Score: " + score;
    }
}
