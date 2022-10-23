using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Komponent który ma za zadanie usunięcie przeszkód które wylecą poza zakresy kamery.
/// </summary>
[RequireComponent(typeof(BoxCollider2D))]
public class AreaDelete : MonoBehaviour
{
    /// <summary>
    /// OnTriggerExit odpala się tylko jeśli komponent na którym jest AreaDelete, ma także jakiegoś Collidera2D
    /// RequireComponent upewnia nas, że obiekt do którego dodamy AreaDelete, również będzie posiadał BoxCollidera2D
    /// </summary>
    /// <param name="col"></param>
    private void OnTriggerExit2D(Collider2D col)
    {
        // Czasami może się przydarzyć, że obiekt który wyjdzie z triggera nie będzie przeszkodą (np. obiekty UI/kamera)
        // Dlatego musimy się upewnić, że to co chcemy usunąć, jest przeszkodą.
        if (!col.gameObject.CompareTag("Obstacle"))
            return; // Jeśli nie jest, po prostu zwrócmy nic i nie idziemy dalej.
        
        Destroy(col.gameObject); // Jeśli jest, usuńmy Game Object który wyszedł z Triggera.
    }
}