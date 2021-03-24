/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectTrailerPopup : PopupBase
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
		private Image trailerImage;
		[SerializeField]
		private UnityEngine.UI.Text popupTitleText;
		[SerializeField]
		private UnityEngine.UI.Text closeButtonText;
		[SerializeField]
		private UnityEngine.UI.Text chapterPrefixText;
		[SerializeField]
		private UnityEngine.UI.Text chapterPostfixText;
		[SerializeField]
		private UnityEngine.UI.Text chapterTextPart2;
		[SerializeField]
		private UnityEngine.UI.Text chapterPostfixTextEn;
		[SerializeField]
		private UnityEngine.UI.Text chapterTextPart2En;
		[SerializeField]
		private GameObject chapterTextObj;
		[SerializeField]
		private GameObject chapterTextObjEn;
		private const string trailerImagePath = "Images/OutGame/Quest/Trailer/Quest_Jikai_Preview_{0}";
	
		// Constructors
		public QuestSelectTrailerPopup();
	
		// Methods
		public static QuestSelectTrailerPopup Create(int questGroupId, bool half);
		public void Initialize(int questGroupId, bool half);
		private void OnLoaded(Material mat);
	}
}
