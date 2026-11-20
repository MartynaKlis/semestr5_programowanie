using UnityEngine;
using UnityEngine.SceneManagement;

public class Portol : MonoBehaviour
{
    [Tooltip(" Level2")]
    [SerializeField] private string nazwaScenyDocelowej = "Level02";

    [Tooltip("Tag obiektu gracza")]
    [SerializeField] private string tagGracza = "Player";


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(tagGracza))
        {
            PrzeniesNaKolejnyPoziom();
        }
    }

    private void PrzeniesNaKolejnyPoziom()
    {
        SceneManager.LoadScene(nazwaScenyDocelowej);
    }
}