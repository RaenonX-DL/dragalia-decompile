/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InquiryFaqBoxUI : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private LayoutElement baseLayout;
		public UnityEngine.UI.Text titleText;
		public LayoutElement questionLayout;
		public UnityEngine.UI.Text questionText;
		public LayoutElement answerLayout;
		public UnityEngine.UI.Text answerText;
		public RectTransform innerBoxBase;
		public RectTransform outerBoxBase;
		public RectTransform arrowImageRect;
		public float moveTime;
		public int faqDataId;
		private bool isOpen;
		private bool isSendOpenMessage;
		private readonly float outerBoxCloseHeight;
		private readonly float outerBoxMerginHeight;
		private readonly float baseMerginHeight;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public RectTransform rect;
			public float beginHeight;
			public float endHeight;
			public InquiryFaqBoxUI __4__this;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _DOHeight_b__0(float value);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<InquiryAggregationResponse> __9__18_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _SendOpenMessage_b__18_0(InquiryAggregationResponse res);
		}
	
		// Constructors
		public InquiryFaqBoxUI();
	
		// Methods
		public void OnButtonPressed();
		private void DOHeight(RectTransform rect, float endHeight, float moveTime);
		private void SendOpenMessage();
	}
}
