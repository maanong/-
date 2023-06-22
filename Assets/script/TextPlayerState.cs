using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextPlayerState : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textPlayerHP;
    [SerializeField]
    private TextMeshProUGUI textPlayerGold;
    [SerializeField]
    private TextMeshProUGUI textWave;
    [SerializeField]
    private PlayerHP playerHP;
    [SerializeField]
    private PlayerGold playerGold;
    [SerializeField]
    private WaveSystem WaveSystem;

    private void Update()
    {
        textPlayerHP.text = "X" + playerHP.CurrentHP;
        textPlayerGold.text = playerGold.CurrentGold.ToString() + "G";
        textWave.text = "Wave" + WaveSystem.CurrentWave;
        if(WaveSystem.CurrentWave == 5)
        {
            textWave.text = "Final Wave";
        }
    }
}
