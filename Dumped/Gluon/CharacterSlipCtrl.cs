using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class CharacterSlipCtrl
	{
		private float elapsedTime;

		private bool start;

		private bool end;

		public float coef
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 slipVec
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 lastMoveVec
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 lastInputVec
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool restart
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isActionMove
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Reset()
		{
		}

		public void Update(float delta, Vector3 moveVec, CharacterBase owner)
		{
		}
	}
}
