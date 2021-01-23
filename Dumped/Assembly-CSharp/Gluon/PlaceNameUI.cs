/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PlaceNameUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text placeName;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text summary;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text exConditionText;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text exCondition2Text;
		[SerializeField]
		private Image bg;
		[SerializeField]
		private Image border;
		[SerializeField]
		private GameObject timeObject;
		[SerializeField]
		private Image timeIcon;
		[SerializeField]
		private UnityEngine.UI.Text timeText;
		[SerializeField]
		[Tooltip]
		private RectTransform exConditionRt;
		[SerializeField]
		[Tooltip]
		private RectTransform exCondition2Rt;
		[SerializeField]
		[Tooltip]
		private RectTransform timeRt;
		[Header]
		[SerializeField]
		private float fadeTime;
		[SerializeField]
		private float bgAlpha;
		private VisibleUIObject rootVisible;
		private Vector3 timeOriginPos;
		private Tweener tweenerFade;
		private const float CONTINUE_IMPOSSIBLE_MERGIN = 45f;
		private readonly Color REBORN_CONDITION_COLOR;
	
		// Constructors
		public PlaceNameUI();
	
		// Methods
		public static PlaceNameUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		public void Open(string placeName, string summary, Color summaryColor, float time);
		public void Close();
		public bool IsVisible();
		private void SetupLayout();
		private void OnUpdateFade(float value);
		private void OnCompleteFadeIn();
		private void OnCompleteFadeOut();
	}
}
