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
        //Rigidbodyを取得
        rb = GetComponent<Rigidbody>();

        //UIを初期化
        score = 0;
        SetCountText();
        winText.text = "";
        //gameObject.SetActive(false);
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
            score = score + 1;

            //線を表示
            SetLine();

            //UIの表示を更新
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
        //スコアの表示を更新
        scoreText.text="Count: " + score.ToString();

        //全てのアイテムを獲得した場合
        if (score >= 4)
        {
            //リザルトの表示を更新
            winText.text = "You Win!";
        }
    }
}
