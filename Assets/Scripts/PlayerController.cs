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

    //public string[] starname = new string[4]{"ボテイン","メサルティム","シュラタン","ハマル"};
    //public int starNomber = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();

        //UIを初期化
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
        //カーソルキーの入力を取得
        var moveHorizontal = Input.GetAxis("Horizontal"); //floatかdoubleのどちらか
        var moveVertical = Input.GetAxis("Vertical"); //floatかdoubleのどちらか

        //カーソルキーの入力に合わせて移動方向を設定
        var movement = new Vector3(moveHorizontal, 0, moveVertical); //vectorは「方向」

        //Rigidbodyに力を与えて玉を動かす
        rb.AddForce(movement * speed);　//AddForce:力を加える,()内は方向と速さ
    }

    //玉がオブジェクトをすり抜けた時に呼び出されるメソッド
    private void OnTriggerEnter(Collider other)
    {
        //すり抜けたアイテムが収集アイテムだった場合
        if (other.gameObject.CompareTag("PickUp" + pickupNomber))
        {
            //その収集アイテムを非表示にします
            other.gameObject.SetActive(false);

            //スコアを加算
            //score = score + 1;

            //線を表示
            SetLine();

            //UIの表示を更新
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
                scoreText.text = "ボテイン";
                break;

            case 2:
                starlight2.SetActive(true);
                starline1.SetActive(true);
                scoreText.text = "メサルティム";
                break;

            case 3:
                starlight3.SetActive(true);
                starline2.SetActive(true);
                scoreText.text = "シュラタン";
                break;

            case 4:
                starlight4.SetActive(true);
                starline3.SetActive(true);
                scoreText.text = "ハマル";

                winText.text = "牡羊座";
                clearCamera.SetActive(true);
                break;

            default:
                break;
        }
    }

    //void SetCountText()
    //{
    //    //スコアの表示を更新
    //    scoreText.text = starname[starNomber];
    //    starNomber++;

    //    //全てのアイテムを獲得した場合
    //    if (score >= 4)
    //    {
    //        //リザルトの表示を更新
    //        winText.text = "牡羊座";

    //        clearCamera.SetActive(true);
    //    }
    //}
}
