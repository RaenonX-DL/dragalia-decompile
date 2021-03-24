/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class STGPausePU : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public GameObject restartButton;
		public PointerEventHandler continueButton;
		public GameObject[] gameOverGOs;
		public GameObject[] pauseGOs;
		public GameObject touchGuard;
		[Header]
		[SerializeField]
		public UIAnimationPublisher publisher;
		private Action onContinue;
		private Action onRestart;
		private Action onRetire;
	
		// Constructors
		public STGPausePU();
	
		// Methods
		public void Setup(bool isPause, bool hasRestart, Action onContinue, Action onRestart, Action onRetire);
		public void OnContinue();
		public void OnRestart();
		public void OnRetire();
	}
}
