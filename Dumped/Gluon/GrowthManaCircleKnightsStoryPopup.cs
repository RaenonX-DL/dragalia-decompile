using System;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class GrowthManaCircleKnightsStoryPopup : CommonPopup
	{
		public Image icon;

		public Text characterName;

		public Text storyName;

		public GameObject alertText;

		public Action popAnimationEndedCallBack;

		public static GrowthManaCircleKnightsStoryPopup Create()
		{
			return null;
		}

		public void SetParameters(GrowthManaCircleModel model, UnitStoryElement element)
		{
		}

		public void SetParameters(UnitStoryElement element, int characterId, int rarity, bool isTemporary)
		{
		}

		public override void StartShowAnimation([Optional] UnityEvent onCompleted)
		{
		}
	}
}
