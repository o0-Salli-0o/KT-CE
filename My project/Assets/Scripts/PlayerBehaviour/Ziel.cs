using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Ziel : MonoBehaviour
{

    public GameObject winner;
    public TextMeshProUGUI winnerText;

      
    // Start is called before the first frame update
    void Start()
    {
        //winnerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            winner = collision.gameObject;
            winnerText.text = winner.name + " hat gewonnen!";
            Debug.Log(winner.name + " hat gewonnen!");
            StartCoroutine(Restart());
        }
    }

    // um den Restart des Spiels um 3 Sekunden zu verzögern
    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

