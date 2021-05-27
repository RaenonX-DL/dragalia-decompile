/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameScoringEventInfoUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _adjustRt;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text _killText;
		[SerializeField]
		[Tooltip]
		private UnityEngine.UI.Text _pointText;
		private VisibleUIObject _rootVisible;
		private int _lastKill;
		private int _lastPoint;
		private bool _isLeft;
		private const int MaxValue = 999999999;
	
		// Constructors
		public InGameScoringEventInfoUI();
	
		// Methods
		public static InGameScoringEventInfoUI Create(GameObject parent, int siblingIndex = -1);
		protected virtual void Initialize();
		public void SetLayout(bool isLeft);
		public void SetKillNum(int value, bool isForce = false);
		public void SetPoint(int value, bool isForce = false);
	}
}
