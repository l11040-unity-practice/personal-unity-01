using UnityEngine;
public enum StatsChangeType
{
    Add,
    Multiple,
    Override
}

[System.Serializable]
public class CharacterStats : MonoBehaviour
{
    public StatsChangeType StatsChangeType;
    [Range(1, 100)] public int maxHealth;
    [Range(1f, 20f)] public float speed;
}
