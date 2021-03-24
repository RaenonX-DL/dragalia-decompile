/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using Gluon.Event;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class ActionPartsBindBullet : Gluon.ActionParts
	{
		// Fields
		private readonly BindBulletData _partsData;
		private long bindEventId;
		private RunActionLongParameter bindEventIdParam;
	
		// Nested types
		public enum GenerationPoint
		{
			AreaAnchor = 0,
			Target = 1,
			Owner = 2
		}
	
		// Constructors
		public ActionPartsBindBullet(Gluon.ActionData.ActionParts resource);
	
		// Methods
		public override RunActionParameterBase CreateRunActionParameter();
		public override void SetRunActionParameter(RunActionParameterBase param);
		public override void OnPostCreated(CharacterBase chara);
		protected override void OnStart();
		private void GenerateBullet();
		private void CalcGenerate(GenerationPoint generation, Vector3 offset, ref Vector3 position, ref Quaternion rotation);
		private bool Misfire();
	}
}
