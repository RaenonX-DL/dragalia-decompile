/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TanatosHourglassUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private bool _isActiveHourglass;
		private float _timer;
		private State _state;
		private TanatosUniqueCtrl _tanatosUniqCtrl;
		private float _floatingHeight;
		private float _moveCount;
		private const float CountDownInterval = 1f;
	
		// Properties
		public TanatosUniqueCtrl TanatosUniqCtrl { get; set; }
	
		// Nested types
		public enum State
		{
			Ignore = 0,
			Floating = 1,
			Drop = 2
		}
	
		// Constructors
		public TanatosHourglassUniqueCtrl();
	
		// Methods
		public override void Initialize();
		protected override void OnEnable();
		public override void FastUpdate();
		private void FloatingHourglassMove();
		private void ActiveHourglass(bool isActive);
		public void ChangeState(State state);
	}
}
