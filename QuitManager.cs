using UnityEngine;

public class QuitManager : MonoBehaviour {
    public void QuitGame() {
        Debug.Log("Quitter"); // Pour vérifier dans la console
        Application.Quit(); 
    }
}