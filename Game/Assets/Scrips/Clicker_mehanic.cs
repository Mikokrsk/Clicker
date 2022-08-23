using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class Clicker_mehanic : MonoBehaviour
{
    public int money = 0;
    public Text money_score;
    public Text text_click_x1;
    public Text total_money_score;
    public int click_x1 = 1;
    public int total_money;
    // Start is called before the first frame update
    public bool get_10_money ;
    public bool get_100_money;
    public bool get_1000_money;
    // Start is called before the first frame update
    public void Start()
    {
      // click_x1 = 1;
        money = PlayerPrefs.GetInt("money");
        click_x1 = PlayerPrefs.GetInt("click_x1");
       total_money = PlayerPrefs.GetInt("total_money");
        //if(click_x1<=0)
        //{
        //  click_x1 = 1;
        //}
        // PlayerPrefs.SetInt("click_x1", click_x1);
        StartCoroutine(IdleFarm());
    }
    public void Click_Cookie()
    {
        money += click_x1;
        total_money += click_x1;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("total_money", total_money);
    }
    public void Click_X1(int click_X)
    {

        click_x1 += click_X;
     PlayerPrefs.SetInt("click_x1", click_x1);
    }

        public void ToAchivments()
    {
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("click_x1", click_x1);
        SceneManager.LoadScene(1);
         
    }
    public void ToSettings()
    {
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("click_x1", click_x1);
        SceneManager.LoadScene(2);

    }
    public void Clear()
    {
        money = 0;
        click_x1 = 1;
        total_money = 0;
        get_10_money = false;
        get_100_money = false;
        get_1000_money = false;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("click_x1", click_x1);
        PlayerPrefs.SetInt("total_money", total_money);
        PlayerPrefs.SetInt("get_10_money", get_10_money ? 1 : 0);
        PlayerPrefs.SetInt("get_100_money", get_10_money ? 1 : 0);
        PlayerPrefs.SetInt("get_1000_money", get_10_money ? 1 : 0);
    }
    // Update is called once per frame
    void Update()
    {
        money_score.text = money.ToString();
        text_click_x1.text = click_x1.ToString();
        total_money_score.text = total_money.ToString();
    }
    IEnumerator IdleFarm()
    {
        yield return new WaitForSeconds(1);
        money += 1;
        total_money += 1;
        PlayerPrefs.SetInt("money", money);
        PlayerPrefs.SetInt("total_money", total_money);
        StartCoroutine(IdleFarm());
    }
}
