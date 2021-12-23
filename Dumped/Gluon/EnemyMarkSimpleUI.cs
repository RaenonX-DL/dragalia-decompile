using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class EnemyMarkSimpleUI : CharacterMarkUI
	{
		protected InGameUICtrl inGameUI;

		private EnemyCharacter _owner;

		protected RectTransform rootRt;

		protected VesselBombUI vesselBombUI;

		protected int lastInfoIconType;

		protected EnemyCharacter owner
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float correctPosY
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public virtual void Initialize(EnemyCharacter enemy, InGameUICtrl inGameUI)
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		public override void UpdatePosition(bool interpolation = true)
		{
		}

		public override void SetVisible(bool visible)
		{
		}

		public override bool IsVisible()
		{
			return default(bool);
		}

		public override VesselBombUI CreateVesselBombUI()
		{
			return null;
		}
	}
}
