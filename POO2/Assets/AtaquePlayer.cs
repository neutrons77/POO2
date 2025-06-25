using UnityEngine;

public class AtaquePlayer : MonoBehaviour
{
    public Personagem personagem;  

    public int AtaqueDoPersonagem()
    {
        if (personagem == null)
        {
            Debug.LogError("ujgvfruhyv");
            return 0; 
        }

        return personagem.Forca_Ataque();
    }
}