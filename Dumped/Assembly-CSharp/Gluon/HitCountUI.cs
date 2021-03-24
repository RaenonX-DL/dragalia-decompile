/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class HitCountUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private RectTransform _countAdjustRt;
		[SerializeField]
		private SpriteRenderer _captionImage;
		[SerializeField]
		private SpriteRenderer[] _countImage;
		[Header]
		[SerializeField]
		[Tooltip]
		private Sprite[] _countSprite;
		[SerializeField]
		[Tooltip]
		private Color _defaultColor;
		[SerializeField]
		[Tooltip]
		private Color _dyingColor;
		[Header]
		[SerializeField]
		[Tooltip]
		private float _digitMergin;
		[SerializeField]
		[Tooltip]
		private float _dyingRate;
		private VisibleUIObject _rootVisible;
		private RectTransform[] _countRt;
		private CharacterMarkUI _mark;
		private RectTransform _markRt;
		private int _maxCount;
		private int _lastCount;
		private int _lastMaxCount;
	
		// Constructors
		public HitCountUI();
	
		// Methods
		public static HitCountUI Create(GameObject parent, CharacterMarkUI mark, int siblingIndex = -1);
		private void Initialize(CharacterMarkUI mark);
		public override void FastUpdate();
		protected void UpdatePosition();
		public void Show();
		public void Hide();
		public void ResetCount();
		public void SetCount(int count, int maxCount);
		private void SetCountSprite(ref SpriteRenderer image, int index, bool isEnabled, Color color);
	}
}
