//---------------------------------------------
// 版权信息：版权所有(C) 2013，EVT Tech
// 变更历史：
//      姓名          日期              说明
//---------------------------------------------
//                    2013/09/15        创建
//---------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.Serialization;

using Evt.Framework.Common;
using Evt.Framework.DataAccess;
using Evt.Framework.Mvc;



namespace SC.Models
{
	/// <summary>
	/// Community实体类
	/// </summary>
	[Serializable]
	[TableMapping(TableName = "Community")]
	public class CommunityDataModel : Model
	{
		/// <summary>
		/// iD
		/// </summary>
		private int? _iD = null;

		/// <summary>
		/// name
		/// </summary>
		private string _name = null;

		/// <summary>
		/// city
		/// </summary>
		private string _city = null;

		/// <summary>
		/// pinyin
		/// </summary>
		private string _pinyin = null;

		/// <summary>
		/// serviceCategoryIds
		/// </summary>
		private string _serviceCategoryIds = null;

		/// <summary>
		/// creatTime
		/// </summary>
		private DateTime? _creatTime = null;

		/// <summary>
		///  (主键) ID 
		/// </summary>
		[TableMapping(FieldName = "ID", PrimaryKey = true)]
		public int? Id
		{
			get { return _iD; }
			set { _iD = value; }
		}

		/// <summary>
		///  Name 
		/// </summary>
		[TableMapping(FieldName = "Name")]
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		///  City 
		/// </summary>
		[TableMapping(FieldName = "City")]
		public string City
		{
			get { return _city; }
			set { _city = value; }
		}

		/// <summary>
		///  Pinyin 
		/// </summary>
		[TableMapping(FieldName = "Pinyin")]
		public string Pinyin
		{
			get { return _pinyin; }
			set { _pinyin = value; }
		}

		/// <summary>
		///  ServiceCategoryIds 
		/// </summary>
		[TableMapping(FieldName = "ServiceCategoryIds")]
		public string Servicecategoryids
		{
			get { return _serviceCategoryIds; }
			set { _serviceCategoryIds = value; }
		}

		/// <summary>
		///  CreatTime 
		/// </summary>
		[TableMapping(FieldName = "CreatTime")]
		public DateTime? Creattime
		{
			get { return _creatTime; }
			set { _creatTime = value; }
		}

	}
}

