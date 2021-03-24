/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TutorialSummonUnitListPopup : PopupBase
	{
		// Fields
		[SerializeField]
		private TutorialSummonUnitListController ctrl;
	
		// Constructors
		public TutorialSummonUnitListPopup();
	
		// Methods
		public static TutorialSummonUnitListPopup Create();
		protected override void Start();
		public override void StartCloseAnimation(UnityEvent onCompleted = null);
		public override void StartShowAnimation(UnityEvent onCompleted = null);
	}
}
