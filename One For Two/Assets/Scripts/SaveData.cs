using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    
  public bool[] levelsCompleted;

    public SaveData(int numberOfLevels)
    {
        levelsCompleted = new bool[numberOfLevels];
    }
}
