using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Employee
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Name")]
        public String Name { get; set; }
        [BsonElement("Email")]
        public String Email { get; set; }
        [BsonElement("Gender")]
        public String Gender { get; set; }

        public Employee(string name, string email, string gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }
    }
}
