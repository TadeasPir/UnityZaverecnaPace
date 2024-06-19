using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// T��da reprezentuj�c� spr�vu sk�re v h�e a jeho vizu�ln� zobrazen� pomoc� TextMeshProUGUI.
/// </summary>
public class ScoreManager : MonoBehaviour
{
    /// <summary>
    /// Aktu�ln� hodnota sk�re.
    /// </summary>
    public int score = 0;

    /// <summary>
    /// Reference na UI TextMeshProUGUI pro zobrazen� sk�re.
    /// </summary>
    public TextMeshProUGUI scoreUI;

    /// <summary>
    /// Metoda volan� p�i startu hry, inicializuje zobrazen� sk�re na UI.
    /// </summary>
    private void Start()
    {
        // Inicializuje zobrazen� sk�re na z�klad� aktu�ln� hodnoty sk�re.
        scoreUI.text = "Sk�re: " + score;
    }

    /// <summary>
    /// Metoda pro p�id�n� bodu k aktu�ln�mu sk�re a aktualizaci zobrazen� sk�re na UI.
    /// </summary>
    public void Add()
    {
        // P�id� bod k aktu�ln�mu sk�re.
        score++;

        // Aktualizuje zobrazen� sk�re na z�klad� nov� hodnoty.
        scoreUI.text = "Sk�re: " + score;
    }
}
