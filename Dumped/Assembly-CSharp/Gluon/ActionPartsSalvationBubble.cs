/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsSalvationBubble : ActionParts
	{
		// Fields
		private readonly SalvationBubbleData _partsData;
		private CharacterBase _protected;
		private List<CharacterBase> _charactersInArea;
		private CharacterBase _supporter;
		private Vector3 _position;
		private float _range;
		private EffectObject _effObj;
	
		// Constructors
		public ActionPartsSalvationBubble(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		public override void Clear();
		protected override void OnFinish();
		protected override bool OnUpdate(float delta);
		private void PlaySe(SalvationBubbleData.BubbleState state);
	}
}
