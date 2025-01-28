using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;

public class MovingScenes : MonoBehaviour
{
    public void ChangeScenes(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
