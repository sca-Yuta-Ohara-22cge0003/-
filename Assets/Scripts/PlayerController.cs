using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 2;

    public Text scoreText;
    public Text winText;

    private Rigidbody rb;
    public int score;

    public int pickupNomber = 1;
    public GameObject line;
    public int lineNomber = 1;

    //public string[] star = new string[] = {}

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody���擾
        rb = GetComponent<Rigidbody>();

        //UI��������
        score = 0;
        SetCountText();
        winText.text = "";
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //�J�[�\���L�[�̓��͂��擾
        var moveHorizontal = Input.GetAxis("Horizontal"); //float��double�̂ǂ��炩
        var moveVertical = Input.GetAxis("Vertical"); //float��double�̂ǂ��炩

        //�J�[�\���L�[�̓��͂ɍ��킹�Ĉړ�������ݒ�
        var movement = new Vector3(moveHorizontal, 0, moveVertical); //vector�́u�����v

        //Rigidbody�ɗ͂�^���ċʂ𓮂���
        rb.AddForce(movement * speed);�@//AddForce:�͂�������,()���͕����Ƒ���
    }

    //�ʂ��I�u�W�F�N�g�����蔲�������ɌĂяo����郁�\�b�h
    private void OnTriggerEnter(Collider other)
    {
        //���蔲�����A�C�e�������W�A�C�e���������ꍇ
        if (other.gameObject.CompareTag("PickUp" + pickupNomber))
        {
            //���̎��W�A�C�e�����\���ɂ��܂�
            other.gameObject.SetActive(false);

            //�X�R�A�����Z
            score = score + 1;

            //����\��
            SetLine();

            //UI�̕\�����X�V
            SetCountText();

            pickupNomber++;
        }
    }

    private void SetLine()
    {
        if (pickupNomber >= 2)
        {
            line = GameObject.Find("StarLine" + lineNomber);
            line.gameObject.SetActive(true);
            lineNomber++;
        }
    }

    void SetCountText()
    {
        //�X�R�A�̕\�����X�V
        scoreText.text="Count: " + score.ToString();

        //�S�ẴA�C�e�����l�������ꍇ
        if (score >= 4)
        {
            //���U���g�̕\�����X�V
            winText.text = "You Win!";
        }
    }
}
