using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public int counter;

    public TextMeshProUGUI score;
    public TextMeshProUGUI best_score;
    public int maxscore;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("highscore")){
            maxscore = PlayerPrefs.GetInt("highscore");
            best_score.text = $"{maxscore.ToString()}";
        } 
    }

    // Update is called once per frame
    void Update()
    {
        counter = Merger.fruit_score;
        score.text = counter.ToString();
        Best_Score();
    }
    void Best_Score(){
        if(counter > maxscore){
            maxscore = counter;
            PlayerPrefs.SetInt("highscore", maxscore);
            PlayerPrefs.Save();
            best_score.text = $"{maxscore.ToString()}";
        }
        
    }
}
