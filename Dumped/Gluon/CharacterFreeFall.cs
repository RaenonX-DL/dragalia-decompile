using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class CharacterFreeFall
	{
		private enum State
		{
			None,
			Fall
		}

		private State state;

		private ActionMoveGravity fallAction;

		private float checkTimer;

		private const float threshold = 0.01f;

		private const float checkInterval = 0.5f;

		private static readonly int layerMask;

		public Vector3 safePosition
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

		public void Initialize()
		{
		}

		public void Update(CharacterBase owner, float delta)
		{
		}

		public bool IsActive()
		{
			return default(bool);
		}
	}
}
