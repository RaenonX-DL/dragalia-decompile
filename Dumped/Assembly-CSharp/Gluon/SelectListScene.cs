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
	public class SelectListScene : ShopTradeScene
	{
		// Fields
		[SerializeField]
		private Transform selectViewParent;
		[Header]
		[SerializeField]
		public Canvas bgCanvas;
		public static UnityAction<UnityAction> decideButtonCallBack;
		private ShopTreasureTradeMaterialSelectView selectView;
		private BaseCanvasContents baseCanvasContents;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__8_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _BackButtonPressed_b__8_0();
		}
	
		// Constructors
		public SelectListScene();
		static SelectListScene();
	
		// Methods
		private new void Awake();
		private new void Start();
		private void OnDecideButtonPressed();
		public void BackButtonPressed();
	}
}
