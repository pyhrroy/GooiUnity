using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerButton : MonoBehaviour
{
    //public int SceneNo = 0;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Button"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}