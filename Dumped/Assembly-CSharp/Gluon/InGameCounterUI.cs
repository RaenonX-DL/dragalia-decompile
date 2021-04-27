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
	public class InGameCounterUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private SpriteRenderer[] _countImage;
		[SerializeField]
		private SpriteRenderer[] _animCountImage;
		[SerializeField]
		private SpriteRenderer _symbolImage;
		[SerializeField]
		private SpriteRenderer _animSymbolImage;
		[Header]
		[SerializeField]
		[Tooltip]
		private int _minDisplayCount;
		[SerializeField]
		[Tooltip]
		private Vector2 _symbolOffset;
		[SerializeField]
		[Tooltip]
		private bool _isEnableSymbol;
		[SerializeField]
		[Tooltip]
		private InGameAnimUI[] _changeAnimUI;
		[Header]
		[SerializeField]
		[Tooltip]
		private Sprite[] _countSprite;
		private VisibleUIObject _rootVisible;
		private Vector3[] _countOriginalScale;
		private int _maxCount;
		private int _lastCount;
		private bool _isEnableAnim;
		private Action<int, int> _onCountChanged;
	
		// Constructors
		public InGameCounterUI();
	
		// Methods
		public void Initialize(Action<int, int> onCountChanged = null);
		private void OnDestroy();
		public void Visible(bool b);
		public bool IsVisible(bool inHierarchy = true);
		public void SetCount(int count, bool isForce = false, bool isAnim = true);
		private void SetCountSprite(int count, int maxCount);
		private void SetCountSprite(int index, int countIndex, bool enabled);
		public void SetColor(Color color, bool isApplyAnimCount);
		private bool PlayChangeAnim();
	}
}
