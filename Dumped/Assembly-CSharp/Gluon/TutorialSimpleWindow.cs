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
	public class TutorialSimpleWindow : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Footer.MenuTab menuTab;
		[SerializeField]
		[TextArea]
		public string text;
		[SerializeField]
		protected Image frame;
		[SerializeField]
		protected UnityEngine.UI.Text title;
		[SerializeField]
		protected RubySupportedText textObj;
		protected Color whiteColor;
		protected Color blackColor;
		protected Color blackOutlineColor;
		protected float textWidthMargin;
		protected float textHeightMargin;
		protected float textPositionOffsetY;
	
		// Nested types
		public enum Menu
		{
			MyPage = 0,
			Growth = 1,
			Party = 2,
			Battle = 3,
			Fort = 4,
			Summon = 5
		}
	
		// Constructors
		public TutorialSimpleWindow();
	
		// Methods
		public static TutorialSimpleWindow CreateTutorialSimpleWindow(Canvas canvas);
		protected virtual void Awake();
		protected virtual void Start();
		public void Close();
		public void SetTitleText(string str);
		public void SetTitleSize(Vector2 vec);
		public void SetText(string str);
	}
}
