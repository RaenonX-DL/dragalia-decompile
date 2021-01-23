/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.UI
{
	[ProjectPrefsAttr]
	[ProjectPrefsAttr]
	[ProjectPrefsAttr]
	[ProjectPrefsAttr]
	[ProjectPrefsAttr]
	[ProjectPrefsAttr]
	[ProjectPrefsAttr]
	[ProjectPrefsAttr]
	[ProjectPrefsAttr]
	[ProjectPrefsAttr]
	public class UIManager : MonoBehaviour
	{
		// Fields
		public const string PrefsPrefix = "UILayer_";
		public const string ToolTip = "UI\u7528\u30EC\u30A4\u30E4\u30FC\u540D\u8A2D\uFFFD";
		public const string Group = "[UI]";
		public const int MaxLayer = 10;
		[CompilerGenerated]
		private static UIManager _Instance_k__BackingField;
		private Dictionary<string, Transform> layers;
		private List<Window> windowBuffer;
	
		// Properties
		public static UIManager Instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public UIManager();
	
		// Methods
		private void Awake();
		public void AddControl(RectTransform control, string layer);
		private void Update();
		private void OnDestroy();
	}
}
