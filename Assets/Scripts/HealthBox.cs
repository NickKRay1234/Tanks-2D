using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBox : MonoBehaviour
{
    protected Player player;
    protected UI _ui;
    [SerializeField] private GameObject _healthBox;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(player.GetHealth() <= 25)
            {
                //Debug.Log(player.GetHealth());
                Destroy(_healthBox);
                player.SetHealth(10);
                _ui.UpdateHp(player.GetHealth());
                //Debug.Log(player.GetHealth());
            }
        }
    }

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>(); // ???
        _ui = GameObject.FindGameObjectWithTag("UI").GetComponent<UI>();
    }



}
