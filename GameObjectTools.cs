using UnityEditor;
using UnityEditor.Experimental.SceneManagement;
using UnityEditor.SceneManagement;
using UnityEngine;

public class GameObjectTools : Editor
{
    [MenuItem("CustomTools/MakeChangesToSelectedGameObject")]
    private static void MakeChangesToSelectedObject()
    {
        if (EditorApplication.isPlaying)
            return;
        GameObject targetGO = Selection.activeGameObject;

        TargetClass targetClass = targetGO.GetComponent<TargetClass>();
        string[] elements = { "bbbb", "aaaaaa", "breangds", "shitwell" };
        targetClass.array = elements;
    }

    [MenuItem("CustomTools/MakeChangesToSelectedPrefab")]
    private static void MakeChangesToSelectedPrefab()
    {
        if (EditorApplication.isPlaying)
            return;

        var prefabAsset = Selection.activeObject;

        //UnityEditor.Undo.RecordObject(gameObject, "descriptive name of this operation");
        var root = PrefabUtility.LoadPrefabContents(AssetDatabase.GetAssetPath(prefabAsset));
        string[] tempArray = null;
        foreach (var comp in root.GetComponentsInChildren<TargetClass>(true))
        {
            tempArray = new string[comp.array.Length];
            for (int i = 0; i < tempArray.Length; i++)
                tempArray[i] = "pppp";
            comp.array = tempArray;
        }

        EditorUtility.SetDirty(root);
        EditorSceneManager.MarkSceneDirty(root.scene);
        string myPath = AssetDatabase.GetAssetPath(prefabAsset);
        PrefabUtility.SaveAsPrefabAsset(root, myPath);
        //UnityEditor.PrefabUtility.RecordPrefabInstancePropertyModifications(gameobject);
        //EditorSceneManager.MarkSceneDirty(PrefabStageUtility.GetPrefabStage(root).scene);
        PrefabUtility.UnloadPrefabContents(root);
    }
}
