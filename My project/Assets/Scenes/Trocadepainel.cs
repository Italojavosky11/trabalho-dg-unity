using UnityEngine;

public class Trocadepainel : MonoBehaviour
{
    public GameObject Menugeral;   // Arraste o objeto Menugeral
    public GameObject Jogoplay;    // Arraste o objeto JogoPlay

    void Start()
    {
        // Garante que o menu apareça ao iniciar a cena e o jogo fique escondido
        Menugeral.SetActive(true);
        Jogoplay.SetActive(false);
    }

    public void IrParaJogo()
    {
        Menugeral.SetActive(false); // Esconde o menu
        Jogoplay.SetActive(true);   // Mostra o jogo
    }

   
}
