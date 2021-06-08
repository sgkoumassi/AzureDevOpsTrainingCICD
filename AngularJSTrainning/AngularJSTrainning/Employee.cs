using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularJSTrainning
{
    public class Employee
    {
        private int _id;
        private string _name;
        private string _gender;
        private int _salary;

        // [DataMember(Name ="ID",Order =1)]
        public int Id { get { return _id; } set { _id = value; } }

        //[DataMember(Order =2)]
        public string Name { get { return _name; } set { _name = value; } }

        // [DataMember(Order = 3)]
        public string Gender { get { return _gender; } set { _gender = value; } }

        public int Salary { get { return _salary; } set { _salary = value; } }

    }
}