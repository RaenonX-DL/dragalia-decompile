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
	public class QuestSelectSummaryPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text chapterText;
		[SerializeField]
		private UnityEngine.UI.Text chapterTextEn;
		[SerializeField]
		private UnityEngine.UI.Text chapterTitleText;
		[SerializeField]
		private UnityEngine.UI.Text trailerText;
		[SerializeField]
		private UnityEngine.UI.Text chapterPrefixText;
		[SerializeField]
		private UnityEngine.UI.Text chapterPostfixText;
		[SerializeField]
		private UnityEngine.UI.Text chapterPostfixTextEn;
		[SerializeField]
		private GameObject chapterTextObj;
		[SerializeField]
		private GameObject chapterTextObjEn;
	
		// Constructors
		public QuestSelectSummaryPopup();
	
		// Methods
		public static QuestSelectSummaryPopup Create(int questGroupId);
		public void Initialize(int questGroupId);
	}
}
