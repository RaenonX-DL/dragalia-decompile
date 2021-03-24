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
	public class FEHQuestMapMiniCharaButton : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public PointerEventHandler pointerEventHandler;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text title;
		public Transform miniCharaAttach;
		public Image balloonImage;
		public Image balloonSelectedImage;
		public Image ribbonImage;
		[Header]
		[SerializeField]
		public Material[] balloonMatList;
		public Material[] balloonSelectedMatList;
		public Material[] ribbonMatList;
		[Header]
		[SerializeField]
		public QuestStateIcon stateIcon;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public Action<int> onMiniCharaTouched;
			public int masterIndex;
	
			// Constructors
			public __c__DisplayClass10_0();
	
			// Methods
			internal void _Setup_b__0();
		}
	
		// Constructors
		public FEHQuestMapMiniCharaButton();
	
		// Methods
		public void Setup(int index, Transform flashTransform, string titleText, Action<int> onMiniCharaTouched, int masterIndex, QuestUtil.QuestState state);
	}
}
