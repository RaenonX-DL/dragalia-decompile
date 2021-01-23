/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestWallClearAllLvPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private Image elementImage;
		[SerializeField]
		private UnityEngine.UI.Text questName;
	
		// Constructors
		public QuestWallClearAllLvPopup();
	
		// Methods
		public static QuestWallClearAllLvPopup Create(int wallId, UnityAction OnCloseCallback = null);
		public void InitData(int wallId);
	}
}
