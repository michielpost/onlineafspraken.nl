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
    public partial class GetCustomerResponse : BaseResponse
    {

        private ResponseCustomer customerField;

        /// <remarks/>
        public ResponseCustomer Customer
        {
            get
            {
                return this.customerField;
            }
            set
            {
                this.customerField = value;
            }
        }
    }
}
