using System;
using UnityEngine;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class ThemePanelColorSwitcher : MonoBehaviour
	{
		public enum ColorSetType
		{
			None,
			MainPanel,
			White,
			Black,
			Base,
			Custom
		}

		[Serializable]
		public class CustomColor
		{
			public Footer.MenuTab menuTab;

			public Color color;
		}

		[SerializeField]
		[Header("Settings")]
		public ColorSetType colorSet;

		public float alpha;

		[SerializeField]
		[Header("CustomColors")]
		public CustomColor[] customColors;

		private void Reset()
		{
		}

		private void Start()
		{
		}

		private Color SetColorByTheme(Footer.MenuTab menuTab, ColorSetType type, Color defaultColor)
		{
			return default(Color);
		}
	}
}
