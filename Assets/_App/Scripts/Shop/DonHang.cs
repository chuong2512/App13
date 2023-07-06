using System;
using UnityEngine;

[Serializable]
public class DonHang : SanPham
{
    public int donHangID;
}
/// <summary>
/// /////
/// </summary>
[Serializable]
public class SanPham
{
    public int ID;
    public Sprite anh;
    /// <summary>
    /// ////////
    /// </summary>
    [HideInInspector]public Sprite anhHai;
    [HideInInspector]public string thongTin;
    /// <summary>
    /// /////
    /// </summary>
    public string gia;
    /// <summary>
    /// /////
    /// </summary>
    public string name;
}


