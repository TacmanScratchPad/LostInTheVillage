using UnityEngine;

[CreateAssetMenu(fileName = "New GUN", menuName = "GunStats")]
public class GUN_Stats : ScriptableObject
{
    public int Range = 30;
    public int Damage = 50;
    public int MagazineAMMO = 30;
    public float ReloadTime = 3f;
    public int impactForce = 150;
    public int fireRate = 10;

    public AudioClip shoot;
    public AudioClip ReloadSound;
    public AudioClip headshoot;
}
