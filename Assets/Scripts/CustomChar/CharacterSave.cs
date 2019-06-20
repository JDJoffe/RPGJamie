using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class CharacterSave 
{
    //save
   public static void SaveCharacter(CustomisationGet customisationGet)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/customisationget.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        CharacterData data = new CharacterData(customisationGet);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static CharacterData LoadCharacter ()
    {
        string path = Application.persistentDataPath + "/savecharacter.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            CharacterData data = formatter.Deserialize(stream) as CharacterData;
            stream.Close();
            return data;
        }else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
