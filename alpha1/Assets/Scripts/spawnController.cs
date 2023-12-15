using UnityEngine;
using TMPro; // Import TextMeshPro namespace

public class spawnController : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int enemiesPerWave = 5;
    private int currentWave = 0;
    private float delayTimer = 0f;
    private bool waveCompleted = false;

    public TextMeshProUGUI waveNumberText; // Reference to the TextMeshPro Text element

    void Start()
    {
        StartNextWave();
    }

    void Update()
    {
        if (AllEnemiesDead())
        {
            if (!waveCompleted)
            {
                delayTimer += Time.deltaTime;
                if (delayTimer >= 5f) // Change the delay time here
                {
                    StartNextWave();
                    delayTimer = 0f;
                    waveCompleted = true;
                }
            }
        }
        else
        {
            waveCompleted = false;
        }

        UpdateWaveNumberText(); // Update the TextMeshPro Text element with the current wave number
    }

    void StartNextWave()
    {
        currentWave++;
        enemiesPerWave = 1 * currentWave; // Change the multiplier to increase enemy count per wave
        SpawnWave();
    }

    void SpawnWave()
    {
        for (int i = 0; i < enemiesPerWave; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-15f, -20f), 1.5f, Random.Range(1f, 5f));
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }

    bool AllEnemiesDead()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        
        // Check if no enemies exist
        return enemies.Length == 0;
    }

    void UpdateWaveNumberText()
    {
        if (waveNumberText != null)
        {
            waveNumberText.text = "Wave: " + currentWave.ToString(); // Update TextMeshPro Text with the current wave number
        }
    }
}
