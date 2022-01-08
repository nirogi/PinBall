using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour
{
    //スコアをメモする変数を宣言する
    int score = 0;
    //メッセージを受け取る
    void OnScore(int num)
    {

        GameObject gameObject = GameObject.Find("Text");
        //scoreに受け取った値を追加する
        score += num;
        //Textコンポーネントを取得する
        Text scoreText = gameObject.GetComponent<Text>();
        
       
        //scoreをテキストとして表示する
        scoreText.text = score.ToString();
    }
    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "LargeStarTag")
        {
            OnScore(100);
            //確認用
            Debug.Log(score);
        }
        if (target.gameObject.tag == "LargeCloudTag")
        {


            OnScore(50);
           

        }
    }
}