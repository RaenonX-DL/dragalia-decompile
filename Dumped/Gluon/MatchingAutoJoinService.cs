using System.Runtime.CompilerServices;

namespace Gluon
{
	public class MatchingAutoJoinService
	{
		public struct ResultType
		{
			public enum ResultCode
			{
				Ok,
				Ng
			}

			public ResultCode code;

			public PhotonCluster bestRegionCluster;
		}

		private enum State
		{
			None,
			WaitForClusterSet,
			Ready,
			SearchCluster,
			Completed
		}

		public PhotonClusterSet _clusterSet;

		private PhotonClusterRttResult _rttCache;

		private PhotonSearchBestRegionService _searchBestRegionService;

		private State _state;

		private ResultType _result;

		public int JoinQuestId
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MatchingAutoJoinService(PhotonClusterRttResult rttCache)
		{
		}

		public void Clear()
		{
		}

		public void Initialize(int joinQuestId)
		{
		}

		public void StartSearchBestRegionCluster(PhotonClusterSet clusterSet)
		{
		}

		public bool HasSearchCompleted()
		{
			return default(bool);
		}

		public ResultType GetSearchReuslt()
		{
			return default(ResultType);
		}

		public void ClearSearchResult()
		{
		}

		public void StartSearchOtherCluster()
		{
		}

		public void Update()
		{
		}

		public void SetEmptyClusterSet()
		{
		}
	}
}
