using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SabnackDarkTorrentData : BulletWithMarkerData
	{
		[SerializeField]
		[HideInInspector]
		private int[] _bulletNum;

		[SerializeField]
		[HideInInspector]
		private int _impactEffectTrigger;

		[SerializeField]
		[HideInInspector]
		private string _impactSeName;

		[SerializeField]
		[HideInInspector]
		private string _mineHitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private float _mineRange;

		[SerializeField]
		[HideInInspector]
		private float _mineIgnitionTime;

		[SerializeField]
		[HideInInspector]
		private int _mineExplodeEffTrig;

		[SerializeField]
		[HideInInspector]
		private float _mineExplodingTime;

		[SerializeField]
		[HideInInspector]
		private string _mineExplodeSeName;

		[SerializeField]
		[HideInInspector]
		private ChargeMarker.eColorType _mineMarkerColor;

		public int[] bulletNum => null;

		public int impactEffectTrigger => default(int);

		public string impactSeName => null;

		public string mineHitAttrLabel => null;

		public float mineRange => default(float);

		public float mineIgnitionTime => default(float);

		public int mineExplodeEffTrig => default(int);

		public float mineExplodingTime => default(float);

		public string mineExplodeSeName => null;

		public ChargeMarker.eColorType mineMarkerColor => default(ChargeMarker.eColorType);
	}
}
