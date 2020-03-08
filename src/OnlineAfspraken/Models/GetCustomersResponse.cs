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
    public partial class GetCustomersResponse : BaseResponse
    {

        private ResponseCustomer[] objectsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Customer", IsNullable = false)]
        public ResponseCustomer[] Objects
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
    public partial class ResponseCustomer
    {

        private int idField;

        private ushort accountNumberField;

        private string firstNameField;

        private string lastNameField;

        private string insertionsField;

        private object birthDateField;

        private string genderField;

        private string streetField;

        private string houseNrField;

        private object houseNrAdditionField;

        private string zipCodeField;

        private string cityField;

        private string countryField;

        private string phoneField;

        private string mobilePhoneField;

        private string emailField;

        private byte statusField;

        private string updateTimeField;

        private string createTimeField;

        private string woonplaatsField;

        /// <remarks/>
        public int Id
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
        public ushort AccountNumber
        {
            get
            {
                return this.accountNumberField;
            }
            set
            {
                this.accountNumberField = value;
            }
        }

        /// <remarks/>
        public string FirstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string LastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        public string Insertions
        {
            get
            {
                return this.insertionsField;
            }
            set
            {
                this.insertionsField = value;
            }
        }

        /// <remarks/>
        public object BirthDate
        {
            get
            {
                return this.birthDateField;
            }
            set
            {
                this.birthDateField = value;
            }
        }

        /// <remarks/>
        public string Gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /// <remarks/>
        public string Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string HouseNr
        {
            get
            {
                return this.houseNrField;
            }
            set
            {
                this.houseNrField = value;
            }
        }

        /// <remarks/>
        public object HouseNrAddition
        {
            get
            {
                return this.houseNrAdditionField;
            }
            set
            {
                this.houseNrAdditionField = value;
            }
        }

        /// <remarks/>
        public string ZipCode
        {
            get
            {
                return this.zipCodeField;
            }
            set
            {
                this.zipCodeField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public string MobilePhone
        {
            get
            {
                return this.mobilePhoneField;
            }
            set
            {
                this.mobilePhoneField = value;
            }
        }

        /// <remarks/>
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public byte Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public string UpdateTime
        {
            get
            {
                return this.updateTimeField;
            }
            set
            {
                this.updateTimeField = value;
            }
        }

        /// <remarks/>
        public string CreateTime
        {
            get
            {
                return this.createTimeField;
            }
            set
            {
                this.createTimeField = value;
            }
        }

        /// <remarks/>
        public string Woonplaats
        {
            get
            {
                return this.woonplaatsField;
            }
            set
            {
                this.woonplaatsField = value;
            }
        }
    }



}
