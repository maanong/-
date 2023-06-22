using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName;

    public void OnDie()
    {
        SceneManager.LoadScene(nextSceneName);
        
    }
}
