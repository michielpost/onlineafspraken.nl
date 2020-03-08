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
    public partial class GetAppointmentsResponse : BaseResponse
    {

        private ResponseAppointment[] objectsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Appointment", IsNullable = false)]
        public ResponseAppointment[] Objects
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
    public partial class ResponseAppointment
    {

        private uint idField;

        private string nameField;

        private string descriptionField;

        private string startTimeField;

        private string finishTimeField;

        private string blockedTimeField;

        private byte capacityField;

        private uint appointmentTypeIdField;

        private string customerIdField;

        private string customerNameField;

        private byte statusField;

        private byte labelField;

        private ResponseAppointmentResources[] resourcesField;

        private string createTimeField;

        private string updateTimeField;

        private string aantal_deelnemersField;

        private string hoe_kent_u_DarkParkField;

        /// <remarks/>
        public uint Id
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
        public string Name
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
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        public string FinishTime
        {
            get
            {
                return this.finishTimeField;
            }
            set
            {
                this.finishTimeField = value;
            }
        }

        /// <remarks/>
        public string BlockedTime
        {
            get
            {
                return this.blockedTimeField;
            }
            set
            {
                this.blockedTimeField = value;
            }
        }

        /// <remarks/>
        public byte Capacity
        {
            get
            {
                return this.capacityField;
            }
            set
            {
                this.capacityField = value;
            }
        }

        /// <remarks/>
        public uint AppointmentTypeId
        {
            get
            {
                return this.appointmentTypeIdField;
            }
            set
            {
                this.appointmentTypeIdField = value;
            }
        }

        /// <remarks/>
        public string CustomerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }

        /// <remarks/>
        public string CustomerName
        {
            get
            {
                return this.customerNameField;
            }
            set
            {
                this.customerNameField = value;
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
        public byte Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Resources")]
        public ResponseAppointmentResources[] Resources
        {
            get
            {
                return this.resourcesField;
            }
            set
            {
                this.resourcesField = value;
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
        public string Aantal_deelnemers
        {
            get
            {
                return this.aantal_deelnemersField;
            }
            set
            {
                this.aantal_deelnemersField = value;
            }
        }

        /// <remarks/>
        public string Hoe_kent_u_DarkPark
        {
            get
            {
                return this.hoe_kent_u_DarkParkField;
            }
            set
            {
                this.hoe_kent_u_DarkParkField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ResponseAppointmentResources
    {

        private uint resourceIdField;

        private string assignedStartTimeField;

        private string assignedFinishTimeField;

        /// <remarks/>
        public uint ResourceId
        {
            get
            {
                return this.resourceIdField;
            }
            set
            {
                this.resourceIdField = value;
            }
        }

        /// <remarks/>
        public string AssignedStartTime
        {
            get
            {
                return this.assignedStartTimeField;
            }
            set
            {
                this.assignedStartTimeField = value;
            }
        }

        /// <remarks/>
        public string AssignedFinishTime
        {
            get
            {
                return this.assignedFinishTimeField;
            }
            set
            {
                this.assignedFinishTimeField = value;
            }
        }
    }


}
