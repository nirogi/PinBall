using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour
{
    //�X�R�A����������ϐ���錾����
    int score = 0;
    //���b�Z�[�W���󂯎��
    void OnScore(int num)
    {

        GameObject gameObject = GameObject.Find("Text");
        //score�Ɏ󂯎�����l��ǉ�����
        score += num;
        //Text�R���|�[�l���g���擾����
        Text scoreText = gameObject.GetComponent<Text>();
        
       
        //score���e�L�X�g�Ƃ��ĕ\������
        scoreText.text = score.ToString();
    }
    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "LargeStarTag")
        {
            OnScore(100);
            //�m�F�p
            Debug.Log(score);
        }
        if (target.gameObject.tag == "LargeCloudTag")
        {


            OnScore(50);
           

        }
    }
}