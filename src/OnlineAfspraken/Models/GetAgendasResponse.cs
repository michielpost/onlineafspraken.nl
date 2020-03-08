using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineAfspraken.Models
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(ElementName = "Response", Namespace = "", IsNullable = false)]
    public partial class GetAgendasResponse : BaseResponse
    {

        private ResponseAgenda[] objectsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Agenda", IsNullable = false)]
        public ResponseAgenda[] Objects
        {
            get
            {
                return this.objectsField;
            }
            set
            {
                this.objectsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseAgenda
    {

        private ushort idField;

        private object nameField;

        private string dateFormatField;

        private string timeFormatField;

        private byte alignGridField;

        private byte isDefaultField;

        /// <remarks/>
        public ushort Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public object Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string DateFormat
        {
            get
            {
                return this.dateFormatField;
            }
            set
            {
                this.dateFormatField = value;
            }
        }

        /// <remarks/>
        public string TimeFormat
        {
            get
            {
                return this.timeFormatField;
            }
            set
            {
                this.timeFormatField = value;
            }
        }

        /// <remarks/>
        public byte AlignGrid
        {
            get
            {
                return this.alignGridField;
            }
            set
            {
                this.alignGridField = value;
            }
        }

        /// <remarks/>
        public byte IsDefault
        {
            get
            {
                return this.isDefaultField;
            }
            set
            {
                this.isDefaultField = value;
            }
        }
    }





}
