using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// GroundChecker ma za zadanie sprawdzenia czy dany GameObject obecnie coś dotyka.
/// Zazwyczaj jest to użyte dla graczy (Przykład: Upewnienie się czy gracz może skoczyć tylko gdy dotyka ziemi)
///
/// <para>Użyte w <see cref="Player"/></para>
/// </summary>
[RequireComponent(typeof(BoxCollider2D))]
public class GroundChecker : MonoBehaviour
{
    // SerializeField jest tutaj tylko by okazać ten obiekt w oknie inspektora w edytorze dla debugowania.
    [SerializeField]
    private GameObject _groundObject;

    // Field który ma tylko gettera, sprawdza czy _groundObject istnieje. Jest to jedyny publiczny field w tej klasie.
    public bool IsTouchingGround => _groundObject != null;

    /// <summary>
    /// Trigger sprawdza czy nowy dotknięty obiekt nadaje się na naszą "ziemię"
    /// (wszystkie przeszkody powinny się nadać, oraz nasza "ziemia" jest oznaczona jako przeszkoda)
    /// </summary>
    private void OnTriggerEnter2D(Collider2D col)
    {
        // Jeśli dalej posiadamy ziemię, albo obiekt którego właśnie dotknęliśmy nie jest "przeszkodą" - anulujemy działanie.
        if (_groundObject != null || !col.gameObject.CompareTag("Platform"))
            return;

        // Jeśli nie mieliśmy już ziemi, a nowy obiekt którego dotknęliśmy jest przeszkodą, ustawmy nową ziemię.
        _groundObject = col.gameObject;
    }

    /// <summary>
    /// Jeśli obiekt który właśnie przestał nas dotykać był naszą ziemią - zresetujmy naszą zapisaną zmienną odpowiedzialną
    /// za ziemię. 
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject != _groundObject)
            return;

        _groundObject = null;
    }
}
