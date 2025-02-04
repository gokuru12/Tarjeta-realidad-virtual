using UnityEngine;
using System.Collections;

public class ClickLink : MonoBehaviour
{
    [SerializeField] string link;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown()
    {
         Application.OpenURL(link);
    }

}
