/**  版本信息模板在安装目录下，可自行修改。
* SMSRecord.cs
*
* 功 能： N/A
* 类 名： SMSRecord
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/1/8 11:16:53   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Jyson.MyCodeManage.Model
{
	/// <summary>
	/// SMSRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SMSRecord
	{
		public SMSRecord()
		{}
		#region Model
		private int _id;
		private long _phone;
		private DateTime _createdate;
		private string _verifycode;
		private string _content;
		private int? _sendtype;
		private int? _priority;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateDate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VerifyCode
		{
			set{ _verifycode=value;}
			get{return _verifycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SendType
		{
			set{ _sendtype=value;}
			get{return _sendtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Priority
		{
			set{ _priority=value;}
			get{return _priority;}
		}
		#endregion Model

	}
}

