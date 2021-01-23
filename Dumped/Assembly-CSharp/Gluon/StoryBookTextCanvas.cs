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
	public class StoryBookTextCanvas : MonoBehaviour
	{
		// Fields
		public Camera mainCamera;
		[SerializeField]
		private Canvas uiCanvas;
		[SerializeField]
		public Image backGround;
		[SerializeField]
		private UnityEngine.UI.Text textBase;
		[SerializeField]
		private RectTransform textRootRect;
		[SerializeField]
		private RectTransform textParentBase;
		private RectTransform[] textParents;
		private string[] textStrings;
		private float[] widths;
		public string baseString;
		private int lineLetterMax;
		private int lineMax;
		private int showLineNum;
		private int totalLetterNum;
		private int pageLetterNum;
		private const int defaultTextSize = 28;
		private static readonly Color defaultColor;
		public bool isFirst;
	
		// Constructors
		public StoryBookTextCanvas();
		static StoryBookTextCanvas();
	
		// Methods
		public void SetCanvasData();
		public void SetDefault();
		public void AddText(string textString, string rubyString = null);
		private void SetDefaultTexts();
		public void SetCentering();
		private void OnDestroy();
	}
}
