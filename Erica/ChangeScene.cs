using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);//Uses the scene manager to load a scene based on the scene ID. The scene ID can be found in File/Build Settings. To implement this script, 
        // drag scenes into the File/Build Settings. I use a button, and in the On Click method, drag in this script attached to an empty gameobject. In the function box, go to Change Scene/ Move to Scene().
        // Type in the number found next to the scene you want to go to in the build settings. 
    }


}
