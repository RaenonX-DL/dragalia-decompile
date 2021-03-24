/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InquiryMessageCell : TableViewCell<Gluon.InquiryMessageListCellData>
	{
		// Fields
		private readonly int TitleStringMax;
		private readonly int TitleStringSingleMax;
		[SerializeField]
		private UnityEngine.UI.Text titleLine;
		[SerializeField]
		private UnityEngine.UI.Text titleLines;
		[SerializeField]
		private UnityEngine.UI.Text time;
		private string opinionId;
		[NonSerialized]
		public UnityAction<string> onClickedCallback;
	
		// Constructors
		public InquiryMessageCell();
	
		// Methods
		public void InitSetting(AtgenOpinionList initOpinion);
		public override void UpdateContent(InquiryMessageListCellData data);
		public void OnLeftButtonPressed();
		private static void OmitText(UnityEngine.UI.Text text);
	}
}
