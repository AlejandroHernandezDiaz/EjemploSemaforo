using System.Threading;
using UnityEngine;

public class SemaforoEnum : MonoBehaviour
{
    public enum EstadoEnumSemaforo
    {
        enRojo,
        enVerde,
        enAmarillo
    }
    [SerializeField] EstadoEnumSemaforo estadoSemaforo = EstadoEnumSemaforo.enRojo;
    float timer = 0.0f;
    private void Start()
    {


    }
    void Update()
    {
        timer += Time.deltaTime;
        switch (estadoSemaforo)
        {
            case EstadoEnumSemaforo.enRojo:
                EjecutarSemaforoRojo();
                break;
        }
    }
    void EjecutarSemaforoRojo()
    {
        if (timer > 10.0f)
        {
            estadoSemaforo = EstadoEnumSemaforo.enVerde;

        }
    }
}
