/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class AlbumPassiveDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private AlbumPassiveType _AlbumPassiveType;
		[SerializeField]
		private int _AlbumPassiveValue;
		[SerializeField]
		private FortPlantEffect _EffectType;
		[SerializeField]
		private float _AlbumPassiveEffHp;
		[SerializeField]
		private float _AlbumPassiveEffAtk;
	
		// Properties
		public int Id { get; }
		public AlbumPassiveType AlbumPassiveType { get; }
		public int AlbumPassiveValue { get; }
		public FortPlantEffect EffectType { get; }
		public float AlbumPassiveEffHp { get; }
		public float AlbumPassiveEffAtk { get; }
	
		// Constructors
		public AlbumPassiveDataElement();
	}
}
