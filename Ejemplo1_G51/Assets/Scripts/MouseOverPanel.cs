using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseOverPanel : MonoBehaviour
{
    public RectTransform panelRojo; // Asigna aqu� tu panel rojo (RectTransform)

    void Update()
    {
        Vector2 localMousePos;

        // Verifica si el mouse est� sobre el panel
        if (RectTransformUtility.RectangleContainsScreenPoint(panelRojo, Input.mousePosition))
        {
            // Convierte a coordenadas locales del panel
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                panelRojo,
                Input.mousePosition,
                null, // o Camera.main si el Canvas est� en Screen Space - Camera
                out localMousePos
            );

            Debug.Log(" Mouse sobre panel rojo. Pos local: " + localMousePos);
        }
    }
}
