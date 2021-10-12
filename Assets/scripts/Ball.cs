using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour

{
    public float speed;
    [SerializeField]
    private Rigidbody2D rb;
    public Ball ball;
    public Rigidbody2D Rb { get => rb; set => rb = value; }
    public Vector3 OrignalPosition { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Launch()
    {


        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
        
        
        
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int x = 6;
        int y = 3;

        if (Random.Range(-1, 1) < 0)
        {
            x = -x; 
        }


        rb.velocity = new Vector2(0, 0);
        transform.position = OrignalPosition;
        rb.velocity = new Vector2(x, y);
    }


}   


        

    
