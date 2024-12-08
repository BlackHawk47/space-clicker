using UnityEngine;

public class Ship : MonoBehaviour
{

    [SerializeField] private float speedX;

    [SerializeField] private float resetXPosition;

    private float shipWidth;

    private GameManager game;

    [SerializeField] int scoreAmount;
   
    
    void Start()
    {
        game = FindFirstObjectByType<GameManager>();

       shipWidth = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    //laat het vliegen
    void Update()
    {
         transform.position = transform.position + new Vector3(speedX * Time.deltaTime, 0f, 0f);
         
         if(transform.position.x + (shipWidth / 2f) < 0)
         {

            transform.position = new Vector3(resetXPosition, transform.position.y, transform.position.z);
         }

    }
    //zorgt er voor dat je er op kan klikken en er dan punten bij komen
    private void OnMouseDown()
    {
        float randomYPosition = Random.Range(-4, 4);
        transform.position = new Vector3(resetXPosition, randomYPosition, transform.position.z);

        game.AddScore(scoreAmount);
    }
}
