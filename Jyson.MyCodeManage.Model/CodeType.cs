using System;
namespace Jyson.MyCodeManage.Model
{
	/// <summary>
	/// CodeType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CodeType
	{
		public CodeType()
		{}
		#region Model
		private int _id;
		private string _typename;
		private int? _orderNo=0;
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
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OrderNo
		{
            set { _orderNo = value; }
            get { return _orderNo; }
		}
		#endregion Model

	}
}

