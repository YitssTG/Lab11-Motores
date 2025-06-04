using UnityEngine;
using UnityEngine.InputSystem;

public class MaterialChangerInput : MonoBehaviour
{
    [SerializeField] private CustomMaterialData[] materialsData;
    private int index = 0;

    public void OnChangeMaterial(InputAction.CallbackContext context)
    {
        if (!context.performed) return;  

        if (materialsData == null || materialsData.Length == 0)
        {
            return;
        }
        index = (index + 1) % materialsData.Length;
        MaterialChangeEvent.OnMaterialChange?.Invoke(materialsData[index]);
    }
}
