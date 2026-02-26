using UnityEngine;

public class BattleCharacterFactory
{
    public BattleCharacter CreateCharacter(CharacterData data)
    {
        return new BattleCharacter();
    }
}
