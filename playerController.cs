using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    Rigidbody2D bird;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        bird = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
            bird.velocity = new Vector2(0,8.5f);
            score ++;
            scoreText.text = score.ToString();
        }
    }

    void OnCollisionEnter2D() {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }
}
