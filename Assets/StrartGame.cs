using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StrartGame : MonoBehaviour
{
 
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("katamarimap");
    }
  
}
