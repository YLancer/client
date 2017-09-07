﻿using System;

namespace AssemblyCSharp
{
	[Serializable]
	public class RoomCreateVo
	{
		public  bool hong;
		public int ma;
		public int roomId;
		public int roomType;//1转转；2、划水；3、长沙 ；4、广东
		/**局数**/
		public int roundNumber;
		public bool sevenDouble;
		public int ziMo;//1：自摸胡；2、抢杠胡
		public int xiaYu;
		public string name;
		public bool addWordCard;
		public int magnification;
        public int gui;//鬼牌 0无鬼；1白板；2翻鬼
        public bool gangHu;//可抢杠胡
        public int guiPai=-1;
        public bool queYiMen = false;

        public RoomCreateVo()
		{

		}
	}
}

