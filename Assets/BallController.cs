using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    int score = 0;

   
    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject GameOverText;

    // Start is called before the first frame update
    void Start()
    {        
        this.GameOverText = GameObject.Find("GameOverText");//シーン中のGameOverTextオブジェクトを取得
    }

    // Update is called once per frame
    void Update()
    { 
        if (this.transform.position.z < this.visiblePosZ)//ボールが画面外に出た場合
        {
            this.GameOverText.GetComponent<Text>().text = "Game Over";//GameoverTextにゲームオーバを表示            
        }
    }



}
