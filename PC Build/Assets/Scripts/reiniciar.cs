using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class reiniciar : MonoBehaviour
{
    // Start is called before the first frame update
    public void pulsa()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
