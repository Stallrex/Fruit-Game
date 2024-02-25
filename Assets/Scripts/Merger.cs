using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Merger : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip pop;

    public static int fruit_score;

    Vector2 fruitPos;
    public GameObject strawberry;
    public GameObject grape;
    public GameObject orange;
    public GameObject apple;
    public GameObject tomato;
    public GameObject melon;

    public int endTimer = 0;

    bool createPenging;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D collision){

        if(gameObject.GetComponent<Rigidbody2D>()){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
    //void OnTriggerExit2D(Collider2D collision)
    //{
       // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}

    void OnCollisionEnter2D(Collision2D collision){
    if(gameObject.GetComponent<Rigidbody2D>()){
        var y = transform.position.y + 0.4f;
        fruitPos = new Vector2(transform.position.x, y);
        if(collision.gameObject.CompareTag("Strawberry")){
            if(gameObject.CompareTag("Strawberry")){
                int thisID = gameObject.GetInstanceID();
                int otherID = collision.gameObject.GetInstanceID();

                if(thisID > otherID){
                    CreateFruit(grape);
                    fruit_score += 25;
                }
                Destroy(gameObject);
                }
            }
        if(collision.gameObject.CompareTag("Grape")){
            if(gameObject.CompareTag("Grape")){
                int thisID = gameObject.GetInstanceID();
                int otherID = collision.gameObject.GetInstanceID();

                if(thisID > otherID){
                    CreateFruit(orange);
                    fruit_score += 50;
                }
                Destroy(gameObject);
                }
            }
            if(collision.gameObject.CompareTag("Orange")){
            if(gameObject.CompareTag("Orange")){
                int thisID = gameObject.GetInstanceID();
                int otherID = collision.gameObject.GetInstanceID();

                if(thisID > otherID){
                    CreateFruit(apple);
                    fruit_score += 100;
                }
                Destroy(gameObject);
                }
            }
            if(collision.gameObject.CompareTag("Apple")){
            if(gameObject.CompareTag("Apple")){
                int thisID = gameObject.GetInstanceID();
                int otherID = collision.gameObject.GetInstanceID();

                if(thisID > otherID){
                    CreateFruit(tomato);
                    fruit_score += 150;
                }
                Destroy(gameObject);
                }
            }
            if(collision.gameObject.CompareTag("Tomato")){
            if(gameObject.CompareTag("Tomato")){
                int thisID = gameObject.GetInstanceID();
                int otherID = collision.gameObject.GetInstanceID();

                if(thisID > otherID){
                    CreateFruit(melon);
                    fruit_score += 200;
                }
                Destroy(gameObject);
                }
            }
            if(collision.gameObject.CompareTag("Melon")){
            if(gameObject.CompareTag("Melon")){
                int thisID = gameObject.GetInstanceID();
                int otherID = collision.gameObject.GetInstanceID();

                if(thisID > otherID){
                    fruit_score += 300;
                }
                Destroy(gameObject);
                }
            }
        }
        }
        void CreateFruit(GameObject fruit){
            var newFruit = Instantiate(fruit, fruitPos, Quaternion.Euler(0,0,0));
                if(!newFruit.GetComponent<Rigidbody2D>()){
                    newFruit.AddComponent<Rigidbody2D>();
                }
    }
}
    
