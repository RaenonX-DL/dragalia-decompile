/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Gluon.Master;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EventQuestConditionPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		public UnityEngine.UI.Text uiTitle;
		public UnityEngine.UI.Text uiConditionTitle;
		public UnityEngine.UI.Text uiConditionText;
	
		// Constructors
		public EventQuestConditionPopup();
	
		// Methods
		public static EventQuestConditionPopup Create(int questId, StringBuilder requiredConditionText, UnityAction onCloseCallback, bool showBlackLayer = true);
		private void ReflectParam(QuestDataElement qde, StringBuilder requiredConditionText);
	}
}
