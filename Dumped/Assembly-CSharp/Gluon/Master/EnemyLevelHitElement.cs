/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EnemyLevelHitElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _GroupLabel;
		[SerializeField]
		private int _Level;
		[SerializeField]
		private string _HitAttributeIDDefault;
		[SerializeField]
		private string _HitAttributeIDFire;
		[SerializeField]
		private string _HitAttributeIDWater;
		[SerializeField]
		private string _HitAttributeIDWind;
		[SerializeField]
		private string _HitAttributeIDLight;
		[SerializeField]
		private string _HitAttributeIDDark;
	
		// Properties
		public int Id { get; }
		public string GroupLabel { get; }
		public int Level { get; }
		public string HitAttributeIDDefault { get; }
		public string HitAttributeIDFire { get; }
		public string HitAttributeIDWater { get; }
		public string HitAttributeIDWind { get; }
		public string HitAttributeIDLight { get; }
		public string HitAttributeIDDark { get; }
	
		// Constructors
		public EnemyLevelHitElement();
	}
}
