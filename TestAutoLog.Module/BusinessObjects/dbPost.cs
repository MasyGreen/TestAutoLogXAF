﻿using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace TestAutoLog.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class dbPost : XPObject
    {

        public dbPost(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        private string post_code;
        [Indexed(Unique = true)]
        public string Post_Code
        {
            get { return post_code; }
            set { SetPropertyValue("Post_Code", ref post_code, value); }
        }
        private string post_name;
        [Size(200)] // имя большое
        public string Post_Name
        {
            get { return post_name; }
            set { SetPropertyValue("Post_Name", ref post_name, value); }
        }
        private DateTime post_date;
        public DateTime Post_Date
        {
            get { return post_date; }
            set { SetPropertyValue("Post_Date", ref post_date, value); }
        }

        private TypeStatus post_status;
        public TypeStatus Post_Status
        {
            get { return post_status; }
            set { SetPropertyValue("Post_Status", ref post_status, value); }
        }
        public enum TypeStatus { Cancel, Assept }

        #region расшифровка ведущего
        private string user_code;
        public string User_Code
        {
            get { return user_code; }
            set { SetPropertyValue("User_Code", ref user_code, value); }
        }

        private string user_name;
        public string User_Name
        {
            get { return user_name; }
            set { SetPropertyValue("User_Name", ref user_name, value); }
        }
        #endregion

    }
}