using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Inventory
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("Products")]
        public String Products { get; set; }
        [BsonElement("Quantity")]
        public Int32 QOP { get; set; }
        [BsonElement("Original Products' Price")]
        public Double OPP { get; set; }
        [BsonElement("Sold Products")]
        public Int32 SoldP { get; set; }
        [BsonElement("Sell Price")]
        public Double SellP { get; set; }
        [BsonElement("Total of Sell Products")]
        public Double TOSP { get; set; }
        [BsonElement("Total Products' Cost")]
        public Double TPC { get; set; }

        public Inventory(string products, int qOP, double oPP, int soldP, double sellP, double tOSP, double tPC)
        {
            Products = products;
            QOP = qOP;
            OPP = oPP;
            SoldP = soldP;
            SellP = sellP;
            TOSP = tOSP;
            TPC = tPC;
        }
    }
}
