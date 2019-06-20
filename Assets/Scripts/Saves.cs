using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class Saves  {

	public static void SaveData(Player Player)
    {
        //binary formatter
        BinaryFormatter formatter = new BinaryFormatter();
        //save path
        string path = Application.persistentDataPath + "/" + Player.name + "";
        //file stream
        FileStream stream = new FileStream(path, FileMode.Create);
        // data
        Data Data = new Data(Player);
        //convert to binary and save to path
        formatter.Serialize(stream, Data);
        //and
        stream.Close();
    }
    public static Data LoadData(Player Player)
    {
        //have a path.. 
        string path = Application.persistentDataPath + "/" + Player.name + "";
        //check if the path exists
        if (File.Exists(path))
        {


            //formatter
            BinaryFormatter formatter = new BinaryFormatter();
            //stream open
            FileStream stream = new FileStream(path, FileMode.Open);
            // data deserialize
            Data data = formatter.Deserialize(stream) as Data;
            //rnd
            stream.Close();
            //return
            return data;
        }
        //else
        else
        {


            //debug error
            Debug.Log("No Path Found");
            //return null
            return null;
        }
    }

}
