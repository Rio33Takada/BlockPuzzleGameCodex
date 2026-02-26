using System.Collections.Generic;
using UnityEngine;

public class BattleInitializer
{
    public BattleInitializer(GameData data)
    {
        var charaFactory = new BattleCharacterFactory();
        var charaList = new List<BattleCharacter>();
        foreach(var c in data.GetTeamDatas())
        {
            var chara = charaFactory.CreateCharacter(c);
            charaList.Add(chara);
        }



        var fieldGrid = new FieldGrid();
        var boardGrid = new BoardGrid();

        var context = new BattleContext(fieldGrid, boardGrid);
    }
}
