using UnityEngine;

namespace Gluon
{
	public class UICommonAutoPartAnimation : MonoBehaviour
	{
		public enum Type
		{
			None,
			NewIcon
		}

		[SerializeField]
		public Type type;

		public bool executeOnAwake;

		public void Awake()
		{
		}

		public void DoAnimation()
		{
		}

		public void DoNewIconFlashingAnimation()
		{
		}
	}
}
