using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class CharacterData : CustomisationSet
{
   

 

    public int[] currentCharRace;
    public int[] currentCharData;
    public CharacterData(CustomisationGet customisationget)
    {
        currentCharData[0] = skinIndex;
        currentCharData[1] = eyesIndex;
        currentCharData[2] = mouthIndex;
        currentCharData[3] = hairIndex;
        currentCharData[4] = armourIndex;
        currentCharData[5] = clothesIndex;

        
    }
}
