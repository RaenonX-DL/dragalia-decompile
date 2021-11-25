using System;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class CraftMaterialWeaponTargetCell : MonoBehaviour
	{
		public Image icon;

		public Transform carftTagIconTransform;

		public GameObject sortDecoAttachNode;

		public Action<int> iconPressCallBack;

		private int weaponId;

		private int limitbreak;

		public void SetIcon(int weaponId)
		{
		}

		public void SetCraftTag(bool isShow)
		{
		}

		public void SetLimitBreak(int limitbreak)
		{
		}

		public void OnIconPressed()
		{
		}

		public void OnIconLongPressed()
		{
		}
	}
}
