/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectEventShortCut : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Toggle[] shortCutButtonsToggle;
	
		// Constructors
		public QuestSelectEventShortCut();
	
		// Methods
		public bool SetShortCut(int eventId, bool isSub);
		public void SetTutorial(bool isEnabled);
	}
}
