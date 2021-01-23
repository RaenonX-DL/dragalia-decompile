/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class SabnackDarkTorrentData : BulletWithMarkerData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int[] _bulletNum;
		[HideInInspector]
		[SerializeField]
		private int _impactEffectTrigger;
		[HideInInspector]
		[SerializeField]
		private string _impactSeName;
		[HideInInspector]
		[SerializeField]
		private string _mineHitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private float _mineRange;
		[HideInInspector]
		[SerializeField]
		private float _mineIgnitionTime;
		[HideInInspector]
		[SerializeField]
		private int _mineExplodeEffTrig;
		[HideInInspector]
		[SerializeField]
		private float _mineExplodingTime;
		[HideInInspector]
		[SerializeField]
		private string _mineExplodeSeName;
		[HideInInspector]
		[SerializeField]
		private ChargeMarker.eColorType _mineMarkerColor;
	
		// Properties
		public int[] bulletNum { get; }
		public int impactEffectTrigger { get; }
		public string impactSeName { get; }
		public string mineHitAttrLabel { get; }
		public float mineRange { get; }
		public float mineIgnitionTime { get; }
		public int mineExplodeEffTrig { get; }
		public float mineExplodingTime { get; }
		public string mineExplodeSeName { get; }
		public ChargeMarker.eColorType mineMarkerColor { get; }
	
		// Constructors
		public SabnackDarkTorrentData();
	}
}
