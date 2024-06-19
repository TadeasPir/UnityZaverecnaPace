using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// Tøída reprezentující správu skóre v høe a jeho vizuální zobrazení pomocí TextMeshProUGUI.
/// </summary>
public class ScoreManager : MonoBehaviour
{
    /// <summary>
    /// Aktuální hodnota skóre.
    /// </summary>
    public int score = 0;

    /// <summary>
    /// Reference na UI TextMeshProUGUI pro zobrazení skóre.
    /// </summary>
    public TextMeshProUGUI scoreUI;

    /// <summary>
    /// Metoda volaná pøi startu hry, inicializuje zobrazení skóre na UI.
    /// </summary>
    private void Start()
    {
        // Inicializuje zobrazení skóre na základì aktuální hodnoty skóre.
        scoreUI.text = "Skóre: " + score;
    }

    /// <summary>
    /// Metoda pro pøidání bodu k aktuálnímu skóre a aktualizaci zobrazení skóre na UI.
    /// </summary>
    public void Add()
    {
        // Pøidá bod k aktuálnímu skóre.
        score++;

        // Aktualizuje zobrazení skóre na základì nové hodnoty.
        scoreUI.text = "Skóre: " + score;
    }
}
