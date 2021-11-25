using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class MatchingConditionChangeAnimation : MonoBehaviour
	{
		private FlashPlayer flashPlayer;

		private const string requireConditionChangeFlashPath = "Prefabs/OutGame/Matching/MatchingRoom/Flash/pf_MatchingConditionIcon";

		private const string iconShaderPath = "FlashToUnity/uGUI/GraphicNormalEx";

		public bool IsOn
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Initialize(FlashPlayer flashPlayer, Material srcMat, Transform parent, bool isOn)
		{
		}

		public IEnumerator Play(float delay)
		{
			return null;
		}

		private void Play(string label)
		{
		}
	}
}
