using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

/// <summary>
/// メンバ変数のコピーを行う
/// EditorWindowでコピー元とコピー先のコンポーネントを指定する
/// </summary>
public class UniCopyField : EditorWindow
{
    private UnityEngine.Object fromObj;
    private UnityEngine.Object toObj;

    [MenuItem("Window/ComponentFieldCopyer")]
    private static void OpenWindow()
    {
        EditorWindow.GetWindow<UniCopyField>("ComponentFieldCopyer");
    }

    void OnGUI()
    {
        fromObj = EditorGUILayout.ObjectField("From", fromObj, typeof(UnityEngine.Object), true);
        toObj = EditorGUILayout.ObjectField("To", toObj, typeof(UnityEngine.Object), true);

        if(GUILayout.Button("Copy")) {
            copy(fromObj.GetType());
        }
    }

    private void copy(Type fromType)
    {
        if(fromType == typeof(MonoBehaviour)) return;
        foreach(var from in fromType.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)) {
            var other = fromType.GetField(from.Name, BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
            if((other != null)) {
                other.SetValue(toObj, from.GetValue(fromObj));
            }
        }
        // fromの親クラスからコピー
        copy(fromType.BaseType);
    }
}