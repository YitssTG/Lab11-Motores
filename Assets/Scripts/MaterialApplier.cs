using UnityEngine;

public class MaterialApplier : MonoBehaviour
{
    [SerializeField] private Renderer _targetRenderer;
    [SerializeField] private CustomMaterialData _materialData;
    private Material _instanceMaterial;

    private void OnEnable()
    {
        MaterialChangeEvent.OnMaterialChange += SetNewMaterialData;
    }

    private void OnDisable()
    {
        MaterialChangeEvent.OnMaterialChange -= SetNewMaterialData;
    }

    private void Start()
    {
        if (_targetRenderer != null)
        {
            _instanceMaterial = new Material(_targetRenderer.sharedMaterial);
            _targetRenderer.material = _instanceMaterial;
            ApplyToExistingMaterial();
        }
    }

    public void ApplyToExistingMaterial()
    {
        if (_instanceMaterial == null || _materialData == null) return;

        _instanceMaterial.color = _materialData.baseColor;
        _instanceMaterial.SetFloat("_Metallic", _materialData.metallic);
        _instanceMaterial.SetFloat("_Glossiness", _materialData.smoothness);
    }

    public void SetNewMaterialData(CustomMaterialData newData)
    {
        _materialData = newData;
        ApplyToExistingMaterial();
    }
}