using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//you will need to change Scenes
public class CustomisationSet : MonoBehaviour
{

    #region Variables
    [Header("Texture List")]
    //Texture2D List for skin,hair, mouth, eyes

    public List<Texture2D> skin = new List<Texture2D>();
    public List<Texture2D> hair = new List<Texture2D>();
    public List<Texture2D> mouth = new List<Texture2D>();
    public List<Texture2D> eyes = new List<Texture2D>();
    public List<Texture2D> armour = new List<Texture2D>();
    public List<Texture2D> clothes = new List<Texture2D>();

    [Header("Index")]
    //index numbers for our current skin, hair, mouth, eyes textures

    public int skinIndex;
    public int hairIndex, mouthIndex, eyesIndex, armourIndex, clothesIndex;
    [Header("Renderer")]
    //renderer for our character mesh so we can reference a material list
    public Renderer character;
    [Header("Max Index")]
    //max amount of skin, hair, mouth, eyes textures that our lists are filling with
    public int skinMax;
    public int hairMax, mouthMax, eyesMax, armourMax, clothesMax;
    [Header("Character Name")]
    //name of our character that the user is making
    public string charName = "Bartholemew Jojo Simpson";
    [Header("Stats")]
    //class enum
    public CharacterClass characterClass;
    public string[] statArray = new string[6];
    public int[] stats = new int[6];
    public int[] statsTemp = new int[6];
    public int points = 10;
    public string[] selectedClass = new string[12];
    public int selectedIndex = 0;
    #endregion

    #region Start
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        statArray = new string[] { "Strength", "Dex builds yuck", "Constitution", "Wisdom", "Intelligence", "Charisma" };
        selectedClass = new string[] { "Borborigan", "Bord", "Cloric", "Drooid", "Foightah", "Moonk", "Poloodoin", "Ronger", "Roogeg", "Soresore_ah", "woolak", "Bizard", };
        //in start we need to set up the following
        #region for loop to pull textures from file
        //for loop looping from 0 to less than the max amount of skin textures we need
        for (int i = 0; i < skinMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for Skin_#
            Texture2D temp = Resources.Load("Character/Skin_" + i.ToString()) as Texture2D;
            //add our temp texture that we just found to the skin List
            skin.Add(temp);
        }
        for (int i = 0; i < eyesMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for eyes_#
            Texture2D temp = Resources.Load("Character/Eyes_" + i.ToString()) as Texture2D;
            //add our temp texture that we just found to the eyes List
            eyes.Add(temp);
        }
        for (int i = 0; i < mouthMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for mouth_#
            Texture2D temp = Resources.Load("Character/Mouth_" + i.ToString()) as Texture2D;
            //add our temp texture that we just found to the mouth List
            mouth.Add(temp);
        }
        for (int i = 0; i < hairMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for hair_#
            Texture2D temp = Resources.Load("Character/Hair_" + i.ToString()) as Texture2D;
            //add our temp texture that we just found to the hair List
            hair.Add(temp);
        }
        for (int i = 0; i < armourMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for armour_#
            Texture2D temp = Resources.Load("Character/Armour_" + i.ToString()) as Texture2D;
            //add our temp texture that we just found to the armour List
            armour.Add(temp);
        }
        for (int i = 0; i < clothesMax; i++)
        {
            //creating a temp Texture2D that it grabs using Resources.Load from the Character File looking for clothes_#
            Texture2D temp = Resources.Load("Character/Clothes_" + i.ToString()) as Texture2D;
            //add our temp texture that we just found to the clothes List
            clothes.Add(temp);
        }
        #endregion

        character = GameObject.Find("Mesh").GetComponent<SkinnedMeshRenderer>();
        SetTexture("skin",skinIndex= 0 );
        SetTexture("eyes", eyesIndex= 0);
        SetTexture("mouth",mouthIndex= 0);
        SetTexture("hair",hairIndex= 0);
        SetTexture("armour",armourIndex= 0);
        SetTexture("clothes",clothesIndex= 0);

