using UnityEngine;

namespace Gluon
{
	public class SummonTop : MonoBehaviour
	{
		public GameObject summonUIContentNode;

		public RectTransform backGround;

		[HideInInspector]
		public SummonScene scene;

		[HideInInspector]
		public SummonTopItemView itemView;

		public void LoadMainUI()
		{
		}

		public void RefreshPrice()
		{
		}

		public void DisableButtonsForTutorial(bool enableMultiButton)
		{
		}

		public void OnBeforeSceneLeaving()
		{
		}

		public void FadeOut()
		{
		}
	}
}
