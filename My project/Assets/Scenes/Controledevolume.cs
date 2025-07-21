using UnityEngine;
using UnityEngine.UI;
public class Controledevolume : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider volumeSlider;
    void Start()
    {
        volumeSlider.value = audioSource.volume;
        // Atualiza o volume sempre que o valor do slider muda
        volumeSlider.onValueChanged.AddListener(delegate {
            audioSource.volume = volumeSlider.value;
        });
    }
}