using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class MyPageLimitedAreaElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _LimitedAreaGroupId;

		[SerializeField]
		private int _Step;

		[SerializeField]
		private int _ReleaseTargetType;

		[SerializeField]
		private int _ReleaseTargetId;

		[SerializeField]
		private string _BgName;

		[SerializeField]
		private int _NpcCoordPattern;

		[SerializeField]
		private int _NpcCoord1;

		[SerializeField]
		private int _LimitedAreaNpcId1;

		[SerializeField]
		private string _LimitedAreaNpcGear1;

		[SerializeField]
		private int _NpcCoord2;

		[SerializeField]
		private int _LimitedAreaNpcId2;

		[SerializeField]
		private string _LimitedAreaNpcGear2;

		[SerializeField]
		private int _NpcCoord3;

		[SerializeField]
		private int _LimitedAreaNpcId3;

		[SerializeField]
		private string _LimitedAreaNpcGear3;

		[SerializeField]
		private int _NpcCoord4;

		[SerializeField]
		private int _LimitedAreaNpcId4;

		[SerializeField]
		private string _LimitedAreaNpcGear4;

		public int Id => default(int);

		public int LimitedAreaGroupId => default(int);

		public int Step => default(int);

		public int ReleaseTargetType => default(int);

		public int ReleaseTargetId => default(int);

		public string BgName => null;

		public int NpcCoordPattern => default(int);

		public int NpcCoord1 => default(int);

		public int LimitedAreaNpcId1 => default(int);

		public string LimitedAreaNpcGear1 => null;

		public int NpcCoord2 => default(int);

		public int LimitedAreaNpcId2 => default(int);

		public string LimitedAreaNpcGear2 => null;

		public int NpcCoord3 => default(int);

		public int LimitedAreaNpcId3 => default(int);

		public string LimitedAreaNpcGear3 => null;

		public int NpcCoord4 => default(int);

		public int LimitedAreaNpcId4 => default(int);

		public string LimitedAreaNpcGear4 => null;
	}
}
