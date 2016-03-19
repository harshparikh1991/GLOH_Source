using System;

namespace GAME
{
	public static class NewGuildDefine
	{
		public enum eNEWGUILD_MEMBER_RANK
		{
			eNEWGUILD_MEMBER_RANK_NONE,
			eNEWGUILD_MEMBER_RANK_INITIATE,
			eNEWGUILD_MEMBER_RANK_REGULAR,
			eNEWGUILD_MEMBER_RANK_OFFICER,
			eNEWGUILD_MEMBER_RANK_SUB_MASTER,
			eNEWGUILD_MEMBER_RANK_MASTER,
			eNEWGUILD_MEMBER_RANK_MAX
		}

		public enum eNEWGUILD_RESULT
		{
			eNEWGUILD_RESULT_DBLOADING = 1
		}

		public enum eNEWGUILD_SORT
		{
			eNEWGUILD_SORT_RANK_MIN,
			eNEWGUILD_SORT_RANK_MAX,
			eNEWGUILD_SORT_LEVEL_MIN,
			eNEWGUILD_SORT_LEVEL_MAX
		}

		public enum eNEWGUILD_BOSSROOMSTATE
		{
			eNEWGUILD_BOSSROOMSTATE_NONE,
			eNEWGUILD_BOSSROOMSTATE_OPEN,
			eNEWGUILD_BOSSROOMSTATE_ACTION,
			eNEWGUILD_BOSSROOMSTATE_CLEAR,
			eNEWGUILD_BOSSROOMSTATE_MAX
		}

		public enum eMY_NEWGUILD_BOSS_PLAYSTATE
		{
			eNEWGUILD_MY_PLAYSTATE_NONE,
			eNEWGUILD_MY_PLAYSTATE_PLAY,
			eNEWGUILD_MY_PLAYSTATE_CLEAR,
			eNEWGUILD_MY_PLAYSTATE_MAX
		}

		public enum eNEWGUILD_BOSSBATTLE_RESULT
		{
			eNEWGUILD_BOSSBATTLE_RESULT_OK,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_OPEN_RANK,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_OPEN_ACTION,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_ROOMINFO,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_ROOMCHECK,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_ROOMCHECK_RANK,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_START_RANK,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_START_USER,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_RESTART,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_START_TIME,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_OPEN_TIME,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_REWARD,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_REWARD_INFO,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_REWARD_CLEAR,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_OPEN_MAX,
			eNEWGUILD_BOSSBATTLE_RESULT_FAIL_NO_START
		}

		public enum eNEWGUILD_INFO_LOAD_TYPE
		{
			eNEWGUILD_INFO_LOAD_TYPE_NONE,
			eNEWGUILD_INFO_LOAD_TYPE_MAINSELECT
		}

		public enum eNEWGUILD_AGIT_RESULT
		{
			eNEWGUILD_AGIT_RESULT_OK,
			eNEWGUILD_AGIT_RESULT_FAIL,
			eNEWGUILD_AGIT_RESULT_DBLOCK
		}

		public enum eNEWGUILD_FUND_USE_TYPE
		{
			eNEWGUILD_FUND_USE_TYPE_NONE,
			eNEWGUILD_FUND_USE_TYPE_AGIT_CREATE,
			eNEWGUILD_FUND_USE_TYPE_AGIT_LEVELUP,
			eNEWGUILD_FUND_USE_TYPE_AGIT_BUY_NPC,
			eNEWGUILD_FUND_USE_TYPE_AGIT_GUARDIAN
		}

		public enum eNEWGUILD_NPC_TYPE
		{
			eNEWGUILD_NPC_TYPE_NONE,
			eNEWGUILD_NPC_TYPE_MERCHANT,
			eNEWGUILD_NPC_TYPE_REFORGE,
			eNEWGUILD_NPC_TYPE_REDUCE,
			eNEWGUILD_NPC_TYPE_ITEMSKILL,
			eNEWGUILD_NPC_TYPE_GOLDENEGG,
			eNEWGUILD_NPC_TYPE_MAX
		}

		public enum eNEWGUILD_AGIT_NPC_USE_RESULT
		{
			eNEWGUILD_AGIT_NPC_USE_RESULT_FULL_INVEN = 1,
			eNEWGUILD_AGIT_NPC_USE_RESULT_REBUY
		}

		public const short NEWGUILD_NAME_LEN = 10;

		public const short NEWGUILD_NAME_LEN_NULL = 11;

		public const short NEWGUILDMEMBER_NAME_LEN_NULL = 11;

		public const short NEWGUILD_INFOMATION_MESSAGE = 50;

		public const int PACKET_SIZE_LIMIT = 20000;

		public const int NEWGUILD_SENDPUSH_TIMELIMIT_MIN = 8;

		public const int NEWGUILD_SENDPUSH_TIMELIMIT_MAX = 21;

		public const int NEWGUILD_PUSHCOUNT = 10;

		public const int NEWGUILD_WAR_PAGE_COUNT = 4;

		public const int AGIT_MAPINDEX = 12;

		public const int AGIT_NPC_RATE_MAX = 10;
	}
}