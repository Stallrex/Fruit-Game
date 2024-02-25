using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public List<GameObject> fruits;

    GameObject fruit;
    Rigidbody2D rb;


    int speed = 4;

    bool fruitGenerated = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GenerateFruit();

    }

    // Update is called once per frame
    void Update()
    {
        if(fruitGenerated == true){
            Move();
            if(!fruit.GetComponent<Rigidbody2D>()){
                var newY = transform.position.y - 1.3f;
                
                fruit.transform.position = new Vector2(transform.position.x, newY);
            }
            if(Input.GetKeyDown(KeyCode.Mouse0)){
                if(!fruit.GetComponent<Rigidbody2D>()){
                    fruit.AddComponent<Rigidbody2D>();
                    fruitGenerated = false;
                    rb.velocity = new Vector2(0, 0);
                    rb.angularVelocity = 0;
                }
                Invoke("GenerateFruit", 2);
            }
        }
    }

    void Move(){
        if(fruitGenerated == true){
            var x = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(x * speed, 0);
        }
    }

    void GenerateFruit(){
        var randomZ = Random.Range(0, 360);
        var randomFruit = fruits[Random.Range(0, fruits.Count)];
        fruit = Instantiate(randomFruit, transform.position, Quaternion.Euler(0,0,randomZ));
        fruitGenerated = true;
    }
}
