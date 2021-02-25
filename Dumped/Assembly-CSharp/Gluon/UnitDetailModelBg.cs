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
	public class UnitDetailModelBg : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private GameObject[] bgObjects;
		[SerializeField]
		[Tooltip]
		private DimToGraySetting[] dimToGraySettings;
		private ThemeColor currentThemeColor;
	
		// Properties
		private int currentThemeColorForBGIndex { get; }
	
		// Nested types
		[Serializable]
		public class DimToGraySetting
		{
			// Fields
			[Tooltip]
			public ThemeColor themeColor;
			[Tooltip]
			public float contrast;
			[Tooltip]
			public float saturation;
			[Tooltip]
			public float brightness;
	
			// Constructors
			public DimToGraySetting();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public Material mat;
			public string propertyName;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _ValueShaderPropertyTo_b__0(float currentValue);
		}
	
		// Constructors
		public UnitDetailModelBg();
	
		// Methods
		private void Start();
		public void SetActiveBg(ThemeColor themeColor);
		public void HideAllBg();
		public void SetGrayoutBg(bool isGrayout, float duration = 0.3f);
		private void ValueShaderPropertyTo(Material mat, string propertyName, float toValue, float duration);
	}
}
