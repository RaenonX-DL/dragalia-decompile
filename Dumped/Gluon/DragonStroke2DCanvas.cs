using System.Collections;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class DragonStroke2DCanvas : AnimationUICanvas
	{
		[SerializeField]
		private Image dragonImage;

		[SerializeField]
		private RectTransform imageOffset;

		public Transform f2UTrans;

		public ContactAsset contactAsset;

		public const string prefabDir = "Prefabs/OutGame/UnitDetail/";

		public const string switchEffectFlashPath = "Prefabs/OutGame/UnitDetail/pf_transform_effect";

		private FlMotion switchF2u;

		private IEnumerator Start()
		{
			return null;
		}

		public void SetBgDragonImage(int dragonId, bool isEnableEffect)
		{
		}

		public void SwitchFlash()
		{
		}
	}
}
