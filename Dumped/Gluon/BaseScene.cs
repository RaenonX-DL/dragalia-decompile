using System.Collections;
using UnityEngine;

namespace Gluon
{
	public class BaseScene : MonoBehaviour
	{
		public BaseCanvas mainCanvas;

		public static string[] residentAssetNames;

		public static string[] residentVoiceGroups;

		public static string[] residentSceneNames;

		public static readonly string questTransitionEffectPath;

		private void Awake()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
