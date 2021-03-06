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
	/// Merchant实体类
	/// </summary>
	[Serializable]
	[TableMapping(TableName = "Merchant")]
	public class MerchantDataModel : Model
	{
		/// <summary>
		/// iD
		/// </summary>
		private int? _iD = null;

		/// <summary>
		/// accountId
		/// </summary>
		private int? _accountId = null;

		/// <summary>
		/// name
		/// </summary>
		private string _name = null;

		/// <summary>
		/// city
		/// </summary>
		private string _city = null;

		/// <summary>
		/// communityIds
		/// </summary>
		private string _communityIds = null;

		/// <summary>
		/// serviceCategoryName
		/// </summary>
		private string _serviceCategoryName = null;

		/// <summary>
		/// address
		/// </summary>
		private string _address = null;

		/// <summary>
		/// mobPhone
		/// </summary>
		private string _mobPhone = null;

		/// <summary>
		/// telPhone
		/// </summary>
		private string _telPhone = null;

		/// <summary>
		/// serviceRadius
		/// </summary>
		private int? _serviceRadius = null;

		/// <summary>
		/// isDoorService
		/// </summary>
		private bool? _isDoorService = null;

		/// <summary>
		/// serviceDes
		/// </summary>
		private string _serviceDes = null;

		/// <summary>
		/// certificatePath
		/// </summary>
		private string _certificatePath = null;

		/// <summary>
		/// shopPicPath
		/// </summary>
		private string _shopPicPath = null;

		/// <summary>
		/// servicePricePath
		/// </summary>
		private string _servicePricePath = null;

		/// <summary>
		/// createTime
		/// </summary>
		private DateTime? _createTime = null;

		/// <summary>
		///  ID 
		/// </summary>
		[TableMapping(FieldName = "ID")]
		public int? Id
		{
			get { return _iD; }
			set { _iD = value; }
		}

		/// <summary>
		///  AccountId 
		/// </summary>
		[TableMapping(FieldName = "AccountId")]
		public int? Accountid
		{
			get { return _accountId; }
			set { _accountId = value; }
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
		///  CommunityIds 
		/// </summary>
		[TableMapping(FieldName = "CommunityIds")]
		public string Communityids
		{
			get { return _communityIds; }
			set { _communityIds = value; }
		}

		/// <summary>
		///  ServiceCategoryName 
		/// </summary>
		[TableMapping(FieldName = "ServiceCategoryName")]
		public string Servicecategoryname
		{
			get { return _serviceCategoryName; }
			set { _serviceCategoryName = value; }
		}

		/// <summary>
		///  Address 
		/// </summary>
		[TableMapping(FieldName = "Address")]
		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}

		/// <summary>
		///  MobPhone 
		/// </summary>
		[TableMapping(FieldName = "MobPhone")]
		public string Mobphone
		{
			get { return _mobPhone; }
			set { _mobPhone = value; }
		}

		/// <summary>
		///  TelPhone 
		/// </summary>
		[TableMapping(FieldName = "TelPhone")]
		public string Telphone
		{
			get { return _telPhone; }
			set { _telPhone = value; }
		}

		/// <summary>
		///  ServiceRadius 
		/// </summary>
		[TableMapping(FieldName = "ServiceRadius")]
		public int? Serviceradius
		{
			get { return _serviceRadius; }
			set { _serviceRadius = value; }
		}

		/// <summary>
		///  IsDoorService 
		/// </summary>
		[TableMapping(FieldName = "IsDoorService")]
		public bool? Isdoorservice
		{
			get { return _isDoorService; }
			set { _isDoorService = value; }
		}

		/// <summary>
		///  ServiceDes 
		/// </summary>
		[TableMapping(FieldName = "ServiceDes")]
		public string Servicedes
		{
			get { return _serviceDes; }
			set { _serviceDes = value; }
		}

		/// <summary>
		///  CertificatePath 
		/// </summary>
		[TableMapping(FieldName = "CertificatePath")]
		public string Certificatepath
		{
			get { return _certificatePath; }
			set { _certificatePath = value; }
		}

		/// <summary>
		///  ShopPicPath 
		/// </summary>
		[TableMapping(FieldName = "ShopPicPath")]
		public string Shoppicpath
		{
			get { return _shopPicPath; }
			set { _shopPicPath = value; }
		}

		/// <summary>
		///  ServicePricePath 
		/// </summary>
		[TableMapping(FieldName = "ServicePricePath")]
		public string Servicepricepath
		{
			get { return _servicePricePath; }
			set { _servicePricePath = value; }
		}

		/// <summary>
		///  CreateTime 
		/// </summary>
		[TableMapping(FieldName = "CreateTime")]
		public DateTime? Createtime
		{
			get { return _createTime; }
			set { _createTime = value; }
		}

	}
}

