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
    private void Start()
    {

    }

    // ������ ���� �� ȣ��Ǵ� �Լ�
    public void PlayCoinSound(GameObject coinObject)
    {
        //audioSource.clip = coinClip;  
        // ���� �Ҹ� ���
        audioSource.PlayOneShot(coinClip);

        // ���� �Ҹ� ����� ���� ������ ��ٸ��� �ʰ� ������ ��� �ı�
        Destroy(coinObject);
    }
}