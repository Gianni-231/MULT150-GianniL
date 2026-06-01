using UnityEngine;
using UnityEngine.SceneManagement;
 
public class scenechanger : MonoBehaviour {
    public void ChangeScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
}
