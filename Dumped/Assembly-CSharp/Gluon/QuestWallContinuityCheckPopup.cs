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
	public class QuestWallContinuityCheckPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private Image questPreviewImage;
		[SerializeField]
		private Image questPreviewElement;
		[SerializeField]
		private UnityEngine.UI.Text questPreviewText;
		[SerializeField]
		private UnityEngine.UI.Text recommendText;
	
		// Constructors
		public QuestWallContinuityCheckPopup();
	
		// Methods
		public static QuestWallContinuityCheckPopup Create(int wallId, UnityAction OnOkCallback = null, UnityAction OnCancelCallback = null);
		public void SetContents(int wallId);
	}
}
