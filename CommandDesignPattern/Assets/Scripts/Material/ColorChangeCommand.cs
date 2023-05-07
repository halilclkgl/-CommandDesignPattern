using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeCommand : ICommand
{
    private GameObject targetObject;
    private List<Material> colorMaterials;
    private Material previousMaterial;

    public ColorChangeCommand(GameObject obj, List<Material> materials)
    {
        targetObject = obj;
        colorMaterials = materials;
    }

    public void Execute()
    {
        // �nceki materyali kaydet
        previousMaterial = targetObject.GetComponent<Renderer>().material;

        // Rastgele bir materyal se�
        Material randomMaterial = colorMaterials[Random.Range(0, colorMaterials.Count)];

        // Se�ilen materyali hedef nesneye uygula
        targetObject.GetComponent<Renderer>().material = randomMaterial;
    }

    public void Undo()
    {
        // �nceki materyali hedef nesneye geri uygula
        targetObject.GetComponent<Renderer>().material = previousMaterial;
    }
}
