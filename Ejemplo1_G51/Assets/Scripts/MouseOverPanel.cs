using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseOverPanel : MonoBehaviour
{
    public RectTransform panelRojo; // Asigna aquí tu panel rojo (RectTransform)

    void Update()
    {
        Vector2 localMousePos;

        // Verifica si el mouse está sobre el panel
        if (RectTransformUtility.RectangleContainsScreenPoint(panelRojo, Input.mousePosition))
        {
            // Convierte a coordenadas locales del panel
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                panelRojo,
                Input.mousePosition,
                null, // o Camera.main si el Canvas está en Screen Space - Camera
                out localMousePos
            );

            Debug.Log(" Mouse sobre panel rojo. Pos local: " + localMousePos);
        }
    }
}
