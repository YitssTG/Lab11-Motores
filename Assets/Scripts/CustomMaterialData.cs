using UnityEngine;

[CreateAssetMenu(fileName = "NewMaterialData", menuName = "Custom/Material Data")]
public class CustomMaterialData : ScriptableObject
{
    public Color baseColor;
    [Range(0f, 1f)] public float metallic;
    [Range(0f, 1f)] public float smoothness;
}