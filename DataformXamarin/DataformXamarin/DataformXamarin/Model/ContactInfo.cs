using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataformXamarin
{
    public class ContactInfo
    {
        private string middelName;
        private string lastname;
        private string contactNo;
        private string email;
        private string address;
        private DateTime? birthDate;
        private string groupName;


        public ContactInfo()
        {

        }

        private string firstName;

        [Display(ShortName = "First Name")]
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
            }
        }


        [Display(ShortName = "Middle Name")]
        public string MiddleName
        {
            get { return this.middelName; }
            set
            {
                this.middelName = value;
            }
        }

        [Display(ShortName = "Last Name")]
        public string LastName
        {
            get { return this.lastname; }
            set
            {
                this.lastname = value;
            }
        }

        [Display(ShortName = "Contact Number")]
        public string ContactNumber
        {
            get { return contactNo; }
            set
            {
                this.contactNo = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }

        [Display(ShortName = "Birth Date")]
        public DateTime? BirthDate
        {
            get { return birthDate; }
            set
            {
                birthDate = value;
            }
        }

        [Display(ShortName = "Group Name")]
        public string GroupName
        {
            get { return groupName; }
            set
            {
                groupName = value;
            }
        }
    }
}


