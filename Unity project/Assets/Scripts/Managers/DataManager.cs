using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : BaseManager
{

    Dictionary<string, Monster> MonsterData = new Dictionary<string, Monster>();
    Dictionary<string, Weapon> WeaponData = new Dictionary<string, Weapon>();
    Player PlayerData = new Player();

    public override void Clear()
    {
    
    }

    public override void Init()
    {
        
    }
}
