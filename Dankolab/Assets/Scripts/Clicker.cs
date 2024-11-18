using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    [SerializeField] private GameObject Money;
    public Transform Spawn;

    private int ClickPower = 1;
    public Text ClickText;

    private int Score = 0;
    public Text ScoreText;

    private int Lvl = 1;
    public Text LvlText;

    private int UpgradeCost = 20;
    public Text UpgradeText;
    public Button UpgradeButton;

    public void Awake()
    {
        UpdUI();
    }

    private void Update()
    {
        if (Score < UpgradeCost)
        {
            UpgradeButton.interactable = false;
        }
        else
        {
            UpgradeButton.interactable = true;
        }
    }

    public void ButtonPress()
    {
        float ang = Random.Range(1f, 180f);
        float dir = Random.Range(-2f, 2f);
        GameObject Throw = Instantiate(Money, Spawn);
        Throw.GetComponent<Rigidbody2D>().velocity = new Vector2(dir, 10f);
        Throw.transform.rotation = Quaternion.AngleAxis(ang + 10f, Vector3.back);
        Score += ClickPower;
        UpdUI();
    }

    public void UpgradePress()
    {
        Score -= UpgradeCost;
        ClickPower += 1;
        Lvl += 1;
        UpgradeCost *= 2;
        UpdUI();
    }

    private void UpdUI()
    {
        ClickText.text = "+" + ClickPower;
        ScoreText.text = Score.ToString();
        LvlText.text = "LV " + Lvl;
        UpgradeText.text = "UPGRADE " + UpgradeCost;
    }
}
