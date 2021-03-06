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
    /// Account实体类
    /// </summary>
    [Serializable]
    [TableMapping(TableName = "Account")]
    public class AccountDataModel : Model
    {
        /// <summary>
        /// iD
        /// </summary>
        private int? _iD = null;

        /// <summary>
        /// mobPhone
        /// </summary>
        private string _mobPhone = null;

        /// <summary>
        /// NikeName
        /// </summary>
        private string _nikeName = null;

        /// <summary>
        /// email
        /// </summary>
        private string _email = null;

        /// <summary>
        /// passsword
        /// </summary>
        private string _passsword = null;

        /// <summary>
        /// potoPath
        /// </summary>
        private string _potoPath = null;

        /// <summary>
        /// createTime
        /// </summary>
        private DateTime? _createTime = null;

        /// <summary>
        /// Address
        /// </summary>
        private string _address = null;

        /// <summary>
        /// ViewHistory
        /// </summary>
        private string _viewHistory = null;

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
        ///  MobPhone 
        /// </summary>
        [TableMapping(FieldName = "MobPhone")]
        public string Mobphone
        {
            get { return _mobPhone; }
            set { _mobPhone = value; }
        }


        /// <summary>
        ///  MobPhone 
        /// </summary>
        [TableMapping(FieldName = "NikeName")]
        public string NikeName
        {
            get { return _nikeName; }
            set { _nikeName = value; }
        }

        /// <summary>
        ///  Email 
        /// </summary>
        [TableMapping(FieldName = "Email")]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        ///  Passsword 
        /// </summary>
        [TableMapping(FieldName = "Passsword")]
        public string Passsword
        {
            get { return _passsword; }
            set { _passsword = value; }
        }

        /// <summary>
        ///  PotoPath 
        /// </summary>
        [TableMapping(FieldName = "PotoPath")]
        public string Potopath
        {
            get { return _potoPath; }
            set { _potoPath = value; }
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

        /// <summary>
        ///  CreateTime 
        /// </summary>
        [TableMapping(FieldName = "ViewHistory")]
        public string ViewHistory
        {
            get { return _viewHistory; }
            set { _viewHistory = value; }
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

    }
}

