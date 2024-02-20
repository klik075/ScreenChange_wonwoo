using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource audioSource;
    private int count = 1; //증가할 코인의 수
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>() != null)
        {
            SoundManager.Instance.PlayCoinSound(gameObject);
            GameManager.Instance.AddCoin(count);
            //audioSource.Play();
            //Destroy(this.gameObject);
        }
    }
}
