using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsChangeType
{
    Credit,
    Withdraw,
    Default,
}

public class CharacterStat
{
    public StatsChangeType statsChangeType;
    public int balanceMoney;
    public int cashData;

}
