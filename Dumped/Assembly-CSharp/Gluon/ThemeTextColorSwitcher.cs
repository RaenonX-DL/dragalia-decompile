/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	[RequireComponent]
	public class ThemeTextColorSwitcher : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public ColorSetType textColorSet;
		public ColorSetType outlineColorSet;
		public float textAlpha;
		public float outlineAlpha;
		[Header]
		[SerializeField]
		public CustomColor[] customColors;
	
		// Nested types
		public class UnitDetailOutlineColor
		{
			// Fields
			public static Color myPageColor;
			public static Color growthColor;
			public static Color partyColor;
			public static Color fortColor;
			public static Color summonColor;
			public static Color menuColor;
			public static Color eventColor;
	
			// Constructors
			public UnitDetailOutlineColor();
			static UnitDetailOutlineColor();
	
			// Methods
			public static Color GetColorByFooterMenu(Footer.MenuTab currentMenuTab);
		}
	
		public enum ColorSetType
		{
			None = 0,
			White = 1,
			Black = 2,
			BlackOutline = 3,
			UnitDetailOutline = 4,
			Custom = 5,
			CustomOutline = 6
		}
	
		[Serializable]
		public class CustomColor
		{
			// Fields
			public Footer.MenuTab menuTab;
			public Color color;
			public Color outlineColor;
	
			// Constructors
			public CustomColor();
		}
	
		// Constructors
		public ThemeTextColorSwitcher();
	
		// Methods
		private void Reset();
		private void Start();
		private Color SetColorByTheme(Footer.MenuTab menuTab, ColorSetType type, Color defaultColor);
	}
}
