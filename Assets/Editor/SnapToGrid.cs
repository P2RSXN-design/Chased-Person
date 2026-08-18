using UnityEngine;
using UnityEditor;

public class SnapToGrid : MonoBehaviour
{
    [MenuItem("Tools/Snap Selected to Grid %g")] // Ctrl+G 단축키 할당
    static void SnapSelected()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Vector3 pos = obj.transform.position;
            pos.x = Mathf.Round(pos.x);
            pos.y = Mathf.Round(pos.y); // 필요에 따라 0으로 고정 가능
            pos.z = Mathf.Round(pos.z);
            obj.transform.position = pos;

            Vector3 rot = obj.transform.eulerAngles;
            rot.x = Mathf.Round(rot.x / 90f) * 90f; // 90도 단위 직각 회전 스냅
            rot.y = Mathf.Round(rot.y / 90f) * 90f;
            rot.z = Mathf.Round(rot.z / 90f) * 90f;
            obj.transform.eulerAngles = rot;
        }
    }
}