/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsTanatosPlayerEffect : ActionParts
	{
		// Fields
		private readonly TanatosPlayerEffectData _partsData;
		private Dictionary<EffectObject, CharacterBase> _effectDic;
	
		// Constructors
		public ActionPartsTanatosPlayerEffect(ActionParts resource);
	
		// Methods
		protected override void OnStart();
		private EffectObject CreateEffect(CharacterBase owner, CharacterBase target, TanatosPlayerEffectData data);
		private bool CalcGeneratePos(TanatosPlayerEffectData data, CharacterBase target, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale, ref Transform attachNode);
	}
}
