using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 2;

    public Text scoreText;
    public Text winText;

    public int pickupNomber = 1;

    private Rigidbody rb;

    public GameObject starline1;
    public GameObject starline2;
    public GameObject starline3;

    public GameObject starlight1;
    public GameObject starlight2;
    public GameObject starlight3;
    public GameObject starlight4;

    public GameObject clearCamera;

    //public string[] starname = new string[4]{"�{�e�C��","���T���e�B��","�V�����^��","�n�}��"};
    //public int starNomber = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody���擾
        rb = GetComponent<Rigidbody>();

        //UI��������
        //SetCountText();
        winText.text = "";

        starline1.SetActive(false);
        starline2.SetActive(false);
        starline3.SetActive(false);

        starlight1.SetActive(false);
        starlight2.SetActive(false);
        starlight3.SetActive(false);
        starlight4.SetActive(false);

        clearCamera.SetActive(false);
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
            //score = score + 1;

            //����\��
            SetLine();

            //UI�̕\�����X�V
            //SetCountText();

            pickupNomber++;
        }
    }

    void SetLine()
    {
        switch (pickupNomber)
        {
            case 1:
                starlight1.SetActive(true);
                scoreText.text = "�{�e�C��";
                break;

            case 2:
                starlight2.SetActive(true);
                starline1.SetActive(true);
                scoreText.text = "���T���e�B��";
                break;

            case 3:
                starlight3.SetActive(true);
                starline2.SetActive(true);
                scoreText.text = "�V�����^��";
                break;

            case 4:
                starlight4.SetActive(true);
                starline3.SetActive(true);
                scoreText.text = "�n�}��";

                winText.text = "���r��";
                clearCamera.SetActive(true);
                break;

            default:
                break;
        }
    }

    //void SetCountText()
    //{
    //    //�X�R�A�̕\�����X�V
    //    scoreText.text = starname[starNomber];
    //    starNomber++;

    //    //�S�ẴA�C�e�����l�������ꍇ
    //    if (score >= 4)
    //    {
    //        //���U���g�̕\�����X�V
    //        winText.text = "���r��";

    //        clearCamera.SetActive(true);
    //    }
    //}
}
