﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestReleasePopup : CommonPopup
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text uiTitle;
		public UnityEngine.UI.Text uiMainText;
	
		// Constructors
		public QuestReleasePopup();
	
		// Methods
		public static QuestReleasePopup Create(string title, string msg, bool showBlackLayer = true, UnityAction OnCloseCallback = null);
	}
}
