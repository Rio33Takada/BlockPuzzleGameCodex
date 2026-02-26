using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "Scriptable Objects/GameData")]
public class GameData : ScriptableObject
{
    [SerializeField] private List<CharacterData> teamDatas;

    public List<CharacterData> GetTeamDatas()
    {
        return new List<CharacterData>(teamDatas);
    }
}
