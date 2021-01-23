/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingAutoJoinService
	{
		// Fields
		public PhotonClusterSet _clusterSet;
		private PhotonClusterRttResult _rttCache;
		private PhotonSearchBestRegionService _searchBestRegionService;
		private State _state;
		private ResultType _result;
		[CompilerGenerated]
		private int _JoinQuestId_k__BackingField;
	
		// Properties
		public int JoinQuestId { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public struct ResultType
		{
			// Fields
			public ResultCode code;
			public PhotonCluster bestRegionCluster;
	
			// Nested types
			public enum ResultCode
			{
				Ok = 0,
				Ng = 1
			}
		}
	
		private enum State
		{
			None = 0,
			WaitForClusterSet = 1,
			Ready = 2,
			SearchCluster = 3,
			Completed = 4
		}
	
		// Constructors
		public MatchingAutoJoinService(PhotonClusterRttResult rttCache);
	
		// Methods
		public void Clear();
		public void Initialize(int joinQuestId);
		public void StartSearchBestRegionCluster(PhotonClusterSet clusterSet);
		public bool HasSearchCompleted();
		public ResultType GetSearchReuslt();
		public void ClearSearchResult();
		public void StartSearchOtherCluster();
		public void Update();
		public void SetEmptyClusterSet();
	}
}
