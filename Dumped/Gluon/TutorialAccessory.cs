using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class TutorialAccessory : MonoBehaviour
	{
		[SerializeField]
		public GameObject blackShade;

		[SerializeField]
		public List<string> reactSoundCueNameList;

		[SerializeField]
		public string skillReactSoundCueName;

		[SerializeField]
		public string dragonReactSoundCueName;

		[SerializeField]
		public Canvas tutorialCanvas;
	}
}
