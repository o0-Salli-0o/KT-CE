using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class FallingDown : MonoBehaviour
{

    public GameObject waterPlayer;
    public TextMeshProUGUI loserText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            waterPlayer = collision.gameObject;
            loserText.text = waterPlayer.name + " hat verloren";
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
