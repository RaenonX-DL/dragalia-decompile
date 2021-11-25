using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace Gluon
{
	public class MyPageSkitMapBgContent : MonoBehaviour
	{
		public PlayableDirector playableDirector;

		public PlayableDirector playableDirector2;

		public PlayableDirector playableDirector3;

		public PlayableDirector playableDirector4;

		public List<GameObject> characterNodes;

		public GameObject[] worldIrisLocators;

		public GameObject[] specialObject;

		private void Awake()
		{
		}
	}
}