        //connect and find the SkinnedMeshRenderer thats in the scene to the variable we made for Renderer
        #region do this after making the function SetTexture
        //SetTexture skin, hair, mouth, eyes to the first texture 0
        #endregion
        ChooseClass(selectedIndex);
        #endregion
        
    }
    #region SetTexture
    //Create a function that is called SetTexture it should contain a string and int
    void SetTexture(string type, int dir)
    {
        int index = 0, max = 0, matIndex = 0;
        Texture2D[] textures = new Texture2D[0];

        #region Switch Material
        switch (type)
        {
            //case skin
            case "skin":               
                //index is the same as our skin index
                index = skinIndex;
                //max is the same as our skin max
                max = skinMax;
                //textures is our skin list .ToArray()
                textures = skin.ToArray();
                //material index element number is 1
                matIndex = 1;
                break;

            case "eyes":
                
                index = eyesIndex;

                max = eyesMax;


                textures = eyes.ToArray();

                matIndex = 2;
                break;

            case "mouth":
                
                index = mouthIndex;

                max = mouthMax;


                textures = mouth.ToArray();

                matIndex = 3;
                break;

            case "hair":
                
                index = hairIndex;

                max = hairMax;


                textures = hair.ToArray();

                matIndex = 4;
                break;

            case "armour":
                
                index = armourIndex;

                max = armourMax;


                textures = armour.ToArray();

                matIndex = 5;
                break;

            case "clothes":
                
                index = clothesIndex;

                max = clothesMax;


                textures = clothes.ToArray();

                matIndex = 6;
                break;

        }

        #endregion
        #region OutSide Switch
        //index plus equals our direction
        //cap our index to loop back around if is is below 0 or above max take one
        //Material array is equal to our characters material list
        //our material arrays current material index's main texture is equal to our texture arrays current index
        //our characters materials are equal to the material array
        //create another switch that is goverened by the same string name of our material
        index += dir;


        if (index < 0)
        {
            index = max - 1;
        }
        if (index > max - 1)
        {
            index = 0;
        }
        Material[] mat = character.materials;
        mat[matIndex].mainTexture = textures[index];
        character.materials = mat;

        #endregion
        #region Set Material Switch
        //case skin
        switch (type)
        {
            case "skin":
                skinIndex = index;
                break;
            case "eyes":
                eyesIndex = index;
                    break;
            case "mouth":
                mouthIndex = index;
                break;
            case "hair":
                hairIndex = index;
                break;
            case "clothes":
                clothesIndex = index;
                break;
            case "armour":
                armourIndex = index;
                break;

        }
       
        #endregion
    }
    //the string is the name of the material we are editing, the int is the direction we are changing
    //we need variables that exist only within this function
    //these are ints index numbers, max numbers, material index and Texture2D array of textures
    //inside a switch statement that is swapped by the string name of our material



    #endregion

    #region Save
    //Function called Save this will allow us to save our indexes 
    void Save()
    {
        //SetInt for SkinIndex, HairIndex, MouthIndex, EyesIndex

        //SetString CharacterName
    }

    #endregion

    #region OnGUI
    //Function for our GUI elements
    private void OnGUI()
    {
        //create the floats scrW and scrH that govern our 16:9 ratio
        float scrW = Screen.width / 16;
        float scrH = Screen.height / 9;

        #region SetTextureGUI
        //create an int that will help with shuffling your GUI elements under eachother
        int i = 0;
        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("skin", -1);
        }

        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "skin");

        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("skin", 1);
        }
        i++;


        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("eyes", -1);
        }

        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "eyes");

        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("eyes", 1);
        }
        i++;


        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("mouth", -1);
        }

        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "mouth");

        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("mouth", 1);
        }
        i++;


        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("hair", -1);
        }

        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "hair");

        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("hair", 1);
        }
        i++;


        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("armour", -1);
        }

        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "armour");

        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("armour", 1);
        }
        i++;


        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("clothes", -1);
        }

        GUI.Box(new Rect(0.75f * scrW, scrH + i * (0.5f * scrH), 1f * scrW, 0.5f * scrH), "clothes");

        if (GUI.Button(new Rect(1.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            SetTexture("clothes", 1);
        }
        i++;
        #endregion

        #region Random Reset
        //create 2 buttons one Random and one Reset
        //Random will feed a random amount to the direction 
        //reset will set all to 0 both use SetTexture
        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), scrW, 0.5f * scrH), "Reset"))
        {
            SetTexture("skin", skinIndex = 0);
            SetTexture("eyes", eyesIndex = 0);
            SetTexture("mouth", mouthIndex = 0);
            SetTexture("hair", hairIndex = 0);
            SetTexture("armour", armourIndex = 0);
            SetTexture("clothes", clothesIndex = 0);
        }

        if (GUI.Button(new Rect(1.25f * scrW, scrH + i * (0.5f * scrH), scrW, 0.5f * scrH), "Random"))
        {

            SetTexture("skin", Random.Range(0, skinMax - 1));
            SetTexture("eyes", Random.Range(0, eyesMax - 1));
            SetTexture("mouth", Random.Range(0, mouthMax - 1));
            SetTexture("hair", Random.Range(0, hairMax - 1));
            SetTexture("armour", Random.Range(0, armourMax - 1));
            SetTexture("clothes", Random.Range(0, clothesMax - 1));
        }
        i++;
        charName = GUI.TextField(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 2 * scrW, 0.5f * scrH), charName, 30);
        i++;
        if (GUI.Button(new Rect(0.25f * scrW, scrH + i * (0.5f * scrH), 2 * scrW, 0.5f * scrH), "Save and play"))
        {
            Save();
            SceneManager.LoadScene(2);
        }
        i = 0;

        GUI.Box(new Rect(3.75f * scrW, scrH + i * (0.5f * scrH), 2 * scrW, 0.5f * scrH), "Class");
        i++;
       

        if (GUI.Button(new Rect(3.25f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "<"))
        {
            selectedIndex--;
            if (selectedIndex < 0)
            {
                selectedIndex = selectedClass.Length - 1;
            }
            ChooseClass(selectedIndex);
        }

        GUI.Box(new Rect(3.75f * scrW, scrH + i * (0.5f * scrH), 2 * scrW, 0.5f * scrH), selectedClass[selectedIndex]);

        if (GUI.Button(new Rect(5.75f * scrW, scrH + i * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), ">"))
        {
            selectedIndex++;
            if (selectedIndex > selectedClass.Length - 1)
            {
                selectedIndex = 0;
            }
            ChooseClass(selectedIndex);
        }
        GUI.Box(new Rect(3.75f * scrW, 2f * scrH, 2f* scrW, 0.5f * scrH), "Points:" + points);
        for (int s = 0; s < 6; s++)
        {
            if (points > 0)
            {
                if (GUI.Button(new Rect(5.75f * scrW, 2.5f * scrH + s * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH),"+"))
                {
                    points--;
                    statsTemp[s]++;
                    
                }
            }
            GUI.Box(new Rect(3.75f * scrW, 2.5f * scrH+s*(0.5f *scrH), 2f * scrW, 0.5f * scrH), statArray[s]+": "+(statsTemp[s] + stats[s]));
            if (points < 10 && statsTemp[s] > 0)
            {
                if (GUI.Button(new Rect(3.25f * scrW, 2.5f * scrH + s * (0.5f * scrH), 0.5f * scrW, 0.5f * scrH), "-"))
                {
                    points++;
                    statsTemp[s]--;

                }
            }
        }
    }
    #endregion

    //move down the screen with the int using ++ each grouping of GUI elements are moved using this

    #endregion
    void ChooseClass(int className)
    {
        switch(className)
        {
            /// <summary>
            /// remember to change stats of each class 
            /// </summary>
            case 0:
                stats[0] = 15; //strength
                stats[1] = 10; //ew dex
                stats[2] = 10; // constitution
                stats[3] = 10; // wisdom
                stats[4] = 10; //intelligence
                stats[5] = 5; //charisma
                characterClass = CharacterClass.Borborigan;
                break;
            case 1:
                stats[0] = 5;
                stats[1] = 10; 
                stats[2] = 5; 
                stats[3] = 10; 
                stats[4] = 15; 
                stats[5] = 15;
                characterClass = CharacterClass.Bord;
                break;
            case 2:
                stats[0] = 5;
                stats[1] = 5;
                stats[2] = 10;
                stats[3] = 15;
                stats[4] = 15;
                stats[5] = 10;
                characterClass = CharacterClass.Cloric;
                break;
            case 3:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 5;
                characterClass = CharacterClass.Drooid;
                break;
            case 4:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 5;
                characterClass = CharacterClass.Foightah;
                break;
            case 5:
                stats[0] = 10;
                stats[1] = 15;
                stats[2] = 10;
                stats[3] = 15;
                stats[4] = 5;
                stats[5] = 5;
                characterClass = CharacterClass.Moonk;
                break;
            case 6:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 5;
                characterClass = CharacterClass.Poloodoin;
                break;
            case 7:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 5;
                characterClass = CharacterClass.Ronger;
                break;
            case 8:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 5;
                characterClass = CharacterClass.Roogeg;
                break;
            case 9:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 5;
                characterClass = CharacterClass.Soresore_ah;
                break;
            case 10:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 5;
                characterClass = CharacterClass.woolak;
                break;
            case 11:
                stats[0] = 10;
                stats[1] = 10;
                stats[2] = 10;
                stats[3] = 10;
                stats[4] = 10;
                stats[5] = 5;
                characterClass = CharacterClass.Bizard;
                break;
           
        }
    }
    #region Character Name and Save & Play
    //name of our character equals a GUI TextField that holds our character name and limit of characters
    //move down the screen with the int using ++ each grouping of GUI elements are moved using this

    //GUI Button called Save and Play
    //this button will run the save function and also load into the game level
    #endregion

}
public enum CharacterClass
{
    Borborigan,
    Bord,
    Cloric,
    Drooid,
    Foightah,
    Moonk,
    Poloodoin,
    Ronger,
    Roogeg,
    Soresore_ah,
    woolak,
    Bizard,

}