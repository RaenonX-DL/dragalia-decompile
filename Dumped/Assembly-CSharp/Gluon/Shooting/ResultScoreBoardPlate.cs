/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class ResultScoreBoardPlate : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text rankText;
		[SerializeField]
		private UnityEngine.UI.Text scoreText;
		[SerializeField]
		private Image newBadge;
		private static Color normalColor;
		private static Color newColor;
		private Vector2 blinkingToFrom;
		private float blinkingDuring;
		private Ease blinkingEasing;
		private Sequence blinkSeq;
	
		// Constructors
		public ResultScoreBoardPlate();
		static ResultScoreBoardPlate();
	
		// Methods
		public void Init(Transform node, int scoreRank, int score, bool isNew);
		private void SetNewScoreTween();
	}
}
