using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance {  get; private set; }

    public AudioSource audioSource;
    public AudioClip coinClip;

    private void Awake()
    {
        // SoundManager 인스턴스 설정
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // 코인이 먹힐 때 호출되는 함수
    public void PlayCoinSound(GameObject coinObject)
    {
        // 코인 소리 재생
        audioSource.PlayOneShot(coinClip);

        // 코인 소리 재생이 끝날 때까지 기다리지 않고 코인을 즉시 파괴
        Destroy(coinObject);
    }
    public void PlaySound()
    {
        audioSource.PlayOneShot(coinClip);
    }
}