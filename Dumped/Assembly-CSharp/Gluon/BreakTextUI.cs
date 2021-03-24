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

namespace Gluon
{
	public class BreakTextUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Image sparkImage;
		[SerializeField]
		private Image breakImage1;
		[SerializeField]
		private Image breakImage2;
		[Header]
		[SerializeField]
		private Vector3 chanceScale0;
		[SerializeField]
		private float chanceTime0;
		[SerializeField]
		private Vector3 chanceScale1;
		[SerializeField]
		private float chanceTime1;
		[SerializeField]
		private Vector3 chanceScale2;
		[SerializeField]
		private float chanceTime2;
		[Header]
		[SerializeField]
		private Vector3 breakScale0;
		[SerializeField]
		private float breakRotz0;
		[SerializeField]
		private float breakTime0;
		[SerializeField]
		private Vector3 breakScale1;
		[SerializeField]
		private float sparkScale1;
		[SerializeField]
		private float breakTime1;
		[SerializeField]
		private Vector3 breakScale2;
		[SerializeField]
		private float breakTime2;
		private RectTransform sparkRT;
		private RectTransform breakRT1;
		private RectTransform breakRT2;
		private Tweener breakTweener;
		private Tweener chanceTweener;
		private PlayMode breakMode;
	
		// Nested types
		private enum PlayMode
		{
			None = 0,
			PlayingStart = 1,
			Visible = 2,
			PlayingEnd = 3
		}
	
		// Constructors
		public BreakTextUI();
	
		// Methods
		public void Initialize();
		public void PlayBreak();
		public void StopBreak();
		public void Stop();
		public bool IsPlayBreak();
		public bool IsPlayChance();
		public bool IsVisibleBreak();
		private void StartBreak();
		private void OnUpdateBreak0(float v);
		private void OnCompleteBreak0();
		private void OnUpdateBreak1(float v);
		private void OnCompleteBreak1();
		private void EndBreak(bool immediate = false);
		private void OnUpdateBreak2(float v);
		private void OnCompleteBreak2();
	}
}
