using UnityEngine;
using System.Collections;
namespace Gamekit2D

{

    public class EnableComponents : MonoBehaviour

    {
        private PlayerCharacter myplayercharacter;

        void Start()
        {
            myplayercharacter = GetComponent<PlayerCharacter>();
        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myplayercharacter.enabled = !myplayercharacter.enabled;
            }
        }
    }
}