using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class UiShownGraphicExchanger : MonoBehaviour
	{
		[Serializable]
		public struct ShownGraphicGroup
		{
			public Graphic[] members;

			public bool isActiveOnStart;
		}

		[SerializeField]
		protected ShownGraphicGroup[] targetGroups;

		[SerializeField]
		private float crossFadingDuration;

		private void Start()
		{
		}

		private void SetGraphicGroupMembersActive(ShownGraphicGroup group, bool isActive)
		{
		}

		private void SetGraphicGroupMembersCrossFading(ShownGraphicGroup group, float targetAlpha, float duration)
		{
		}

		public void ExchangeShownGrapic(int fromIndex, int toIndex, bool isCrossfading)
		{
		}

		public void SetText(int index, string text)
		{
		}
	}
}
