/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestSelectNhaam : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private FlashPlayerManager nhaamFlashMgr;
		private FlashPlayer twinkleFlash;
		private readonly Vector2 twinklePos;
		private FlashPlayer moveFlash;
	
		// Constructors
		public QuestSelectNhaam();
	
		// Methods
		public void Initialize(int sortOrder);
		public void PlayAnimation();
		public void PlayExitAnimation(Action onEnd);
		public void SetSortingOrder(int sortOrder);
		public bool IsInitialized();
	}
}
