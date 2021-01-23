/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsIceRay : ActionParts
	{
		// Fields
		private readonly IceRayData _partsData;
		private SheruSheiruUniqueCtrl _ctrl;
		private Transform startTransform;
		private bool OverlapSphereChecked;
		private int layerMask;
	
		// Constructors
		public ActionPartsIceRay(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override bool OnUpdate(float delta);
		protected override void OnFinish();
		private void CalcStartTransfrom();
	}
}
