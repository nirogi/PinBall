using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    int score = 0;

   
    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject GameOverText;

    // Start is called before the first frame update
    void Start()
    {        
        this.GameOverText = GameObject.Find("GameOverText");//�V�[������GameOverText�I�u�W�F�N�g���擾
    }

    // Update is called once per frame
    void Update()
    { 
        if (this.transform.position.z < this.visiblePosZ)//�{�[������ʊO�ɏo���ꍇ
        {
            this.GameOverText.GetComponent<Text>().text = "Game Over";//GameoverText�ɃQ�[���I�[�o��\��            
        }
    }



}
