using UnityEngine;

public class Trocadepainel : MonoBehaviour
{
    public GameObject menuGeral;   // Arraste o objeto Menugeral
    public GameObject jogoPlay;    // Arraste o objeto JogoPlay

    public void IrParaJogo()
    {
        menuGeral.SetActive(false); // Esconde o menu
        jogoPlay.SetActive(true);   // Mostra o jogo
    }

    public void VoltarParaMenu()
    {
        jogoPlay.SetActive(false);  // Esconde o jogo
        menuGeral.SetActive(true);  // Mostra o menu
    }
}
