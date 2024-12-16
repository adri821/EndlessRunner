using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    int camaraUtilizada = 0;
    [SerializeField]
    Camera camara1, camara2, camara3;
    // Update se llama en cada frame
    void Update() {
        CambiarCamara();
    }
    // Método para alternar entre las tres cámaras
    void CambiarCamara() {
        if (Input.GetKeyDown(KeyCode.C)) {
            camaraUtilizada++;
            if (camaraUtilizada > 2) camaraUtilizada = 0;
            switch (camaraUtilizada) {
                case 0:
                    camara1.enabled = true;
                    camara2.enabled = false;
                    camara3.enabled = false;
                    break;
                case 1:
                    camara1.enabled = false;
                    camara2.enabled = true;
                    camara3.enabled = false;
                    break;
                case 2:
                    camara1.enabled = false;
                    camara2.enabled = false;
                    camara3.enabled = true;
                    break;
                default:
                    camara1.enabled = true;
                    camara2.enabled = false;
                    camara3.enabled = false;
                    break;
            }
        }
    }
}
