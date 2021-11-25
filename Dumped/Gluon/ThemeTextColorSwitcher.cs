using System;
using UnityEngine;

namespace Gluon
{
	[DisallowMultipleComponent]
	public class ThemeTextColorSwitcher : MonoBehaviour
	{
		public class UnitDetailOutlineColor
		{
			public static Color myPageColor;

			public static Color growthColor;

			public static Color partyColor;

			public static Color fortColor;

			public static Color summonColor;

			public static Color menuColor;

			public static Color eventColor;

			public static Color GetColorByFooterMenu(Footer.MenuTab currentMenuTab)
			{
				return default(Color);
			}
		}

		public enum ColorSetType
		{
			None,
			White,
			Black,
			BlackOutline,
			UnitDetailOutline,
			Custom,
			CustomOutline
		}

		[Serializable]
		public class CustomColor
		{
			public Footer.MenuTab menuTab;

			public Color color;

			public Color outlineColor;
		}

		[SerializeField]
		[Header("Settings")]
		public ColorSetType textColorSet;

		public ColorSetType outlineColorSet;

		public float textAlpha;

		public float outlineAlpha;

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
