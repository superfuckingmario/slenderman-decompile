using UnityEngine;
using UnityEditor;

// tool made specifically cuz this ver of unity fucking sucks
public class MaterialThingy : EditorWindow {
    Material matA = null;
    Material matB = null;

    [MenuItem("Window/Material Thingy")]
    public static void Init()
    {
        MaterialThingy window = (MaterialThingy)EditorWindow.GetWindow(typeof(MaterialThingy));
    }

    private void OnGUI()
    {
        matA = (Material)EditorGUI.ObjectField(new Rect(3, 3, position.width - 6, 20), "Material A", matA, typeof(Material));
        matB = (Material)EditorGUI.ObjectField(new Rect(3, 23, position.width - 6, 20), "Material B", matB, typeof(Material));
        if (GUI.Button(new Rect(3, 43, position.width - 6, 20), "Copy Shader"))
            matB.shader = matA.shader;
    }
}