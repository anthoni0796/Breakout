using UnityEngine;

public class Bloque_Invulnerable : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool esInvulnerable = true;
    void Start()
    {
        resistencia = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (esInvulnerable)
        {
            resistencia = 1;
        }
    }
}
