using Sirenix.OdinInspector;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SanphamSO", order = 1)]
public class SanPhamSO : ScriptableObject
{
  

    public SanPham GetSanPhamWithID(int id)
    {
        return SanPham[id];
    }
    
    [InlineProperty]public SanPham[] SanPham;

    [Button]
    public void SetID()
    {
        for (int i = 0; i < SanPham.Length; i++)
        {
            SanPham[i].ID = i;
        }
    }s
}