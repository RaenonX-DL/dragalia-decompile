/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	[RequireComponent]
	public class ThemePanelColorSwitcher : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public ColorSetType colorSet;
		public float alpha;
		[Header]
		[SerializeField]
		public CustomColor[] customColors;
	
		// Nested types
		public enum ColorSetType
		{
			None = 0,
			MainPanel = 1,
			White = 2,
			Black = 3,
			Base = 4,
			Custom = 5
		}
	
		[Serializable]
		public class CustomColor
		{
			// Fields
			public Footer.MenuTab menuTab;
			public Color color;
	
			// Constructors
			public CustomColor();
		}
	
		// Constructors
		public ThemePanelColorSwitcher();
	
		// Methods
		private void Reset();
		private void Start();
		private Color SetColorByTheme(Footer.MenuTab menuTab, ColorSetType type, Color defaultColor);
	}
}
