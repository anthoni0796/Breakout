using System;
using UnityEngine;

public class Bola : MonoBehaviour
{
    bool isGameStarted = false;
    [SerializeField] public float VelocidadBola = 10.0f;
    void Start()
    {
        Vector3 posicionInicial = GameObject.FindGameObjectsWithTag("Jugador")[0].transform.position;
        posicionInicial.y += 3;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectsWithTag("Jugador")[0].transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetButton("Submit"))


        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().linearVelocity = VelocidadBola * Vector3.up;
            }
        }
    }
}
