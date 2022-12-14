using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Texts : MonoBehaviour
{
    public Enemy Enemy;
    public EnemyMove EnemyMove;

    public TMP_Text wavesText;
    public TMP_Text enemyText;

    private void Awake()
    {
        wavesText.enabled = false;
        enemyText.enabled = false;
    }
    void Update()
    {
        if (Enemy.wavesLeft == 0)
        {
            wavesText.SetText("Last Wave!");
            enemyText.SetText("Enemies Left: " + Enemy.enemies.Count);
        }
        else
        {
            wavesText.SetText("Waves Left: " + Enemy.wavesLeft);
            enemyText.SetText("Enemies Left: " + Enemy.enemies.Count);
        }
    }
}