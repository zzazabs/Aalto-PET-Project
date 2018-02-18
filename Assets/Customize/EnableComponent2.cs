using UnityEngine;

namespace Gamekit2D

{

	public class EnableComponent2 : MonoBehaviour   {
        
		private CharacterController2D myplayercharacter;

		void Start()
		{
			myplayercharacter = GetComponent<CharacterController2D>();
		}


		void Update()
		{
            if (Input.GetKey(KeyCode.M)) ;
			{
                myplayercharacter.enabled = !myplayercharacter.enabled;
			}
		}
	}
}