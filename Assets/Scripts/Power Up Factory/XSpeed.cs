using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XSpeed : PowerUp, PowerUpInterface
{
    public override string PowerUpName => "XSpeedPowerUp";
    public float newSpeed = 12f;
    public float baseSpeed = 6f;

    private void Start()
    {
        gameObject.SetActive(true);
    }
    public void Action(GameObject player)
    {
        player.GetComponent<Player>().XSpeed(newSpeed, baseSpeed);
        gameObject.SetActive(false);
    }
}
