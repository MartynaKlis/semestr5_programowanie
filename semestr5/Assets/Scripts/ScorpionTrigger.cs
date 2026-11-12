using System.Collections;
using Unity.Cinemachine;
using UnityEngine;

public class ScorpionTrigger : MonoBehaviour
{
    AudioSource m_AudioSource;
    int value = 1;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       


        if (collision.CompareTag("Player"))
        {
            PlayerController player =collision.GetComponentInParent<PlayerController>();
            if (player == null) return;
            player.AddPoints(value);
            m_AudioSource.Play();
            StartCoroutine("Delay");
        }


    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
