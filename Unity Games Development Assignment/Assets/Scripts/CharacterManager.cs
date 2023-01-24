using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public enum CharacterTypes { Player1, Player2, Player3 };
    public List<GameObject> characters = new List<GameObject>();
    public GameObject currentCharacter;
    public CharacterTypes currentCharacterType;


    void Awake()
    {   // Instantiate the initial character
        currentCharacterType = CharacterTypes.Player1;
        InstantiateCharacter((int)currentCharacterType);
    }

    // Instantiate a character at the position of the current GameObject
    public void InstantiateCharacter(int index)
    {
        if (characters[index] == null)
            return;
        if(currentCharacter != null)
        {
            Destroy(currentCharacter);
        }
        currentCharacter = Instantiate(characters[index], transform);
        currentCharacter.transform.localPosition = Vector3.zero;
        currentCharacter.transform.localRotation = Quaternion.identity;
        currentCharacter.name = characters[index].name;
        currentCharacterType = (CharacterTypes)index;
        CharacterType();
    }

    // Swap to the next charekter in the list
    public void SwapCharacter()
    {
        int nextCharacterType = (int)(currentCharacterType + 1) % characters.Count;
        InstantiateCharacter(nextCharacterType);
    }

    // prints in console wich charecter is swicht to
    public void CharacterType()
    {
        switch (currentCharacterType)
        {
            case CharacterTypes.Player1:
                print("Im player1");
            break;
            case CharacterTypes.Player2:
                print("im player2");
                    break;
            case CharacterTypes.Player3:
                print("im player3");
                    break;
        }
        
    }

}
