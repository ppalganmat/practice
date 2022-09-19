using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    public float GameDuration;
    public GameObject timerGO;
    void Start()
    {
        StartCoroutine(delayedHelloWorld());
    }

    // Update is called once per frame
    void Update()
    {
        timerGO.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameDuration + "";
    }
    private void FixedUpdate()
    {
        GameDuration -= Time.deltaTime; 
    }

    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }

    IEnumerator delayedHelloWorld(){
        yield return new WaitForSeconds(5f);
        Debug.Log("delayed message");
    }
}
