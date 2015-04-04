using UnityEngine;


namespace TangScene
{
  public class CameraBhvr : MonoBehaviour
  {
    void Start()
    {
      GetComponent<Camera>().orthographic = true;
      GetComponent<Camera>().orthographicSize = Screen.height / 2;
    }
  }
}