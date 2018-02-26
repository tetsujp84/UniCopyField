using UnityEngine;

/// <summary>
/// 基底クラス
/// private, protected, publicのメンバ変数全てをコピーする
/// </summary>
public class Common : MonoBehaviour
{
    [SerializeField] private int intValue;
    [SerializeField] private GameObject objectValue;

    [SerializeField] protected int protectedIntValue;

    public int publicIntValue;
}
