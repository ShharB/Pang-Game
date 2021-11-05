using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManger : MonoBehaviour
{



    [SerializeField]
    private GameObject hp1, hp2, hp3, hp4;

    [SerializeField]
    private Text pointText;

    [SerializeField]
    private Button backBt;

    [SerializeField]
    private int maxPointForLevel = 63;

    [SerializeField]
    private GameObject youWinUi;


    private void Start()
    {
        GameManger.instance.uIManger = this;
        SetPoint(GameManger.instance.points);
        SetHp(GameManger.instance.hp);

       
    }

    public void SetPoint(int pointNum)
    {
        pointText.text = pointNum.ToString();
        if (maxPointForLevel== pointNum)
        {
            youWinUi.SetActive(true);
        }
    }

    public void SetHp(int hp)
    {
        switch (hp)
        {
            case 4:
                hp1.SetActive(true);
                hp2.SetActive(true);
                hp3.SetActive(true);
                hp4.SetActive(true);
                break;

            case 3:
                hp1.SetActive(true);
                hp2.SetActive(true);
                hp3.SetActive(true);
                hp4.SetActive(false);
                break;

            case 2:
                hp1.SetActive(true);
                hp2.SetActive(true);
                hp3.SetActive(false);
                hp4.SetActive(false);
                break;

            case 1:
                hp1.SetActive(true);
                hp2.SetActive(false);
                hp3.SetActive(false);
                hp4.SetActive(false);
                break;

            case 0:
                hp1.SetActive(false);
                hp2.SetActive(false);
                hp3.SetActive(false);
                hp4.SetActive(false);
                break;

            default:
                break;
        }
    }

    public void GoBackToMain()
    {
        GameManger.instance.DestroyManger();
        Application.LoadLevel("Main");
    }

    public void GoToLevelByName(string lvlName)
    {
        if (lvlName == "Main")
        {
            GoBackToMain();
        }
        else
        {
            Application.LoadLevel(lvlName);
        }
        
    }
   
}
