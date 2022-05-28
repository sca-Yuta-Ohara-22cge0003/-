using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour
{
    public float speed = 2;

    public Text scoreText;
    public Text winText;

    public int pickupNomber = 0;

    private Rigidbody rb;

    public GameObject starline1;
    public GameObject starline2;
    public GameObject starline3;
    public GameObject starline4;
    public GameObject starline5;
    public GameObject starline6;
    public GameObject starline7;
    public GameObject starline8;
    public GameObject starline9;
    public GameObject starline10;
    public GameObject starline11;
    public GameObject starline12;
    public GameObject starline13;
    public GameObject starline14;
    public GameObject starline15;
    public GameObject starline16;
    public GameObject starline17;
    public GameObject starline18;
    public GameObject starline19;
    public GameObject starline20;
    public GameObject starline21;
    public GameObject starline22;
    public GameObject starline23;

    public GameObject starlight1;
    public GameObject starlight2;
    public GameObject starlight3;
    public GameObject starlight4;
    public GameObject starlight5;
    public GameObject starlight6;
    public GameObject starlight7;
    public GameObject starlight8;
    public GameObject starlight9;
    public GameObject starlight10;
    public GameObject starlight11;
    public GameObject starlight12;
    public GameObject starlight13;
    public GameObject starlight14;
    public GameObject starlight15;
    public GameObject starlight16;
    public GameObject starlight17;
    public GameObject starlight18;
    public GameObject starlight19;
    public GameObject starlight20;
    public GameObject starlight21;
    public GameObject starlight22;
    public GameObject starlight23;

    public GameObject clearCamera;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();

        scoreText.text = "";
        winText.text = "";

        starline1.SetActive(false);
        starline2.SetActive(false);
        starline3.SetActive(false);
        starline4.SetActive(false);
        starline5.SetActive(false);
        starline6.SetActive(false);
        starline7.SetActive(false);
        starline8.SetActive(false);
        starline9.SetActive(false);
        starline10.SetActive(false);
        starline11.SetActive(false);
        starline12.SetActive(false);
        starline13.SetActive(false);
        starline14.SetActive(false);
        starline15.SetActive(false);
        starline16.SetActive(false);
        starline17.SetActive(false);
        starline18.SetActive(false);
        starline19.SetActive(false);
        starline20.SetActive(false);
        starline21.SetActive(false);
        starline22.SetActive(false);
        starline23.SetActive(false);

        starlight1.SetActive(false);
        starlight2.SetActive(false);
        starlight3.SetActive(false);
        starlight4.SetActive(false);
        starlight5.SetActive(false);
        starlight6.SetActive(false);
        starlight7.SetActive(false);
        starlight8.SetActive(false);
        starlight9.SetActive(false);
        starlight10.SetActive(false);
        starlight11.SetActive(false);
        starlight12.SetActive(false);
        starlight13.SetActive(false);
        starlight14.SetActive(false);
        starlight15.SetActive(false);
        starlight16.SetActive(false);
        starlight17.SetActive(false);
        starlight18.SetActive(false);
        starlight19.SetActive(false);
        starlight20.SetActive(false);
        starlight21.SetActive(false);
        starlight22.SetActive(false);
        starlight23.SetActive(false);

        clearCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //カーソルキーの入力を取得
        var moveHorizontal = Input.GetAxis("Horizontal"); //floatかdoubleのどちらか
        var moveVertical = Input.GetAxis("Vertical"); //floatかdoubleのどちらか

        //カーソルキーの入力に合わせて移動方向を設定
        var movement = new Vector3(moveHorizontal, 0, moveVertical); //vectorは「方向」

        //Rigidbodyに力を与えて玉を動かす
        rb.AddForce(movement * speed);　//AddForce:力を加える,()内は方向と速さ

        if (pickupNomber == 23 && Input.GetKey(KeyCode.Space))
        {
            Application.Quit();
        }
    }

    //玉がオブジェクトをすり抜けた時に呼び出されるメソッド
    private void OnTriggerEnter(Collider other)
    {
        //すり抜けたアイテムが収集アイテムだった場合
        if (other.gameObject.CompareTag("PickUp" + pickupNomber))
        {
            //その収集アイテムを非表示にします
            other.gameObject.SetActive(false);

            pickupNomber++;

            //線を表示
            SetLine();
        }
    }

    void SetLine()
    {
        switch (pickupNomber)
        {
            case 1:
                starlight1.SetActive(true);
                scoreText.text = "エルナト";
                break;

            case 2:
                starlight2.SetActive(true);
                starline1.SetActive(true);
                scoreText.text = "";
                break;

            case 3:
                starlight3.SetActive(true);
                starline2.SetActive(true);
                scoreText.text = "";
                break;

            case 4:
                starlight4.SetActive(true);
                starline3.SetActive(true);
                scoreText.text = "アイン";
                break;

            case 5:
                starlight5.SetActive(true);
                starline4.SetActive(true);
                scoreText.text = "";
                break;

            case 6:
                starlight6.SetActive(true);
                starline5.SetActive(true);
                scoreText.text = "";
                break;

            case 7:
                starlight7.SetActive(true);
                starline6.SetActive(true);
                scoreText.text = "プレアデス星団";
                break;

            case 8:
                starlight8.SetActive(true);
                starline7.SetActive(true);
                scoreText.text = "";
                break;

            case 9:
                starlight9.SetActive(true);
                starline8.SetActive(true);
                scoreText.text = "";
                break;

            case 10:
                starlight10.SetActive(true);
                starline9.SetActive(true);
                scoreText.text = "";
                break;

            case 11:
                starlight11.SetActive(true);
                starline10.SetActive(true);
                scoreText.text = "";
                break;

            case 12:
                starlight12.SetActive(true);
                starline11.SetActive(true);
                scoreText.text = "";
                break;

            case 13:
                starlight13.SetActive(true);
                starline12.SetActive(true);
                scoreText.text = "";
                break;

            case 14:
                starlight14.SetActive(true);
                starline13.SetActive(true);
                scoreText.text = "";
                break;

            case 15:
                starlight15.SetActive(true);
                starline14.SetActive(true);
                scoreText.text = "";
                break;

            case 16:
                starlight16.SetActive(true);
                starline15.SetActive(true);
                scoreText.text = "";
                break;

            case 17:
                starlight17.SetActive(true);
                starline16.SetActive(true);
                scoreText.text = "";
                break;

            case 18:
                starlight18.SetActive(true);
                starline17.SetActive(true);
                scoreText.text = "";
                break;

            case 19:
                starlight19.SetActive(true);
                starline18.SetActive(true);
                scoreText.text = "アルデバラン";
                break;

            case 20:
                starlight20.SetActive(true);
                starline19.SetActive(true);
                scoreText.text = "";
                break;

            case 21:
                starlight21.SetActive(true);
                starline20.SetActive(true);
                scoreText.text = "";
                break;

            case 22:
                starlight22.SetActive(true);
                starline21.SetActive(true);
                scoreText.text = "ヒアデス星団";
                break;

            case 23:
                starlight23.SetActive(true);
                starline22.SetActive(true);
                starline23.SetActive(true);
                scoreText.text = "";

                winText.text = "牡牛座";
                clearCamera.SetActive(true);
                break;
                
            default:
                break;
        }
    }
}
