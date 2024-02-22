using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance {  get; private set; }

    public AudioSource audioSource;
    public AudioClip coinClip;

    private void Awake()
    {
        // SoundManager �ν��Ͻ� ����
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // ������ ���� �� ȣ��Ǵ� �Լ�
    public void PlayCoinSound(GameObject coinObject)
    {
        // ���� �Ҹ� ���
        audioSource.PlayOneShot(coinClip);

        // ���� �Ҹ� ����� ���� ������ ��ٸ��� �ʰ� ������ ��� �ı�
        Destroy(coinObject);
    }
    public void PlaySound()
    {
        audioSource.PlayOneShot(coinClip);
    }
}