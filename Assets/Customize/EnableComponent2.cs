using UnityEngine;

namespace Gamekit2D

{

	public class EnableComponent2 : MonoBehaviour

	{
		private PlayerCharacter myplayercharacter;

		void Start()
		{
			myplayercharacter = GetComponent<PlayerCharacter>();
		}


		void Update()
		{
            if (Input.GetKeyDown(KeyCode.L)) ;
			{
				myplayercharacter.enabled = !myplayercharacter.enabled;
			}
		}
	}
}