﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Common
{
    [Table("SubItemEntityModel")]
    public class SubItemEntityModel : INotifyPropertyChanged
    {
        [PrimaryKey]
        public int Id { get; set; }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; NotifyPropertyChanged(); }
        }

        //public string Name { get; set; }

        public bool IsFieldEnabledAsBool
        {
            get
            {
                switch (IsFieldEnabled)
                {
                    case "Disabled":
                        return false;

                    case "Enabled":
                        return true;

                    default: return false;
                }
            }
            set { }
        }

        [ForeignKey(typeof(MenuItemEntityModel))]
        public int? MenuItemId { get; set; }

        [ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
        public MenuItemEntityModel MenuItemEntity { get; set; }

        private string _fieldValue;

        public string FieldValue
        {
            get { return _fieldValue; }
            set 
            {
                _fieldValue = value; 
                NotifyPropertyChanged(); 
            }
        }

        public string IsFieldEnabled { get; set; }
        public string IsNumericFieldEnabled { get; set; }
        public bool NumericFieldEnabled
        {
            get
            {
                switch (IsNumericFieldEnabled)
                {
                    case "No":
                        return false;
                    case "Yes":
                        return true;

                    default: return false;
                }
            }
            private set { }
        }
        public int FieldMinLength { get; set; }
        public int FieldMaxLength { get; set; }
        public string KeyboardInput { get; set; }
        public string EmptyField { get; set; }
        public string KeepFieldValue { get; set; }
        public string IsScanEnabled { get; set; }
        public bool ScanEnabled
        {
            get
            {
                switch (IsScanEnabled)
                {
                    case "Disabled":
                        return false;

                    case "Enabled":
                        return true;

                    default: return false;
                }
            }
            private set { }
        }

        public string Type { get; set; }
        public int Length { get; set; }
        public string StartWith { get; set; }
        public int Offset { get; set; }
        public int ValueLength { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
