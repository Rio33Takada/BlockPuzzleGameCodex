using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Scriptable Objects/CharacterData")]
public class CharacterData : ScriptableObject
{
    [SerializeField] private int id;
    [SerializeField] private string charaName;
    [SerializeField] private Sprite charaIcon;
    [SerializeField] private int hp;
    [SerializeField] private int attack;
}
