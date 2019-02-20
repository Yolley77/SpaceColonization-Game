using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trade_2 : MonoBehaviour
{

    [Header("Переменные значения")]
    public float x_sell = 0f;
    public float y_buy = 0f;
    [Header("Кнопки + и -")]
    public Button plus1;
    public Button minus1;
    public Button plus10;
    public Button minus10;
    public Button plus100;
    public Button minus100;
    public Button plus1000;
    public Button minus1000;
    [Header("Кнопки ресурсов")]
    public Button goldbutton;
    public Button crystalbutton;
    public Button fuelbutton;
    [Header("Кнопка трейда")]
    public Button tradebutton;
    [Header("(Тексты) со значением цены")]
    public Text Sellvalue;
    public Text Buyvalue;
    [Header("Player")]
    public GameObject player;
    [Header("Картинки продажи")]
    public GameObject sellgold;
    public GameObject sellcrystals;
    public GameObject sellfuel;
    [Header("Картинки покупаемого")]
    public GameObject buygold;
    public GameObject buycrystals;

    void Start()
    {
        Sellvalue.text = string.Format("{0:0}", x_sell);
        Buyvalue.text = string.Format("{0:0}", y_buy);

        goldbutton.onClick.AddListener(delegate { press_smthbutton(); });
        crystalbutton.onClick.AddListener(delegate { press_smthbutton(); });
        fuelbutton.onClick.AddListener(delegate { press_smthbutton(); });

        plus1.onClick.AddListener(delegate { press_1plus(); });
        minus1.onClick.AddListener(delegate { press_1minus(); });
        plus10.onClick.AddListener(delegate { press_10plus(); });
        minus10.onClick.AddListener(delegate { press_10minus(); });
        plus100.onClick.AddListener(delegate { press_100plus(); });
        minus100.onClick.AddListener(delegate { press_100minus(); });
        plus1000.onClick.AddListener(delegate { press_1000plus(); });
        minus1000.onClick.AddListener(delegate { press_1000minus(); });

        tradebutton.onClick.AddListener(delegate { press_trade(); });
        tradebutton.onClick.AddListener(delegate { press_smthbutton(); });
    }

    void Update()
    {
        if (sellgold.active == true && buygold.active == true)
        {
            y_buy = x_sell;
            if (y_buy > 1000 - player.GetComponent<Player>().money)
            {
                while (y_buy > 1000 - player.GetComponent<Player>().money)
                {
                    x_sell--;
                    y_buy = x_sell;
                }
            }
            Sellvalue.text = string.Format("{0:0}", x_sell);
            Buyvalue.text = string.Format("{0:0}", y_buy);
        }

        if (sellgold.active == true && buycrystals.active == true)
        {
            y_buy = x_sell * 2;
            if (y_buy > 1000 - player.GetComponent<Player>().crystals)
            {
                while (y_buy > 1000 - player.GetComponent<Player>().crystals)
                {
                    x_sell--;
                    y_buy = x_sell * 2;
                }
            }
            Sellvalue.text = string.Format("{0:0}", x_sell);
            Buyvalue.text = string.Format("{0:0}", y_buy);
        }

        //--------------------------------------------------------------//

        if (sellcrystals.active == true && buygold.active == true)
        {
            y_buy = x_sell / 2;
            if (y_buy > 1000 - player.GetComponent<Player>().money)
            {
                while (y_buy > 1000 - player.GetComponent<Player>().money)
                {
                    x_sell--;
                    y_buy = x_sell / 2;
                }
            }
            Sellvalue.text = string.Format("{0:0}", x_sell);
            Buyvalue.text = string.Format("{0:0}", y_buy);
        }

        if (sellcrystals.active == true && buycrystals.active == true)
        {
            y_buy = x_sell;
            if (y_buy > 1000 - player.GetComponent<Player>().crystals)
            {
                while (y_buy > 1000 - player.GetComponent<Player>().crystals)
                {
                    x_sell--;
                    y_buy = x_sell;
                }
            }
            Sellvalue.text = string.Format("{0:0}", x_sell);
            Buyvalue.text = string.Format("{0:0}", y_buy);
        }

        //-------------------------------------------------------------//

        //--------------------------------------------------------------//

        if (sellfuel.active == true && buygold.active == true)
        {
            y_buy = x_sell * 3;
            if (y_buy > 1000 - player.GetComponent<Player>().money)
            {
                while (y_buy > 1000 - player.GetComponent<Player>().money)
                {
                    x_sell--;
                    y_buy = x_sell * 3;
                }
            }
            Sellvalue.text = string.Format("{0:0}", x_sell);
            Buyvalue.text = string.Format("{0:0}", y_buy);
        }

        if (sellfuel.active == true && buycrystals.active == true)
        {
            y_buy = x_sell * 6;
            if (y_buy > 1000 - player.GetComponent<Player>().crystals)
            {
                while (y_buy > 1000 - player.GetComponent<Player>().crystals)
                {
                    x_sell--;
                    y_buy = x_sell * 6;
                }
            }
            Sellvalue.text = string.Format("{0:0}", x_sell);
            Buyvalue.text = string.Format("{0:0}", y_buy);
        }
    }

    //ФУНКЦИИ + И -/////////////////////////////////////////////////////////////////////////////////////////////////////////

    //ДЛЯ 1------------------------------------------

    public void press_1plus()
    {
        if (x_sell + 1 <= player.GetComponent<Player>().money && sellgold.active == true)
        {
            x_sell += 1;
            Sellvalue.text = string.Format("{0:0}", x_sell);
        }

        if (x_sell + 1 <= player.GetComponent<Player>().crystals && sellcrystals.active == true)
        {
            x_sell += 1;
            Sellvalue.text = string.Format("{0:0}", x_sell);
        }

        if (x_sell + 1 <= player.GetComponent<Player>().fuel && sellfuel.active == true)
        {
            x_sell += 1;
            Sellvalue.text = string.Format("{0:0}", x_sell);
        }
    }

    //+++++++++++++++++++++++++++++++

    public void press_1minus()
    {
        if (x_sell >= 1)
        {
            x_sell -= 1;
            Sellvalue.text = string.Format("{0:0}", x_sell);
        }
    }

    //ДЛЯ 10----------------------------------------------------------

    public void press_10plus()
    {
        if (player.GetComponent<Player>().money > x_sell && sellgold.active == true)
        {
            if (x_sell + 10 <= player.GetComponent<Player>().money)
            {
                x_sell += 10;
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
            else
            {
                while (x_sell != player.GetComponent<Player>().money)
                {
                    x_sell++;
                }
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
        }

        //---------------------------------------------------------

        if (player.GetComponent<Player>().crystals > x_sell && sellcrystals.active == true)
        {
            if (x_sell + 10 <= player.GetComponent<Player>().crystals)
            {
                x_sell += 10;
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
            else
            {
                while (x_sell != player.GetComponent<Player>().crystals)
                {
                    x_sell++;
                }
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
        }

        //----------------------------------------------

        //----------------------------------------------

        if (player.GetComponent<Player>().fuel > x_sell && sellfuel.active == true)
        {
            if (x_sell + 10 <= player.GetComponent<Player>().fuel)
            {
                x_sell += 10;
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
            else
            {
                while (x_sell != player.GetComponent<Player>().fuel)
                {
                    x_sell++;
                }
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
        }
    }

    //++++++++++++++++++++++++++++++++++++++++++++++

    public void press_10minus()
    {
        if (x_sell >= 10)
        {
            x_sell -= 10;
            Sellvalue.text = string.Format("{0:0}", x_sell);
        }
        else
        {
            x_sell = 0;
            Sellvalue.text = string.Format("{0:0}", x_sell);
        }
    }

    //ДЛЯ 100-------------------------------------------------

    public void press_100plus()
    {
        if (player.GetComponent<Player>().money > x_sell && sellgold.active == true)
        {
            if (x_sell + 100 <= player.GetComponent<Player>().money)
            {
                x_sell += 100;
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
            else
            {
                while (x_sell != player.GetComponent<Player>().money)
                {
                    x_sell++;
                }
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
        }

        //-------------------------------------------------------------------

        if (player.GetComponent<Player>().crystals > x_sell && sellcrystals.active == true)
        {
            if (x_sell + 100 <= player.GetComponent<Player>().crystals)
            {
                x_sell += 100;
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
            else
            {
                while (x_sell != player.GetComponent<Player>().crystals)
                {
                    x_sell++;
                }
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
        }

        //------------------------------------------------------------

        //------------------------------------------------

        if (player.GetComponent<Player>().fuel > x_sell && sellfuel.active == true)
        {
            if (x_sell + 100 <= player.GetComponent<Player>().fuel)
            {
                x_sell += 100;
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
            else
            {
                while (x_sell != player.GetComponent<Player>().fuel)
                {
                    x_sell++;
                }
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
        }
    }

    //++++++++++++++++++++++++++++++++++++++++++++

    public void press_100minus()
    {
        if (x_sell >= 100)
        {
            x_sell -= 100;
            Sellvalue.text = string.Format("{0:0}", x_sell);
        }
        else
        {
            x_sell = 0;
            Sellvalue.text = string.Format("{0:0}", x_sell);
        }
    }

    //ДЛЯ 1000--------------------------------------------

    public void press_1000plus()
    {
        if (player.GetComponent<Player>().money > x_sell && sellgold.active == true)
        {
            if (x_sell + 1000 <= player.GetComponent<Player>().money)
            {
                x_sell += 1000;
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
            else
            {
                while (x_sell != player.GetComponent<Player>().money)
                {
                    x_sell++;
                }
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
        }

        //------------------------------------------

        if (player.GetComponent<Player>().crystals > x_sell && sellcrystals.active == true)
        {
            if (x_sell + 1000 <= player.GetComponent<Player>().crystals)
            {
                x_sell += 1000;
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
            else
            {
                while (x_sell != player.GetComponent<Player>().crystals)
                {
                    x_sell++;
                }
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
        }

        //---------------------------------------------

        //--------------------------------------------------

        if (player.GetComponent<Player>().fuel > x_sell && sellfuel.active == true)
        {
            if (x_sell + 1000 <= player.GetComponent<Player>().fuel)
            {
                x_sell += 1000;
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
            else
            {
                while (x_sell != player.GetComponent<Player>().fuel)
                {
                    x_sell++;
                }
                Sellvalue.text = string.Format("{0:0}", x_sell);
            }
        }
    }

    //+++++++++++++++++++++++++++++++++++++++++++

    public void press_1000minus()
    {
        if (x_sell >= 1000)
        {
            x_sell -= 1000;
            Sellvalue.text = string.Format("{0:0}", x_sell);
        }
        else
        {
            x_sell = 0;
            Sellvalue.text = string.Format("{0:0}", x_sell);
        }
    }

    //ФУНКЦИЯ ТРЕЙДА/////////////////////////////////////////////////////////////////////////////////////////////

    public void press_trade()
    {
        if (sellgold.active == true)
        {
            player.GetComponent<Player>().money -= x_sell;
        }

        if (sellcrystals.active == true)
        {
            player.GetComponent<Player>().crystals -= x_sell;
        }

        if (sellfuel.active == true)
        {
            player.GetComponent<Player>().fuel -= x_sell;
        }

        //------------------------------------------------------------

        if (buygold.active == true)
        {
            player.GetComponent<Player>().money += y_buy;
        }

        if (buycrystals.active == true)
        {
            player.GetComponent<Player>().crystals += y_buy;
        }
    }

    //ФУНКЦИЯ ОБНУЛЕНИЯ x_sell ПРИ ПЕРЕХОДЕ//////////////////////////////////////

    public void press_smthbutton()
    {
        x_sell = 0;
    }
}
